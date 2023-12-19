using Ejercicio6ObligatorioC.Dtos;
using Ejercicio6ObligatorioC.Servicios;

namespace Ejercicio6ObligatorioC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dtocliente> list = new List<Dtocliente>(); 
            
            menuInterfaz mi = new menuImplementacion();
            clienteInterfaz ci = new clienteImplementacion();
            
            bool abrirMenu = false;

            while (!false)
            {
                int eleccion = mi.menu();
                switch (eleccion) 
                { 
                case 0:
                        Console.WriteLine("cierre aplicacion");
                        break;
                case 1:
                        break; 
                case 2:
                        break;
                default: Console.WriteLine("eleccion inexistente");
                        break;
                }

            }

        }
    }


}
