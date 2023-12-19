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
            int eleccion = mi.menu();

        }
    }


}
