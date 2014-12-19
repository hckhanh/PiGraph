using System.Windows.Forms;
using Telerik.WinControls.UI;
namespace PixelsGraph.AddFunctionForm
{
    partial class AddFunction
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
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem1 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem2 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem3 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem4 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem5 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem6 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem7 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem8 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            Telerik.WinControls.UI.DescriptionTextListDataItem descriptionTextListDataItem9 = new Telerik.WinControls.UI.DescriptionTextListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFunction));
            this.choseFunction = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.param1 = new Telerik.WinControls.UI.RadTextBox();
            this.param2 = new Telerik.WinControls.UI.RadTextBox();
            this.param3 = new Telerik.WinControls.UI.RadTextBox();
            this.param4 = new Telerik.WinControls.UI.RadTextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX0 = new System.Windows.Forms.Label();
            this.addFunctionButton = new Telerik.WinControls.UI.RadButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noteTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorBox = new PixelsGraph.ColorBox();
            this.nonAbsRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.absf_xRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.absxRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.choseFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFunctionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonAbsRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absf_xRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absxRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // choseFunction
            // 
            this.choseFunction.AutoSizeItems = true;
            this.choseFunction.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.OutBack;
            this.choseFunction.DropDownAnimationFrames = 11;
            this.choseFunction.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.choseFunction.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.choseFunction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem1.DescriptionText = "Hàm bậc nhất";
            descriptionTextListDataItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem1.Text = "y = ax + b";
            descriptionTextListDataItem1.TextWrap = true;
            descriptionTextListDataItem2.DescriptionText = "Hàm bậc hai";
            descriptionTextListDataItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem2.Text = "y = ax² + bx + c";
            descriptionTextListDataItem2.TextWrap = true;
            descriptionTextListDataItem3.DescriptionText = "Hàm bậc ba";
            descriptionTextListDataItem3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem3.Text = "y = ax³ + bx² + cx + d";
            descriptionTextListDataItem3.TextWrap = true;
            descriptionTextListDataItem4.DescriptionText = "Hàm trùng phương";
            descriptionTextListDataItem4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem4.Text = "y = ax⁴ + bx² + c";
            descriptionTextListDataItem4.TextWrap = true;
            descriptionTextListDataItem5.DescriptionText = "Hàm phân thức bậc nhất trên bậc nhất";
            descriptionTextListDataItem5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem5.Text = "y = (ax + b) / (cx + d)";
            descriptionTextListDataItem5.TextWrap = true;
            descriptionTextListDataItem6.DescriptionText = "Hàm sin";
            descriptionTextListDataItem6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem6.Text = "y = a.sin(bx + c) + d";
            descriptionTextListDataItem6.TextWrap = true;
            descriptionTextListDataItem7.DescriptionText = "Hàm cos";
            descriptionTextListDataItem7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem7.Text = "y = a.cos(bx + c) + d";
            descriptionTextListDataItem7.TextWrap = true;
            descriptionTextListDataItem8.DescriptionText = "Hàm log";
            descriptionTextListDataItem8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem8.Text = "y = log(x) / log(a)";
            descriptionTextListDataItem8.TextWrap = true;
            descriptionTextListDataItem9.DescriptionText = "Hàm căn thức bậc nhất";
            descriptionTextListDataItem9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionTextListDataItem9.Text = "y = √(ax + b)";
            descriptionTextListDataItem9.TextWrap = true;
            this.choseFunction.Items.Add(descriptionTextListDataItem1);
            this.choseFunction.Items.Add(descriptionTextListDataItem2);
            this.choseFunction.Items.Add(descriptionTextListDataItem3);
            this.choseFunction.Items.Add(descriptionTextListDataItem4);
            this.choseFunction.Items.Add(descriptionTextListDataItem5);
            this.choseFunction.Items.Add(descriptionTextListDataItem6);
            this.choseFunction.Items.Add(descriptionTextListDataItem7);
            this.choseFunction.Items.Add(descriptionTextListDataItem8);
            this.choseFunction.Items.Add(descriptionTextListDataItem9);
            this.choseFunction.Location = new System.Drawing.Point(13, 37);
            this.choseFunction.Name = "choseFunction";
            this.choseFunction.NullText = "Chọn loại hàm số.";
            this.choseFunction.SelectNextOnDoubleClick = true;
            this.choseFunction.Size = new System.Drawing.Size(547, 27);
            this.choseFunction.TabIndex = 0;
            this.choseFunction.ThemeName = "Office2013Light";
            this.choseFunction.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.choseFunction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn loại hàm số:";
            // 
            // param1
            // 
            this.param1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1.Location = new System.Drawing.Point(57, 145);
            this.param1.Margin = new System.Windows.Forms.Padding(4);
            this.param1.Name = "param1";
            this.param1.NullText = "a";
            this.param1.Size = new System.Drawing.Size(65, 25);
            this.param1.TabIndex = 1;
            this.param1.ThemeName = "Office2013Light";
            this.param1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyDown);
            // 
            // param2
            // 
            this.param2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param2.Location = new System.Drawing.Point(180, 145);
            this.param2.Margin = new System.Windows.Forms.Padding(4);
            this.param2.Name = "param2";
            this.param2.NullText = "b";
            this.param2.Size = new System.Drawing.Size(65, 25);
            this.param2.TabIndex = 2;
            this.param2.ThemeName = "Office2013Light";
            this.param2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyDown);
            // 
            // param3
            // 
            this.param3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param3.Location = new System.Drawing.Point(303, 145);
            this.param3.Name = "param3";
            this.param3.NullText = "c";
            this.param3.Size = new System.Drawing.Size(65, 25);
            this.param3.TabIndex = 3;
            this.param3.ThemeName = "Office2013Light";
            this.param3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyDown);
            // 
            // param4
            // 
            this.param4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param4.Location = new System.Drawing.Point(426, 145);
            this.param4.Name = "param4";
            this.param4.NullText = "d";
            this.param4.Size = new System.Drawing.Size(65, 25);
            this.param4.TabIndex = 4;
            this.param4.ThemeName = "Office2013Light";
            this.param4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyDown);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(8, 148);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(30, 20);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "y =";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(123, 148);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(50, 20);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "lable1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(246, 148);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 20);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "label2";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(369, 148);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 20);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "label4";
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX0.Location = new System.Drawing.Point(492, 148);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(50, 20);
            this.labelX0.TabIndex = 10;
            this.labelX0.Text = "label5";
            // 
            // addFunctionButton
            // 
            this.addFunctionButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunctionButton.Location = new System.Drawing.Point(437, 299);
            this.addFunctionButton.Name = "addFunctionButton";
            this.addFunctionButton.Size = new System.Drawing.Size(123, 34);
            this.addFunctionButton.TabIndex = 6;
            this.addFunctionButton.Text = "Thêm hàm";
            this.addFunctionButton.ThemeName = "Office2013Light";
            this.addFunctionButton.Click += new System.EventHandler(this.addFunctionButton_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(8, 299);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(112, 20);
            this.labelMessage.TabIndex = 12;
            this.labelMessage.Text = "error message...";
            this.labelMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Màu sắc:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(13, 254);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.NullText = "Ghi chú cho hàm số.";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextBox.Size = new System.Drawing.Size(547, 24);
            this.noteTextBox.TabIndex = 5;
            this.noteTextBox.ThemeName = "Office2013Light";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ghi chú:";
            // 
            // colorBox
            // 
            this.colorBox.AccessibleDescription = "The ColorBox";
            this.colorBox.AccessibleName = "ColorBox";
            this.colorBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.colorBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBox.ForeColor = System.Drawing.Color.White;
            this.colorBox.Location = new System.Drawing.Point(83, 193);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.ReadOnly = true;
            this.colorBox.Size = new System.Drawing.Size(138, 27);
            this.colorBox.TabIndex = 19;
            // 
            // nonAbsRadioButton
            // 
            this.nonAbsRadioButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonAbsRadioButton.Location = new System.Drawing.Point(12, 102);
            this.nonAbsRadioButton.Name = "nonAbsRadioButton";
            this.nonAbsRadioButton.Size = new System.Drawing.Size(77, 22);
            this.nonAbsRadioButton.TabIndex = 20;
            this.nonAbsRadioButton.TabStop = true;
            this.nonAbsRadioButton.Text = "y = f(x)";
            this.nonAbsRadioButton.ThemeName = "Office2013Light";
            this.nonAbsRadioButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.nonAbsRadioButton_ToggleStateChanged);
            // 
            // absf_xRadioButton
            // 
            this.absf_xRadioButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absf_xRadioButton.Location = new System.Drawing.Point(115, 102);
            this.absf_xRadioButton.Name = "absf_xRadioButton";
            this.absf_xRadioButton.Size = new System.Drawing.Size(89, 22);
            this.absf_xRadioButton.TabIndex = 21;
            this.absf_xRadioButton.TabStop = true;
            this.absf_xRadioButton.Text = "y = |f(x)|";
            this.absf_xRadioButton.ThemeName = "Office2013Light";
            this.absf_xRadioButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.absf_xRadioButton_ToggleStateChanged);
            // 
            // absxRadioButton
            // 
            this.absxRadioButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absxRadioButton.Location = new System.Drawing.Point(228, 102);
            this.absxRadioButton.Name = "absxRadioButton";
            this.absxRadioButton.Size = new System.Drawing.Size(89, 22);
            this.absxRadioButton.TabIndex = 22;
            this.absxRadioButton.TabStop = true;
            this.absxRadioButton.Text = "y = f(|x|)";
            this.absxRadioButton.ThemeName = "Office2013Light";
            this.absxRadioButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.absxRadioButton_ToggleStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dạng hàm thể hiện:";
            // 
            // AddFunction
            // 
            this.AcceptButton = this.addFunctionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.absxRadioButton);
            this.Controls.Add(this.absf_xRadioButton);
            this.Controls.Add(this.nonAbsRadioButton);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.addFunctionButton);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.param4);
            this.Controls.Add(this.param3);
            this.Controls.Add(this.param2);
            this.Controls.Add(this.param1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choseFunction);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFunction";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Hàm Số";
            this.ThemeName = "Office2013Light";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddFunctionForm_FormClosed);
            this.Load += new System.EventHandler(this.AddFunctionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.choseFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFunctionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonAbsRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absf_xRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absxRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadTextBox param3;
        private RadTextBox param4;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label3;
        private RadTextBox noteTextBox;
        private System.Windows.Forms.Label label2;
        private ColorBox colorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private RadDropDownList choseFunction;
        private RadTextBox param1;
        private RadTextBox param2;
        private Label labelY;
        private System.Windows.Forms.Label labelX3;
        private RadButton addFunctionButton;
        private RadRadioButton nonAbsRadioButton;
        private RadRadioButton absf_xRadioButton;
        private RadRadioButton absxRadioButton;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}

