using Ejercicio6ObligatorioC.Dtos;
using Ejercicio6ObligatorioC.Servicios;

namespace Ejercicio6ObligatorioC
{
    /// <summary>
    /// clase pricipal
    /// <author>amd - 19/12/23</author>
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodo principal
        /// <author>amd - 19/12/23</author>
        /// </summary>
        /// <param name="args"></param>
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
                        abrirMenu = true;
                        break;
                case 1:
                        Console.WriteLine("dar alta cliente");
                        ci.darAltaCliente(list);
                        break; 
                case 2:
                        Console.WriteLine("ordenar cliente");
                        ci.ordenarCliente(list);    
                        break;
                default: Console.WriteLine("eleccion inexistente");
                        break;
                }

            }

        }
    }


}
