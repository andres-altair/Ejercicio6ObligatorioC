using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ObligatorioC.Servicios
{
    internal interface clienteInterfaz
    {
        /// <summary>
        /// metodo que crea un nuevo cliente
        /// <author>amd - 19/12/23</author>
        /// </summary>
        public void darAltaCliente();

        /// <summary>
        /// metodo que ordena los cliente
        /// <author>amd - 19/12/23</author>
        /// </summary>
        public void ordenarCliente();
    }
}
