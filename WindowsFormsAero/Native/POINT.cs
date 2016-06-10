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

	[StructLayout(LayoutKind.Sequential)]
	internal struct POINT {
		internal POINT(int x, int y) {
			X = x;
			Y = y;
		}
		internal POINT(System.Drawing.Point p) {
			X = p.X;
			Y = p.Y;
		}
		internal POINT(System.Drawing.PointF p) {
			X = (int)p.X;
			Y = (int)p.Y;
		}

		internal int X;
		internal int Y;
	}

}
