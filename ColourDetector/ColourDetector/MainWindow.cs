using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ColourDetector
{
    /// <summary>
    /// The Main Window Form.
    /// </summary>
    public partial class MainWindow : Form
    {
        readonly private Detector detector = new Detector();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYUP = 0x100;

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

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

            pbZoom.DataBindings.Add("Image", detector, "Screenshot",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);

            cbZoomLevel.DataSource = detector.ZoomLevels;
            tmrUpdate.Start();
            SetHook();
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

        private void cbZoomLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            detector.ZoomLevel = (int)cbZoomLevel.SelectedItem;
        }

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr) WM_KEYUP)
            {
                Console.WriteLine(lParam);
                int vkCode = Marshal.ReadInt32(lParam);

                Console.WriteLine(vkCode);
                if (vkCode.ToString() == "113")
                {
                    Console.WriteLine("You pressed a F2");
                }
                return (IntPtr) 1;
            }
            else
            {
                return CallNextHookEx(hhook, code, (int) wParam, lParam);
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
            UnregisterHotKey(this.Handle, 0); // Unregister hotkey with id 0 before closing the form.
        }
    }
}
