using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PixelsGraph.AddTangentialLineForm
{
    /// <summary>
    /// The class of Addfunction form in PixelsGragh namspace.
    /// </summary>
    public partial class AddTangentialLine : RadForm
    {
        #region Public

        public delegate void EventFunctionHandler(object sender, EventFunctionArgs e);

        [Category("PixelsGraph")]
        public event EventFunctionHandler FunctionOK = null;

        /// <summary>
        /// Initialize the AddFunction form.
        /// </summary>
        public AddTangentialLine()
        {
            InitializeComponent();
            Initialize();

            DialogResult = System.Windows.Forms.DialogResult.None;
        }

        /// <summary>
        /// Initialize the AddFunction/EditFunction form with the icon.
        /// </summary>
        /// <param name="icon">The icon of the form.</param>
        public AddTangentialLine(Icon icon)
        {
            InitializeComponent();
            Initialize();

            this.Icon = icon;
            DialogResult = System.Windows.Forms.DialogResult.None;
        }

        #region Properties

        /// <summary>
        /// Gets or sets the color of this function.
        /// </summary>
        [Category("PixelsGraph")]
        public Color TangentialFunctionColor
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
        /// Gets the tangential line function in PixelsGraph.Function class.
        /// </summary>
        [Category("PixelsGraph")]
        public Function TangentialFunction
        {
            get
            {
                return function;
            }
        }

        Function mainFunction = null;
        /// <summary>
        /// Gets the function in PixelsGraph.Function class.
        /// </summary>
        [Category("PixelsGraph")]
        public Function Function
        {
            get
            {
                return mainFunction;
            }
            set
            {
                if (value != null)
                {
                    mainFunction = value;
                    Text = string.Format(Text, mainFunction);
                }
            }
        }

        /// <summary>
        /// Gets the tangential point of function.
        /// </summary>
        [Category("PixelsGraph")]
        public PointF TangentialPointF
        {
            get
            {
                return new PointF(Params[0], Params[1]);
            }
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

        private const int paramsNumber = 2;
        private float[] Params = null;
        private RadTextBox[] TextBoxs = null;
        private Function function = null;

        #endregion

        #region Processing Methods

        private void Initialize()
        {
            Params = new float[2];

            TextBoxs = new RadTextBox[2];
            TextBoxs[0] = param1;
            TextBoxs[1] = param2;

            function = new Function();
        }

        #region Validating Methods

        private bool TryGetValue(out string Message)
        {
            string message = "Giá trị:";
            bool canTry = true;

            for (int i = 0; i < Params.Length; i++)
            {
                if (TextBoxs[i].Visible == true && !float.TryParse(TextBoxs[i].Text, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-US"), out Params[i]))
                {
                    canTry = false;
                    message += string.Format(" {0},", (char)(i + 'x'));
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

        #endregion

        #region Independent Methods

        public static int Find(BindingSource source, Function funct)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if ((source[i] as Function) == funct)
                {
                    return i;
                }
            }
            return -1;
        }

        private static bool IsValidTangentialLine(PointF pt, Function funct)
        {
            return pt.Y == CalculateTangentialPoint_Y(pt.X, funct);
        }

        private static float CalculateTangentialPoint_Y(float X, Function funct)
        {
            switch (funct.FunctionType)
            {
                case LoaiHam.BacHai:
                    {
                        return (float)(funct.Values[0] * Math.Pow(X, 2) + funct.Values[1] * X + funct.Values[2]);
                    }
                case LoaiHam.BacBa:
                    {
                        return (float)(funct.Values[0] * Math.Pow(X, 3) + funct.Values[1] * Math.Pow(X, 2) + funct.Values[2] * X + funct.Values[3]);
                    }
                case LoaiHam.TrungPhuong:
                    {
                        return (float)(funct.Values[0] * Math.Pow(X, 4) + funct.Values[1] * Math.Pow(X, 2) + funct.Values[2]);
                    }
                default:
                    return 0;
            }
        }

        #endregion

        #endregion

        #region Event Handles

        private void addFunctionButton_Click(object sender, EventArgs e)
        {
            string Message = null;
            Params = new float[paramsNumber];

            if (TryGetValue(out Message))
            {
                SetTangentialLineValue();

                BindingSource source = DataSource as BindingSource;
                if (source != null && Find(source, function) != -1)
                {
                    Message = string.Format("Tiếp tuyến {0} đã có trong danh sách hàm số.\r\nMời bạn vui lòng nhập lại tham số hoặc chọn lại hàm số khác.", this.TangentialFunction.FunctionString);
                }
                else
                {
                    if (source != null && (source.Current as Function) != function && Find(source, function) != -1)
                    {
                        Message = string.Format("Hàm số {0} đã có trong danh sách hàm số.\r\nMời bạn vui lòng nhập lại tham số hoặc chọn lại hàm số khác.", this.TangentialFunction.FunctionString);
                    }
                    else
                    {
                        if (!IsValidTangentialLine(TangentialPointF, Function))
                        {
                            Message = string.Format("Điểm {0} không thuộc hàm số {1}\r\nMời bạn nhập lại điểm khác cho hàm số trên.", TangentialPointF, Function.FunctionString);
                        }
                        else
                        {
                            if (TangentialFunctionColor == BackGroundAxisColor)
                            {
                                Message = "Tiếp tuyến trên có màu trùng mà với màu nền của trục tọa độ\r\nMời bạn chọn lại màu của tiếp tuyến.";
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
                FunctionOK(this, new EventFunctionArgs(function));
            }

            this.Close();
        }

        private void SetTangentialLineValue()
        {
            Function.ComputeTangentialLine(TangentialPointF, ref function);
            function.Note = noteTextBox.Text;
            function.Color = colorBox.ColorValue;
        }

        private void ValidateKeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Shift && (char.IsDigit((char)e.KeyValue) || (int)e.KeyValue == 190 || e.KeyCode == Keys.Delete
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

        private void AddFunctionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.None)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void param1_TextChanged(object sender, EventArgs e)
        {
            RadTextBox textBox = sender as RadTextBox;
            float x = 0;
            if (textBox.Text == string.Empty)
            {
                param2.Clear();
            }
            else
            {
                if (float.TryParse(textBox.Text, out x))
                {
                    param2.Text = CalculateTangentialPoint_Y(x, Function).ToString();
                }
            }
        }

        #endregion

        #endregion
    }
}
