using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ObligatorioC.Servicios
{
    internal interface menuInterfaz
    {
        /// <summary>
        /// metodo encargado de mostrar menu y recoger opcion elegida
        /// <author>amd - 19/12/23</author>
        /// </summary>
        /// <returns>int (opcion elegida)</returns>
        public int menu();
    }
}
