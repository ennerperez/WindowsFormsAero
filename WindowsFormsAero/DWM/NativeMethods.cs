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
using System.Drawing;

namespace WindowsFormsAero.Dwm
{
    internal static class NativeMethods
    {

        #region DWM Thumbnail methods

        [Flags()]
        internal enum DwmThumbnailFlags {
            RectDestination = 0x1,
            RectSource = 0x2,
            Opacity = 0x4,
            Visible = 0x8,
            SourceClientAreaOnly = 0x10
        }

        internal struct DwmThumbnailProperties {
            internal DwmThumbnailFlags dwFlags;
            internal Native.RECT rcDestination;
            internal Native.RECT rcSource;
            internal byte opacity;
            [MarshalAs(UnmanagedType.Bool)]
            internal bool fVisible;
            [MarshalAs(UnmanagedType.Bool)]
            internal bool fSourceClientAreaOnly;
        }

		[StructLayout(LayoutKind.Sequential)]
		internal struct DwmSize {
			internal int Width;
			internal int Height;

			internal Size ToSize(){
				return new Size(Width, Height);
			}
		}



        [DllImport("dwmapi.dll")]
        internal static extern int DwmRegisterThumbnail(IntPtr hwndDestination, IntPtr hwndSource, out Thumbnail phThumbnailId);

        [DllImport("dwmapi.dll")]
        internal static extern int DwmUnregisterThumbnail(IntPtr hThumbnailId);

        [DllImport("dwmapi.dll")]
        internal static extern int DwmUpdateThumbnailProperties(Thumbnail hThumbnailId, ref DwmThumbnailProperties ptnProperties);

        [DllImport("dwmapi.dll")]
        internal static extern int DwmIsCompositionEnabled([MarshalAs(UnmanagedType.Bool)] out bool pfEnabled);

		[DllImport("dwmapi.dll")]
		internal static extern int DwmQueryThumbnailSourceSize(Thumbnail hThumbnail, out DwmSize pSize);

        #endregion

        #region DWM Blur Behind

        [StructLayout(LayoutKind.Sequential)]
        internal struct BlurBehind {
            internal BlurBehindFlags dwFlags;
            internal bool fEnable;
            internal IntPtr hRgnBlur;
            internal bool fTransitionOnMaximized;
        }

        internal enum BlurBehindFlags : int {
            Enable = 0x00000001,
            BlurRegion = 0x00000002,
            TransitionOnMaximized = 0x00000004
        }

        [DllImport("dwmapi.dll", PreserveSig = false)]
        internal static extern int DwmEnableBlurBehindWindow(IntPtr hWnd, ref BlurBehind pBlurBehind);

        #endregion

        #region DWM Glass Frame

        [DllImport("dwmapi.dll", PreserveSig = false)]
        internal static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Margins pMarInset);

        #endregion

        #region Attributes

        internal enum DwmWindowAttribute : int {
            DWMWA_NCRENDERING_ENABLED = 1,
            DWMWA_FLIP3D_POLICY = 8,
            DWMWA_DISALLOW_PEEK = 11,
            DWMWA_EXCLUDED_FROM_PEEK = 12,
        }

        [DllImport("dwmapi.dll")]
        internal static extern int DwmSetWindowAttribute(IntPtr hwnd, DwmWindowAttribute dwAttribute, ref int pvAttribute, int cbAttribute);

        internal static int DwmSetWindowFlip3dPolicy(IntPtr hwnd, Flip3DPolicy policy) {
            int iPolicy = (int)policy;
            return DwmSetWindowAttribute(hwnd, DwmWindowAttribute.DWMWA_FLIP3D_POLICY,
                ref iPolicy, Marshal.SizeOf(typeof(int)));
        }

        internal static int DwmSetWindowDisallowPeek(IntPtr hwnd, bool disallowPeek) {
            int iPrevent = (disallowPeek) ? 1 : 0;
            return DwmSetWindowAttribute(hwnd, DwmWindowAttribute.DWMWA_DISALLOW_PEEK,
                ref iPrevent, Marshal.SizeOf(typeof(int)));
        }

        internal static int DwmSetWindowExcludedFromPeek(IntPtr hwnd, bool preventPeek) {
            int iPrevent = (preventPeek) ? 1 : 0;
            return DwmSetWindowAttribute(hwnd, DwmWindowAttribute.DWMWA_EXCLUDED_FROM_PEEK,
                ref iPrevent, Marshal.SizeOf(typeof(int)));
        }

        #endregion

    }
}
