namespace G2_Ejercicio_02
{
    internal class ClienteBanco
    {
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoCuenta { get; set; }
        public string NIT { get; set; }
        public ClienteCuenta Cuenta { get; set; }
        public ClienteSucursal Sucursal { get; set; }

        public ClienteBanco(string dui, string nombre, string apellido, string tipoCuenta, string nit, ClienteSucursal sucursal)
        {
            DUI = dui;
            Nombre = nombre;
            Apellido = apellido;
            TipoCuenta = tipoCuenta;
            NIT = nit;
            Sucursal = sucursal;
        }
    }
}