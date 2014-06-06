using System;
using System.Windows.Forms;

namespace ColourDetector
{
    public partial class MainWindow : Form
    {
        readonly private Detector detector = new Detector();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            this.Opacity = (double)Properties.Settings.Default.Opacity;
            this.TopMost = Properties.Settings.Default.TopMost;
            this.tmrUpdate.Interval = Properties.Settings.Default.UpdateFreq;
        }

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

            pnlColourView.DataBindings.Add("BackColor", detector, "Colour",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourName.DataBindings.Add("Text", detector, "ColourName",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbMouseX.DataBindings.Add("Text", detector, "MousePos.X",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbMouseY.DataBindings.Add("Text", detector, "MousePos.Y",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourR.DataBindings.Add("Text", detector, "Colour.R",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourG.DataBindings.Add("Text", detector, "Colour.G",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourB.DataBindings.Add("Text", detector, "Colour.B",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourRX.DataBindings.Add("Text", detector, "RedX",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourGX.DataBindings.Add("Text", detector, "GreenX",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourBX.DataBindings.Add("Text", detector, "BlueX",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourSat.DataBindings.Add("Text", detector, "Saturation",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourHue.DataBindings.Add("Text", detector, "Hue",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            tbColourBri.DataBindings.Add("Text", detector, "Brightness",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);
           
            tmrUpdate.Start();
        }

        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            detector.Update();
        }

        /// <summary>
        /// Opens a colour dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColourSel_Click(object sender, EventArgs e)
        {
            cdiagColour.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
            this.LoadSettings();
        }
    }
}
