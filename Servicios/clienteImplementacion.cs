using Ejercicio6ObligatorioC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ObligatorioC.Servicios
{
    /// <summary>
    /// implementacion que implementa  a la interfaz clienteInterfaz
    /// <author>amd - 19/12/23</author>
    /// </summary>
    internal class clienteImplementacion : clienteInterfaz
    {
        public void darAltaCliente(List<Dtocliente>listaAntigua)
        {
            Dtocliente cliente = crearCliente();
            listaAntigua.Add(cliente);
            Console.WriteLine(listaAntigua.ToString());
        }
        
        /// <summary>
        /// metodo que crea un cliente
        /// <author>amd - 19/12/23</author>
        /// </summary>
        /// <returns>un objeto cliente nuevo</returns>
        private Dtocliente crearCliente()
        {
            Dtocliente cliente = new Dtocliente();

            Console.WriteLine("escribe tu edad");
            cliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("escribe tu nombre");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("escribe tu apellido");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("escribe tu edad");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());
            return cliente; 
        }
        public void ordenarCliente(List<Dtocliente> listaAntigua)
        {
            
            if(3 > listaAntigua.Count)
            {
                Console.WriteLine("debe existir un minimo de 3 usuarios");
            }
            else
            {
                Dtocliente dtocliente = new Dtocliente();
               // dtocliente = listaAntigua();               


               for (int i = 0; i < listaAntigua.Count -1; i++)
               {
                   for (int j = 0; j < listaAntigua.Count -1 -i; j++)
                   {
                        if (listaAntigua[j].Edad < listaAntigua[j + 1].Edad)
                        {
                            Dtocliente aux = listaAntigua[j];
                            listaAntigua[j] = listaAntigua[j + 1];
                            listaAntigua[j + 1] = aux;
                        }
                   }
               }
            }
        }
    }
}
