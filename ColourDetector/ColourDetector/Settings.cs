using System;
using System.Windows.Forms;

namespace ColourDetector
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            numOpacity.Value = Properties.Settings.Default.Opacity;
            cbOntop.Checked = Properties.Settings.Default.TopMost;
            cbSaveCol.Checked = Properties.Settings.Default.SaveColours;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Opacity = numOpacity.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TopMost = cbOntop.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveColours = cbSaveCol.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
