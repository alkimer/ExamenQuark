using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class Cotizacion
    {
        public Guid Identificaor { get; set; } = new();
        public DateTime FechaHora { get; private set; }
        public int CodigoVendedor { get; private set; }
        public Prenda PrendaCotizada { get; private set; }
        public int CantidadUnidades { get; private set; }
        public float PrecioCotizado { get; private set; }

        public Cotizacion(DateTime fechaHora, int codigoVendedor, Prenda prendaCotizada, int cantidadUnidades, float precioCotizado)
        {
            FechaHora = fechaHora;
            CodigoVendedor = codigoVendedor;
            PrendaCotizada = prendaCotizada;
            CantidadUnidades = cantidadUnidades;
            PrecioCotizado = precioCotizado;
        }

        public override string ToString()
        {
            return ($"{FechaHora} - {PrendaCotizada} - Precio cotizado: { PrecioCotizado}  ");

        }
    }
}
