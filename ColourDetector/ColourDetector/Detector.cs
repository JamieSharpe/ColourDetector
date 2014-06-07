using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace ColourDetector
{
    internal class Detector : INotifyPropertyChanged
    {
        #region Fields
        private string redX;
        private string greenX;
        private string blueX;
        private double saturation;
        private double hue;
        private double brightness;
        private string colourName;

        private Point mousePos;
        private Color colour;
        private Image screenShot = new Bitmap(25, 25, PixelFormat.Format32bppArgb);
        private readonly ColourData allColours = new ColourData();
        #endregion Fields

        #region Properties
        /// <summary>
        /// Gets/Sets the Red additive colour in hexadecimal format.
        /// This is between [00-FF].
        /// </summary>
        public string RedX
        {
            get { return this.redX; }
            private set
            {
                this.redX = value;
                OnPropertyChanged("RedX");
            }
        }

        /// <summary>
        /// Gets/Sets the Green additive colour in hexadecimal format.
        /// This is between [00-FF].
        /// </summary>
        public string GreenX
        {
            get { return this.greenX; }
            private set
            {
                this.greenX = value;
                OnPropertyChanged("GreenX");
            }
        }

        /// <summary>
        /// Gets/Sets the Blue additive colour in hexadecimal format.
        /// This is between [00-FF].
        /// </summary>
        public string BlueX
        {
            get { return this.blueX; }
            private set
            {
                this.blueX = value;
                OnPropertyChanged("BlueX");
            }
        }

        /// <summary>
        /// Gets/Sets the colour Saturation.
        /// This is between [0-1] with three decimal places.
        /// </summary>
        public double Saturation
        {
            get { return this.saturation; }
            private set
            {
                this.saturation = Math.Truncate(value * 1000) / 1000;
                OnPropertyChanged("Saturation");
            }
        }

        /// <summary>
        /// Gets/Sets the colour Hue.
        /// This is between [0-1] with three decimal places.
        /// </summary>
        public double Hue
        {
            get { return this.hue; }
            private set
            {
                this.hue = Math.Truncate(value * 1000) / 1000;
                OnPropertyChanged("Hue");
            }
        }

        /// <summary>
        /// Gets/Sets the colour Brightness.
        /// This is between [0-1] with three decimal places.
        /// </summary>
        public double Brightness
        {
            get { return this.brightness; }
            private set
            {
                this.brightness = Math.Truncate(value * 1000) / 1000;
                OnPropertyChanged("Brightness");
            }
        }

        /// <summary>
        /// Gets/Sets the Colour's Name.
        /// </summary>
        public string ColourName
        {
            get { return this.colourName; }
            private set
            {
                this.colourName = value;
                OnPropertyChanged("ColourName");
            }
        }

        /// <summary>
        /// Gets the Mouse Position
        /// </summary>
        public Point MousePos
        {
            get { return this.mousePos; }
        }

        /// <summary>
        /// Gets/Sets the Colour.
        /// </summary>
        public Color Colour
        {
            get
            {
                return this.colour;
            }
            private set
            {
                colour = value;
                OnPropertyChanged("Colour");
            }
        }

        /// <summary>
        /// Gets/Sets the Screenshot.
        /// </summary>
        public Image ScreenShot
        {
            get
            {
                return this.screenShot;
            }
            private set
            {
                this.screenShot = value;
                this.OnPropertyChanged("ScreenShot");
            }
        }
        #endregion Properties

        #region ImportedMethods
        #endregion ImportedMethods

        #region Methods
        /// <summary>
        /// Updates all the properties of the current mouse position.
        /// </summary>
        public void Update()
        {
            NativeMethods.GetCursorPos(ref mousePos);

            this.Colour = GetColorAt(MousePos);

            this.GetColourName();

            this.RedX = this.Colour.R.ToString("X2");
            this.GreenX = this.Colour.G.ToString("X2");
            this.BlueX = this.Colour.B.ToString("X2");

            this.Saturation = this.Colour.GetSaturation();
            this.Hue = this.Colour.GetHue();
            this.Brightness = this.Colour.GetBrightness();

            this.GetScreenShot(MousePos);
        }

        /// <summary>
        /// Gets the Colour at a Point on the screen.
        /// </summary>
        /// <param name="location">Location on the screen.</param>
        /// <returns>Color</returns>
        public Color GetColorAt(Point location)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = NativeMethods.BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            return screenPixel.GetPixel(0, 0);
        }

        /// <summary>
        /// Gets the colour name from a list of known colours.
        /// </summary>
        private void GetColourName()
        {
            string name = "Unknown";

            // For shades of grey
            if (this.Colour.R == this.Colour.G && this.Colour.G == this.Colour.B)
            {
                string preShade = "";
                if (this.Colour.R < byte.MaxValue / 2)
                {
                    preShade = "Dark ";
                }
                else
                {
                    preShade = "Light ";
                }
                name = preShade + "Shade of Grey";
            }
            // Get known colour
            string colourHex = "#" + this.Colour.R.ToString("X2") + this.Colour.G.ToString("X2") + this.Colour.B.ToString("X2");
            foreach (KeyValuePair<string, string> c in this.allColours.KnownColours)
            {
                if (colourHex == c.Value)
                {
                    name = c.Key;
                    break;
                }
            }
            this.colourName = name;
        }

        /// <summary>
        /// Gets a zoomed in screenshot of the area
        /// and draws a crosshair on it.
        /// </summary>
        /// <param name="location"></param>
        private void GetScreenShot(Point location)
        {
            Bitmap capture = new Bitmap(116 / 8, 116 / 8, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(capture))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = NativeMethods.BitBlt(hDC, 0, 0, 116 / 8, 116 / 8, hSrcDC, location.X - 116 / 16, location.Y - 116 / 16, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            Bitmap b = new Bitmap(116, 116, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(capture, 0, 0, 116, 116);
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, 116 / 2, 0, 116 / 2, 110);
            g.DrawLine(p, 0, 116 / 2, 110, 116 / 2);
            this.ScreenShot = b;
        }
        #endregion Methods

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Changed event so the UI knowns when yo update.
        /// </summary>
        /// <param name="propertyName">Property being updated.</param>
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion Events
    }
}
