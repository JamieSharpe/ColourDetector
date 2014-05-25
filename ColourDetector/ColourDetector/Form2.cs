using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ColourDetector
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Bitmap colours = new Bitmap(256, 256);
            for (int i = 0; i < 256; ++i)
            {
                for (int j = 0; j < 256; ++j)
                {
                    colours.SetPixel(i, j, Color.FromArgb(i, j, (i+j)/2));
                }
            }
            pictureBox1.Image = colours;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("moved");
        }
    }
}
