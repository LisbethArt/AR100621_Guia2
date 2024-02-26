using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Ejercicio_02
{
    internal class ClienteSucursal
    {
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }

        public ClienteSucursal(string nombreSucursal, string direccion)
        {
            NombreSucursal = nombreSucursal;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return $"{NombreSucursal}, {Direccion}";
        }
    }
}
