using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatic_Image_Enhancement
{
    public partial class Form1 : Form
    {
        private Bitmap Im1, Im2;
        private Image loadedImage;
        private object _imageLock = new object();

        public Form1()
        {
            InitializeComponent();
            Im1 = new Bitmap(pictureBox1.Image);
            Im2 = new Bitmap(pictureBox2.Image);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticAdjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.swapButton = new System.Windows.Forms.Button();
            this.HistogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Automatic_Image_Enhancement.Properties.Resources.dog800x600blurry;
            this.pictureBox2.Location = new System.Drawing.Point(884, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 822);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Automatic_Image_Enhancement.Properties.Resources.dog800x600;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 822);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(2002, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeGrayscaleToolStripMenuItem,
            this.automaticAdjustmentToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // makeGrayscaleToolStripMenuItem
            // 
            this.makeGrayscaleToolStripMenuItem.Name = "makeGrayscaleToolStripMenuItem";
            this.makeGrayscaleToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.makeGrayscaleToolStripMenuItem.Text = "Make grayscale";
            this.makeGrayscaleToolStripMenuItem.Click += new System.EventHandler(this.makeGrayscaleToolStripMenuItem_Click);
            // 
            // automaticAdjustmentToolStripMenuItem
            // 
            this.automaticAdjustmentToolStripMenuItem.Name = "automaticAdjustmentToolStripMenuItem";
            this.automaticAdjustmentToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.automaticAdjustmentToolStripMenuItem.Text = "Automatic Enhancement";
            this.automaticAdjustmentToolStripMenuItem.Click += new System.EventHandler(this.automaticEnhancementToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(818, 420);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(60, 60);
            this.swapButton.TabIndex = 5;
            this.swapButton.Text = "Swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButon_Click_1);
            // 
            // HistogramChart
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            this.HistogramChart.ChartAreas.Add(chartArea1);
            this.HistogramChart.ChartAreas.Add(chartArea2);
            this.HistogramChart.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.HistogramChart.Legends.Add(legend1);
            this.HistogramChart.Location = new System.Drawing.Point(1690, 27);
            this.HistogramChart.Name = "HistogramChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea2";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea3";
            series3.Color = System.Drawing.Color.DeepSkyBlue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.HistogramChart.Series.Add(series1);
            this.HistogramChart.Series.Add(series2);
            this.HistogramChart.Series.Add(series3);
            this.HistogramChart.Size = new System.Drawing.Size(300, 822);
            this.HistogramChart.TabIndex = 6;
            this.HistogramChart.Text = "chart1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(2002, 861);
            this.Controls.Add(this.HistogramChart);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Automatic Image Enhancement";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.Write("blabla");
            HistogramChart.Legends.Clear();
            RefreshHistograms();
        }

        private void RefreshHistograms()
        {
            HistogramChart.Series["Red"].Points.Clear();
            HistogramChart.Series["Green"].Points.Clear();
            HistogramChart.Series["Blue"].Points.Clear();
            var r = GetHistogram("R");
            var g = GetHistogram("G");
            var b = GetHistogram("B");
            for (int i = 0; i < 256; i++)
            {
                HistogramChart.Series["Red"].Points.AddXY(i, r[i]);
                HistogramChart.Series["Green"].Points.AddXY(i, g[i]);
                HistogramChart.Series["Blue"].Points.AddXY(i, b[i]);
            }
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

        private void swapButon_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Im2;
            pictureBox1.Refresh();
            pictureBox2.Image = Im1;
            pictureBox2.Refresh();

            Im1 = new Bitmap(pictureBox1.Image);
            Im2 = new Bitmap(pictureBox2.Image);
            RefreshHistograms();
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
                RefreshHistograms();
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Something went wrong when opening image.");
            }
        }

        private void genericBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = EqualizeHistogram();
            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
            RefreshHistograms();
        }

        public int[] GetHistogram(String component)
        {
            var histogram = new int[256];

            lock (_imageLock)
            {
                unsafe
                {
                    var data = Im1.LockBits(new Rectangle(0, 0, Im1.Width, Im1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                    var offset = data.Stride - Im1.Width * 3;

                    var p = (byte*)data.Scan0.ToPointer();

                    for (var i = 0; i < Im1.Height; i++)
                    {
                        for (var j = 0; j < Im1.Width; j++, p += 3)
                        {
                            switch (component)
                            {
                                case "R":
                                    histogram[p[2]]++;
                                    break;

                                case "G":
                                    histogram[p[1]]++;
                                    break;

                                default:
                                    histogram[p[0]]++;
                                    break;
                            }
                        }
                        p += offset;
                    }

                    Im1.UnlockBits(data);
                }
            }

            return histogram;
        }

        private void makeGrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = new Bitmap(Im1);
            for (var i = 0; i < Im1.Height; i++)
                for (var j = 0; j < Im1.Width; j++)
                {
                    var c = Im1.GetPixel(j, i);
                    var grayScale = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    Im2.SetPixel(j, i, Color.FromArgb(c.A, grayScale, grayScale, grayScale));
                }

            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
        }

        private void automaticEnhancementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Im2 = EqualizeHistogram();
            pictureBox2.Image = Im2;
            pictureBox2.Refresh();
            RefreshHistograms();
        }

        public Bitmap EqualizeHistogram()
        {
            unsafe
            {
                var finalImg = new Bitmap(Im1.Width, Im1.Height);

                var rHistogram = GetHistogram("R");
                var gHistogram = GetHistogram("G");
                var bHistogram = GetHistogram("B");

                var data = Im1.LockBits(new Rectangle(0, 0, Im1.Width, Im1.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                var finalData = finalImg.LockBits(new Rectangle(0, 0, finalImg.Width, finalImg.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                var histR = new float[256];
                var histG = new float[256];
                var histB = new float[256];

                histR[0] = (rHistogram[0] * rHistogram.Length) / (finalData.Width * finalData.Height);
                histG[0] = (gHistogram[0] * gHistogram.Length) / (finalData.Width * finalData.Height);
                histB[0] = (bHistogram[0] * bHistogram.Length) / (finalData.Width * finalData.Height);

                long cumulativeR = rHistogram[0];
                long cumulativeG = gHistogram[0];
                long cumulativeB = bHistogram[0];

                for (var i = 1; i < histR.Length; i++)
                {
                    cumulativeR += rHistogram[i];
                    histR[i] = (cumulativeR * rHistogram.Length) / (finalData.Width * finalData.Height);

                    cumulativeG += gHistogram[i];
                    histG[i] = (cumulativeG * gHistogram.Length) / (finalData.Width * finalData.Height);

                    cumulativeB += bHistogram[i];
                    histB[i] = (cumulativeB * bHistogram.Length) / (finalData.Width * finalData.Height);
                }

                var ptr = (byte*)data.Scan0;
                var ptrFinal = (byte*)finalData.Scan0;

                var remain = data.Stride - data.Width * 3;

                for (var i = 0; i < data.Height; i++, ptr += remain, ptrFinal += remain)
                {
                    for (var j = 0; j < data.Width; j++, ptrFinal += 3, ptr += 3)
                    {
                        var intensityR = ptr[2];
                        var intensityG = ptr[1];
                        var intensityB = ptr[0];

                        var nValueR = (byte)histR[intensityR];
                        var nValueG = (byte)histG[intensityG];
                        var nValueB = (byte)histB[intensityB];

                        if (histR[intensityR] > 255)
                            nValueR = 255;
                        if (histG[intensityG] > 255)
                            nValueG = 255;
                        if (histB[intensityB] > 255)
                            nValueB = 255;

                        ptrFinal[2] = nValueR;
                        ptrFinal[1] = nValueG;
                        ptrFinal[0] = nValueB;
                    }
                }

                Im1.UnlockBits(data);
                finalImg.UnlockBits(finalData);

                return finalImg;
            }
        }
    }
}