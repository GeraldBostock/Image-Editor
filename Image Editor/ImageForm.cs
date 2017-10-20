using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Image_Editor
{
    public enum ImageMode
    {
        Default,
        Grayscale,
        Channeled
    }

    public partial class ImageForm : Form
    {
        public string imagePath;
        public ColorFilter filter;
        public GrayScaleMode scaleMode;
        public ImageMode imageMode;
        private Bitmap image;
        private Bitmap modifiedImage;
        private Bitmap originalImage;
        private Main owner;
        public ImageForm(string imagePath, Main owner)
        {
            InitializeComponent();

            this.owner = owner;
            Owner = owner;

            imageMode = ImageMode.Default;
            scaleMode = GrayScaleMode.Null;

            filter = new ColorFilter();

            this.imagePath = imagePath;
            using (var bmpTemp = new Bitmap(imagePath))
            {
                image = new Bitmap(bmpTemp);
                originalImage = new Bitmap(bmpTemp);
            }

            Text = imagePath;
            pictureBox.Image = image;

            MaximumSize = new Size(owner.Width - 100, owner.Height - 150);
            setSizeAuto();
        }

        public void saveBitmap(string filePath)
        {
            if (imageMode == ImageMode.Channeled || imageMode == ImageMode.Grayscale)
            {
                modifiedImage.Save(filePath, ImageFormat.Jpeg);
            } else
            {
                image.Save(filePath, ImageFormat.Jpeg);
            }
        }

        public void invertColors()
        {
            if (imageMode == ImageMode.Channeled || imageMode == ImageMode.Grayscale)
            {
                modifiedImage = ImageProcessing.invertColors(modifiedImage);
            }
            image = ImageProcessing.invertColors(image);
            changeBitmap(getCurrentImage());
        }

        public void mirror(Axis axis)
        {
            if (imageMode == ImageMode.Channeled || imageMode == ImageMode.Grayscale)
            {
                modifiedImage = ImageProcessing.mirror(modifiedImage, axis);
            }
            image = ImageProcessing.mirror(image, axis);
            changeBitmap(getCurrentImage());
        }

        public void rotate(Rotation rotation)
        {
            if (imageMode == ImageMode.Channeled || imageMode == ImageMode.Grayscale)
            {
                modifiedImage = ImageProcessing.rotate(modifiedImage, rotation);
            }
            image = ImageProcessing.rotate(image, rotation);
            changeBitmap(getCurrentImage());
        }

        public void resize(int width, int height, int algorithm)
        {
            if (imageMode == ImageMode.Channeled || imageMode == ImageMode.Grayscale)
            {
                modifiedImage = ImageProcessing.resize(modifiedImage, width, height);
            }
            if(algorithm == 0) image = ImageProcessing.resize(image, width, height);
            else image = ImageProcessing.resizeBilinear(image, width, height);
            changeBitmap(getCurrentImage());
        }

        public void openResizingDialog()
        {
            Resize resizeWindow = new Resize(image.Width, image.Height);
            resizeWindow.Owner = this;
            resizeWindow.Show();
        }

        public void changeMode(ImageMode mode)
        {
            imageMode = mode;
            scaleMode = GrayScaleMode.Null;
            changeBitmap(getCurrentImage());
        }

        public void grayScaleMode(GrayScaleMode scaleMode)
        {
            modifiedImage = ImageProcessing.grayScale(image, scaleMode);
            imageMode = ImageMode.Grayscale;
            this.scaleMode = scaleMode;
            changeBitmap(getCurrentImage());
        }

        public void colorFilterMode()
        {
            modifiedImage = ImageProcessing.colorFiltering(image, filter);
            imageMode = ImageMode.Channeled;
            changeBitmap(getCurrentImage());
        }

        public void showHistogram()
        {
            ImageProcessing process = new ImageProcessing();

            Color[][] imageMatrix = new Color[getCurrentImage().Width][];
            for (int y = 0; y < getCurrentImage().Width; y++)
            {
                imageMatrix[y] = new Color[getCurrentImage().Height];
                for (int x = 0; x < getCurrentImage().Height; x++)
                {
                    imageMatrix[y][x] = getCurrentImage().GetPixel(y, x);
                }
            }
            Bitmap histogram = (Bitmap)(getBitmap(process.histogram(imageMatrix, image.Width, image.Height), 256, 256));
            int[] histogramArray = new int[256];
            histogramArray = process.getHistogram();

            HistogramForm histogramForm = new HistogramForm(histogram, histogramArray, image.Width, image.Height);

            histogramForm.Draw(histogram);
            histogramForm.Text = "Histogram";
            histogramForm.Owner = this;
            histogramForm.Show();
        }

        public Bitmap getBitmap(Color[][] matrix, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bitmap.SetPixel(i, j, matrix[i][j]);
                }
            }

            return bitmap;
        }

        public void reopen()
        {
            image = new Bitmap(originalImage);
            changeMode(ImageMode.Default);
            filter = new ColorFilter();
        }

        private void changeBitmap(Bitmap newBitmap)
        {
            pictureBox.Image = newBitmap;
            setSizeAuto();
            update();
        }

        private void update()
        {
            pictureBox.Refresh();
        }

        private void setSizeAuto()
        {
            if (getCurrentImage().Width > MaximumSize.Width || getCurrentImage().Height > MaximumSize.Height)
            {
                if ((float)getCurrentImage().Width / MaximumSize.Width > (float)getCurrentImage().Height / MaximumSize.Height)
                {
                    Width = MaximumSize.Width;
                    Height = (int)(getCurrentImage().Height * ((float)Width / getCurrentImage().Width));
                } else
                {
                    Height = MaximumSize.Height;
                    Width = (int)(getCurrentImage().Width * ((float)Height / getCurrentImage().Height));
                }
            } else
            {
                Width = getCurrentImage().Width;
                Height = getCurrentImage().Height;
            }
        }

        private void focusAction(object sender, EventArgs e)
        {
            owner.lastFocused = this;
            owner.imageEditing(true);
        }

        private void exitAction(object sender, FormClosingEventArgs e)
        {
            owner.lastFocused = null;
            owner.imageEditing(false);
        }

        private Bitmap getCurrentImage()
        {
            if (imageMode == ImageMode.Channeled || imageMode == ImageMode.Grayscale)
            {
                return modifiedImage;
            } else
            {
                return image;
            }
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
