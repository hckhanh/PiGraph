using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PixelsGraph.ReferencesForm
{
    public partial class References : RadForm
    {
        #region Public

        public References()
        {
            InitializeComponent();
        }

        public Color NumbericColor
        {
            get
            {
                return settings.NumbericColor;
            }
            set
            {
                settings.NumbericColor = value;
                numberColorBox.ColorValue = value;
            }
        }


        public Color GridColor
        {
            get
            {
                return settings.GridColor;
            }
            set
            {
                settings.GridColor = value;
                gridColorBox.ColorValue = value;
            }
        }

        public Color AxisCoordinateColor
        {
            get
            {
                return settings.AxisCoordinateColor;
            }
            set
            {
                settings.AxisCoordinateColor = value;
                axisCoordinateColorBox.ColorValue = value;
            }
        }

        public bool EnableCoordinateGrid
        {
            get
            {
                return settings.EnableCoordinateGrid;
            }
            set
            {
                settings.EnableCoordinateGrid = value;
                enableCoordinateGridcheckBox.Checked = value;
            }
        }

        public Color BackGroundColor
        {
            get
            {
                return settings.BackGroundColor;
            }
            set
            {
                settings.BackGroundColor = value;
                backGroundColorBox.ColorValue = value;
            }
        }

        public new decimal Scale
        {
            get
            {
                return settings.Scale;
            }
            set
            {
                settings.Scale = value;
                zoomNumericUpDown.Value = value;
            }
        }

        public decimal NoteSize
        {
            get
            {
                return settings.NoteSize;
            }
            set
            {
                settings.NoteSize = value;
                noteSizeNumericUpDown.Value = value;
            }
        }

        public decimal DepthLine
        {
            get
            {
                return settings.DepthLine;
            }
            set
            {
                settings.DepthLine = value;
                depthLineNumericUpDown.Value = value;
            }
        }

        public void Save()
        {
            SaveSettings();
            settings.Save();
        }

        public event EventHandler SettingsOK = null;

        #endregion

        #region Private

        Properties.Settings settings = new Properties.Settings();

        private void LoadSettings()
        {
            numberColorBox.ColorValue = settings.NumbericColor;
            gridColorBox.ColorValue = settings.GridColor;
            axisCoordinateColorBox.ColorValue = settings.AxisCoordinateColor;
            enableCoordinateGridcheckBox.Checked = settings.EnableCoordinateGrid;
            backGroundColorBox.ColorValue = settings.BackGroundColor;
            zoomNumericUpDown.Value = settings.Scale;
            noteSizeNumericUpDown.Value = settings.NoteSize;
            depthLineNumericUpDown.Value = settings.DepthLine;
        }

        private void SaveSettings()
        {
            settings.NumbericColor = numberColorBox.ColorValue;
            settings.GridColor = gridColorBox.ColorValue;
            settings.AxisCoordinateColor = axisCoordinateColorBox.ColorValue;
            settings.EnableCoordinateGrid = enableCoordinateGridcheckBox.Checked;
            settings.BackGroundColor = backGroundColorBox.ColorValue;
            settings.Scale = zoomNumericUpDown.Value;
            settings.NoteSize = noteSizeNumericUpDown.Value;
            settings.DepthLine = depthLineNumericUpDown.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            settings.Save();
            if (SettingsOK != null)
            {
                SettingsOK(sender, e);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSettings();
            this.Close();
        }

        private void References_Load(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            LoadSettings();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            numberColorBox.ColorValue = Color.Red;
            gridColorBox.ColorValue = Color.DarkGray;
            axisCoordinateColorBox.ColorValue = Color.Black;
            enableCoordinateGridcheckBox.Checked = true;
            backGroundColorBox.ColorValue = Color.White;
            zoomNumericUpDown.Value = 50;
            noteSizeNumericUpDown.Value = 14;
            depthLineNumericUpDown.Value = 1.5M;
        }

        #endregion
    }
}
