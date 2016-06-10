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

namespace WindowsFormsAero.Native {
	internal static class Bitmap {

		[StructLayout(LayoutKind.Sequential)]
		internal struct BITMAPINFO {
			internal int biSize;
			internal int biWidth;
			internal int biHeight;
			internal short biPlanes;
			internal short biBitCount;
			internal int biCompression;
			internal int biSizeImage;
			internal int biXPelsPerMeter;
			internal int biYPelsPerMeter;
			internal int biClrUsed;
			internal int biClrImportant;
			internal byte bmiColors_rgbBlue;
			internal byte bmiColors_rgbGreen;
			internal byte bmiColors_rgbRed;
			internal byte bmiColors_rgbReserved;
		}

		[DllImport("gdi32.dll")]
		internal static extern IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFO pbmi, uint iUsage, int ppvBits, IntPtr hSection, uint dwOffset);

	}
}
