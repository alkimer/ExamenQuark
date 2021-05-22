using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class Vendedor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CodigoVendedor { get; set; }
        public List<Cotizacion> HistorialCotizaciones { get; set; } = new();
        public Cotizacion RealizarCotizacion(Prenda prendaACotizar, int cantidadUnidades, Cotizador cotizador)
        {
            Cotizacion cotizacion = cotizador.RealizarCotizacion(CodigoVendedor, prendaACotizar, cantidadUnidades);
            HistorialCotizaciones.Add(cotizacion);
            return cotizacion;
        }
    }
}
