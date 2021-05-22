using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class Cotizador
    {
        public Cotizacion RealizarCotizacion(int codigoVendedor, Prenda prendaACotizar, int cantidadUnidades)
        {
            float precioCotizado = prendaACotizar.Precio;
            if (prendaACotizar is Camisa)
            {
                if (((Camisa)prendaACotizar).Manga == Enums.TManga.corta) { precioCotizado = (precioCotizado * 0.9f); }
                if (((Camisa)prendaACotizar).Cuello == Enums.TCuello.mao) { precioCotizado = (precioCotizado * 1.03f); }

            }
            else if (prendaACotizar is Pantalon)
            {
                if (((Pantalon)prendaACotizar).Tipo == Enums.TPantalon.chupin) { precioCotizado = (precioCotizado * 0.88f); }
            }

            if (prendaACotizar.Calidad == Enums.TCalidad.premium) { precioCotizado = precioCotizado * 1.3f; }

            precioCotizado = precioCotizado * cantidadUnidades;
            return new Cotizacion(DateTime.Now, codigoVendedor, prendaACotizar, cantidadUnidades, precioCotizado);

        }

    }


}
