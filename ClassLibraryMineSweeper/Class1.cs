using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace ClassLibraryMineSweeper
{
    public static class Functions     //Some simple functions for Unit test purposes
    {
        public static int AppWidth(int length)
        {
            return 649 + length * 25;
        }
        public static int AppHeight(int length)
        {
            return 500 + length * 10;
        }
        public static int ButtonLocationj(int j)
        {
            return 30 + 30 * j;
        }
        public static int ButtonLocationi(int i)
        {
            return 30 + 30 * i;
        }
    }
}
