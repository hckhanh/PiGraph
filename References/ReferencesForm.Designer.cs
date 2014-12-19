using Telerik.WinControls.UI;
namespace PixelsGraph.ReferencesForm
{
    partial class References
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
            this.enableCoordinateGridcheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.depthLineNumericUpDown = new Telerik.WinControls.UI.RadSpinEditor();
            this.button1 = new Telerik.WinControls.UI.RadButton();
            this.button2 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.axisCoordinateColorBox = new PixelsGraph.ColorBox();
            this.gridColorBox = new PixelsGraph.ColorBox();
            this.numberColorBox = new PixelsGraph.ColorBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noteSizeNumericUpDown = new Telerik.WinControls.UI.RadSpinEditor();
            this.zoomNumericUpDown = new Telerik.WinControls.UI.RadSpinEditor();
            this.label8 = new System.Windows.Forms.Label();
            this.backGroundColorBox = new PixelsGraph.ColorBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.enableCoordinateGridcheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthLineNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // enableCoordinateGridcheckBox
            // 
            this.enableCoordinateGridcheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableCoordinateGridcheckBox.Location = new System.Drawing.Point(151, 129);
            this.enableCoordinateGridcheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.enableCoordinateGridcheckBox.Name = "enableCoordinateGridcheckBox";
            this.enableCoordinateGridcheckBox.Size = new System.Drawing.Size(220, 24);
            this.enableCoordinateGridcheckBox.TabIndex = 0;
            this.enableCoordinateGridcheckBox.Text = "Hiện lưới tọa độ trên trục số.";
            this.enableCoordinateGridcheckBox.ThemeName = "Office2013Light";
            this.enableCoordinateGridcheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // depthLineNumericUpDown
            // 
            this.depthLineNumericUpDown.DecimalPlaces = 1;
            this.depthLineNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLineNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.depthLineNumericUpDown.Location = new System.Drawing.Point(163, 293);
            this.depthLineNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.depthLineNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depthLineNumericUpDown.Name = "depthLineNumericUpDown";
            this.depthLineNumericUpDown.Size = new System.Drawing.Size(78, 27);
            this.depthLineNumericUpDown.TabIndex = 1;
            this.depthLineNumericUpDown.TabStop = false;
            this.depthLineNumericUpDown.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.depthLineNumericUpDown.ThemeName = "Office2013Light";
            this.depthLineNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Xác nhận";
            this.button1.ThemeName = "Office2013Light";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Hủy bỏ";
            this.button2.ThemeName = "Office2013Light";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Độ dày của nét vẽ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Màu lưới tọa độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Màu trục tọa độ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Màu chữ số:";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.Controls.Add(this.axisCoordinateColorBox);
            this.groupBox1.Controls.Add(this.gridColorBox);
            this.groupBox1.Controls.Add(this.numberColorBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.enableCoordinateGridcheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.HeaderText = "Lưới tọa độ";
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 157);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lưới tọa độ";
            this.groupBox1.ThemeName = "Office2013Light";
            // 
            // axisCoordinateColorBox
            // 
            this.axisCoordinateColorBox.AccessibleDescription = "The ColorBox";
            this.axisCoordinateColorBox.AccessibleName = "ColorBox";
            this.axisCoordinateColorBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.axisCoordinateColorBox.BackColor = System.Drawing.Color.Black;
            this.axisCoordinateColorBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.axisCoordinateColorBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisCoordinateColorBox.Location = new System.Drawing.Point(151, 92);
            this.axisCoordinateColorBox.Margin = new System.Windows.Forms.Padding(4);
            this.axisCoordinateColorBox.Name = "axisCoordinateColorBox";
            this.axisCoordinateColorBox.ReadOnly = true;
            this.axisCoordinateColorBox.Size = new System.Drawing.Size(100, 29);
            this.axisCoordinateColorBox.TabIndex = 10;
            // 
            // gridColorBox
            // 
            this.gridColorBox.AccessibleDescription = "The ColorBox";
            this.gridColorBox.AccessibleName = "ColorBox";
            this.gridColorBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.gridColorBox.BackColor = System.Drawing.Color.DarkGray;
            this.gridColorBox.ColorValue = System.Drawing.Color.DarkGray;
            this.gridColorBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gridColorBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColorBox.Location = new System.Drawing.Point(151, 60);
            this.gridColorBox.Margin = new System.Windows.Forms.Padding(4);
            this.gridColorBox.Name = "gridColorBox";
            this.gridColorBox.ReadOnly = true;
            this.gridColorBox.Size = new System.Drawing.Size(100, 29);
            this.gridColorBox.TabIndex = 9;
            // 
            // numberColorBox
            // 
            this.numberColorBox.AccessibleDescription = "The ColorBox";
            this.numberColorBox.AccessibleName = "ColorBox";
            this.numberColorBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.numberColorBox.BackColor = System.Drawing.Color.Red;
            this.numberColorBox.ColorValue = System.Drawing.Color.Red;
            this.numberColorBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numberColorBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberColorBox.Location = new System.Drawing.Point(151, 28);
            this.numberColorBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberColorBox.Name = "numberColorBox";
            this.numberColorBox.ReadOnly = true;
            this.numberColorBox.Size = new System.Drawing.Size(100, 29);
            this.numberColorBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Màu nền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Scale:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kích thước ghi chú:";
            // 
            // noteSizeNumericUpDown
            // 
            this.noteSizeNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteSizeNumericUpDown.Location = new System.Drawing.Point(163, 258);
            this.noteSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noteSizeNumericUpDown.Name = "noteSizeNumericUpDown";
            this.noteSizeNumericUpDown.Size = new System.Drawing.Size(78, 27);
            this.noteSizeNumericUpDown.TabIndex = 16;
            this.noteSizeNumericUpDown.TabStop = false;
            this.noteSizeNumericUpDown.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.noteSizeNumericUpDown.ThemeName = "Office2013Light";
            this.noteSizeNumericUpDown.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // zoomNumericUpDown
            // 
            this.zoomNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomNumericUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.zoomNumericUpDown.Location = new System.Drawing.Point(163, 223);
            this.zoomNumericUpDown.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.zoomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zoomNumericUpDown.Name = "zoomNumericUpDown";
            this.zoomNumericUpDown.Size = new System.Drawing.Size(78, 27);
            this.zoomNumericUpDown.TabIndex = 17;
            this.zoomNumericUpDown.TabStop = false;
            this.zoomNumericUpDown.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.zoomNumericUpDown.ThemeName = "Office2013Light";
            this.zoomNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "px";
            // 
            // backGroundColorBox
            // 
            this.backGroundColorBox.AccessibleDescription = "The ColorBox";
            this.backGroundColorBox.AccessibleName = "ColorBox";
            this.backGroundColorBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.backGroundColorBox.BackColor = System.Drawing.SystemColors.Window;
            this.backGroundColorBox.ColorValue = System.Drawing.SystemColors.Window;
            this.backGroundColorBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.backGroundColorBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backGroundColorBox.Location = new System.Drawing.Point(163, 189);
            this.backGroundColorBox.Margin = new System.Windows.Forms.Padding(4);
            this.backGroundColorBox.Name = "backGroundColorBox";
            this.backGroundColorBox.ReadOnly = true;
            this.backGroundColorBox.Size = new System.Drawing.Size(100, 27);
            this.backGroundColorBox.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(256, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 20);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cài đặt về mặc định";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // References
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.backGroundColorBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zoomNumericUpDown);
            this.Controls.Add(this.noteSizeNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depthLineNumericUpDown);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "References";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chỉnh";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.References_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enableCoordinateGridcheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthLineNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadCheckBox enableCoordinateGridcheckBox;
        private RadSpinEditor depthLineNumericUpDown;
        private RadButton button1;
        private RadButton button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RadGroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private RadSpinEditor noteSizeNumericUpDown;
        private RadSpinEditor zoomNumericUpDown;
        private System.Windows.Forms.Label label8;
        private ColorBox axisCoordinateColorBox;
        private ColorBox gridColorBox;
        private ColorBox numberColorBox;
        private ColorBox backGroundColorBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}

