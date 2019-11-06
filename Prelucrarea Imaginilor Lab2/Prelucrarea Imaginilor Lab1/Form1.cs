using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Prelucrarea_Imaginilor_Lab2
{
    public partial class Form1 : Form
    {
        private Bitmap Im1, Im2;
        private Image loadedImage;

        public Form1()
        {
            InitializeComponent();
            Im1 = new Bitmap(pictureBox1.Image);
            Im2 = new Bitmap(pictureBox2.Image);
        }

        private static double NormalizeTo255(double p)
        {
            if (p < 0) p = 0;
            if (p > 255) p = 255;
            return p;
        }

        private static double ApplyContrastCompression(double contrast, byte colorVal)
        {
            var p = contrast * Math.Log(1 + colorVal);
            return p;
        }

        private static double ApplyContrast(double contrast, byte colorVal)
        {
            var p = colorVal / 255.0;
            p -= 0.5;
            p *= contrast;
            p += 0.5;
            p *= 255;
            return p;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                loadedImage = Image.FromFile(openFileDialog1.FileName);
                Im1 = new Bitmap(loadedImage);
                pictureBox1.Image = Im1;
                pictureBox1.Refresh();
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Something went wrong when opening image.");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Data Files (*.png)|*.png";
                saveFileDialog1.DefaultExt = "png";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.ShowDialog();
                Im2.Save(saveFileDialog1.FileName);
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Something went wrong when saving image.");
            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);
            for (var i = 0; i < Im1.Height; i++)
            for (var j = 0; j < Im1.Width; j++)
            {
                var c = Im1.GetPixel(j, i);
                var grayScale = (int) (c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                Im2.SetPixel(j, i, Color.FromArgb(c.A, grayScale, grayScale, grayScale));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void swapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Im2;
            pictureBox1.Refresh();
            pictureBox2.Image = Im1;
            pictureBox2.Refresh();

            Im1 = new Bitmap(pictureBox1.Image);
            Im2 = new Bitmap(pictureBox2.Image);
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);
            for (var i = 0; i < Im1.Height; i++)
            for (var j = 0; j < Im1.Width; j++)
            {
                var c = Im1.GetPixel(j, i);
                Im2.SetPixel(j, i, Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void compressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);
            double contrast = 30;

            for (var i = 0; i < Im1.Width; i++)
            for (var j = 0; j < Im1.Height; j++)
            {
                var c = Im1.GetPixel(i, j);

                var pR = ApplyContrastCompression(contrast, c.R);
                pR = NormalizeTo255(pR);

                var pG = ApplyContrastCompression(contrast, c.G);
                pG = NormalizeTo255(pG);

                var pB = ApplyContrastCompression(contrast, c.B);
                pB = NormalizeTo255(pB);

                Im2.SetPixel(i, j, Color.FromArgb((int) pR, (int) pG, (int) pB));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void accentuationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);
            double contrast = 30; // intre -100 si 100
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;


            for (var i = 0; i < Im1.Width; i++)
            for (var j = 0; j < Im1.Height; j++)
            {
                var c = Im1.GetPixel(i, j);

                var pR = ApplyContrast(contrast, c.R);
                pR = NormalizeTo255(pR);

                var pG = ApplyContrast(contrast, c.G);
                pG = NormalizeTo255(pG);

                var pB = ApplyContrast(contrast, c.B);
                pB = NormalizeTo255(pB);

                Im2.SetPixel(i, j, Color.FromArgb((int) pR, (int) pG, (int) pB));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void reductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);
            double contrast = -30; // intre -100 si 100
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;


            for (var i = 0; i < Im1.Width; i++)
            for (var j = 0; j < Im1.Height; j++)
            {
                var c = Im1.GetPixel(i, j);

                var pR = ApplyContrast(contrast, c.R);
                pR = NormalizeTo255(pR);

                var pG = ApplyContrast(contrast, c.G);
                pG = NormalizeTo255(pG);

                var pB = ApplyContrast(contrast, c.B);
                pB = NormalizeTo255(pB);

                Im2.SetPixel(i, j, Color.FromArgb((int) pR, (int) pG, (int) pB));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}