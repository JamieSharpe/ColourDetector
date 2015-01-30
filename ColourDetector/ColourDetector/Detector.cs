using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
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
        private int zoomLevel = 8;

        private Point mousePos;
        private Color colour;
        private Image screenShot = new Bitmap(25, 25, PixelFormat.Format32bppArgb);
        private readonly ColourData allColours = new ColourData();

        public readonly int[] ZoomLevels = {1, 2, 4, 8, 16, 32};
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
        /// Gets/Sets the Zoom Level.
        /// </summary>
        public int ZoomLevel
        {
            get { return this.zoomLevel; }
            set
            {
                switch (value)
                {
                    case 1:
                    case 2:
                    case 4:
                    case 8:
                    case 16:
                    case 32:
                        this.zoomLevel = value;
                        break;
                    default:
                        this.zoomLevel = 8;
                        break;
                }
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

        #region Methods
        /// <summary>
        /// Updates all the properties of the current mouse position.
        /// </summary>
        public void Update()
        {
            NativeMethods.GetCursorPos(ref mousePos);

            // 120 is the size of the Image panel window.
            // numbers in the power of 2 work best
            this.GetCapture(MousePos, 120, 120, this.zoomLevel);

            this.GetColourName();

            this.RedX = this.Colour.R.ToString("X2");
            this.GreenX = this.Colour.G.ToString("X2");
            this.BlueX = this.Colour.B.ToString("X2");

            this.Saturation = this.Colour.GetSaturation();
            this.Hue = this.Colour.GetHue();
            this.Brightness = this.Colour.GetBrightness();
        }

        /// <summary>
        /// Gets the Colour and Screenshot at a Point on the screen.
        /// </summary>
        /// <param name="location">Location on the screen.</param>
        /// <param name="width">Width of the capture area.</param>
        /// <param name="height">Height of the capture area.</param>
        /// <param name="scale">Zoom scale of the captured area.</param>
        /// <returns>Color</returns>
        private void GetCapture(Point location, int width, int height, int scale)
        {
            Bitmap capture = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(capture))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int captureX = width;
                    int captureY = height;
                    int locationX = location.X - width/2;
                    int locationY = location.Y - height/2;
                    int retval = NativeMethods.BitBlt(hDC, 0, 0, captureX, captureY, hSrcDC, locationX, locationY, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            this.Colour = capture.GetPixel(width / 2, height / 2);
            // Upscale the image with no pixel blending
            Bitmap scaled = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(scaled);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            // TODO: Less hard coded numbers.
            // (x*2)+60
            // (y*2)+60
            switch (scale)
            {
                case 1:
                    g.DrawImage(capture, 0, 0, width * scale, height * scale);
                    break;
                case 2:
                    g.DrawImage(capture, -60, -60, width * scale, height * scale);
                    break;
                case 4:
                    g.DrawImage(capture, -180, -180, width * scale, height * scale);
                    break;
                case 8:
                    g.DrawImage(capture, -420, -420, width * scale, height * scale);
                    break;
                case 16:
                    g.DrawImage(capture, -900, -900, width * scale, height * scale);
                    break;
                case 32:
                    g.DrawImage(capture, -1860, -1860, width * scale, height * scale);
                    break;
                default:
                    g.DrawImage(capture, 0, 0, width, height);
                    break;
            }
            // Draw crosshair
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, width / 2, 0, width / 2, height);
            g.DrawLine(p, 0, height / 2, width, height / 2);
            this.ScreenShot = scaled;
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
        #endregion Methods

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Changed event so the UI knowns when to update.
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
