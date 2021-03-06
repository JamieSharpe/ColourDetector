﻿namespace ColourDetector
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.cbOntop = new System.Windows.Forms.CheckBox();
            this.lblOntop = new System.Windows.Forms.Label();
            this.llblInfo = new System.Windows.Forms.LinkLabel();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblSaveCol = new System.Windows.Forms.Label();
            this.cbSaveCol = new System.Windows.Forms.CheckBox();
            this.lblUpdateFreq = new System.Windows.Forms.Label();
            this.numUpdateFreq = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHotKey = new System.Windows.Forms.Label();
            this.tbHotKey = new System.Windows.Forms.TextBox();
            this.lblZoomLevel = new System.Windows.Forms.Label();
            this.cbZoomLevel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // numOpacity
            // 
            this.numOpacity.DecimalPlaces = 2;
            this.numOpacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpacity.Location = new System.Drawing.Point(93, 7);
            this.numOpacity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(90, 20);
            this.numOpacity.TabIndex = 0;
            this.numOpacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpacity.ValueChanged += new System.EventHandler(this.numOpacity_ValueChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(12, 9);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(46, 13);
            this.lblOpacity.TabIndex = 1;
            this.lblOpacity.Text = "Opacity:";
            // 
            // cbOntop
            // 
            this.cbOntop.AutoSize = true;
            this.cbOntop.Location = new System.Drawing.Point(93, 59);
            this.cbOntop.Name = "cbOntop";
            this.cbOntop.Size = new System.Drawing.Size(15, 14);
            this.cbOntop.TabIndex = 2;
            this.cbOntop.UseVisualStyleBackColor = true;
            this.cbOntop.CheckedChanged += new System.EventHandler(this.cbOnTop_CheckedChanged);
            // 
            // lblOntop
            // 
            this.lblOntop.AutoSize = true;
            this.lblOntop.Location = new System.Drawing.Point(12, 60);
            this.lblOntop.Name = "lblOntop";
            this.lblOntop.Size = new System.Drawing.Size(75, 13);
            this.lblOntop.TabIndex = 3;
            this.lblOntop.Text = "Always Ontop:";
            // 
            // llblInfo
            // 
            this.llblInfo.AutoSize = true;
            this.llblInfo.LinkArea = new System.Windows.Forms.LinkArea(58, 12);
            this.llblInfo.Location = new System.Drawing.Point(12, 158);
            this.llblInfo.Name = "llblInfo";
            this.llblInfo.Size = new System.Drawing.Size(172, 42);
            this.llblInfo.TabIndex = 4;
            this.llblInfo.TabStop = true;
            this.llblInfo.Text = "This application is open source\r\nand can be found on this GitHub\r\npage.";
            this.llblInfo.UseCompatibleTextRendering = true;
            this.llblInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblInfo_LinkClicked);
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(12, 152);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(171, 2);
            this.lblDivider.TabIndex = 5;
            // 
            // lblSaveCol
            // 
            this.lblSaveCol.AutoSize = true;
            this.lblSaveCol.Location = new System.Drawing.Point(12, 80);
            this.lblSaveCol.Name = "lblSaveCol";
            this.lblSaveCol.Size = new System.Drawing.Size(73, 13);
            this.lblSaveCol.TabIndex = 7;
            this.lblSaveCol.Text = "Save Colours:";
            // 
            // cbSaveCol
            // 
            this.cbSaveCol.AutoSize = true;
            this.cbSaveCol.Location = new System.Drawing.Point(93, 79);
            this.cbSaveCol.Name = "cbSaveCol";
            this.cbSaveCol.Size = new System.Drawing.Size(15, 14);
            this.cbSaveCol.TabIndex = 6;
            this.cbSaveCol.UseVisualStyleBackColor = true;
            this.cbSaveCol.CheckedChanged += new System.EventHandler(this.cbSaveCol_CheckedChanged);
            // 
            // lblUpdateFreq
            // 
            this.lblUpdateFreq.AutoSize = true;
            this.lblUpdateFreq.Location = new System.Drawing.Point(12, 35);
            this.lblUpdateFreq.Name = "lblUpdateFreq";
            this.lblUpdateFreq.Size = new System.Drawing.Size(67, 13);
            this.lblUpdateFreq.TabIndex = 9;
            this.lblUpdateFreq.Text = "Update (ms):";
            // 
            // numUpdateFreq
            // 
            this.numUpdateFreq.Location = new System.Drawing.Point(93, 33);
            this.numUpdateFreq.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpdateFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdateFreq.Name = "numUpdateFreq";
            this.numUpdateFreq.Size = new System.Drawing.Size(90, 20);
            this.numUpdateFreq.TabIndex = 8;
            this.numUpdateFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdateFreq.ValueChanged += new System.EventHandler(this.numUpdateFreq_ValueChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 2);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Program: Colour Detector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Version: 1.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Author: Jamie Sharpe";
            // 
            // lblHotKey
            // 
            this.lblHotKey.AutoSize = true;
            this.lblHotKey.Location = new System.Drawing.Point(12, 102);
            this.lblHotKey.Name = "lblHotKey";
            this.lblHotKey.Size = new System.Drawing.Size(78, 13);
            this.lblHotKey.TabIndex = 14;
            this.lblHotKey.Text = "Pause HotKey:";
            // 
            // tbHotKey
            // 
            this.tbHotKey.Location = new System.Drawing.Point(93, 99);
            this.tbHotKey.Name = "tbHotKey";
            this.tbHotKey.ReadOnly = true;
            this.tbHotKey.Size = new System.Drawing.Size(90, 20);
            this.tbHotKey.TabIndex = 15;
            this.tbHotKey.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tbHotKey.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblZoomLevel
            // 
            this.lblZoomLevel.AutoSize = true;
            this.lblZoomLevel.Location = new System.Drawing.Point(12, 128);
            this.lblZoomLevel.Name = "lblZoomLevel";
            this.lblZoomLevel.Size = new System.Drawing.Size(66, 13);
            this.lblZoomLevel.TabIndex = 16;
            this.lblZoomLevel.Text = "Zoom Level:";
            // 
            // cbZoomLevel
            // 
            this.cbZoomLevel.FormattingEnabled = true;
            this.cbZoomLevel.Location = new System.Drawing.Point(93, 125);
            this.cbZoomLevel.Name = "cbZoomLevel";
            this.cbZoomLevel.Size = new System.Drawing.Size(90, 21);
            this.cbZoomLevel.TabIndex = 17;
            this.cbZoomLevel.SelectionChangeCommitted += new System.EventHandler(this.cbZoomLevel_SelectionChangeCommitted);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 260);
            this.Controls.Add(this.cbZoomLevel);
            this.Controls.Add(this.lblZoomLevel);
            this.Controls.Add(this.tbHotKey);
            this.Controls.Add(this.lblHotKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUpdateFreq);
            this.Controls.Add(this.numUpdateFreq);
            this.Controls.Add(this.lblSaveCol);
            this.Controls.Add(this.cbSaveCol);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.llblInfo);
            this.Controls.Add(this.lblOntop);
            this.Controls.Add(this.cbOntop);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.numOpacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.CheckBox cbOntop;
        private System.Windows.Forms.Label lblOntop;
        private System.Windows.Forms.LinkLabel llblInfo;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblSaveCol;
        private System.Windows.Forms.CheckBox cbSaveCol;
        private System.Windows.Forms.Label lblUpdateFreq;
        private System.Windows.Forms.NumericUpDown numUpdateFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHotKey;
        private System.Windows.Forms.TextBox tbHotKey;
        private System.Windows.Forms.Label lblZoomLevel;
        private System.Windows.Forms.ComboBox cbZoomLevel;
    }
}