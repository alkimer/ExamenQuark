using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Prenda> Prendas { get; private set; } = new();
        public int VerCantidadDeStock(Prenda prenda)
        {

            foreach (Prenda elem in Prendas)
            {
                if (elem.GetType().Equals(prenda.GetType()))
                {
                    if (elem.Equals(prenda))
                    {
                        return elem.Stock;
                    }
                }
            }
            return 0;
        }
    }
}
