using System;
using System.Collections.Generic;
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

        private void medianFiltrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);


            for (var i = 1; i < Im1.Width - 1; i++)
            for (var j = 1; j < Im1.Height - 1; j++)
            {
                var cCenter = Im1.GetPixel(i, j);
                var cLeft = Im1.GetPixel(i - 1, j - 1);
                var cRight = Im1.GetPixel(i + 1, j + 1);

                Im2.SetPixel(i, j,
                    Color.FromArgb((cCenter.R + cLeft.R + cRight.R) / 3, (cCenter.G + cLeft.G + cRight.G) / 3,
                        (cCenter.B + cLeft.B + cRight.B) / 3));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void countourAccentuationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Im2 is grayscale
            Im2 = new Bitmap(Im1);
            for (var i = 1; i < Im1.Width - 1; i++)
            for (var j = 1; j < Im1.Height - 1; j++)
            {
                var c = Im1.GetPixel(i, j);
                var u1 = Im1.GetPixel(i - 1, j);
                var u2 = Im1.GetPixel(i + 1, j);
                var u3 = Im1.GetPixel(i, j - 1);
                var u4 = Im1.GetPixel(i, j + 1);
                Im2.SetPixel(i, j,
                    Color.FromArgb(c.A, (u1.R + u2.R + u3.R + u4.R) / 4, (u1.G + u2.G + u3.G + u4.G) / 4,
                        (u1.B + u2.B + u3.B + u4.B) / 4));
            }

            Bitmap Im3 = new Bitmap(Im1);


            double l = 5;
            for (int i = 0; i < Im1.Width; i++)
            for (int j = 0; j < Im1.Height; j++)
            {
                int ur = Im1.GetPixel(i, j).R;
                int fr = Im2.GetPixel(i, j).R;
                int vr = ur + (int) (l * (ur - fr));
                if (vr < 0) vr = 0;
                else if (vr > 255) vr = 255;

                int ug = Im1.GetPixel(i, j).G;
                int fg = Im2.GetPixel(i, j).G;
                int vg = ug + (int) (l * (ug - fg));
                if (vg < 0) vg = 0;
                else if (vg > 255) vg = 255;

                int ub = Im1.GetPixel(i, j).B;
                int fb = Im2.GetPixel(i, j).B;
                int vb = ub + (int) (l * (ub - fb));
                if (vb < 0) vb = 0;
                else if (vb > 255) vb = 255;

                Im3.SetPixel(i, j, Color.FromArgb(255, vr, vg, vb));
            }

            pictureBox2.Image = Im3;
            pictureBox2.Refresh();
        }

        private void biomedicalImageImprovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void lAPLACIANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);

            for (var i = 1; i < Im1.Width - 1; i++)
            for (var j = 1; j < Im1.Height - 1; j++)
            {
                Color colorC, colorTL, colorT, colorTR, colorL, colorR, colorBL, colorB, colorBR;

                colorTL = Im1.GetPixel(i - 1, j - 1);
                colorT = Im1.GetPixel(i, j - 1);
                colorTR = Im1.GetPixel(i + 1, j - 1);
                colorL = Im1.GetPixel(i - 1, j);
                colorC = Im1.GetPixel(i, j);
                colorR = Im1.GetPixel(i + 1, j);
                colorBL = Im1.GetPixel(i - 1, j - 1);
                colorB = Im1.GetPixel(i, j - 1);
                colorBR = Im1.GetPixel(i + 1, j - 1);
                // LAPLACIAN
                int r = colorTL.R * (-1) + colorT.R * (-1) + colorTR.R * (-1) + colorL.R * (-1) + colorC.R * (9) +
                        colorR.R * (-1) + colorBL.R * (-1) + colorB.R * (-1) + colorBR.R * (-1);
                int g = colorTL.G * (-1) + colorT.G * (-1) + colorTR.G * (-1) + colorL.G * (-1) + colorC.G * (9) +
                        colorR.G * (-1) + colorBL.G * (-1) + colorB.G * (-1) + colorBR.G * (-1);
                int b = colorTL.B * (-1) + colorT.B * (-1) + colorTR.B * (-1) + colorL.B * (-1) + colorC.B * (9) +
                        colorR.B * (-1) + colorBL.B * (-1) + colorB.B * (-1) + colorBR.B * (-1);

                int avg = (r + g + b) / 3;
                if (avg > 255) avg = 255;
                if (avg < 0) avg = 0;
                Im2.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void sOBELVERTICALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);

            for (var i = 1; i < Im1.Width - 1; i++)
            for (var j = 1; j < Im1.Height - 1; j++)
            {
                Color colorC, colorTL, colorT, colorTR, colorL, colorR, colorBL, colorB, colorBR;

                colorTL = Im1.GetPixel(i - 1, j - 1);
                colorT = Im1.GetPixel(i, j - 1);
                colorTR = Im1.GetPixel(i + 1, j - 1);
                colorL = Im1.GetPixel(i - 1, j);
                colorC = Im1.GetPixel(i, j);
                colorR = Im1.GetPixel(i + 1, j);
                colorBL = Im1.GetPixel(i - 1, j - 1);
                colorB = Im1.GetPixel(i, j - 1);
                colorBR = Im1.GetPixel(i + 1, j - 1);

                // SOBEL VERTICAL
                int r = colorTL.R * (1) + colorT.R * (0) + colorTR.R * (-1) + colorL.R * (2) + colorC.R * (0) +
                        colorR.R * (-2) + colorBL.R * (1) + colorB.R * (0) + colorBR.R * (-1);
                int g = colorTL.G * (1) + colorT.G * (0) + colorTR.G * (-1) + colorL.G * (2) + colorC.G * (0) +
                        colorR.G * (-2) + colorBL.G * (1) + colorB.G * (0) + colorBR.G * (-1);
                int b = colorTL.B * (1) + colorT.B * (0) + colorTR.B * (-1) + colorL.B * (2) + colorC.B * (0) +
                        colorR.B * (-2) + colorBL.B * (1) + colorB.B * (0) + colorBR.B * (-1);

                int avg = (r + g + b) / 3;
                if (avg > 255) avg = 255;
                if (avg < 0) avg = 0;
                Im2.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void contrastCompressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void kIRSCHHORIZONTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);

            for (var i = 1; i < Im1.Width - 1; i++)
            for (var j = 1; j < Im1.Height - 1; j++)
            {
                Color colorC, colorTL, colorT, colorTR, colorL, colorR, colorBL, colorB, colorBR;

                colorTL = Im1.GetPixel(i - 1, j - 1);
                colorT = Im1.GetPixel(i, j - 1);
                colorTR = Im1.GetPixel(i + 1, j - 1);
                colorL = Im1.GetPixel(i - 1, j);
                colorC = Im1.GetPixel(i, j);
                colorR = Im1.GetPixel(i + 1, j);
                colorBL = Im1.GetPixel(i - 1, j - 1);
                colorB = Im1.GetPixel(i, j - 1);
                colorBR = Im1.GetPixel(i + 1, j - 1);

                // KIRSCH HORIZONTAL
                int r = colorTL.R * (-3) + colorT.R * (-3) + colorTR.R * (5) + colorL.R * (-3) + colorC.R * (0) +
                        colorR.R * (5) + colorBL.R * (-3) + colorB.R * (-3) + colorBR.R * (5);
                int g = colorTL.G * (-3) + colorT.G * (-3) + colorTR.G * (5) + colorL.G * (-3) + colorC.G * (0) +
                        colorR.G * (5) + colorBL.G * (-3) + colorB.G * (-3) + colorBR.G * (5);
                int b = colorTL.B * (-3) + colorT.B * (-3) + colorTR.B * (5) + colorL.B * (-3) + colorC.B * (0) +
                        colorR.B * (5) + colorBL.B * (-3) + colorB.B * (-3) + colorBR.B * (5);

                int avg = (r + g + b) / 3;
                if (avg > 255) avg = 255;
                if (avg < 0) avg = 0;
                Im2.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);
            for (var i = 0; i < Im1.Height; i++)
            for (var j = 0; j < Im1.Width; j++)
            {
                var blackOrWhite = 255;
                var c = Im1.GetPixel(j, i);
                if ((c.R + c.G + c.B) / 3 < 128)
                {
                    blackOrWhite = 0;
                }
                Im2.SetPixel(j, i, Color.FromArgb(blackOrWhite,blackOrWhite,blackOrWhite));
            }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void HistoGram()
        {
            // Get your image in a bitmap; this is how to get it from a picturebox
            Bitmap bm = (Bitmap)pictureBox1.Image;
            // Store the histogram in a dictionary          
            Dictionary<Color, int> histo = new Dictionary<Color, int>();
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    // Get pixel color 
                    Color c = bm.GetPixel(x, y);
                    // If it exists in our 'histogram' increment the corresponding value, or add new
                    if (histo.ContainsKey(c))
                        histo[c] = histo[c] + 1;
                    else
                        histo.Add(c, 1);
                }
            }
            // This outputs the histogram in an output window
            foreach (Color key in histo.Keys)
            {
                Debug.WriteLine(key.ToString() + ": " + histo[key]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}