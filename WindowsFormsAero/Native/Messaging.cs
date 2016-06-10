/*****************************************************
 *            Vista Controls for .NET 2.0
 * 
 * http://www.codeplex.com/vistacontrols
 * 
 * @author: Lorenz Cuno Klopfenstein
 * Licensed under Microsoft Community License (Ms-CL)
 * 
 *****************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace WindowsFormsAero.Native
{
    internal static class Messaging
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = false)]
        internal static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        internal const int WM_NCHITTEST = 0x84;
        internal const int WM_NCLBUTTONUP = 0x00A2;
        internal const int WM_NCLBUTTONDOWN = 0x00A1;
        internal const int WM_NCLBUTTONDBLCLK = 0x00A3;

        internal const int HTCAPTION = 2;
        internal const int HTCLIENT = 1;

    }
}
