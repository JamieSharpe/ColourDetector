namespace ColourDetector
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
            this.llblInfo.LinkArea = new System.Windows.Forms.LinkArea(57, 11);
            this.llblInfo.Location = new System.Drawing.Point(12, 102);
            this.llblInfo.Name = "llblInfo";
            this.llblInfo.Size = new System.Drawing.Size(172, 42);
            this.llblInfo.TabIndex = 4;
            this.llblInfo.TabStop = true;
            this.llblInfo.Text = "This application is open source\nand can be found on this GitHub\npage.";
            this.llblInfo.UseCompatibleTextRendering = true;
            this.llblInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblInfo_LinkClicked);
            // 
            // lblDivider
            // 
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(12, 96);
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
            this.lblUpdateFreq.Size = new System.Drawing.Size(45, 13);
            this.lblUpdateFreq.TabIndex = 9;
            this.lblUpdateFreq.Text = "Update:";
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 147);
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
    }
}