using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGeometria
{
    public class Rombo
    {
        private const int NLATI = 4;
        private double lato;


        public double CalcolaPerimetro()
        {
            return lato * 4 ;
        }
    }

}
