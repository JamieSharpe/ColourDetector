namespace ColourDetector
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbColourName = new System.Windows.Forms.TextBox();
            this.pnlColourView = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColourR = new System.Windows.Forms.Label();
            this.tbColourR = new System.Windows.Forms.TextBox();
            this.lblColourG = new System.Windows.Forms.Label();
            this.tbColourG = new System.Windows.Forms.TextBox();
            this.lblColourB = new System.Windows.Forms.Label();
            this.tbColourB = new System.Windows.Forms.TextBox();
            this.tbMouseX = new System.Windows.Forms.TextBox();
            this.lblColourBX = new System.Windows.Forms.Label();
            this.tbColourBX = new System.Windows.Forms.TextBox();
            this.lblColourGX = new System.Windows.Forms.Label();
            this.tbColourGX = new System.Windows.Forms.TextBox();
            this.lblColourRX = new System.Windows.Forms.Label();
            this.tbColourRX = new System.Windows.Forms.TextBox();
            this.tbColourSat = new System.Windows.Forms.TextBox();
            this.lblColourSat = new System.Windows.Forms.Label();
            this.lblColourHue = new System.Windows.Forms.Label();
            this.tbColourHue = new System.Windows.Forms.TextBox();
            this.lblColourBri = new System.Windows.Forms.Label();
            this.tbColourBri = new System.Windows.Forms.TextBox();
            this.lblMouseX = new System.Windows.Forms.Label();
            this.lblMouseY = new System.Windows.Forms.Label();
            this.tbMouseY = new System.Windows.Forms.TextBox();
            this.gbColour = new System.Windows.Forms.GroupBox();
            this.gbColourX = new System.Windows.Forms.GroupBox();
            this.gbColourInfo = new System.Windows.Forms.GroupBox();
            this.gbMouse = new System.Windows.Forms.GroupBox();
            this.btnColourSel = new System.Windows.Forms.Button();
            this.cdiagColour = new System.Windows.Forms.ColorDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbZoom = new System.Windows.Forms.PictureBox();
            this.cbZoomLevel = new System.Windows.Forms.ComboBox();
            this.lblZoom = new System.Windows.Forms.Label();
            this.tmrKeyState = new System.Windows.Forms.Timer(this.components);
            this.gbColour.SuspendLayout();
            this.gbColourX.SuspendLayout();
            this.gbColourInfo.SuspendLayout();
            this.gbMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tbColourName
            // 
            this.tbColourName.Location = new System.Drawing.Point(184, 22);
            this.tbColourName.Name = "tbColourName";
            this.tbColourName.Size = new System.Drawing.Size(146, 20);
            this.tbColourName.TabIndex = 0;
            // 
            // pnlColourView
            // 
            this.pnlColourView.Location = new System.Drawing.Point(12, 12);
            this.pnlColourView.Name = "pnlColourView";
            this.pnlColourView.Size = new System.Drawing.Size(116, 116);
            this.pnlColourView.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(140, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblColourR
            // 
            this.lblColourR.AutoSize = true;
            this.lblColourR.Location = new System.Drawing.Point(6, 22);
            this.lblColourR.Name = "lblColourR";
            this.lblColourR.Size = new System.Drawing.Size(30, 13);
            this.lblColourR.TabIndex = 4;
            this.lblColourR.Text = "Red:";
            // 
            // tbColourR
            // 
            this.tbColourR.Location = new System.Drawing.Point(50, 19);
            this.tbColourR.Name = "tbColourR";
            this.tbColourR.Size = new System.Drawing.Size(42, 20);
            this.tbColourR.TabIndex = 3;
            // 
            // lblColourG
            // 
            this.lblColourG.AutoSize = true;
            this.lblColourG.Location = new System.Drawing.Point(6, 48);
            this.lblColourG.Name = "lblColourG";
            this.lblColourG.Size = new System.Drawing.Size(39, 13);
            this.lblColourG.TabIndex = 6;
            this.lblColourG.Text = "Green:";
            // 
            // tbColourG
            // 
            this.tbColourG.Location = new System.Drawing.Point(50, 45);
            this.tbColourG.Name = "tbColourG";
            this.tbColourG.Size = new System.Drawing.Size(42, 20);
            this.tbColourG.TabIndex = 5;
            // 
            // lblColourB
            // 
            this.lblColourB.AutoSize = true;
            this.lblColourB.Location = new System.Drawing.Point(6, 74);
            this.lblColourB.Name = "lblColourB";
            this.lblColourB.Size = new System.Drawing.Size(31, 13);
            this.lblColourB.TabIndex = 8;
            this.lblColourB.Text = "Blue:";
            // 
            // tbColourB
            // 
            this.tbColourB.Location = new System.Drawing.Point(50, 71);
            this.tbColourB.Name = "tbColourB";
            this.tbColourB.Size = new System.Drawing.Size(42, 20);
            this.tbColourB.TabIndex = 7;
            // 
            // tbMouseX
            // 
            this.tbMouseX.Location = new System.Drawing.Point(29, 13);
            this.tbMouseX.Name = "tbMouseX";
            this.tbMouseX.Size = new System.Drawing.Size(32, 20);
            this.tbMouseX.TabIndex = 10;
            // 
            // lblColourBX
            // 
            this.lblColourBX.AutoSize = true;
            this.lblColourBX.Location = new System.Drawing.Point(6, 74);
            this.lblColourBX.Name = "lblColourBX";
            this.lblColourBX.Size = new System.Drawing.Size(31, 13);
            this.lblColourBX.TabIndex = 16;
            this.lblColourBX.Text = "Blue:";
            // 
            // tbColourBX
            // 
            this.tbColourBX.Location = new System.Drawing.Point(50, 71);
            this.tbColourBX.Name = "tbColourBX";
            this.tbColourBX.Size = new System.Drawing.Size(42, 20);
            this.tbColourBX.TabIndex = 15;
            // 
            // lblColourGX
            // 
            this.lblColourGX.AutoSize = true;
            this.lblColourGX.Location = new System.Drawing.Point(6, 48);
            this.lblColourGX.Name = "lblColourGX";
            this.lblColourGX.Size = new System.Drawing.Size(39, 13);
            this.lblColourGX.TabIndex = 14;
            this.lblColourGX.Text = "Green:";
            // 
            // tbColourGX
            // 
            this.tbColourGX.Location = new System.Drawing.Point(50, 45);
            this.tbColourGX.Name = "tbColourGX";
            this.tbColourGX.Size = new System.Drawing.Size(42, 20);
            this.tbColourGX.TabIndex = 13;
            // 
            // lblColourRX
            // 
            this.lblColourRX.AutoSize = true;
            this.lblColourRX.Location = new System.Drawing.Point(6, 22);
            this.lblColourRX.Name = "lblColourRX";
            this.lblColourRX.Size = new System.Drawing.Size(30, 13);
            this.lblColourRX.TabIndex = 12;
            this.lblColourRX.Text = "Red:";
            // 
            // tbColourRX
            // 
            this.tbColourRX.Location = new System.Drawing.Point(50, 19);
            this.tbColourRX.Name = "tbColourRX";
            this.tbColourRX.Size = new System.Drawing.Size(42, 20);
            this.tbColourRX.TabIndex = 11;
            // 
            // tbColourSat
            // 
            this.tbColourSat.Location = new System.Drawing.Point(65, 19);
            this.tbColourSat.Name = "tbColourSat";
            this.tbColourSat.Size = new System.Drawing.Size(42, 20);
            this.tbColourSat.TabIndex = 17;
            // 
            // lblColourSat
            // 
            this.lblColourSat.AutoSize = true;
            this.lblColourSat.Location = new System.Drawing.Point(6, 22);
            this.lblColourSat.Name = "lblColourSat";
            this.lblColourSat.Size = new System.Drawing.Size(58, 13);
            this.lblColourSat.TabIndex = 18;
            this.lblColourSat.Text = "Saturation:";
            // 
            // lblColourHue
            // 
            this.lblColourHue.AutoSize = true;
            this.lblColourHue.Location = new System.Drawing.Point(6, 48);
            this.lblColourHue.Name = "lblColourHue";
            this.lblColourHue.Size = new System.Drawing.Size(30, 13);
            this.lblColourHue.TabIndex = 20;
            this.lblColourHue.Text = "Hue:";
            // 
            // tbColourHue
            // 
            this.tbColourHue.Location = new System.Drawing.Point(65, 45);
            this.tbColourHue.Name = "tbColourHue";
            this.tbColourHue.Size = new System.Drawing.Size(42, 20);
            this.tbColourHue.TabIndex = 19;
            // 
            // lblColourBri
            // 
            this.lblColourBri.AutoSize = true;
            this.lblColourBri.Location = new System.Drawing.Point(6, 74);
            this.lblColourBri.Name = "lblColourBri";
            this.lblColourBri.Size = new System.Drawing.Size(59, 13);
            this.lblColourBri.TabIndex = 22;
            this.lblColourBri.Text = "Brightness:";
            // 
            // tbColourBri
            // 
            this.tbColourBri.Location = new System.Drawing.Point(65, 71);
            this.tbColourBri.Name = "tbColourBri";
            this.tbColourBri.Size = new System.Drawing.Size(42, 20);
            this.tbColourBri.TabIndex = 21;
            // 
            // lblMouseX
            // 
            this.lblMouseX.AutoSize = true;
            this.lblMouseX.Location = new System.Drawing.Point(6, 16);
            this.lblMouseX.Name = "lblMouseX";
            this.lblMouseX.Size = new System.Drawing.Size(17, 13);
            this.lblMouseX.TabIndex = 23;
            this.lblMouseX.Text = "X:";
            // 
            // lblMouseY
            // 
            this.lblMouseY.AutoSize = true;
            this.lblMouseY.Location = new System.Drawing.Point(67, 16);
            this.lblMouseY.Name = "lblMouseY";
            this.lblMouseY.Size = new System.Drawing.Size(17, 13);
            this.lblMouseY.TabIndex = 25;
            this.lblMouseY.Text = "Y:";
            // 
            // tbMouseY
            // 
            this.tbMouseY.Location = new System.Drawing.Point(90, 13);
            this.tbMouseY.Name = "tbMouseY";
            this.tbMouseY.Size = new System.Drawing.Size(32, 20);
            this.tbMouseY.TabIndex = 24;
            // 
            // gbColour
            // 
            this.gbColour.Controls.Add(this.lblColourR);
            this.gbColour.Controls.Add(this.tbColourR);
            this.gbColour.Controls.Add(this.tbColourG);
            this.gbColour.Controls.Add(this.lblColourG);
            this.gbColour.Controls.Add(this.tbColourB);
            this.gbColour.Controls.Add(this.lblColourB);
            this.gbColour.Location = new System.Drawing.Point(134, 57);
            this.gbColour.Name = "gbColour";
            this.gbColour.Size = new System.Drawing.Size(104, 100);
            this.gbColour.TabIndex = 26;
            this.gbColour.TabStop = false;
            this.gbColour.Text = "RGB";
            // 
            // gbColourX
            // 
            this.gbColourX.Controls.Add(this.lblColourRX);
            this.gbColourX.Controls.Add(this.tbColourRX);
            this.gbColourX.Controls.Add(this.tbColourGX);
            this.gbColourX.Controls.Add(this.lblColourGX);
            this.gbColourX.Controls.Add(this.tbColourBX);
            this.gbColourX.Controls.Add(this.lblColourBX);
            this.gbColourX.Location = new System.Drawing.Point(244, 57);
            this.gbColourX.Name = "gbColourX";
            this.gbColourX.Size = new System.Drawing.Size(101, 100);
            this.gbColourX.TabIndex = 27;
            this.gbColourX.TabStop = false;
            this.gbColourX.Text = "RGB Hex";
            // 
            // gbColourInfo
            // 
            this.gbColourInfo.Controls.Add(this.lblColourSat);
            this.gbColourInfo.Controls.Add(this.tbColourSat);
            this.gbColourInfo.Controls.Add(this.tbColourHue);
            this.gbColourInfo.Controls.Add(this.lblColourHue);
            this.gbColourInfo.Controls.Add(this.tbColourBri);
            this.gbColourInfo.Controls.Add(this.lblColourBri);
            this.gbColourInfo.Location = new System.Drawing.Point(351, 57);
            this.gbColourInfo.Name = "gbColourInfo";
            this.gbColourInfo.Size = new System.Drawing.Size(116, 100);
            this.gbColourInfo.TabIndex = 28;
            this.gbColourInfo.TabStop = false;
            this.gbColourInfo.Text = "Info";
            // 
            // gbMouse
            // 
            this.gbMouse.Controls.Add(this.lblMouseX);
            this.gbMouse.Controls.Add(this.tbMouseX);
            this.gbMouse.Controls.Add(this.tbMouseY);
            this.gbMouse.Controls.Add(this.lblMouseY);
            this.gbMouse.Location = new System.Drawing.Point(336, 9);
            this.gbMouse.Name = "gbMouse";
            this.gbMouse.Size = new System.Drawing.Size(131, 42);
            this.gbMouse.TabIndex = 29;
            this.gbMouse.TabStop = false;
            this.gbMouse.Text = "Position";
            // 
            // btnColourSel
            // 
            this.btnColourSel.Location = new System.Drawing.Point(12, 134);
            this.btnColourSel.Name = "btnColourSel";
            this.btnColourSel.Size = new System.Drawing.Size(87, 23);
            this.btnColourSel.TabIndex = 30;
            this.btnColourSel.Text = "Colour Selector";
            this.btnColourSel.UseVisualStyleBackColor = true;
            this.btnColourSel.Click += new System.EventHandler(this.btnColourSel_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Location = new System.Drawing.Point(105, 134);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 23);
            this.btnSettings.TabIndex = 31;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbZoom
            // 
            this.pbZoom.Location = new System.Drawing.Point(473, 12);
            this.pbZoom.Name = "pbZoom";
            this.pbZoom.Size = new System.Drawing.Size(116, 116);
            this.pbZoom.TabIndex = 32;
            this.pbZoom.TabStop = false;
            // 
            // cbZoomLevel
            // 
            this.cbZoomLevel.FormattingEnabled = true;
            this.cbZoomLevel.Location = new System.Drawing.Point(545, 136);
            this.cbZoomLevel.Name = "cbZoomLevel";
            this.cbZoomLevel.Size = new System.Drawing.Size(44, 21);
            this.cbZoomLevel.TabIndex = 33;
            this.cbZoomLevel.SelectedIndexChanged += new System.EventHandler(this.cbZoomLevel_SelectedIndexChanged);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(473, 139);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(66, 13);
            this.lblZoom.TabIndex = 23;
            this.lblZoom.Text = "Zoom Level:";
            // 
            // tmrKeyState
            // 
            this.tmrKeyState.Interval = 10;
            this.tmrKeyState.Tick += new System.EventHandler(this.tmrKeyState_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 166);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.cbZoomLevel);
            this.Controls.Add(this.pbZoom);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnColourSel);
            this.Controls.Add(this.gbMouse);
            this.Controls.Add(this.gbColourInfo);
            this.Controls.Add(this.gbColourX);
            this.Controls.Add(this.gbColour);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlColourView);
            this.Controls.Add(this.tbColourName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Colour Detector";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbColour.ResumeLayout(false);
            this.gbColour.PerformLayout();
            this.gbColourX.ResumeLayout(false);
            this.gbColourX.PerformLayout();
            this.gbColourInfo.ResumeLayout(false);
            this.gbColourInfo.PerformLayout();
            this.gbMouse.ResumeLayout(false);
            this.gbMouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TextBox tbColourName;
        private System.Windows.Forms.Panel pnlColourView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColourR;
        private System.Windows.Forms.TextBox tbColourR;
        private System.Windows.Forms.Label lblColourG;
        private System.Windows.Forms.TextBox tbColourG;
        private System.Windows.Forms.Label lblColourB;
        private System.Windows.Forms.TextBox tbColourB;
        private System.Windows.Forms.TextBox tbMouseX;
        private System.Windows.Forms.Label lblColourBX;
        private System.Windows.Forms.TextBox tbColourBX;
        private System.Windows.Forms.Label lblColourGX;
        private System.Windows.Forms.TextBox tbColourGX;
        private System.Windows.Forms.Label lblColourRX;
        private System.Windows.Forms.TextBox tbColourRX;
        private System.Windows.Forms.TextBox tbColourSat;
        private System.Windows.Forms.Label lblColourSat;
        private System.Windows.Forms.Label lblColourHue;
        private System.Windows.Forms.TextBox tbColourHue;
        private System.Windows.Forms.Label lblColourBri;
        private System.Windows.Forms.TextBox tbColourBri;
        private System.Windows.Forms.Label lblMouseX;
        private System.Windows.Forms.Label lblMouseY;
        private System.Windows.Forms.TextBox tbMouseY;
        private System.Windows.Forms.GroupBox gbColour;
        private System.Windows.Forms.GroupBox gbColourX;
        private System.Windows.Forms.GroupBox gbColourInfo;
        private System.Windows.Forms.GroupBox gbMouse;
        private System.Windows.Forms.Button btnColourSel;
        private System.Windows.Forms.ColorDialog cdiagColour;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbZoom;
        private System.Windows.Forms.ComboBox cbZoomLevel;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Timer tmrKeyState;
    }
}

