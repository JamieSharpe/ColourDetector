using System;
using System.Windows.Forms;

namespace ColourDetector
{
    /// <summary>
    /// The Settings Form.
    /// </summary>
    public partial class Settings : Form
    {
        #region Fields
        bool inTBHotKey = false;
        #endregion Fields

        #region Properties
        private bool InTBHotKey
        {
            get
            {
                return this.inTBHotKey;
            }
            set
            {
                this.inTBHotKey = value;
            }
        }
        #endregion Properties

        #region Constructor
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Settings()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Events
        /// <summary>
        /// Update form controls to current settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Load(object sender, EventArgs e)
        {
            this.cbZoomLevel.DataSource = Detector.ZoomLevels;
            numOpacity.Value = Properties.Settings.Default.Opacity;
            numUpdateFreq.Value = Properties.Settings.Default.UpdateFreq / 100;
            cbOntop.Checked = Properties.Settings.Default.TopMost;
            cbSaveCol.Checked = Properties.Settings.Default.SaveColours;
            tbHotKey.Text = ((Keys)Properties.Settings.Default.HKFreeze).ToString();
            cbZoomLevel.SelectedIndex = Properties.Settings.Default.ZoomLevelIndex;
        }

        /// <summary>
        /// The Opacity of the Main Window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numOpacity_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Opacity = numOpacity.Value;
        }

        /// <summary>
        /// How often to update the colour.
        /// This is in milliseconds.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numUpdateFreq_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpdateFreq = (int)numUpdateFreq.Value * 100;
        }

        /// <summary>
        /// Allways have the Main Window ontop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOnTop_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TopMost = cbOntop.Checked;
        }

        /// <summary>
        /// Save the colours to a local file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSaveCol_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveColours = cbSaveCol.Checked;
        }

        /// <summary>
        /// Open linked webpage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llblInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.GitHubURL);
        }

        /// <summary>
        /// Gets all the keys pressed. This helps
        /// with the limitation of TextBox not
        /// detecting Function keys.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData">The key pressed</param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.InTBHotKey)
            {
                Properties.Settings.Default.HKFreeze = (int)keyData;
                this.tbHotKey.Text = keyData.ToString();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// When the end user gives focus to the
        /// textbox, listen for keyboard input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.InTBHotKey = true;
        }

        /// <summary>
        /// When the end user leaves focus of the
        /// textbox, stop listening for keyboard input.
        /// </summary>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.InTBHotKey = false;
        }

        /// <summary>
        /// When the end user changes the zoom
        /// level combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbZoomLevel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.ZoomLevelIndex = cbZoomLevel.SelectedIndex;
        }

        /// <summary>
        /// Save the settings opon closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        #endregion Events
    }
}
