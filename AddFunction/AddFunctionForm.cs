using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;

namespace PixelsGraph.AddFunctionForm
{
    /// <summary>
    /// The class of Addfunction form in PixelsGragh namspace.
    /// </summary>
    public partial class AddFunction : RadForm
    {
        #region Public

        public delegate void EventFunctionHandler(object sender, EventFunctionArgs e);

        [Category("PixelsGraph")]
        public event EventFunctionHandler FunctionOK = null;

        /// <summary>
        /// Initialize the AddFunction form.
        /// </summary>
        public AddFunction()
        {
            InitializeComponent();
            Initialize();

            choseFunction.SelectedIndex = 0;
            DialogResult = System.Windows.Forms.DialogResult.None;
            nonAbsRadioButton.IsChecked = true;
        }

        /// <summary>
        /// Initialize the AddFunction/EditFunction form with the icon.
        /// </summary>
        /// <param name="icon">The icon of the form.</param>
        public AddFunction(Icon icon)
        {
            InitializeComponent();
            Initialize();

            choseFunction.SelectedIndex = 0;
            this.Icon = icon;
            nonAbsRadioButton.IsChecked = true;
            DialogResult = System.Windows.Forms.DialogResult.None;
        }

        #region Properties

        /// <summary>
        /// Gets the type of chosen function.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(LoaiHam.BacNhat)]
        public LoaiHam TypeOfFunction
        {
            get
            {
                return (LoaiHam)choseFunction.SelectedIndex;
            }
        }

        /// <summary>
        /// Gets or sets the form of chosen function.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(DangHam.NonAbs)]
        public DangHam FunctionForm
        {
            get
            {
                return function.FunctionForm;
            }
            set
            {
                function.FunctionForm = value;
                switch (function.FunctionForm)
                {
                    case DangHam.NonAbs:
                        {
                            nonAbsRadioButton.IsChecked = true;
                            break;
                        }
                    case DangHam.Absf_x:
                        {
                            absf_xRadioButton.IsChecked = true;
                            break;
                        }
                    case DangHam.Absx:
                        {
                            absxRadioButton.IsChecked = true;
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Gets or sets the color of this function.
        /// </summary>
        [Category("PixelsGraph")]
        public Color FunctionColor
        {
            get
            {
                return function.Color;
            }
            set
            {
                function.Color = value;
                colorBox.ColorValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the initialize function when show this add function form.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(null)]
        public Function InitializeFunction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the function in PixelsGraph.Function class.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(null)]
        public Function Function
        {
            get
            {
                return function;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                choseFunction.SelectedIndex = (int)value.FunctionType;
                FunctionColor = value.Color;
                noteTextBox.Text = value.Note;
                FunctionForm = value.FunctionForm;
                function.SetFunctionParamsAndType(value);

                if (value.FunctionType == LoaiHam.Log)
                {
                    TextBoxs[1].Text = value.Values[0].ToString();
                }
                else
                {
                    for (int i = 0; i < value.Values.Length; i++)
                    {
                        TextBoxs[i].Text = value.Values[i].ToString();
                    }
                }

            }
        }

        /// <summary>
        /// Gets the parameters of function.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(null)]
        public float[] FunctionParams
        {
            get
            {
                return Params;
            }
        }

        /// <summary>
        /// Gets or sets the value indicating whether this AddFunction form turn into EditFunction.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(false)]
        public bool IsEditFunction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value indicating whether the input function is validated.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(false)]
        public bool IsValidated
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the datasoure for validating function.
        /// </summary>
        [Category("PixelsGraph")]
        [DefaultValue(null)]
        public object DataSource
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the background color of the axis.
        /// </summary>
        [Category("PixelsGraph")]
        public Color BackGroundAxisColor
        {
            get;
            set;
        }

        #endregion

        #endregion

        #region Private

        #region Attributes

        private int paramsNumber = 0;
        private float[] Params = null;
        private Label[] Labels = null;
        private RadTextBox[] TextBoxs = null;
        private Function function = null;

        #endregion

        #region Processing Methods

        private void Initialize()
        {
            Labels = new Label[4];
            Labels[0] = labelX3;
            Labels[1] = labelX2;
            Labels[2] = labelX1;
            Labels[3] = labelX0;

            TextBoxs = new RadTextBox[4];
            TextBoxs[0] = param1;
            TextBoxs[1] = param2;
            TextBoxs[2] = param3;
            TextBoxs[3] = param4;

            function = new Function();
        }

        #region Independent Methods

        private void ShowHideLabel(params string[] LabelArray)
        {
            for (int i = 0; i < 4; i++)
            {
                if (!string.IsNullOrEmpty(LabelArray[i]))
                {
                    Labels[i].Text = LabelArray[i];
                    Labels[i].Visible = true;
                }
                else
                {
                    Labels[i].Visible = false;
                }
            }
        }

        private void ShowHideParam(params bool[] BoolArray)
        {
            paramsNumber = 4;
            for (int i = 0; i < 4; i++)
            {
                TextBoxs[i].Visible = BoolArray[i];
                if (BoolArray[i] == false)
                {
                    paramsNumber--;
                }
            }
        }

        private bool TryGetValue(out string Message)
        {
            string message = "Tham số:";
            bool canTry = true;

            for (int i = 0; i < Params.Length; i++)
            {
                if (TextBoxs[i].Visible == true && !float.TryParse(TextBoxs[i].Text, NumberStyles.Float, CultureInfo.CreateSpecificCulture("en-US"), out Params[i]))
                {
                    canTry = false;
                    message += string.Format(" {0},", (char)(i + 'a'));
                }
            }
            message = message.Remove(message.Length - 1);
            message += " chưa hợp lệ.\r\nXin bạn vui lòng nhập lại các thông số này của hàm số.";

            if (!canTry)
            {
                Message = message;
            }
            else
            {
                Message = null;
            }

            return canTry;
        }

        public static bool Exist(BindingSource source, Function funct)
        {
            foreach (Function f in source)
            {
                if (f == funct)
                {
                    return true;
                }
            }
            return false;

            //for (int i = 0; i < source.Count; i++)
            //{
            //    if ((source[i] as Function) == funct)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
        }

        #endregion

        #endregion

        #region Equation Functions

        private void HambacNhat()
        {
            labelY.Text = "y =";
            ShowHideLabel("x  +", null, null, null);
            ShowHideParam(true, true, false, false);
        }

        private void HamBacHai()
        {
            labelY.Text = "y =";
            ShowHideLabel(string.Format("x{0}  +", KyTuDacBiet.Bac_2), "x  +", null, null);
            ShowHideParam(true, true, true, false);
        }

        private void HamBacBa()
        {
            labelY.Text = "y =";
            ShowHideLabel(string.Format("x{0}  +", KyTuDacBiet.Bac_3), string.Format("x{0}  +", KyTuDacBiet.Bac_2), "x   +", null);
            ShowHideParam(true, true, true, true);
        }

        private void HamTrungPhuong()
        {
            labelY.Text = "y =";
            ShowHideLabel(string.Format("x{0}  +", KyTuDacBiet.Bac_4), string.Format("x{0}  +", KyTuDacBiet.Bac_2), null, null);
            ShowHideParam(true, true, true, false);
        }

        private void HamPhanThuc()
        {
            labelY.Text = "y =   (";
            ShowHideLabel("x   +", " )   /   (", "x   +", ")");
            ShowHideParam(true, true, true, true);
        }

        private void HamSin()
        {
            labelY.Text = "y =";
            ShowHideLabel(".     sin(", "x   +", ")    +", null);
            ShowHideParam(true, true, true, true);
        }

        private void HamCos()
        {
            labelY.Text = "y =";
            ShowHideLabel(".    cos(", "x   +", ")    +", null);
            ShowHideParam(true, true, true, true);
        }

        private void HamLog()
        {
            labelY.Text = "y =       log(x)    /";
            ShowHideLabel("     log(", ")", null, null);
            ShowHideParam(false, true, false, false);
        }

        private void HamCanThuc()
        {
            labelY.Text = string.Format("y = {0}(", KyTuDacBiet.CanBacHai);
            ShowHideLabel("x   +", ")", null, null);
            ShowHideParam(true, true, false, false);
        }

        #endregion

        #region Event Handles

        private void choseFunction_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            labelMessage.Visible = false;
            RadDropDownList dropDownList = sender as RadDropDownList;

            switch ((LoaiHam)dropDownList.SelectedIndex)
            {
                case LoaiHam.BacNhat:
                    {
                        HambacNhat();
                        break;
                    }
                case LoaiHam.BacHai:
                    {
                        HamBacHai();
                        break;
                    }
                case LoaiHam.BacBa:
                    {
                        HamBacBa();
                        break;
                    }
                case LoaiHam.TrungPhuong:
                    {
                        HamTrungPhuong();
                        break;
                    }
                case LoaiHam.PhanThuc:
                    {
                        HamPhanThuc();
                        break;
                    }
                case LoaiHam.Sin:
                    {
                        HamSin();
                        break;
                    }
                case LoaiHam.Cos:
                    {
                        HamCos();
                        break;
                    }
                case LoaiHam.Log:
                    {
                        HamLog();
                        break;
                    }
                case LoaiHam.CanThuc:
                    {
                        HamCanThuc();
                        break;
                    }
            }
        }

        private void nonAbsRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            function.FunctionForm = DangHam.NonAbs;
        }

        private void absf_xRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            function.FunctionForm = DangHam.Absf_x;
        }

        private void absxRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            function.FunctionForm = DangHam.Absx;
        }

        #region Independent Methods

        private void addFunctionButton_Click(object sender, EventArgs e)
        {
            string Message = null;
            Params = new float[paramsNumber];

            if (TypeOfFunction == LoaiHam.Log)
            {
                if (!float.TryParse(TextBoxs[1].Text, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-US"), out Params[0]))
                {
                    Message = "Hàm log trên không hợp lệ.\r\nMời bạn nhập lại thông số của hàm Log.";
                }
                else
                {
                    if (Params[0] == 1)
                    {
                        Message = "Hàm log trên không hợp lệ do có mẫu bằng 0.\r\nXin bạn vui lòng nhập lại mẫu số cho hàm Log trên.";
                    }
                    else
                    {
                        if (Params[0] <= 0)
                        {
                            Message = "Hàm log trên không hợp lệ do có a ≤ 0.\r\nXin bạn vui lòng nhập lại mẫu số cho hàm Log trên.";
                        }
                        else
                        {
                            SetFunctionValues();
                        }
                    }
                }
            }
            else
            {
                if (TryGetValue(out Message))
                {
                    SetFunctionValues();

                    if (IsValidated && Message == null)
                    {
                        BindingSource source = DataSource as BindingSource;
                        if (!IsEditFunction && Exist(source, function))
                        {
                            Message = string.Format("Hàm số {0} đã có trong danh sách hàm số.\r\nMời bạn vui lòng nhập lại tham số hoặc chọn lại hàm số khác.", this.Function.FunctionString);
                        }
                        else
                        {
                            if (IsEditFunction && (source.Current as Function) != function && Exist(source, function))
                            {
                                Message = string.Format("Hàm số {0} đã có trong danh sách hàm số.\r\nMời bạn vui lòng nhập lại tham số hoặc chọn lại hàm số khác.", this.Function.FunctionString);
                            }
                            else
                            {
                                if (TypeOfFunction == LoaiHam.PhanThuc && Params[2] == 0 && Params[3] == 0)
                                {
                                    Message = "Hàm phân thức trên không hợp lệ do có mẫu bằng 0.\r\nXin bạn vui lòng nhập lại mẫu số cho hàm phân thức trên.";
                                }
                                else
                                {
                                    if (FunctionColor == BackGroundAxisColor)
                                    {
                                        Message = "Hàm số trên có màu trùng mà với màu nền của trục tọa độ\r\nMời bạn chọn lại màu của hàm số.";
                                    }
                                }
                            }
                        }
                    }
                }
            }



            if (Message != null)
            {
                labelMessage.Visible = true;
                labelMessage.Text = Message;
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            if (FunctionOK != null)
            {
                FunctionOK(this, new EventFunctionArgs(function, IsEditFunction));
            }

            this.Close();
        }

        private void SetFunctionValues()
        {
            function.SetFunctionParamsAndType(this.TypeOfFunction, Params);
            function.Note = noteTextBox.Text;
            function.Color = colorBox.ColorValue;
        }

        private void ValidateKeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Shift && (char.IsDigit((char)e.KeyValue) || e.KeyValue == 190 || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Home || e.KeyCode == Keys.End
                || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Back || e.KeyCode == Keys.OemMinus || (Keys.NumPad0 <= e.KeyCode && e.KeyCode <= Keys.NumPad9)))
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                e.SuppressKeyPress = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void AddFunctionForm_Load(object sender, EventArgs e)
        {
            if (IsEditFunction)
            {
                this.Text = "Chỉnh sửa hàm số";
                this.addFunctionButton.Text = "&Chỉnh sửa";

                if (InitializeFunction != null)
                {
                    this.Function = this.InitializeFunction;
                    this.Text += " " + InitializeFunction.FunctionString;
                }
            }
        }

        private void AddFunctionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.None)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        #endregion

        #endregion

        #endregion
    }
}
