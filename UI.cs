using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuark
{
    class UI
    {
        private const int CANTIDAD_INICIAL_CAMISAS_MANGA_LARGA_CUELLO_MAO = 200;
        private const int CANTIDAD_INICIAL_CAMISAS_MANGA_LARGA_CUELLO_NORMAL = 300;
        private const int CANTIDAD_INICIAL_CAMISAS_MANGA_CORTA_CUELLO_MAO = 150;
        private const int CANTIDAD_INICIAL_CAMISAS_MANGA_CORTA_CUELLO_NORMAL = 350;

        private const int CANTIDAD_INICIAL_PANTALONES_CHUPINES = 1500;
        private const int CANTIDAD_INICIAL_PANTALONES_COMUN = 500;

        ConsoleKeyInfo pressedKey;


        private Vendedor vendedor = new();
        private Tienda tienda = new();
        private Cotizador cotizador = new();

        public UI()
        {
            this.CargaDatosIniciales();
            this.MostrarMenuPrincipal();

        }

        private void MostrarMenuPrincipal()
        {

            Console.CursorVisible = false;
            Console.WriteLine();


            Console.WriteLine(@$"################################ BIENVENIDOS AL SISTEMA DE COTIZACION ################################
                                Tienda: {tienda.Nombre} Direccion: {tienda.Direccion}
                                Vendedor: {vendedor.Nombre} {vendedor.Apellido} - CODIGO: {vendedor.CodigoVendedor}
                                1 - COTIZAR CAMISA
                                2 - COTIZAR PANTALON
                                3 - LISTAR HISTORICO DE COTIZACIONES
################################· PRESIONE Q PARA SALIR DEL COTIZADOR #################################");
            Console.WriteLine();

            while (pressedKey.Key != ConsoleKey.Q)
            {
                pressedKey = Console.ReadKey();
                Console.WriteLine();
                EvaluateKeyPressed(pressedKey);

            }
        }

        private void EvaluateKeyPressed(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    this.CotizarCamisa();
                    break;
                case ConsoleKey.D2:
                    this.CotizarPantalon();
                    break;
                case ConsoleKey.D3:
                    this.VerHistoricoDeCotizaciones();
                    MostrarMenuPrincipal();

                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.Q:
                    break;
                default:
                    Console.WriteLine("Apretaste cualqa :( take a look at the menu above plis!");
                    break;

            }
        }

        private void VerHistoricoDeCotizaciones()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-------------HISTORICO DE COTIZACIONES---------------");

            foreach (Cotizacion cotizacion in vendedor.HistorialCotizaciones)
            {
                Console.WriteLine(cotizacion);
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

        }

        private void CotizarCamisa()
        {
            Cotizacion cotizacion;
            Console.WriteLine("################################ COTIZANDO CAMISA #################################");
            Console.WriteLine("Recuerde que ingresando 'hist' puede consultar su historico de cotizaciones mientras ingresa los datos");

            int cantidadACotizar = 0;
            Camisa camisa = new();

            camisa.Cuello = (Enums.TCuello)Enum.Parse(typeof(Enums.TCuello), PedirInformacionYObtenerRespuesta("Ingrese tipo de cuello: normal/mao", typeof(Enums.TCuello)), true);
            camisa.Manga = (Enums.TManga)Enum.Parse(typeof(Enums.TManga), PedirInformacionYObtenerRespuesta("Ingrese tipo de manga: corta/larga", typeof(Enums.TManga)), true);

            cantidadACotizar = int.Parse(PedirInformacionYObtenerRespuesta("Ingrese la cantidad a cotizar", typeof(int)));

            IngresarDatosGenerales(camisa);

            int stockReal = tienda.VerCantidadDeStock(camisa);
            if (cantidadACotizar <= stockReal)
            {
                cotizacion = vendedor.RealizarCotizacion(camisa, cantidadACotizar, cotizador);
                MostrarCotizacion(cotizacion);
            }
            else
            {
                Console.WriteLine($"La cantidad a cotizar {cantidadACotizar} no puede ser mayor al stock en la tienda para esa prenda que es {stockReal}");
            }

            MostrarMenuPrincipal();

        }


        private void CotizarPantalon()
        {
            Cotizacion cotizacion;
            Console.WriteLine("################################ COTIZANDO PANTALON #################################");
            Console.WriteLine("Recuerde que ingresando 'hist' puede consultar su historico de cotizaciones mientras ingresa los datos");

            int cantidadACotizar = 0;
            Pantalon pantalon = new();

            pantalon.Tipo = (Enums.TPantalon)Enum.Parse(typeof(Enums.TPantalon), PedirInformacionYObtenerRespuesta("Ingrese tipo de pantalon : comun/chupin", typeof(Enums.TPantalon)), true);

            cantidadACotizar = int.Parse(PedirInformacionYObtenerRespuesta("Ingrese la cantidad a cotizar", typeof(int)));

            IngresarDatosGenerales(pantalon);

            int stockReal = tienda.VerCantidadDeStock(pantalon);
            if (cantidadACotizar <= stockReal)
            {
                cotizacion = vendedor.RealizarCotizacion(pantalon, cantidadACotizar, cotizador);
                MostrarCotizacion(cotizacion);
            }
            else
            {
                Console.WriteLine($"La cantidad a cotizar {cantidadACotizar} no puede ser mayor al stock en la tienda para esa prenda que es {stockReal}");
            }

            MostrarMenuPrincipal();

        }


        private void MostrarCotizacion(Cotizacion cotizacion)
        {
            Console.WriteLine($"----------------- LA COTIZACION ES: {cotizacion.PrecioCotizado} ");
        }

        private Prenda IngresarDatosGenerales(Prenda prenda)
        {
            prenda.Precio = float.Parse(PedirInformacionYObtenerRespuesta("Ingrese el precio ", typeof(float)));
            prenda.Calidad = (Enums.TCalidad)Enum.Parse(typeof(Enums.TCalidad), PedirInformacionYObtenerRespuesta("Ingrese calidad: standard/premium", typeof(Enums.TCalidad)), true);
            return prenda;

        }
        private void CargaDatosIniciales()
        {
            vendedor.Nombre = "Carlos";
            vendedor.Apellido = "García Moreno";
            vendedor.CodigoVendedor = 9999;

            tienda.Nombre = "Alta llanta";
            tienda.Direccion = "Av. Siempreviva 1992";

            tienda.Prendas.Add(new Camisa(Enums.TCuello.mao, Enums.TManga.larga, CANTIDAD_INICIAL_CAMISAS_MANGA_LARGA_CUELLO_MAO));
            tienda.Prendas.Add(new Camisa(Enums.TCuello.mao, Enums.TManga.corta, CANTIDAD_INICIAL_CAMISAS_MANGA_CORTA_CUELLO_MAO));
            tienda.Prendas.Add(new Camisa(Enums.TCuello.normal, Enums.TManga.larga, CANTIDAD_INICIAL_CAMISAS_MANGA_LARGA_CUELLO_NORMAL));
            tienda.Prendas.Add(new Camisa(Enums.TCuello.normal, Enums.TManga.corta, CANTIDAD_INICIAL_CAMISAS_MANGA_CORTA_CUELLO_NORMAL));
            tienda.Prendas.Add(new Pantalon(Enums.TPantalon.chupin, CANTIDAD_INICIAL_PANTALONES_CHUPINES));
            tienda.Prendas.Add(new Pantalon(Enums.TPantalon.comun, CANTIDAD_INICIAL_PANTALONES_COMUN));

        }


        private string PedirInformacionYObtenerRespuesta(string message, Type expectedType)
        {
            string enteredValue = "";

            Console.WriteLine(message);
            enteredValue = Console.ReadLine();

            while (!Utils.IsValidField(enteredValue, expectedType))
            {
                if (enteredValue.ToLower().Equals("hist"))
                {
                    VerHistoricoDeCotizaciones();
                    Console.WriteLine(message);

                    enteredValue = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Verifique el valor ingresado");
                    enteredValue = Console.ReadLine();
                }

            }
            return enteredValue;

        }



    }





}