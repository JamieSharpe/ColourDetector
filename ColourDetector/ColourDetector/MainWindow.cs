﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ColourDetector
{
    /// <summary>
    /// The form window of the colour detector window.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Fields
        readonly private Detector detector = new Detector();

        private bool updateDetector = true;
        #endregion Fields

        #region Properties
        /// <summary>
        /// Used for the keyboard shortcut to
        /// disable/enable the detector.
        /// </summary>
        private bool UpdateDetector
        {
            get
            {
                return this.updateDetector;
            }
            set
            {
                this.updateDetector = value;
            }
        }
        #endregion Properties

        #region DllImports
        /// <summary>
        /// Used to get keyboard button state.
        /// This is then used for global setting changes.
        /// </summary>
        /// <param name="vKey">The vKey to determine whether
        /// it was pressed after a previous call to the
        /// method.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 vKey);
        #endregion DllImports

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Events
        /// <summary>
        /// Called when the form is loaded.
        /// Binds the UI components to the detector.
        /// Starts a update timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.LoadSettings();

            this.pnlColourView.DataBindings.Add("BackColor", detector, "Colour",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourName.DataBindings.Add("Text", detector, "ColourName",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbMouseX.DataBindings.Add("Text", detector, "MousePos.X",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbMouseY.DataBindings.Add("Text", detector, "MousePos.Y",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourR.DataBindings.Add("Text", detector, "Colour.R",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourG.DataBindings.Add("Text", detector, "Colour.G",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourB.DataBindings.Add("Text", detector, "Colour.B",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourRX.DataBindings.Add("Text", detector, "RedX",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourGX.DataBindings.Add("Text", detector, "GreenX",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourBX.DataBindings.Add("Text", detector, "BlueX",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourSat.DataBindings.Add("Text", detector, "Saturation",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourHue.DataBindings.Add("Text", detector, "Hue",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.tbColourBri.DataBindings.Add("Text", detector, "Brightness",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.pbZoom.DataBindings.Add("Image", detector, "Screenshot",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            this.cbZoomLevel.DataSource = detector.ZoomLevels;
            this.tmrUpdate.Start();
            this.tmrKeyState.Start();

        }

        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            this.detector.Update();
        }

        /// <summary>
        /// Opens a colour dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColourSel_Click(object sender, EventArgs e)
        {
            this.cdiagColour.ShowDialog();
        }

        /// <summary>
        /// Button pressed for settings form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
            this.LoadSettings();
        }

        /// <summary>
        /// Called when the drop down box for screen view zoom level has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbZoomLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.detector.ZoomLevel = (int)cbZoomLevel.SelectedItem;
        }

        /// <summary>
        /// Checks to see is the keybaord short cut is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrKeyState_Tick(object sender, EventArgs e)
        {
            int keyState = GetAsyncKeyState(0x71); // 0x71 is F2: see https://msdn.microsoft.com/en-us/library/windows/desktop/dd375731(v=vs.85).aspx

            // Least significant bit set: see https://msdn.microsoft.com/en-us/library/windows/desktop/ms646293%28v=vs.85%29.aspx
            if (keyState == -32767)
            {
                this.UpdateDetector = !this.UpdateDetector;
                if (this.UpdateDetector)
                {
                    this.tmrUpdate.Start();
                }
                else
                {
                    this.tmrUpdate.Stop();
                }
            }
        }
        #endregion Events

        #region Methods
        private void LoadSettings()
        {
            this.Opacity = (double)Properties.Settings.Default.Opacity;
            this.TopMost = Properties.Settings.Default.TopMost;
            this.tmrUpdate.Interval = Properties.Settings.Default.UpdateFreq;
        }
        #endregion Methods
    }
}
