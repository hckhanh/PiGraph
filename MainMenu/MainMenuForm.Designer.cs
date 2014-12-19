using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace PixelsGraph.MainMenuForm
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openGLControl = new SharpGL.OpenGLControl();
            this.openGLContextMenuStrip = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.gridEnableToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator8 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.zoomInToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.zoomOutToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator12 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.zoomTo100ToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.fileMenuToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.newToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.openFileToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.saveFileToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.saveAsToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.exportToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.exitToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.editMenuToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.unbindFunctionListToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator10 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.optionToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.functionMenuToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.addFunctionToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.editFunctionToolStripMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.removeFunctionToolStripMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator6 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.addTangentLineToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator5 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.removeAllFunctionToolStripMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.helpMenuToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.helpToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator13 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.aboutToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.piGraphToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.rightClickMenuStrip = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.addToolStripMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.removeFunctionToolStripMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.editFunctionToolStripMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator9 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.unbindFunctionListToolStripMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator4 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.addTangentLineToolStripMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.toolStripSeparator7 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.removeAllFunctionToolStripMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.noteTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.listBox1 = new Telerik.WinControls.UI.RadListControl();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.toolStripStatusLabel1 = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.currentFunctionToolStripStatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.saveImageFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.saveBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.menuStrip = new Telerik.WinControls.UI.RadMenu();
            this.pointToolStripStatusLabel1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radOffice2007ScreenTipElement1 = new Telerik.WinControls.UI.RadOffice2007ScreenTipElement();
            this.radDesktopAlert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openGLControl
            // 
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.FrameRate = 28;
            this.openGLControl.Location = new System.Drawing.Point(0, 0);
            this.openGLControl.Name = "openGLControl";
            this.radContextMenuManager1.SetRadContextMenu(this.openGLControl, this.openGLContextMenuStrip);
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(747, 362);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.SharpGLForm_Load);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseEnter += new System.EventHandler(this.openGLControl_MouseEnter);
            this.openGLControl.MouseLeave += new System.EventHandler(this.openGLControl_MouseLeave);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            this.openGLControl.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseWheel);
            // 
            // openGLContextMenuStrip
            // 
            this.openGLContextMenuStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.gridEnableToolStripMenuItem,
            this.toolStripSeparator8,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.toolStripSeparator12,
            this.zoomTo100ToolStripMenuItem});
            this.openGLContextMenuStrip.ThemeName = "Office2013Light";
            // 
            // gridEnableToolStripMenuItem
            // 
            this.gridEnableToolStripMenuItem.AccessibleDescription = "Hiện lưới tọa độ";
            this.gridEnableToolStripMenuItem.AccessibleName = "Hiện lưới tọa độ";
            this.gridEnableToolStripMenuItem.CheckOnClick = true;
            this.gridEnableToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEnableToolStripMenuItem.IsChecked = true;
            this.gridEnableToolStripMenuItem.Name = "gridEnableToolStripMenuItem";
            this.gridEnableToolStripMenuItem.Text = "Hiện lưới tọa độ";
            this.gridEnableToolStripMenuItem.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.gridEnableToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.gridEnableToolStripMenuItem.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.gridEnableToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.AccessibleDescription = "Phóng to";
            this.zoomInToolStripMenuItem.AccessibleName = "Phóng to";
            this.zoomInToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomInToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.Zoom_5442;
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Text = "Phóng to";
            this.zoomInToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            this.zoomInToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomInToolStripMenuItem_MouseDown);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.AccessibleDescription = "Thu nhỏ";
            this.zoomOutToolStripMenuItem.AccessibleName = "Thu nhỏ";
            this.zoomOutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomOutToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.ZoomOut_12927;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Text = "Thu nhỏ";
            this.zoomOutToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // zoomTo100ToolStripMenuItem
            // 
            this.zoomTo100ToolStripMenuItem.AccessibleDescription = "Đưa kích thước trở về mặc định";
            this.zoomTo100ToolStripMenuItem.AccessibleName = "Đưa kích thước trở về mặc định";
            this.zoomTo100ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomTo100ToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.ZoomToFit;
            this.zoomTo100ToolStripMenuItem.Name = "zoomTo100ToolStripMenuItem";
            this.zoomTo100ToolStripMenuItem.Text = "Đưa kích thước trở về mặc định";
            this.zoomTo100ToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.zoomTo100ToolStripMenuItem.Click += new System.EventHandler(this.zoomTo100ToolStripMenuItem_Click);
            // 
            // fileMenuToolStripMenuItem
            // 
            this.fileMenuToolStripMenuItem.AccessibleDescription = "&Tệp";
            this.fileMenuToolStripMenuItem.AccessibleName = "&Tệp";
            this.fileMenuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenuToolStripMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.newToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileMenuToolStripMenuItem.Name = "fileMenuToolStripMenuItem";
            this.fileMenuToolStripMenuItem.ShowArrow = false;
            this.fileMenuToolStripMenuItem.Text = "&Tệp";
            this.fileMenuToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.AccessibleDescription = "Tạo &mới";
            this.newToolStripMenuItem.AccessibleName = "Tạo &mới";
            this.newToolStripMenuItem.DescriptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.NewFile_6276;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Text = "Tạo &mới";
            this.newToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.AccessibleDescription = "&Mở tệp";
            this.openFileToolStripMenuItem.AccessibleName = "&Mở tệp";
            this.openFileToolStripMenuItem.AutoToolTip = true;
            this.openFileToolStripMenuItem.DescriptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileToolStripMenuItem.HintText = "";
            this.openFileToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.Open_6529;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Text = "&Mở tệp";
            this.openFileToolStripMenuItem.ToolTipText = "Mở định dạng tệp *pig";
            this.openFileToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.AccessibleDescription = "&Lưu";
            this.saveFileToolStripMenuItem.AccessibleName = "&Lưu";
            this.saveFileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.Save_6530;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Text = "&Lưu";
            this.saveFileToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.AccessibleDescription = "Lưu &vào...";
            this.saveAsToolStripMenuItem.AccessibleName = "Lưu &vào...";
            this.saveAsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Text = "Lưu &vào...";
            this.saveAsToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.AccessibleDescription = "&Xuất ảnh";
            this.exportToolStripMenuItem.AccessibleName = "&Xuất ảnh";
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Text = "&Xuất ảnh";
            this.exportToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = "T&hoát";
            this.exitToolStripMenuItem.AccessibleName = "T&hoát";
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Text = "T&hoát";
            this.exitToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editMenuToolStripMenuItem
            // 
            this.editMenuToolStripMenuItem.AccessibleDescription = "&Tùy chỉnh";
            this.editMenuToolStripMenuItem.AccessibleName = "&Tùy chỉnh";
            this.editMenuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenuToolStripMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.unbindFunctionListToolStripMenuItem,
            this.toolStripSeparator10,
            this.optionToolStripMenuItem});
            this.editMenuToolStripMenuItem.Name = "editMenuToolStripMenuItem";
            this.editMenuToolStripMenuItem.ShowArrow = false;
            this.editMenuToolStripMenuItem.Text = "&Tùy chỉnh";
            this.editMenuToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // unbindFunctionListToolStripMenuItem
            // 
            this.unbindFunctionListToolStripMenuItem.AccessibleDescription = "&Gỡ danh sách";
            this.unbindFunctionListToolStripMenuItem.AccessibleName = "&Gỡ danh sách";
            this.unbindFunctionListToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unbindFunctionListToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.HideMember_6755;
            this.unbindFunctionListToolStripMenuItem.Name = "unbindFunctionListToolStripMenuItem";
            this.unbindFunctionListToolStripMenuItem.Text = "&Gỡ danh sách";
            this.unbindFunctionListToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.unbindFunctionListToolStripMenuItem.Click += new System.EventHandler(this.unbindFunctionListToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.AccessibleDescription = "&Tùy chỉnh...";
            this.optionToolStripMenuItem.AccessibleName = "&Tùy chỉnh...";
            this.optionToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.ProcessWindow_6545;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Text = "&Tùy chỉnh...";
            this.optionToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // functionMenuToolStripMenuItem
            // 
            this.functionMenuToolStripMenuItem.AccessibleDescription = "&Hàm số";
            this.functionMenuToolStripMenuItem.AccessibleName = "&Hàm số";
            this.functionMenuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionMenuToolStripMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.addFunctionToolStripMenuItem,
            this.editFunctionToolStripMenuItem1,
            this.removeFunctionToolStripMenuItem1,
            this.toolStripSeparator6,
            this.addTangentLineToolStripMenuItem,
            this.toolStripSeparator5,
            this.removeAllFunctionToolStripMenuItem1});
            this.functionMenuToolStripMenuItem.Name = "functionMenuToolStripMenuItem";
            this.functionMenuToolStripMenuItem.ShowArrow = false;
            this.functionMenuToolStripMenuItem.Text = "&Hàm số";
            this.functionMenuToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.functionMenuToolStripMenuItem.DropDownOpening += new System.ComponentModel.CancelEventHandler(this.functionMenuToolStripMenuItem_DropDownOpening);
            // 
            // addFunctionToolStripMenuItem
            // 
            this.addFunctionToolStripMenuItem.AccessibleDescription = "&Thêm hàm";
            this.addFunctionToolStripMenuItem.AccessibleName = "&Thêm hàm";
            this.addFunctionToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunctionToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.AddMark_10580;
            this.addFunctionToolStripMenuItem.Name = "addFunctionToolStripMenuItem";
            this.addFunctionToolStripMenuItem.Text = "&Thêm hàm";
            this.addFunctionToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.addFunctionToolStripMenuItem.Click += new System.EventHandler(this.addFunctionToolStripMenuItem_Click);
            // 
            // editFunctionToolStripMenuItem1
            // 
            this.editFunctionToolStripMenuItem1.AccessibleDescription = "&Sửa hàm đang chọn";
            this.editFunctionToolStripMenuItem1.AccessibleName = "&Sửa hàm đang chọn";
            this.editFunctionToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFunctionToolStripMenuItem1.Image = global::PixelsGraph.Properties.Resources.EditTitleString_357;
            this.editFunctionToolStripMenuItem1.Name = "editFunctionToolStripMenuItem1";
            this.editFunctionToolStripMenuItem1.Text = "&Sửa hàm đang chọn";
            this.editFunctionToolStripMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.editFunctionToolStripMenuItem1.Click += new System.EventHandler(this.editFunctionToolStripMenuItem_Click);
            // 
            // removeFunctionToolStripMenuItem1
            // 
            this.removeFunctionToolStripMenuItem1.AccessibleDescription = "&Xóa hàm đang chọn";
            this.removeFunctionToolStripMenuItem1.AccessibleName = "&Xóa hàm đang chọn";
            this.removeFunctionToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFunctionToolStripMenuItem1.Image = global::PixelsGraph.Properties.Resources.Clearallrequests_8816;
            this.removeFunctionToolStripMenuItem1.Name = "removeFunctionToolStripMenuItem1";
            this.removeFunctionToolStripMenuItem1.Text = "&Xóa hàm đang chọn";
            this.removeFunctionToolStripMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.removeFunctionToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // addTangentLineToolStripMenuItem
            // 
            this.addTangentLineToolStripMenuItem.AccessibleDescription = "Thê&m tiếp tuyến hàm đang chọn";
            this.addTangentLineToolStripMenuItem.AccessibleName = "Thê&m tiếp tuyến hàm đang chọn";
            this.addTangentLineToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTangentLineToolStripMenuItem.Name = "addTangentLineToolStripMenuItem";
            this.addTangentLineToolStripMenuItem.Text = "Thê&m tiếp tuyến hàm đang chọn";
            this.addTangentLineToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.addTangentLineToolStripMenuItem.Click += new System.EventHandler(this.addTangentLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // removeAllFunctionToolStripMenuItem1
            // 
            this.removeAllFunctionToolStripMenuItem1.AccessibleDescription = "Xóa &danh sách hàm số";
            this.removeAllFunctionToolStripMenuItem1.AccessibleName = "Xóa &danh sách hàm số";
            this.removeAllFunctionToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllFunctionToolStripMenuItem1.Image = global::PixelsGraph.Properties.Resources.Clearwindowcontent_6304;
            this.removeAllFunctionToolStripMenuItem1.Name = "removeAllFunctionToolStripMenuItem1";
            this.removeAllFunctionToolStripMenuItem1.Text = "Xóa &danh sách hàm số";
            this.removeAllFunctionToolStripMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.removeAllFunctionToolStripMenuItem1.Click += new System.EventHandler(this.deleteAllFunctionToolStripMenuItem_Click);
            // 
            // helpMenuToolStripMenuItem
            // 
            this.helpMenuToolStripMenuItem.AccessibleDescription = "Trợ giúp";
            this.helpMenuToolStripMenuItem.AccessibleName = "Trợ giúp";
            this.helpMenuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMenuToolStripMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.helpToolStripMenuItem,
            this.toolStripSeparator13,
            this.aboutToolStripMenuItem,
            this.piGraphToolStripMenuItem});
            this.helpMenuToolStripMenuItem.Name = "helpMenuToolStripMenuItem";
            this.helpMenuToolStripMenuItem.ShowArrow = false;
            this.helpMenuToolStripMenuItem.Text = "Trợ giúp";
            this.helpMenuToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleDescription = "&Hướng dẫn sử dụng";
            this.helpToolStripMenuItem.AccessibleName = "&Hướng dẫn sử dụng";
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.Help_6522;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Text = "&Hướng dẫn sử dụng";
            this.helpToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AccessibleDescription = "&Thông tin về nhóm phát triển";
            this.aboutToolStripMenuItem.AccessibleName = "&Thông tin về nhóm phát triển";
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.StatusAnnotations_Information_16xLG;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Text = "&Thông tin về nhóm phát triển";
            this.aboutToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // piGraphToolStripMenuItem
            // 
            this.piGraphToolStripMenuItem.AccessibleDescription = "PiGraph";
            this.piGraphToolStripMenuItem.AccessibleName = "PiGraph";
            this.piGraphToolStripMenuItem.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.piGraphToolStripMenuItem.Enabled = false;
            this.piGraphToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piGraphToolStripMenuItem.Name = "piGraphToolStripMenuItem";
            this.piGraphToolStripMenuItem.Text = "PiGraph";
            this.piGraphToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // rightClickMenuStrip
            // 
            this.rightClickMenuStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.addToolStripMenuItem,
            this.removeFunctionToolStripMenuItem2,
            this.editFunctionToolStripMenuItem2,
            this.toolStripSeparator9,
            this.unbindFunctionListToolStripMenuItem2,
            this.toolStripSeparator4,
            this.addTangentLineToolStripMenuItem2,
            this.toolStripSeparator7,
            this.removeAllFunctionToolStripMenuItem2});
            this.rightClickMenuStrip.ThemeName = "Office2013Light";
            this.rightClickMenuStrip.DropDownOpening += new System.ComponentModel.CancelEventHandler(this.rightClickMenuStrip_DropDownOpeningOpening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.AccessibleDescription = "Thêm";
            this.addToolStripMenuItem.AccessibleName = "Thêm";
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Image = global::PixelsGraph.Properties.Resources.AddMark_10580;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Text = "Thêm";
            this.addToolStripMenuItem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addFunctionToolStripMenuItem_Click);
            // 
            // removeFunctionToolStripMenuItem2
            // 
            this.removeFunctionToolStripMenuItem2.AccessibleDescription = "Xóa";
            this.removeFunctionToolStripMenuItem2.AccessibleName = "Xóa";
            this.removeFunctionToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFunctionToolStripMenuItem2.Image = global::PixelsGraph.Properties.Resources.Clearallrequests_8816;
            this.removeFunctionToolStripMenuItem2.Name = "removeFunctionToolStripMenuItem2";
            this.removeFunctionToolStripMenuItem2.Text = "Xóa";
            this.removeFunctionToolStripMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.removeFunctionToolStripMenuItem2.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // editFunctionToolStripMenuItem2
            // 
            this.editFunctionToolStripMenuItem2.AccessibleDescription = "Sửa";
            this.editFunctionToolStripMenuItem2.AccessibleName = "Sửa";
            this.editFunctionToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFunctionToolStripMenuItem2.Image = global::PixelsGraph.Properties.Resources.EditTitleString_357;
            this.editFunctionToolStripMenuItem2.Name = "editFunctionToolStripMenuItem2";
            this.editFunctionToolStripMenuItem2.Text = "Sửa";
            this.editFunctionToolStripMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.editFunctionToolStripMenuItem2.Click += new System.EventHandler(this.editFunctionToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // unbindFunctionListToolStripMenuItem2
            // 
            this.unbindFunctionListToolStripMenuItem2.AccessibleDescription = "&Gỡ danh sách";
            this.unbindFunctionListToolStripMenuItem2.AccessibleName = "&Gỡ danh sách";
            this.unbindFunctionListToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unbindFunctionListToolStripMenuItem2.Image = global::PixelsGraph.Properties.Resources.HideMember_6755;
            this.unbindFunctionListToolStripMenuItem2.Name = "unbindFunctionListToolStripMenuItem2";
            this.unbindFunctionListToolStripMenuItem2.Text = "&Gỡ danh sách";
            this.unbindFunctionListToolStripMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.unbindFunctionListToolStripMenuItem2.Click += new System.EventHandler(this.unbindFunctionListToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // addTangentLineToolStripMenuItem2
            // 
            this.addTangentLineToolStripMenuItem2.AccessibleDescription = "Thêm tiếp tuyến";
            this.addTangentLineToolStripMenuItem2.AccessibleName = "Thêm tiếp tuyến";
            this.addTangentLineToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTangentLineToolStripMenuItem2.Name = "addTangentLineToolStripMenuItem2";
            this.addTangentLineToolStripMenuItem2.Text = "Thêm tiếp tuyến";
            this.addTangentLineToolStripMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.addTangentLineToolStripMenuItem2.Click += new System.EventHandler(this.addTangentLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // removeAllFunctionToolStripMenuItem2
            // 
            this.removeAllFunctionToolStripMenuItem2.AccessibleDescription = "Xóa danh sách";
            this.removeAllFunctionToolStripMenuItem2.AccessibleName = "Xóa danh sách";
            this.removeAllFunctionToolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllFunctionToolStripMenuItem2.Image = global::PixelsGraph.Properties.Resources.Clearwindowcontent_6304;
            this.removeAllFunctionToolStripMenuItem2.Name = "removeAllFunctionToolStripMenuItem2";
            this.removeAllFunctionToolStripMenuItem2.Text = "Xóa danh sách";
            this.removeAllFunctionToolStripMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.removeAllFunctionToolStripMenuItem2.Click += new System.EventHandler(this.deleteAllFunctionToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.noteTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radSplitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 392);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(3, 365);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.NullText = "Ghi chú của hàm số.";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(939, 24);
            this.noteTextBox.TabIndex = 3;
            this.noteTextBox.TabStop = false;
            this.noteTextBox.ThemeName = "Office2013Light";
            this.noteTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(945, 362);
            this.radSplitContainer1.SplitterWidth = 5;
            this.radSplitContainer1.TabIndex = 4;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            this.radSplitContainer1.ThemeName = "Office2013Light";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.listBox1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(193, 362);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.2946808F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-278, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "Office2013Light";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.radContextMenuManager1.SetRadContextMenu(this.listBox1, this.rightClickMenuStrip);
            this.listBox1.Size = new System.Drawing.Size(193, 362);
            this.listBox1.TabIndex = 2;
            this.listBox1.ThemeName = "Office2013Light";
            this.listBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.openGLControl);
            this.splitPanel2.Location = new System.Drawing.Point(198, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(747, 362);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.2946808F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(278, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "Office2013Light";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.toolStripStatusLabel1,
            this.commandBarSeparator1,
            this.currentFunctionToolStripStatusLabel,
            this.radLabelElement1});
            this.statusStrip.Location = new System.Drawing.Point(0, 411);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(945, 26);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ThemeName = "Office2013Light";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AccessibleDescription = "Nhấn F1 để xem hướng dẫn";
            this.toolStripStatusLabel1.AccessibleName = "Nhấn F1 để xem hướng dẫn";
            this.toolStripStatusLabel1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.statusStrip.SetSpring(this.toolStripStatusLabel1, false);
            this.toolStripStatusLabel1.Text = "Nhấn F1 để xem hướng dẫn";
            this.toolStripStatusLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripStatusLabel1.TextWrap = true;
            this.toolStripStatusLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.statusStrip.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // currentFunctionToolStripStatusLabel
            // 
            this.currentFunctionToolStripStatusLabel.AccessibleDescription = "Function status";
            this.currentFunctionToolStripStatusLabel.AccessibleName = "Function status";
            this.currentFunctionToolStripStatusLabel.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.currentFunctionToolStripStatusLabel.AutoToolTip = true;
            this.currentFunctionToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFunctionToolStripStatusLabel.Name = "currentFunctionToolStripStatusLabel";
            this.statusStrip.SetSpring(this.currentFunctionToolStripStatusLabel, false);
            this.currentFunctionToolStripStatusLabel.Text = "Function status";
            this.currentFunctionToolStripStatusLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.currentFunctionToolStripStatusLabel.TextWrap = true;
            this.currentFunctionToolStripStatusLabel.ToolTipText = "Hàm đang được chọn trên danh sách hàm số.";
            this.currentFunctionToolStripStatusLabel.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.AccessibleDescription = "X: 0, Y: 0";
            this.radLabelElement1.AccessibleName = "X: 0, Y: 0";
            this.radLabelElement1.AutoSize = true;
            this.radLabelElement1.FlipText = false;
            this.radLabelElement1.Name = "radLabelElement1";
            this.statusStrip.SetSpring(this.radLabelElement1, true);
            this.radLabelElement1.Text = "X: 0, Y: 0";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // saveImageFileDialog
            // 
            this.saveImageFileDialog.Filter = "Portable Network Graphics (PNG) file (*.png)|*.png|Joint Photographic Experts Gro" +
    "up (JPEG) file (*.jpeg)|*.jpeg|Bitmap (BMP) file (*.bmp)|*.bmp";
            this.saveImageFileDialog.Title = "Chọn đường dẫn để lưu hình vẽ";
            this.saveImageFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveImgaeFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "graph1";
            this.saveFileDialog.Title = "Chọn đường dẫn để lưu tệp vẽ";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Chọn đường dẫn để mở tệp";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openFileBackgroundWorker
            // 
            this.openFileBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.openFileBackgroundWorker_DoWork);
            this.openFileBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.openFileBackgroundWorker_RunWorkerCompleted);
            // 
            // saveBackgroundWorker
            // 
            this.saveBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.saveBackgroundWorker_DoWork);
            this.saveBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.saveBackgroundWorker_RunWorkerCompleted);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.fileMenuToolStripMenuItem,
            this.functionMenuToolStripMenuItem,
            this.editMenuToolStripMenuItem,
            this.helpMenuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(945, 19);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ThemeName = "Office2013Light";
            // 
            // pointToolStripStatusLabel1
            // 
            this.pointToolStripStatusLabel1.AccessibleDescription = "| X: 12.0, Y: 12.0";
            this.pointToolStripStatusLabel1.AccessibleName = "| X: 12.0, Y: 12.0";
            this.pointToolStripStatusLabel1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.pointToolStripStatusLabel1.AutoSize = true;
            this.pointToolStripStatusLabel1.Name = "pointToolStripStatusLabel1";
            this.pointToolStripStatusLabel1.RightToLeft = false;
            this.pointToolStripStatusLabel1.Text = "| X: 12.0, Y: 12.0";
            this.pointToolStripStatusLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pointToolStripStatusLabel1.TextWrap = true;
            this.pointToolStripStatusLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radOffice2007ScreenTipElement1
            // 
            this.radOffice2007ScreenTipElement1.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTipElement1.Name = "radOffice2007ScreenTipElement1";
            this.radOffice2007ScreenTipElement1.TemplateType = null;
            this.radOffice2007ScreenTipElement1.TipSize = new System.Drawing.Size(210, 50);
            this.radOffice2007ScreenTipElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radDesktopAlert
            // 
            this.radDesktopAlert.AutoCloseDelay = 35;
            this.radDesktopAlert.FadeAnimationSpeed = 12;
            this.radDesktopAlert.FadeAnimationType = Telerik.WinControls.UI.FadeAnimationType.FadeIn;
            this.radDesktopAlert.Opacity = 1F;
            this.radDesktopAlert.PopupAnimationEasing = Telerik.WinControls.RadEasingType.OutBounce;
            this.radDesktopAlert.ShowOptionsButton = false;
            this.radDesktopAlert.ThemeName = "Office2013Light";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 437);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.KeyPreview = true;
            this.Name = "MainMenu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PiGraph";
            this.ThemeName = "Office2013Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.Resize += new System.EventHandler(this.MainMenuForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private RadMenuItem fileMenuToolStripMenuItem;
        private RadMenuItem newToolStripMenuItem;
        private RadMenuItem openFileToolStripMenuItem;
        private RadMenuItem saveFileToolStripMenuItem;
        private RadMenuItem exportToolStripMenuItem;
        private RadMenuItem exitToolStripMenuItem;
        private RadMenuItem editMenuToolStripMenuItem;
        private RadMenuItem optionToolStripMenuItem;
        private RadMenuItem functionMenuToolStripMenuItem;
        private RadMenuItem addFunctionToolStripMenuItem;
        private RadMenuItem editFunctionToolStripMenuItem1;
        private RadMenuItem addTangentLineToolStripMenuItem;
        private RadMenuItem helpMenuToolStripMenuItem;
        private RadMenuItem aboutToolStripMenuItem;
        private RadMenuSeparatorItem toolStripSeparator1;
        private RadMenuSeparatorItem toolStripSeparator2;
        private RadContextMenu rightClickMenuStrip;
        private RadMenuItem addToolStripMenuItem;
        private RadMenuItem removeFunctionToolStripMenuItem2;
        private RadMenuItem editFunctionToolStripMenuItem2;
        private RadMenuItem removeFunctionToolStripMenuItem1;
        private RadMenuSeparatorItem toolStripSeparator5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RadMenuItem helpToolStripMenuItem;
        private RadTextBox noteTextBox;
        private RadMenuSeparatorItem toolStripSeparator6;
        private RadMenuItem removeAllFunctionToolStripMenuItem1;
        private RadMenuItem removeAllFunctionToolStripMenuItem2;
        private RadStatusStrip statusStrip;
        private System.Windows.Forms.SaveFileDialog saveImageFileDialog;
        private RadMenuSeparatorItem toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private RadMenuItem saveAsToolStripMenuItem;
        private RadLabelElement toolStripStatusLabel1;
        private RadContextMenu openGLContextMenuStrip;
        private RadMenuItem zoomInToolStripMenuItem;
        private RadMenuItem zoomOutToolStripMenuItem;
        private RadMenuSeparatorItem toolStripSeparator8;
        private RadMenuItem zoomTo100ToolStripMenuItem;
        private RadMenuSeparatorItem toolStripSeparator9;
        private RadLabelElement currentFunctionToolStripStatusLabel;
        private RadMenuItem unbindFunctionListToolStripMenuItem;
        private RadMenuSeparatorItem toolStripSeparator10;
        private System.Windows.Forms.Timer timer1;
        private RadMenuItem gridEnableToolStripMenuItem;
        private RadMenuSeparatorItem toolStripSeparator12;
        private System.ComponentModel.BackgroundWorker openFileBackgroundWorker;
        private System.ComponentModel.BackgroundWorker saveBackgroundWorker;
        private RadMenuItem piGraphToolStripMenuItem;
        private RadMenuSeparatorItem toolStripSeparator13;
        private RadMenuItem unbindFunctionListToolStripMenuItem2;
        private RadMenuItem addTangentLineToolStripMenuItem2;
        private RadMenuSeparatorItem toolStripSeparator7;
        private volatile RadListControl listBox1;
        private RadContextMenuManager radContextMenuManager1;
        private RadThemeManager radThemeManager1;
        private RadMenu menuStrip;
        private RadSplitContainer radSplitContainer1;
        private SplitPanel splitPanel1;
        private SplitPanel splitPanel2;
        private RadLabelElement pointToolStripStatusLabel1;
        private CommandBarSeparator commandBarSeparator1;
        private RadLabelElement radLabelElement1;
        private RadOffice2007ScreenTipElement radOffice2007ScreenTipElement1;
        private RadDesktopAlert radDesktopAlert;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}

