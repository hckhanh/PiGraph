using Telerik.WinControls.UI;
namespace PixelsGraph.AddTangentialLineForm
{
    partial class AddTangentialLine
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
            this.param1 = new Telerik.WinControls.UI.RadTextBox();
            this.param2 = new Telerik.WinControls.UI.RadTextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.addFunctionButton = new Telerik.WinControls.UI.RadButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noteTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorBox = new PixelsGraph.ColorBox();
            this.label1 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.param1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFunctionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // param1
            // 
            this.param1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1.Location = new System.Drawing.Point(51, 34);
            this.param1.Margin = new System.Windows.Forms.Padding(4);
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(117, 25);
            this.param1.TabIndex = 2;
            this.param1.TabStop = false;
            this.param1.ThemeName = "Office2013Light";
            this.param1.TextChanged += new System.EventHandler(this.param1_TextChanged);
            this.param1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyDown);
            // 
            // param2
            // 
            this.param2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param2.Location = new System.Drawing.Point(213, 34);
            this.param2.Margin = new System.Windows.Forms.Padding(4);
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(117, 25);
            this.param2.TabIndex = 3;
            this.param2.TabStop = false;
            this.param2.ThemeName = "Office2013Light";
            this.param2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateKeyDown);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(12, 37);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(30, 20);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "x =";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(175, 37);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(30, 20);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "y =";
            // 
            // addFunctionButton
            // 
            this.addFunctionButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFunctionButton.Location = new System.Drawing.Point(428, 169);
            this.addFunctionButton.Name = "addFunctionButton";
            this.addFunctionButton.Size = new System.Drawing.Size(129, 34);
            this.addFunctionButton.TabIndex = 11;
            this.addFunctionButton.Text = "Thêm tiếp tuyến";
            this.addFunctionButton.ThemeName = "Office2013Light";
            this.addFunctionButton.Click += new System.EventHandler(this.addFunctionButton_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(12, 169);
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
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Màu sắc:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(15, 129);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.NullText = "Ghi chú cho tiếp tuyến.";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextBox.Size = new System.Drawing.Size(542, 25);
            this.noteTextBox.TabIndex = 17;
            this.noteTextBox.TabStop = false;
            this.noteTextBox.ThemeName = "Office2013Light";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
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
            this.colorBox.Location = new System.Drawing.Point(89, 68);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.ReadOnly = true;
            this.colorBox.Size = new System.Drawing.Size(138, 27);
            this.colorBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mời bạn nhập điểm trên hàm số:";
            // 
            // AddTangentialLine
            // 
            this.AcceptButton = this.addFunctionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.addFunctionButton);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.param2);
            this.Controls.Add(this.param1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTangentialLine";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm tiếp tuyến cho hàm số {0}";
            this.ThemeName = "Office2013Light";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddFunctionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.param1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFunctionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label3;
        private RadTextBox noteTextBox;
        private System.Windows.Forms.Label label2;
        private ColorBox colorBox;
        private RadTextBox param1;
        private RadTextBox param2;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX3;
        private RadButton addFunctionButton;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}

