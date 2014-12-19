using PixelsGraph.AddFunctionForm;
using PixelsGraph.AddTangentialLineForm;
using PixelsGraph.ReferencesForm;
using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;

namespace PixelsGraph.MainMenuForm
{
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class MainMenu : RadForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainMenu"/> class.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            openFileDialog.Filter = saveFileDialog.Filter = "Pixels Graph file (*.pig)|*.pig";
            piGraphToolStripMenuItem.Text += " " + this.ProductVersion;
            RadMessageBox.SetThemeName(office2013LightTheme1.ThemeName);
        }

        #region Attributes

        private volatile Data functionList = null;

        private References SettingsForm = null;

        private List<Input> drawFunctionList = null;

        Graph graph = new Graph(Input.Root, Input.scale);

        //delegate void ListBoxProcess(object sender, PositionChangedEventArgs e);
        //ListBoxProcess SafeProcess = null;

        //Properties.Settings setting = new Properties.Settings();

        #endregion

        #region Graphic Methods

        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            Color colorUserColor = Color.Blue;
            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            //  Clear the color and depth buffer. 
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            // Chọn Màu nè
            gl.Color(colorUserColor.R / 255.0, colorUserColor.G / 255.0, colorUserColor.B / 255.0, colorUserColor.A / 255.0);

            graph.updateAxis(Input.Root, Input.scale);
            graph.Build(gl, displayNet);


            for (int i = 0; i < drawFunctionList.Count; i++)
            {
                drawFunctionList[i].Draw(gl);
            }

            myNote.draw(ref gl);
        }

        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the clear color.
            gl.ClearColor(backgroundColor.R / 255.0f, backgroundColor.G / 255.0f, backgroundColor.B / 255.0f, backgroundColor.A / 255.0f);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
        }

        #endregion

        #region Family Line Attributes

        //tung độ tối thiểu và tung độ tối đa
        //note: cho người dùng nhập 2 vị trí này để xác định vùng người dùng cần chạy
        int maxFam = 0, minFam = 0;

        //hệ số đường thẳng
        //note: đây là hệ số của đường thẳng
        float[] arrPara = new float[2];

        #endregion

        #region Setting Atttributes

        bool move;
        bool MoveCom;
        double zoom;
        bool displayNet;// ẩn/hiện lưới tọa độ
        Color backgroundColor = Color.White;
        Note myNote = new Note();
        Point OldPoint, NewPoint;
        Point curPos;

        public bool DisplayAxisCoordinate
        {
            get
            {
                return displayNet;
            }
            set
            {
                displayNet = value;
            }
        }

        #endregion

        #region System Event Handles

        private void SharpGLForm_Load(object sender, EventArgs e)
        {
            Input.Root = new Point();
            Input.Root.X = 200;
            Input.Root.Y = 200;

            move = false;

            zoom = 1.0d;

            Input.scale = 50;
            displayNet = true;

            drawFunctionList = new List<Input>();
            openGLControl.Select();
        }

        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                return;
            }

            if (myNote.inCom(new Point(e.X, openGLControl.Height - e.Y)))
            {
                MoveCom = true;
                OldPoint = e.Location;
                NewPoint = e.Location;
            }
            else
            {
                move = true;

                OpenGL gl = openGLControl.OpenGL;

                curPos.X = e.Location.X;
                curPos.Y = gl.RenderContextProvider.Height - e.Location.Y;
            }
        }

        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            MoveCom = false;
        }

        private void openGLControl_MouseWheel(object sender, MouseEventArgs e)
        {
            // Cuộn chuột xuống
            if (e.Delta < 0)
            {
                zoom = 1 / 1.5f;

                if (Input.scale <= 1)
                    zoom = 1;
            }

            // Cuộn chuột lên
            if (e.Delta > 0)
            {
                if (Input.scale < 10000)
                    zoom = 1.5f;
                else
                    zoom = 1;
            }

            findNewRoot(e);
            findSclale();
            SettingsForm.Scale = Input.scale;
        }

        // Tính toán tọa độ mới của gốc tọa độ sau phép zoom
        private void findNewRoot(MouseEventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            double oldDistance_X = e.Location.X - Input.Root.X;
            double oldDistance_Y = (gl.RenderContextProvider.Height - e.Location.Y) - Input.Root.Y;

            double newDistance_X = oldDistance_X * zoom;
            double newDistance_Y = oldDistance_Y * zoom;

            Input.Root.X = (int)(e.Location.X - newDistance_X);
            Input.Root.Y = (int)(gl.RenderContextProvider.Height - e.Location.Y - newDistance_Y);
        }

        // Tính tỉ lệ mới
        private void findSclale()
        {
            if (Input.scale < 2)
            {
                if (zoom > 1)
                    Input.scale = (int)(Input.scale * zoom) + 1;
            }
            else
                Input.scale = (int)(Input.scale * zoom);
        }

        private void SetDefault()
        {
            OpenGL gl = openGLControl.OpenGL;

            Input.Root.X = gl.RenderContextProvider.Width / 2;
            Input.Root.Y = gl.RenderContextProvider.Height / 2;

            Input.scale = 50;

            zoom = 1;
        }

        #region Draw Family Line

        private void drawFamLine()
        {
            arrPara[1] += 0.1F;
            if (arrPara[1] > maxFam)
                arrPara[1] = minFam;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawFamLine();
        }

        #endregion

        #endregion

        #region Main Interface Methods

        private void addTangentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTangentialLine addTangentialLineFunction = new AddTangentialLine();
            addTangentialLineFunction.Function = functionList.FunctionList.Current as Function;
            addTangentialLineFunction.DataSource = functionList.FunctionList;
            addTangentialLineFunction.BackGroundAxisColor = SettingsForm.BackGroundColor;
            addTangentialLineFunction.FunctionOK += addFunction_FunctionOK;

            addTangentialLineFunction.ShowDialog(sender as IWin32Window);
        }

        private void SettingForm_OK(object sender, EventArgs e)
        {
            // TODO: Phương thức này được gọi sau khi người dùng tay đổi các tùy chỉnh của chương trình.
            graph.update(SettingsForm.GridColor, SettingsForm.AxisCoordinateColor);
            graph.updateNumColor(SettingsForm.NumbericColor);
            gridEnableToolStripMenuItem.IsChecked = SettingsForm.EnableCoordinateGrid;
            backgroundColor = SettingsForm.BackGroundColor;
            openGLControl.OpenGL.ClearColor(backgroundColor.R / 255.0f, backgroundColor.G / 255.0f, backgroundColor.B / 255.0f, backgroundColor.A / 255.0f);
            Input.scale = (int)SettingsForm.Scale;
            myNote.setSize((int)SettingsForm.NoteSize);
            Input.DepthLine = (float)SettingsForm.DepthLine;
        }

        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            PointF temp = ConvertToXY(e.Location);
            radLabelElement1.Text = string.Format("X: {0:0.00}, Y: {1:0.00}", temp.X, temp.Y);

            // TODO: Xử lý các sự kiện mouse move.
            if (MoveCom == true)
            {
                NewPoint = e.Location;
                Point tmp = new Point(NewPoint.X - OldPoint.X, OldPoint.Y - NewPoint.Y);
                myNote.updatePos(tmp, openGLControl.Width, openGLControl.Height);
                if (e.Location.X < 0 ||
                    e.Location.Y < 0 ||
                    e.Location.X > openGLControl.Width ||
                    e.Location.Y > openGLControl.Height)
                    MoveCom = false;
                OldPoint = NewPoint;
            }

            if (!move)
                return;

            OpenGL gl = openGLControl.OpenGL;

            Input.Root.X += e.Location.X - curPos.X;
            Input.Root.Y += gl.RenderContextProvider.Height - e.Location.Y - curPos.Y;

            curPos.X = e.Location.X;
            curPos.Y = gl.RenderContextProvider.Height - e.Location.Y;
        }

        private PointF ConvertToXY(Point p)
        {
            OpenGL gl = openGLControl.OpenGL;
            return new PointF((p.X - Input.Root.X) / (float)Input.scale, ((gl.RenderContextProvider.Height - Input.Root.Y) - p.Y) / (float)Input.scale);
        }

        #region Static Methods

        private static Input ConvertFromFunction(Function funct)
        {
            Input temp = null;
            switch (funct.FunctionType)
            {
                case LoaiHam.BacNhat:
                    {
                        temp = new P1();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.BacHai:
                    {
                        temp = new P2();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.BacBa:
                    {
                        temp = new P3();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.TrungPhuong:
                    {
                        temp = new P4();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.PhanThuc:
                    {
                        temp = new Frac();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.Sin:
                    {
                        temp = new Sin();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.Cos:
                    {
                        temp = new Cos();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.Log:
                    {
                        temp = new Logarit();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.CanThuc:
                    {
                        temp = new SQRT();
                        temp.update(new List<float>(funct.Values), Input.scale, funct.Color);

                        break;
                    }
                case LoaiHam.Undefined:
                    {
                        throw new Exception("Can not determine the type of function.");
                    }
            }
            temp.setType((int)funct.FunctionForm);

            return temp;
        }

        private static void OpenFile(string safeFileName, byte[] buffer)
        {
            string direct = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
            string fileName = Path.Combine(direct, safeFileName);
            if (!File.Exists(fileName))
            {
                if (!Directory.Exists(direct))
                {
                    Directory.CreateDirectory(direct);
                }

                FileStream sFile = File.OpenWrite(fileName);
                sFile.Write(buffer, 0, buffer.Length);
                sFile.Close();
            }
            else
            {
                FileStream sFile = File.OpenRead(fileName);
                if (sFile.Length != buffer.LongLength)
                {
                    sFile.Close();
                    sFile = File.OpenWrite(fileName);
                    sFile.Write(buffer, 0, buffer.Length);
                    sFile.Close();
                }
            }
            System.Diagnostics.Process.Start(fileName);
        }

        #endregion

        #endregion

        #region Interface

        #region Interface Attributes
        /// <summary>
        /// The saving status of program.
        /// </summary>
        private volatile bool isSaved = true;

        private const string SoftwareNameFormat = "{0} - PiGraph";

        private const string CurrentSelectedFunctonFormat = "{0} ({1})";

        #endregion

        #region About Info

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile("Thong tin ve nhom phat trien.pdf", Properties.Resources.Thong_tin_nhom_phat_trien);
        }

        #endregion

        #region Load Main Menu

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            functionList = new Data();
            functionList.FunctionList.ListChanged += functionList_ListChanged;

            SettingsForm = new References();
            SettingsForm.SettingsOK += SettingForm_OK;

            listBox1.DataSource = functionList.FunctionList;

            SettingForm_OK(sender, e);
            newToolStripMenuItem_Click(sender, e);
            SetDefault();

            String[] commandLines = Environment.GetCommandLineArgs();
            foreach (string s in commandLines)
            {
                MessageBox.Show(s);
            }

            if (!Properties.Settings.Default.showCaption)
            {
                radDesktopAlert.FixedSize = new Size(540, 160);
                radDesktopAlert.CaptionText = "Một số nhắc nhở khi sử dụng phần mềm PiGraph";
                radDesktopAlert.ContentText = "1. Để chương trình chạy ổn định nhất, bạn nên sử dụng card đồ họa rời\r\nvà cập nhật driver cho card màn hình phiên bản mới nhất.\r\n2. Để xem hướng dẫn bạn hãy nhấn F1\r\n3. Để xem thông tin về nhóm phát triển, nhấn F2\r\nNhóm Pixels hy vọng phần mềm này sẽ giúp ích cho bạn trong việc học tập. ;)\r\n(Nhắc nhở này chỉ xuất hiện duy nhất một lần khi chương trình lần đầu được chạy)";
                Properties.Settings.Default.showCaption = true;

                Properties.Settings.Default.Save();
                radDesktopAlert.Show();
            }
        }

        #endregion

        #region Event Handles

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult temp = RadMessageBox.Show(sender as IWin32Window, string.Format("Xác nhận xóa hàm số\r\n{0}", listBox1.SelectedItem), "Xóa hàm số", MessageBoxButtons.OKCancel, RadMessageIcon.Info);
                if (temp == System.Windows.Forms.DialogResult.OK)
                {
                    functionList.FunctionList.RemoveCurrent();
                }
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                removeToolStripMenuItem_Click(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteAllFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                DialogResult result = RadMessageBox.Show(sender as IWin32Window, "Bạn có muốn xóa danh sách hàm số không?", "Xóa danh sách hàm số", MessageBoxButtons.OKCancel, RadMessageIcon.Info);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    functionList.Clear();
                }
            }
        }

        private void openGLControl_MouseLeave(object sender, EventArgs e)
        {
            radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        private void openGLControl_MouseEnter(object sender, EventArgs e)
        {
            radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImageFileDialog.ShowDialog(sender as IWin32Window);
        }

        private void saveImgaeFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap bitmap = new Bitmap(openGLControl.DisplayRectangle.Width, openGLControl.DisplayRectangle.Height, openGLControl.CreateGraphics());
            ImageFormat imageFormat = null;

            openGLControl.DrawToBitmap(bitmap, openGLControl.DisplayRectangle);

            switch (saveImageFileDialog.FilterIndex)
            {
                case 1:
                    {
                        imageFormat = ImageFormat.Png;
                        break;
                    }
                case 2:
                    {
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    }
                case 3:
                    {
                        imageFormat = ImageFormat.Bmp;
                        break;
                    }
            }

            bitmap.Save(saveImageFileDialog.FileName, imageFormat);
        }

        private delegate void FunctionInvoke();

        private void listBox1_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            noteTextBox.TextChanged -= this.textBox1_TextChanged;
            Function funct = listBox1.SelectedValue as Function;
            if (funct != null)
            {
                noteTextBox.BeginInvoke(new FunctionInvoke(() => { noteTextBox.ReadOnly = false; }));
                noteTextBox.BeginInvoke(new FunctionInvoke(() => { noteTextBox.Text = funct.Note; }));

                currentFunctionToolStripStatusLabel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                commandBarSeparator1.Visibility = ElementVisibility.Visible;
                currentFunctionToolStripStatusLabel.Text = string.Format(CurrentSelectedFunctonFormat, funct.FunctionString, funct.Color.ToString());

            }
            else
            {
                noteTextBox.BeginInvoke(new FunctionInvoke(noteTextBox.Clear));
                noteTextBox.BeginInvoke(new FunctionInvoke(() => { noteTextBox.ReadOnly = true; }));

                currentFunctionToolStripStatusLabel.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                commandBarSeparator1.Visibility = ElementVisibility.Collapsed;
            }
            noteTextBox.TextChanged += this.textBox1_TextChanged;
        }

        void functionList_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    {
                        Function temp = functionList.FunctionList[e.NewIndex] as Function;
                        drawFunctionList.Add(ConvertFromFunction(temp));
                        myNote.add(temp.FunctionString, temp.Color, openGLControl.Width);
                        break;
                    }
                case ListChangedType.ItemDeleted:
                    {
                        drawFunctionList.RemoveAt(e.NewIndex);
                        myNote.remove(e.NewIndex);
                        break;
                    }
                case ListChangedType.ItemChanged:
                    {
                        Function temp = functionList.FunctionList[e.NewIndex] as Function;
                        drawFunctionList[e.NewIndex] = ConvertFromFunction(temp);
                        myNote.edit(e.NewIndex, temp.FunctionString, temp.Color);
                        break;
                    }
                case ListChangedType.Reset:
                    {
                        drawFunctionList.Clear();
                        myNote.clear();
                        break;
                    }
            }

            if (listBox1.Items.Count > 0)
            {
                noteTextBox.BeginInvoke(new FunctionInvoke(() => { noteTextBox.ReadOnly = false; }));

                if (listBox1.SelectedIndex == -1)
                {
                    listBox1.SelectedIndex = 0;
                }
            }
            else
            {
                noteTextBox.BeginInvoke(new FunctionInvoke(noteTextBox.Clear));
                noteTextBox.BeginInvoke(new FunctionInvoke(() => { noteTextBox.ReadOnly = true; }));
                currentFunctionToolStripStatusLabel.Visibility = ElementVisibility.Collapsed;
                commandBarSeparator1.Visibility = ElementVisibility.Collapsed;
            }

            isSaved = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Function funct = listBox1.SelectedValue as Function;

            if (funct != null)
            {
                funct.Note = noteTextBox.Text;
                isSaved = false;
            }
        }

        private void addFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFunction addFunction = new AddFunction();
            addFunction.IsValidated = true;
            addFunction.DataSource = functionList.FunctionList;
            addFunction.BackGroundAxisColor = SettingsForm.BackGroundColor;
            addFunction.FunctionOK += addFunction_FunctionOK;

            addFunction.ShowDialog(sender as IWin32Window);
        }

        void addFunction_FunctionOK(object sender, EventFunctionArgs e)
        {
            if (!e.IsEditFunction)
            {
                functionList.FunctionList.Add(e.Function);
            }
            else
            {
                functionList.FunctionList[listBox1.SelectedIndex] = e.Function;
                int tmp = listBox1.SelectedIndex;
                listBox1.SelectedIndex = -1;
                listBox1.SelectedIndex = tmp;
            }
        }

        private void editFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFunction addFunction = new AddFunction();
            addFunction.InitializeFunction = functionList.FunctionList.Current as Function;
            addFunction.IsEditFunction = true;
            addFunction.IsValidated = true;
            addFunction.DataSource = functionList.FunctionList;
            addFunction.FunctionOK += this.addFunction_FunctionOK;
            addFunction.ShowDialog(sender as IWin32Window);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm.ShowDialog(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSaved && listBox1.Items.Count > 0)
            {
                DialogResult result = RadMessageBox.Show(this, "Ban có muốn lưu lại danh sách hàm số trước khi tạo mới danh sách không?",
                    "Tạo mới danh sách", MessageBoxButtons.YesNoCancel, RadMessageIcon.Info);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(openFileDialog.FileName))
                    {
                        saveBackgroundWorker.RunWorkerAsync(openFileDialog.FileName);
                    }
                    else
                    {
                        if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            functionList.Clear();
                        }
                    }
                }
                else
                {
                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        functionList.Clear();
                    }
                }
            }
            else
            {
                functionList.Clear();
            }

            openFileDialog.FileName = string.Empty;
            this.Text = string.Format(SoftwareNameFormat, "graph1.pig");
            saveFileToolStripMenuItem.Text = string.Format("Lưu graph1.pig");
            saveAsToolStripMenuItem.Text = "Lưu graph1.pig vào...";
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && !isSaved)
            {
                if (string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    saveFileDialog.ShowDialog(this);
                }
                else
                {
                    saveBackgroundWorker.RunWorkerAsync(openFileDialog.FileName);
                }
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.UseWaitCursor = true;
            saveBackgroundWorker.RunWorkerAsync(saveFileDialog.FileName);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && !isSaved)
            {
                DialogResult temp = RadMessageBox.Show(this, "Bạn có muốn lưu lại danh sách hàm số không?",
                    "Lưu danh sách hàm số", MessageBoxButtons.YesNoCancel, RadMessageIcon.Info);
                if (temp == System.Windows.Forms.DialogResult.Yes)
                {
                    saveFileDialog.ShowDialog(this);
                }
                else
                {
                    if (temp == System.Windows.Forms.DialogResult.No)
                    {
                        return;
                    }
                }
            }

            openFileDialog.ShowDialog(this);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            functionList.Clear();
            this.UseWaitCursor = true;
            openFileBackgroundWorker.RunWorkerAsync(openFileDialog.FileName);
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved && listBox1.Items.Count > 0)
            {
                DialogResult result = RadMessageBox.Show(this, "Ban có muốn lưu lại danh sách hàm số không?",
                    "Lưu danh sách hàm số", MessageBoxButtons.YesNoCancel, RadMessageIcon.Info);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(openFileDialog.FileName))
                    {
                        Task<bool> saveFileTask = new Task<bool>(new Func<bool>(() =>
                            {
                                return !functionList.Save(openFileDialog.FileName);
                            }));
                        saveFileTask.Start();
                        e.Cancel = saveFileTask.Result;
                    }
                    else
                    {
                        if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                    }
                }
                else
                {
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            SettingsForm.Save();
        }

        private void rightClickMenuStrip_DropDownOpeningOpening(object sender, CancelEventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                editFunctionToolStripMenuItem2.Enabled = false;
                removeFunctionToolStripMenuItem2.Enabled = false;
                addTangentLineToolStripMenuItem2.Enabled = false;
                removeAllFunctionToolStripMenuItem2.Enabled = false;
            }
            else
            {
                editFunctionToolStripMenuItem2.Enabled = true;
                removeFunctionToolStripMenuItem2.Enabled = true;
                removeAllFunctionToolStripMenuItem2.Enabled = true;
                addTangentLineToolStripMenuItem2.Enabled = (listBox1.SelectedValue as Function).HasTangentialLine;
            }
        }

        private void functionMenuToolStripMenuItem_DropDownOpening(object sender, CancelEventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                editFunctionToolStripMenuItem1.Enabled = false;
                addTangentLineToolStripMenuItem.Enabled = false;
                removeFunctionToolStripMenuItem1.Enabled = false;
                removeAllFunctionToolStripMenuItem1.Enabled = false;
            }
            else
            {
                editFunctionToolStripMenuItem1.Enabled = true;
                removeFunctionToolStripMenuItem1.Enabled = true;
                removeAllFunctionToolStripMenuItem1.Enabled = true;
                addTangentLineToolStripMenuItem.Enabled = (listBox1.SelectedValue as Function).HasTangentialLine;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = openFileDialog.InitialDirectory;
            saveFileDialog.ShowDialog(this);
        }

        private void unbindFunctionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionListForm functionForm = new FunctionListForm();
            functionForm.Controls.Add(this.splitPanel1);
            functionForm.Controls[0].Dock = DockStyle.Fill;
            functionForm.Icon = this.Icon;
            functionForm.FormClosing += functionForm_FormClosing;

            unbindFunctionListToolStripMenuItem.Enabled = false;
            unbindFunctionListToolStripMenuItem2.Enabled = false;

            functionForm.Show();
        }

        void functionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.radSplitContainer1.SplitPanels.Insert(0, this.splitPanel1);

            unbindFunctionListToolStripMenuItem.Enabled = true;
            unbindFunctionListToolStripMenuItem2.Enabled = true;
        }

        private void MainMenuForm_Resize(object sender, EventArgs e)
        {
            myNote.fix(openGLControl.Width, openGLControl.Height);
        }

        private void gridEnableToolStripMenuItem_CheckedChanged(object sender, StateChangedEventArgs e)
        {
            DisplayAxisCoordinate = gridEnableToolStripMenuItem.IsChecked;
            SettingsForm.EnableCoordinateGrid = gridEnableToolStripMenuItem.IsChecked;
        }

        private void zoomTo100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDefault();
        }

        #region Zoom In/Out

        private Point location;
        private void zoomInToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openGLControl_MouseWheel(sender, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, location.X, location.Y, 0, 1));
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openGLControl_MouseWheel(sender, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, location.X, location.Y, 0, -1));
        }

        #endregion

        private void openFileBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = functionList.Load(e.Argument as string);
        }

        private void openFileBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result == true)
            {
                isSaved = true; /// Open is not change any functions.
                saveFileDialog.InitialDirectory = openFileDialog.InitialDirectory;
                saveFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);

                Text = string.Format(SoftwareNameFormat, openFileDialog.SafeFileName);
                saveFileToolStripMenuItem.Text = string.Format("Lưu {0}", openFileDialog.SafeFileName);
                saveAsToolStripMenuItem.Text = string.Format("Lưu {0} vào...", openFileDialog.SafeFileName);
            }
            this.UseWaitCursor = false;
        }

        private void saveBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = functionList.Save(e.Argument as string);
        }

        private void saveBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result == true)
            {
                isSaved = true; /// Open is not change any functions.
                string safeFileName = Path.GetFileName(saveFileDialog.FileName);
                openFileDialog.InitialDirectory = saveFileDialog.InitialDirectory;

                Text = string.Format(SoftwareNameFormat, safeFileName);
                saveFileToolStripMenuItem.Text = string.Format("Lưu {0}", safeFileName);
                saveAsToolStripMenuItem.Text = string.Format("Lưu {0} vào...", safeFileName);
            }
            this.UseWaitCursor = false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile("Huong dan su dung.pdf", Properties.Resources.Huong_dan_su_dung);
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                helpToolStripMenuItem_Click(sender, e);
            }
            else
            {
                if (e.KeyData == Keys.F2)
                {
                    aboutToolStripMenuItem_Click(sender, e);
                }
            }
        }

        #endregion

        #endregion
    }
}
