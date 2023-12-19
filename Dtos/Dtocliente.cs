using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ObligatorioC.Dtos
{
    internal class Dtocliente
    {
        long idCliente = 11111111111111;
        string nombreCliente = "aaaaaaaa";
        string apellidosCliente = "aaaaaaaaaa";
        string nombreCompletoCliente = "aaaaaaaaaa";
        int edad = 111;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }
    
    
        
        public Dtocliente() { }

        public Dtocliente(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.edad = edad;
        }

        override
        public string ToString()
        {
            string cliente = "idCliente:  " + this.idCliente +
                "    nombreCliente:  " + this.nombreCliente +
                "    apellidioCliente:  " + this.apellidosCliente +
                "    nombreCompletoCliente:  " + this.nombreCompletoCliente +
                "    edad:  " +this.edad;
            return cliente; 
        }
    }
}
