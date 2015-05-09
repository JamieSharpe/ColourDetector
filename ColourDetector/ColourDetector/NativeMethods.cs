using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace ColourDetector
{
    internal static class NativeMethods
    {
        #region DllImports
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

        /// <summary>
        /// Used to get keyboard button state.
        /// This is then used for global setting changes.
        /// </summary>
        /// <param name="vKey">The vKey to determine whether
        /// it was pressed after a previous call to the
        /// method.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Int32 vKey);
        #endregion DllImports
    }
}
