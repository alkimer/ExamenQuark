using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    abstract class Prenda
    {
        public Enums.TCalidad Calidad { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return "Tipo:" + this.GetType().Name + " - Calidad: " + Calidad.ToString() + " - Stock: " + Stock.ToString() + " - Precio: " + Precio.ToString();
        }
    }
}
