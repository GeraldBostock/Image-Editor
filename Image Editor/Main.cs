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
    public partial class Main : Form
    {
        public ImageForm lastFocused;
        private Dictionary<ToolStripMenuItem, GrayScaleMode> scalingDict;
        private ToolStripMenuItem[] RgbButtons;

        public Main()
        {
            InitializeComponent();

            lastFocused = null;
            
            scalingDict = new Dictionary<ToolStripMenuItem, GrayScaleMode>();
            scalingDict[averageToolStripMenuItem] = GrayScaleMode.Average;
            scalingDict[lumaToolStripMenuItem] = GrayScaleMode.Luma;
            scalingDict[desaturationToolStripMenuItem] = GrayScaleMode.Desaturation;
            scalingDict[decompositionMaxToolStripMenuItem] = GrayScaleMode.DecompositionMax;
            scalingDict[decompositionMinToolStripMenuItem] = GrayScaleMode.DecompositionMin;

            RgbButtons = new ToolStripMenuItem[3];
            RgbButtons[0] = RedChannel;
            RgbButtons[1] = GreenChannel;
            RgbButtons[2] = BlueChannel;
        }

        private void fileOpenClick(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim dosyaları (*.bmp, *.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.bmp; *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string imagePath = file.FileName;

                ImageForm imageForm = new ImageForm(imagePath, this);
                imageForm.Show();
            }
        }

        public void imageEditing(Boolean status)
        {
            save.Enabled = status;
            saveAs.Enabled = status;
            histogramButton.Enabled = status;
            invertButton.Enabled = status;
            resizeButton.Enabled = status;
            mirroringDropdown.Enabled = status;
            rotateDropdown.Enabled = status;
            colorChannelButton.Enabled = status;
            reopenToolStripMenuItem.Enabled = status;

            grayscalingDropdown.Enabled = status;
            foreach (ToolStripMenuItem item in scalingDict.Keys)
            {
                item.Checked = false;
            }

            if (status)
            {
                if (lastFocused.imageMode == ImageMode.Default)
                {
                    grayscalingDropdown.Enabled = true;
                    foreach(ToolStripMenuItem item in scalingDict.Keys)
                    {
                        item.Checked = false;
                    }

                    colorChannelButton.Enabled = true;
                    foreach(ToolStripMenuItem item in RgbButtons)
                    {
                        item.Checked = true;
                    }
                } else if (lastFocused.imageMode == ImageMode.Grayscale)
                {
                    grayscalingDropdown.Enabled = true;
                    foreach (KeyValuePair<ToolStripMenuItem, GrayScaleMode> entry in scalingDict)
                    {
                        if (entry.Value == lastFocused.scaleMode) entry.Key.Checked = true;
                        else entry.Key.Checked = false;
                    }

                    colorChannelButton.Enabled = false;
                    foreach (ToolStripMenuItem item in RgbButtons)
                    {
                        item.Checked = true;
                    }
                } else if (lastFocused.imageMode == ImageMode.Channeled)
                {
                    grayscalingDropdown.Enabled = false;
                    foreach (KeyValuePair<ToolStripMenuItem, GrayScaleMode> entry in scalingDict)
                    {
                        entry.Key.Checked = false;
                    }

                    colorChannelButton.Enabled = true;
                    RedChannel.Checked = lastFocused.filter.red;
                    GreenChannel.Checked = lastFocused.filter.green;
                    BlueChannel.Checked = lastFocused.filter.blue;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            lastFocused.saveBitmap(lastFocused.imagePath);
            statusLabel.Text = "Kaydedildi.";
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Bitmap dosyası (*.bmp) | *.bmp;";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string imagePath = file.FileName;

                lastFocused.saveBitmap(imagePath);
                statusLabel.Text = "Kaydedildi.";
            } else
            {
                statusLabel.Text = "Dosya seçmediniz.";
            }
        }

        private void histogramButton_Click(object sender, EventArgs e)
        {
            lastFocused.showHistogram();
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            lastFocused.invertColors();
        }

        private void horizontalMirrorButton_Click(object sender, EventArgs e)
        {
            lastFocused.mirror(Axis.Horizontal);
        }

        private void verticalMirrorButton_Click(object sender, EventArgs e)
        {
            lastFocused.mirror(Axis.Vertical);
        }

        private void rotateClockwiseButton_Click(object sender, EventArgs e)
        {
            lastFocused.rotate(Rotation.Clockwise);
        }

        private void rotateCounterClockwiseButton_Click(object sender, EventArgs e)
        {
            lastFocused.rotate(Rotation.CounterClockwise);
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            lastFocused.openResizingDialog();
        }

        private void grayScaling(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked)
            {
                colorChannelButton.Enabled = true;
                ((ToolStripMenuItem)sender).Checked = false;

                lastFocused.changeMode(ImageMode.Default);
            } else
            {
                foreach (ToolStripMenuItem item in scalingDict.Keys)
                {
                    item.Checked = false;
                }

                ((ToolStripMenuItem)sender).Checked = true;
                colorChannelButton.Enabled = false;

                lastFocused.grayScaleMode(scalingDict[(ToolStripMenuItem)sender]);
            }
        }

        private void channelClick(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender) == RedChannel) lastFocused.filter.red = !((ToolStripMenuItem)sender).Checked;
            else if (((ToolStripMenuItem)sender) == GreenChannel) lastFocused.filter.green = !((ToolStripMenuItem)sender).Checked;
            else if (((ToolStripMenuItem)sender) == BlueChannel) lastFocused.filter.blue = !((ToolStripMenuItem)sender).Checked;
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;

            if (!((ToolStripMenuItem)sender).Checked)
            {
                Boolean anyChecked = false;
                foreach (ToolStripMenuItem item in RgbButtons)
                {
                    if (item.Checked) anyChecked = true;
                }
                if (!anyChecked)
                {
                    foreach (ToolStripMenuItem item in RgbButtons)
                    {
                        item.Checked = true;
                    }
                    lastFocused.filter = new ColorFilter();
                    lastFocused.changeMode(ImageMode.Default);
                    grayscalingDropdown.Enabled = true;
                } else
                {
                    lastFocused.colorFilterMode();
                    grayscalingDropdown.Enabled = false;
                }
            } else
            {
                Boolean allChecked = true;
                foreach (ToolStripMenuItem item in RgbButtons)
                {
                    if (!item.Checked) allChecked = false;
                }
                if (!allChecked)
                {
                    lastFocused.colorFilterMode();
                    grayscalingDropdown.Enabled = false;
                }
                else
                {
                    lastFocused.changeMode(ImageMode.Default);
                    grayscalingDropdown.Enabled = true;
                }
            }
        }

        private void resetImageModeToolbar()
        {
            colorChannelButton.Enabled = true;
            RedChannel.Checked = true;
            GreenChannel.Checked = true;
            BlueChannel.Checked = true;

            grayscalingDropdown.Enabled = true;
            averageToolStripMenuItem.Checked = false;
            lumaToolStripMenuItem.Checked = false;
            desaturationToolStripMenuItem.Checked = false;
            decompositionMaxToolStripMenuItem.Checked = false;
            decompositionMinToolStripMenuItem.Checked = false;
        }

        private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastFocused.reopen();
            resetImageModeToolbar();
        }

        protected override void WndProc(ref Message m)
        {
            int WM_PARENTNOTIFY = 0x0210;
            if (!this.Focused && m.Msg == WM_PARENTNOTIFY)
            {
                this.Activate();
            }
            base.WndProc(ref m);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
