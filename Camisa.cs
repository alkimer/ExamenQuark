using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class Camisa : Prenda
    {
        public Enums.TCuello Cuello { get; set; }
        public Enums.TManga Manga { get; set; }

        public Camisa(Enums.TCuello cuello, Enums.TManga manga, int stock)

        {
            Stock = stock;
            Cuello = cuello;
            Manga = manga;
        }

        public Camisa() { }

        public override bool Equals(object obj)
        {
            return obj is Camisa camisa &&
                   Calidad == camisa.Calidad &&
                   Cuello == camisa.Cuello &&
                   Manga == camisa.Manga;
        }

        public override string ToString()
        {
            return base.ToString() + " - Cuello: " + Cuello.ToString() + " - Manga: " + Manga.ToString();
        }
    }
}
