using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minergame
{
    public static class Core
    {

        //gombnyomása\\
        public readonly static Keys Keyup = Keys.W;
        public readonly static Keys Keydown = Keys.S;
        public readonly static Keys KeyLeft = Keys.A;
        public readonly static Keys Keyright = Keys.D;

        //mozgás cuccok\\

        public static bool IsUp = false;
        public static bool IsDown = false;
        public static bool IsLeft = false;
        public static bool IsRight = false;




    }
}
