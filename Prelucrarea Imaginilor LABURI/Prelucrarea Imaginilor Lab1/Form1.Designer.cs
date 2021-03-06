﻿using System.Drawing;
using Prelucrarea_Imaginilor_Lab1.Properties;

namespace Prelucrarea_Imaginilor_Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastCompressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accentuationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFiltrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countourAccentuationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biomedicalImageImprovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAPLACIANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBELVERTICALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIRSCHHORIZOLNTALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Prelucrarea_Imaginilor_Lab1.Properties.Resources.dog800x600blurry;
            this.pictureBox2.Location = new System.Drawing.Point(867, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(850, 568);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prelucrarea_Imaginilor_Lab1.Properties.Resources.dog800x600;
            this.pictureBox1.Location = new System.Drawing.Point(11, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 568);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1729, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
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
            this.swapToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.contrastCompressionToolStripMenuItem,
            this.medianFiltrationToolStripMenuItem,
            this.countourAccentuationToolStripMenuItem,
            this.biomedicalImageImprovementToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // swapToolStripMenuItem
            // 
            this.swapToolStripMenuItem.Name = "swapToolStripMenuItem";
            this.swapToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.swapToolStripMenuItem.Text = "Swap";
            this.swapToolStripMenuItem.Click += new System.EventHandler(this.swapToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // contrastCompressionToolStripMenuItem
            // 
            this.contrastCompressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressionToolStripMenuItem,
            this.accentuationToolStripMenuItem,
            this.reductionToolStripMenuItem});
            this.contrastCompressionToolStripMenuItem.Name = "contrastCompressionToolStripMenuItem";
            this.contrastCompressionToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.contrastCompressionToolStripMenuItem.Text = "Contrast";
            this.contrastCompressionToolStripMenuItem.Click += new System.EventHandler(this.contrastCompressionToolStripMenuItem_Click);
            // 
            // compressionToolStripMenuItem
            // 
            this.compressionToolStripMenuItem.Name = "compressionToolStripMenuItem";
            this.compressionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.compressionToolStripMenuItem.Text = "Compression";
            this.compressionToolStripMenuItem.Click += new System.EventHandler(this.compressionToolStripMenuItem_Click);
            // 
            // accentuationToolStripMenuItem
            // 
            this.accentuationToolStripMenuItem.Name = "accentuationToolStripMenuItem";
            this.accentuationToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.accentuationToolStripMenuItem.Text = "Accentuation";
            this.accentuationToolStripMenuItem.Click += new System.EventHandler(this.accentuationToolStripMenuItem_Click);
            // 
            // reductionToolStripMenuItem
            // 
            this.reductionToolStripMenuItem.Name = "reductionToolStripMenuItem";
            this.reductionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.reductionToolStripMenuItem.Text = "Reduction";
            this.reductionToolStripMenuItem.Click += new System.EventHandler(this.reductionToolStripMenuItem_Click);
            // 
            // medianFiltrationToolStripMenuItem
            // 
            this.medianFiltrationToolStripMenuItem.Name = "medianFiltrationToolStripMenuItem";
            this.medianFiltrationToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.medianFiltrationToolStripMenuItem.Text = "Median Filtration";
            this.medianFiltrationToolStripMenuItem.Click += new System.EventHandler(this.medianFiltrationToolStripMenuItem_Click);
            // 
            // countourAccentuationToolStripMenuItem
            // 
            this.countourAccentuationToolStripMenuItem.Name = "countourAccentuationToolStripMenuItem";
            this.countourAccentuationToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.countourAccentuationToolStripMenuItem.Text = "Countour Accentuation";
            this.countourAccentuationToolStripMenuItem.Click += new System.EventHandler(this.countourAccentuationToolStripMenuItem_Click);
            // 
            // biomedicalImageImprovementToolStripMenuItem
            // 
            this.biomedicalImageImprovementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lAPLACIANToolStripMenuItem,
            this.sOBELVERTICALToolStripMenuItem,
            this.kIRSCHHORIZOLNTALToolStripMenuItem});
            this.biomedicalImageImprovementToolStripMenuItem.Name = "biomedicalImageImprovementToolStripMenuItem";
            this.biomedicalImageImprovementToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.biomedicalImageImprovementToolStripMenuItem.Text = "Biomedical Image Improvement";
            this.biomedicalImageImprovementToolStripMenuItem.Click += new System.EventHandler(this.biomedicalImageImprovementToolStripMenuItem_Click);
            // 
            // lAPLACIANToolStripMenuItem
            // 
            this.lAPLACIANToolStripMenuItem.Name = "lAPLACIANToolStripMenuItem";
            this.lAPLACIANToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.lAPLACIANToolStripMenuItem.Text = "LAPLACIAN";
            this.lAPLACIANToolStripMenuItem.Click += new System.EventHandler(this.lAPLACIANToolStripMenuItem_Click);
            // 
            // sOBELVERTICALToolStripMenuItem
            // 
            this.sOBELVERTICALToolStripMenuItem.Name = "sOBELVERTICALToolStripMenuItem";
            this.sOBELVERTICALToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sOBELVERTICALToolStripMenuItem.Text = "SOBEL VERTICAL";
            this.sOBELVERTICALToolStripMenuItem.Click += new System.EventHandler(this.sOBELVERTICALToolStripMenuItem_Click);
            // 
            // kIRSCHHORIZOLNTALToolStripMenuItem
            // 
            this.kIRSCHHORIZOLNTALToolStripMenuItem.Name = "kIRSCHHORIZOLNTALToolStripMenuItem";
            this.kIRSCHHORIZOLNTALToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kIRSCHHORIZOLNTALToolStripMenuItem.Text = "KIRSCH HORIZONTAL";
            this.kIRSCHHORIZOLNTALToolStripMenuItem.Click += new System.EventHandler(this.kIRSCHHORIZONTALToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.blackAndWhiteToolStripMenuItem.Text = "Black and White";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackAndWhiteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 634);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem swapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastCompressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accentuationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFiltrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countourAccentuationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biomedicalImageImprovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAPLACIANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBELVERTICALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIRSCHHORIZOLNTALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
    }
}

