using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class Resize : Form
    {
        public float ratio;
        private Boolean locked;
        public Resize(int width, int height)
        {
            InitializeComponent();

            locked = false;

            this.width.Value = width;
            this.height.Value = height;

            ratio = (float)this.width.Value / (float)this.height.Value;

            aspectRatioButton.Checked = true;
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            if (!locked && aspectRatioButton.Checked)
            {
                locked = true;
                height.Value = (int)((int)(width.Value) / ratio);
                locked = false;
            } 
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {
            if (!locked && aspectRatioButton.Checked)
            {
                locked = true;
                height.Value = (int)((int)(width.Value) * ratio);
                locked = false;
            }
        }

        private void resizeApplyButton_Click(object sender, EventArgs e)
        {
            ((ImageForm)Owner).resize((int)width.Value, (int)height.Value, comboBox1.SelectedIndex);
            Close();
        }

        private void Resize_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
