namespace G2_Ejercicio_02
{
    internal class ClienteCuenta
    {
        public string TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal MontoDisponible { get; set; }

        public ClienteCuenta(string tipoCuenta, string numeroCuenta, decimal montoDisponible)
        {
            TipoCuenta = tipoCuenta;
            NumeroCuenta = numeroCuenta;
            MontoDisponible = montoDisponible;
        }
    }
}