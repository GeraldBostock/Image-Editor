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
    public partial class HistogramForm : Form
    {
        Bitmap image;
        int[] histogramArray;
        int width, height;

        public HistogramForm(Bitmap imageToDisplay, int[] histogram, int width, int height)
        {
            InitializeComponent();
            image = imageToDisplay;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pixelsLabel.Text = (width * height).ToString();
            histogramArray = histogram;
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0);
        }

        public void Draw(Bitmap newImage)
        {
            image = (Bitmap)newImage.Clone();
            this.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);
            levelLabel.Text = relativePoint.X.ToString();
            countLabel.Text = histogramArray[relativePoint.X].ToString();
        }
    }
}
