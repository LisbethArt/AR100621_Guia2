using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G2_Ejercicio_02
{
    public partial class Form1 : Form
    {
        private List<ClienteBanco> _clientes = new List<ClienteBanco>();
        public Form1()
        {
            InitializeComponent();

            cmbSucursal.Items.Add(new ClienteSucursal("Sucursal Apopa", "Plaza Mundo Apopa"));
            cmbSucursal.Items.Add(new ClienteSucursal("Sucursal Soyapango", "Plaza Mundo Apopa"));
            cmbSucursal.Items.Add(new ClienteSucursal("Sucursal HollowNest", "Hollow Knight"));

            cmbTipoCuenta.Items.Add("Corriente");
            cmbTipoCuenta.Items.Add("Ahorros");
            cmbTipoCuenta.Items.Add("Plazos");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string dui = txtDUI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string tipoCuenta = cmbTipoCuenta.Text;
            string nit = txtNIT.Text;
            decimal monto;

            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("El monto ingreso no es válido.");
                return;
            }

            if (string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            ClienteSucursal sucursal = cmbSucursal.SelectedItem as ClienteSucursal;

            if (sucursal == null)
            {
                MessageBox.Show("Seleccione una sucursal válida.");
                return;
            }

            ClienteBanco cliente = new ClienteBanco(dui, nombre, apellido, tipoCuenta, nit, sucursal);

            ClienteCuenta cuenta = new ClienteCuenta(tipoCuenta, GenerarNumeroCuenta(tipoCuenta), monto);

            cliente.Cuenta = cuenta;

            _clientes.Add(cliente);

            MessageBox.Show("Cliente registrado correctamente!");
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            foreach (ClienteBanco cliente in _clientes)
            {
                string mensaje = $"Información sobre el cliente:\n";
                mensaje += $"Nombre: {cliente.Nombre} {cliente.Apellido}\n";
                mensaje += $"DUI: {cliente.DUI}\n";
                mensaje += $"Tipo de cuenta: {cliente.TipoCuenta}\n";
                mensaje += $"Sucursal: {cliente.Sucursal.NombreSucursal}\n";
                mensaje += $"Número de cuenta: {cliente.Cuenta.NumeroCuenta}\n";
                mensaje += $"Monto disponible: {cliente.Cuenta.MontoDisponible}\n";

                MessageBox.Show(mensaje);
            }
        }

        private string GenerarNumeroCuenta(string tipoCuenta)
        {
            string abreviacion = "";
            int numeroConsecutivo = _clientes.Count + 1;

            switch (tipoCuenta)
            {
                case "Corriente":
                    abreviacion = "CO";
                    break;
                case "Ahorros":
                    abreviacion = "CA";
                    break;
                case "Plazos":
                    abreviacion = "CP";
                    break;
            }

            return $"{abreviacion}-{numeroConsecutivo:00000}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}