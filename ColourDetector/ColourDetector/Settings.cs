using System;
using System.Windows.Forms;

namespace ColourDetector
{
    /// <summary>
    /// The Settings Form.
    /// </summary>
    public partial class Settings : Form
    {
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
            numOpacity.Value = Properties.Settings.Default.Opacity;
            numUpdateFreq.Value = Properties.Settings.Default.UpdateFreq / 100;
            cbOntop.Checked = Properties.Settings.Default.TopMost;
            cbSaveCol.Checked = Properties.Settings.Default.SaveColours;
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
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
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
