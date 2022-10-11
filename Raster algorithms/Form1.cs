using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Raster_algorithms
{
    enum ResizeMode
    {
        none,
        KNN,
        KTimes,
        BLI
    }
    public partial class Form1 : Form
    {
        private Bitmap sourceBitmap;
        private Bitmap destinationBitmap;

        private int sourceWidth;
        private int sourceHeight;
        private int destinationWidth;
        private int destinationHeight;
        private ResizeMode mode = ResizeMode.none;
        
        public Form1()
        {
            InitializeComponent();
        }

        delegate void Algorithm(double doefX, double coefY);

        private void StartAlgorithm(double coefX, double coefY)
        {
            Algorithm algorithmFunc;
            switch (mode)
            {
                case ResizeMode.KNN:
                    {
                        algorithmFunc = KNN;
                    }
                    break;
                case ResizeMode.KTimes:
                    {
                        algorithmFunc = KTimes;
                    }
                    break;
                default:
                    {
                        algorithmFunc = BilinearInterpolation;
                    }
                    break;
            }
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            algorithmFunc(coefX, coefY);
            stopwatch.Stop();

            pictureBox1.Image = destinationBitmap;
            extentionLabel2.Text = extensionLabel.Text;
            resolutionLabel2.Text = destinationWidth.ToString() + '×' + destinationHeight.ToString();

            timeLabel.Text = stopwatch.Elapsed.Milliseconds.ToString();
        }

        private Bitmap calculateSizes(double coefX, double coefY)
        {
            sourceWidth = sourceBitmap.Width;
            destinationWidth = (int)(sourceWidth * coefX);
            sourceHeight = sourceBitmap.Height;
            destinationHeight = (int)(sourceHeight * coefY);

            return new Bitmap(destinationWidth, destinationHeight);
        }

        private void KNN(double coefX, double coefY)
        {
            destinationBitmap = calculateSizes(coefX, coefY);

                for (int x = 0; x < destinationWidth; x++)
                {
                    int srcX = (int)(x / coefX);

                    for (int y = 0; y < destinationHeight; y++)
                    {
                        int srcY = (int)(y / coefY);
                        destinationBitmap.SetPixel(x, y, sourceBitmap.GetPixel(srcX, srcY));
                    }
                }
        }

        private int LinearInterpolation(int coord1, int coord2, int value1, int value2, double axis)
        {
            double coef1 = (coord2 - axis) / (coord2 - coord1);
            double coef2 = (axis - coord1) / (coord2 - coord1);

            return (int)(coef1 * value1) + (int)(coef2 * value2);
        }

        private Color GetLinearInterpolationColor(Point point1, Point point2, double axis)
        {
            Color color1 = sourceBitmap.GetPixel(point1.X, point1.Y);
            Color color2 = sourceBitmap.GetPixel(point2.X, point2.Y);

            int colorR = LinearInterpolation(point1.X, point2.X, color1.R, color2.R, axis);
            int colorG = LinearInterpolation(point1.X, point2.X, color1.G, color2.G, axis);
            int colorB = LinearInterpolation(point1.X, point2.X, color1.B, color2.B, axis);

            return Color.FromArgb(colorR, colorG, colorB);
        }

        private void BilinearInterpolation(double coefX, double coefY)
        {
            destinationBitmap = calculateSizes(coefX, coefY);

            for(int x=0; x < destinationWidth; x++)
            {
                double srcX = x / (coefX*sourceWidth/(sourceWidth -1));

                for(int y=0; y < destinationHeight; y++)
                {
                    double srcY = y / (coefY*sourceHeight/(sourceHeight - 1));

                    int firstX = (int)srcX;
                    int firstY = (int)srcY;
                    int secondX = Convert.ToInt32(Math.Ceiling(srcX));
                    int secondY = Convert.ToInt32(Math.Ceiling(srcY));

                    if (firstX == secondX )
                    {
                            srcX += 0.00001;
                            secondX += 1;
                    }

                    if (firstY == secondY)
                    {
                            srcY += 0.00001;
                            secondY += 1;
                    }

                    if (firstX != sourceWidth - 1 && firstY != sourceHeight - 1)
                    {

                        Point point1 = new Point(firstX, firstY);
                        Point point2 = new Point(firstX, secondY);
                        Point point3 = new Point(secondX, firstY);
                        Point point4 = new Point(secondX, secondY);

                        Color color1 = GetLinearInterpolationColor(point1, point3, srcX);
                        Color color2 = GetLinearInterpolationColor(point2, point4, srcX);

                        int colorR = LinearInterpolation(point1.Y, point2.Y, color1.R, color2.R, srcY);
                        int colorG = LinearInterpolation(point1.Y, point2.Y, color1.G, color2.G, srcY);
                        int colorB = LinearInterpolation(point1.Y, point2.Y, color1.B, color2.B, srcY);

                        Color resultColor = Color.FromArgb(colorR, colorG, colorB);

                        destinationBitmap.SetPixel(x, y, resultColor);
                    }
                }
            }
        }

        private int CalculateColorValue(int firstColorValue, int secondColorValue, double coef, int index)
        {
            double colorCoef = (secondColorValue - firstColorValue) / coef;

            return (int)(index * colorCoef + firstColorValue);
        }

        private Color CalculateColor(int x , int firstY, int secondY, double coefY, int destY)
        {
            Color firstXYColor = sourceBitmap.GetPixel(x, firstY);
            Color secondYColor = sourceBitmap.GetPixel(x, secondY);

            if (firstY == 0)
            {
                firstY++;
            }

            int Ydiff = destY % Convert.ToInt32(Math.Ceiling(firstY * coefY));

            int colorYRvalue = CalculateColorValue(firstXYColor.R, secondYColor.R, coefY, Ydiff);
            int colorYBValue = CalculateColorValue(firstXYColor.B, secondYColor.B, coefY, Ydiff);
            int colorYGValue = CalculateColorValue(firstXYColor.G, secondYColor.G, coefY, Ydiff);

            return Color.FromArgb(colorYRvalue, colorYGValue, colorYBValue);
        }

        private void KTimes(double coefX, double coefY)
        {
           destinationBitmap = calculateSizes(coefX, coefY);

            for (int x = 0; x < destinationWidth; x++)
            {
                double srcX = x / coefX;

                for (int y = 0; y < destinationHeight; y++)
                {
                    double srcY = y / coefY;
                    int intSrcYFirst = (int)srcY;
                    int intSrcYSecond = intSrcYFirst;

                    if (intSrcYFirst < sourceHeight - 1)
                    {
                        intSrcYSecond+=1;
                    }

                    Color color = CalculateColor((int)srcX, intSrcYFirst, intSrcYSecond, coefY, y);

                    destinationBitmap.SetPixel(x, y, color);
                }
            }
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {

                dlg.Title = "Open image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName = dlg.FileName;
                    sourceBitmap = new Bitmap(fileName);

                    pictureBox1.Image = sourceBitmap;
                    extensionLabel.Text = Path.GetExtension(fileName);
                    resolutionLabel.Text = sourceBitmap.Width.ToString() + '×' + sourceBitmap.Height.ToString();
                    sizeLabel.Text = new FileInfo(fileName).Length.ToString();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                
                dlg.Title = "Save image";
                dlg.InitialDirectory = @"C:\";
                dlg.DefaultExt = "png";
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string filename = dlg.FileName;
                    destinationBitmap.Save(filename, ImageFormat.Png);
                    extentionLabel2.Text = Path.GetExtension(filename);
                    sizeLabel2.Text = new FileInfo(filename).Length.ToString();
                }
            }
        }

        private void ResizeXYButton_Click(object sender, EventArgs e)
        {
            if (XTextbox.Text != String.Empty && YTextbox.Text != String.Empty && mode!= ResizeMode.none)
            {
                var coefX = Convert.ToDouble(XTextbox.Text, NumberFormatInfo.InvariantInfo);
                var coefY = Convert.ToDouble(YTextbox.Text, NumberFormatInfo.InvariantInfo);

                StartAlgorithm(coefX, coefY);
            }
        }

        private void ResizeXButton_Click(object sender, EventArgs e)
        {
            if (XTextbox.Text != String.Empty && mode != ResizeMode.none)
            {
                var coefX = Convert.ToDouble(XTextbox.Text, NumberFormatInfo.InvariantInfo);
                var coefY = 1;

                StartAlgorithm(coefX, coefY);
            }
        }

        private void ResizeYButton_Click(object sender, EventArgs e)
        {
            if (YTextbox.Text != String.Empty && mode != ResizeMode.none)
            {
                var coefY = Convert.ToDouble(YTextbox.Text, NumberFormatInfo.InvariantInfo);
                var coefX = 1;

                StartAlgorithm(coefX, coefY);
            }
        }

        private void KNNButton_Click(object sender, EventArgs e)
        {
            mode = ResizeMode.KNN;
            algLabel.Text = "KNN";
        }

        private void KTimesButton_Click(object sender, EventArgs e)
        {
            mode = ResizeMode.KTimes;
            algLabel.Text = "K-times";
        }

        private void BLButton_Click(object sender, EventArgs e)
        {
            mode = ResizeMode.BLI;
            algLabel.Text = "BLI";
        }
    }
}
