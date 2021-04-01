using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBuilder.Models
{
    class Mouse
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public bool L_Click { get; set; }
        public bool R_Click { get; set; }
        public bool M_Click { get; set; }

        public Mouse()
        {
            PosX = 0;
            PosY = 0;
            L_Click = false;
            R_Click = false;
            M_Click = false;

        }

        public Mouse(int x, int y, bool mouse1, bool mouse2, bool mouse3)
        {
            PosX = x;
            PosY = y;

            L_Click = mouse1;
            R_Click = mouse2;
            M_Click = mouse3;
        }

        public String toString()
        {
            String aux = "";

            if (L_Click == true)
            {
                aux += "M1 ";
            }

            if (R_Click == true)
            {
                aux += "M2 ";
            }

            if (M_Click == true)
            {
                aux += "M3 ";
            }

            return aux;
        }

        public override bool Equals(object obj)
        {
            return obj is Mouse mouse &&
                   PosX == mouse.PosX &&
                   PosY == mouse.PosY &&
                   L_Click == mouse.L_Click &&
                   R_Click == mouse.R_Click &&
                   M_Click == mouse.M_Click;
        }
    }
}
