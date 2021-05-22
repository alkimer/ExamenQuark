using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class Pantalon : Prenda
    {
        public Enums.TPantalon Tipo { get; set; }

        public Pantalon(Enums.TPantalon tipo, int stock)
        {
            Stock = stock;
            Tipo = tipo;
        }


        public Pantalon() { }

        public override bool Equals(object obj)
        {
            return obj is Pantalon pantalon &&
                   Calidad == pantalon.Calidad &&
                   Tipo == pantalon.Tipo;
        }

        public override string ToString()
        {
            return base.ToString() + " Tipo: " + Tipo.ToString();
        }
    }



}
