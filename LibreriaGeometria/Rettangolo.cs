using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGeometria
{
    class Rettangolo
    {
        private const int NLATI = 4;
        private double b;
        private double h;

        public double CalcolaPerimetro()
        {
            return b*h;
        }
    }
}
