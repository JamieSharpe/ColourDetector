using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace ColourDetector
{
    public partial class Form1 : Form
    {
        private readonly ColourData colours = new ColourData();

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            textBox5.Text = cursor.X.ToString();
            textBox12.Text = cursor.Y.ToString();

            Color c = GetColorAt(cursor);
            panel1.BackColor = c;

            string name = "Unknown";

            // For shades of grey
            if (c.R == c.G && c.G == c.B)
            {
                string preShade = "";
                if (c.R < byte.MaxValue / 2)
                {
                    preShade = "Dark";
                }
                else
                {
                    preShade = "Light";
                }
                name = preShade + " Shade of Grey";
            }
            // Get known colour
            string colourHex = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            foreach (KeyValuePair<string,string> colour in this.colours.knownColours)
            {
                if (colourHex == colour.Value)
                {
                    name = colour.Key;
                    break;
                }
            }
            textBox1.Text = name;

            textBox2.Text = c.R.ToString();
            textBox3.Text = c.G.ToString();
            textBox4.Text = c.B.ToString();

            textBox6.Text = c.R.ToString("X2");
            textBox7.Text = c.G.ToString("X2");
            textBox8.Text = c.B.ToString("X2");

            textBox9.Text = (Math.Truncate(c.GetSaturation() * 1000) / 1000).ToString();
            textBox10.Text = (Math.Truncate(c.GetHue() * 1000) / 1000).ToString();
            textBox11.Text = (Math.Truncate(c.GetBrightness() * 1000) / 1000).ToString();
        }

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
