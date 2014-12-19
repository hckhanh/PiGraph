using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PixelsGraph
{
    public partial class ColorBox : TextBox
    {
        #region Initialize Methods

        /// <summary>
        /// Initialize the color box with default color (White).
        /// </summary>
        public ColorBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize the color boxc with specified color.
        /// </summary>
        /// <param name="color">The color of color box.</param>
        public ColorBox(Color color)
        {
            InitializeComponent();
            ColorValue = color;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets or sets the color of Color Box.
        /// </summary>
        [Category("User Property")]
        [Description("The color value of the color box")]
        [DefaultValue(typeof(Color), "Black")]
        public Color ColorValue
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        [Category("User Events")]
        [Description("Occurs whenever the user click the OK button in color dialog.")]
        public event EventHandler ColorBox_OK = null;

        #endregion

        #region Disable Properties

        [Browsable(false)]
        [ReadOnly(true)]
        public override bool Multiline
        {
            get
            {
                return base.Multiline;
            }
            set
            {
                base.Multiline = value;
            }
        }

        [Browsable(false)]
        [ReadOnly(true)]
        public override string Text
        {
            get
            {
                return string.Empty;
            }
        }

        #endregion

        void ColorBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = ColorValue;

            var result = colorDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                ColorValue = colorDialog.Color;
                if (ColorBox_OK != null)
                {
                    ColorBox_OK(sender, e);
                }
            }
        }
    }
}
