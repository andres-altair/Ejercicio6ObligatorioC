using Ejercicio6ObligatorioC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ObligatorioC.Servicios
{
    /// <summary>
    /// interfaz encragada de los clientes
    /// <author>amd - 19/12/23</author>
    /// </summary>
    internal interface clienteInterfaz
    {
        /// <summary>
        /// /// metodo que crea un nuevo cliente
        /// <author>amd - 19/12/23</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<Dtocliente> listaAntigua);

        /// <summary>
        /// metodo que ordena los cliente
        /// <author>amd - 19/12/23</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void ordenarCliente(List<Dtocliente> listaAntigua);
    }
}
