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

    [StructLayout(LayoutKind.Sequential)]
    internal struct RECT
    {
        internal RECT(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        internal RECT(System.Drawing.Rectangle rect)
        {
            Left = rect.X;
            Top = rect.Y;
            Right = rect.Right;
            Bottom = rect.Bottom;
        }

        internal int Left;
        internal int Top;
        internal int Right;
        internal int Bottom;

        internal int Width
        {
            get
            {
                return Right - Left;
            }
            set
            {
                Right = Left + value;
            }
        }
        internal int Height
        {
            get
            {
                return Bottom - Top;
            }
            set
            {
                Bottom = Top + value;
            }
        }

        internal System.Drawing.Rectangle ToRectangle()
        {
            return new System.Drawing.Rectangle(Left, Top, Right - Left, Bottom - Top);
        }

    }
}
