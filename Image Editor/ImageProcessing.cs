using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Image_Editor
{
    public enum Axis
    {
        Vertical,
        Horizontal
    }

    public enum Rotation
    {
        Clockwise,
        CounterClockwise
    }

    public enum GrayScaleMode
    {
        Null,
        Average,
        Luma,
        Desaturation,
        DecompositionMin,
        DecompositionMax
    }

    public class ColorFilter
    {
        public Boolean red;
        public Boolean green;
        public Boolean blue;
        public ColorFilter()
        {
            red = true;
            green = true;
            blue = true;
        }
        private int getRed(Color color)
        {
            if (this.red) return color.R;
            else if (this.green && this.blue) return 0;
            else if (this.green) return color.G;
            else if (this.blue) return color.B;
            return 0; 
        }
        private int getGreen(Color color)
        {
            if (this.green) return color.G;
            else if (this.red && this.blue) return 0;
            else if (this.red) return color.R;
            else if (this.blue) return color.B;
            return 0;
        }
        private int getBlue(Color color)
        {
            if (this.blue) return color.B;
            else if (this.red && this.green) return 0;
            else if (this.red) return color.R;
            else if (this.green) return color.G;
            return 0;
        }
        public Color getFilteredColor(Color color)
        {
            return Color.FromArgb(getRed(color), getGreen(color), getBlue(color));
        }
        
    }

    class ImageProcessing
    {
        public static int[] Histogram = new int[256];
        public static Bitmap invertColors(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color color = image.GetPixel(i, j);
                    Color invertedColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    newImage.SetPixel(i, j, invertedColor);
                }
            }
            return newImage;
        }
        
        public static Bitmap mirror(Bitmap image, Axis axis)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (axis == Axis.Horizontal)
                    {
                        newImage.SetPixel(i, j, image.GetPixel(image.Width - i - 1, j));
                    } else if (axis == Axis.Vertical)
                    {
                        newImage.SetPixel(i, j, image.GetPixel(i, image.Height - j - 1));
                    }
                   
                }
            }
            return newImage;
        }

        public static Bitmap rotate(Bitmap image, Rotation rotation)
        {
            Bitmap newImage = new Bitmap(image.Height, image.Width);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (rotation == Rotation.Clockwise)
                    {
                        newImage.SetPixel(image.Height - j - 1, i, image.GetPixel(i, j));
                    } else if (rotation == Rotation.CounterClockwise)
                    {
                        newImage.SetPixel(j, image.Width - i - 1, image.GetPixel(i, j));
                    }
                }
            }
            return newImage;
        }

        public static Bitmap resize(Bitmap image, int width, int height)
        {
            Bitmap newImage = new Bitmap(width, height);
            double xRatio = (double)image.Width / width;
            double yRatio = (double)image.Height / height;
            double px, py;
            for (int y = 0; y < newImage.Height; y++)
            {
                for (int x = 0; x < newImage.Width; x++)
                {
                    px = Math.Floor(x * xRatio);
                    py = Math.Floor(y * yRatio);
                    newImage.SetPixel(x, y, image.GetPixel((int)px, (int)py));
                }
            }
            return newImage;
        }

        public static Bitmap resizeBilinear(Bitmap image, int width, int height)
        {
            Bitmap newImage = new Bitmap(width, height);
            double xRatio = (double)(image.Width - 1) / width;
            double yRatio = (double)(image.Height - 1) / height;
            Color a, b, c, d;
            int x, y, blue, red, green;
            double xDiff, yDiff;
            for (int yNew = 0; yNew < height; yNew++)
            {
                for (int xNew = 0; xNew < width; xNew++)
                {
                    x = (int)(xRatio * xNew);
                    y = (int)(yRatio * yNew);
                    xDiff = (xRatio * xNew) - x;
                    yDiff = (yRatio * yNew) - y;

                    a = image.GetPixel(x, y);
                    b = image.GetPixel(x + 1, y);
                    c = image.GetPixel(x, y + 1);
                    d = image.GetPixel(x + 1, y + 1);

                    red = (int)((a.R * (1 - xDiff) * (1 - yDiff)) + (b.R * xDiff * (1 - yDiff)) + (c.R * (1 - xDiff) * yDiff) + (d.R * xDiff * yDiff));
                    green = (int)((a.G * (1 - xDiff) * (1 - yDiff)) + (b.G * xDiff * (1 - yDiff)) + (c.G * (1 - xDiff) * yDiff) + (d.G * xDiff * yDiff));
                    blue = (int)((a.B * (1 - xDiff) * (1 - yDiff)) + (b.B * xDiff * (1 - yDiff)) + (c.B * (1 - xDiff) * yDiff) + (d.B * xDiff * yDiff));
                    newImage.SetPixel(xNew, yNew, Color.FromArgb(red, green, blue));
                }
            }
            return newImage;
        }

        public static Bitmap grayScale(Bitmap image, GrayScaleMode mode)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for(int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int gray = 0;
                    int R = image.GetPixel(x, y).R;
                    int G = image.GetPixel(x, y).G;
                    int B = image.GetPixel(x, y).B;
                    switch (mode)
                    {
                        case GrayScaleMode.Average:
                            gray = (R + G + B) / 3;
                            break;
                        case GrayScaleMode.Luma:
                            gray = (int)Math.Round(R * 0.2126 + G * 0.7152 + B * 0.0722, 0);
                            break;
                        case GrayScaleMode.Desaturation:
                            gray = (Math.Max(Math.Max(R, G), B) + Math.Min(Math.Min(R, G), B)) / 2;
                            break;
                        case GrayScaleMode.DecompositionMin:
                            gray = Math.Min(Math.Min(R, G), B);
                            break;
                        case GrayScaleMode.DecompositionMax:
                            gray = Math.Max(Math.Max(R, G), B);
                            break;
                    }
                    newImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return newImage;
        }
        public static Bitmap colorFiltering(Bitmap image, ColorFilter filter)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < newImage.Height; y++)
            {
                for (int x = 0; x < newImage.Width; x++)
                {
                    newImage.SetPixel(x, y, filter.getFilteredColor(image.GetPixel(x, y)));
                }
            }
            return newImage;
        }

        public Color[][] histogram(Color[][] imageMatrix, int width, int height)
        {
            int[] histogram = new int[256];
            float max = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int red = imageMatrix[i][j].R;
                    int green = imageMatrix[i][j].G;
                    int blue = imageMatrix[i][j].B;

                    histogram[red]++;
                    histogram[green]++;
                    histogram[blue]++;

                    if (histogram[red] > max) max = histogram[red];
                    if (histogram[green] > max) max = histogram[green];
                    if (histogram[blue] > max) max = histogram[blue];
                }
            }

            Histogram = histogram;

            int histHeight = 256;

            Color[][] histogramMatrix = new Color[256][];

            for (int i = 0; i < 256; i++)
            {
                histogramMatrix[i] = new Color[histHeight];
            }

            for (int i = 0; i < histogram.Length; i++)
            {
                float percentage = histogram[i] / max;
                for (int j = histHeight - (int)Math.Round((percentage * histHeight), 0); j < histHeight; j++)
                {
                    histogramMatrix[i][j] = Color.FromArgb(255, 0, 0, 0);
                }
            }

            return histogramMatrix;
        }
        public int[] getHistogram()
        {
            return Histogram;
        }
    }
}
