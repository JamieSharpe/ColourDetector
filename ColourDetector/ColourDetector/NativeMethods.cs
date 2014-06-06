using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace ColourDetector
{
    internal static class NativeMethods
    {
        /// <summary>
        /// Used to get the current cursor position.
        /// </summary>
        /// <remarks>http://msdn.microsoft.com/en-gb/library/windows/desktop/ms648390(v=vs.85).aspx</remarks>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point lpPoint);

        /// <summary>
        /// Used to get a colour of the screen.
        /// </summary>
        /// <remarks>http://msdn.microsoft.com/en-gb/library/windows/desktop/dd183370(v=vs.85).aspx</remarks>
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
    }
}
