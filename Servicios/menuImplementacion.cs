using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ObligatorioC.Servicios
{
    internal class menuImplementacion : menuInterfaz
    {
        public int menu()
        {
            Console.WriteLine("0. cerrar menú");
            Console.WriteLine("1. dar de alta nuevo cliente");
            Console.WriteLine("2. ordenar lista clientes");
            int eleccion = Console.ReadKey(true).KeyChar - ('0');
            
            return eleccion;
        }
    }
}
