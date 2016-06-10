using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAero.Native {
    internal static class IntHelpers {

        internal static ushort LowWord(uint val) {
            return (ushort)val;
        }

        internal static ushort HighWord(uint val) {
            return (ushort)(val >> 16);
        }

    }
}
