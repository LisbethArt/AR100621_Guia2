using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Ejercicio_01
{
    public partial class Form1 : Form
    {
        private Celular celular;
        public Form1()
        {
            InitializeComponent();
            // Crea una instancia de la clase Celular al iniciar el formulario
            celular = new Celular("Samsung", "Galaxy", "Negro", 500);
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            celular.Encender();
            MessageBox.Show("Celular encendido.");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            celular.Apagar();
            MessageBox.Show("Celular apagado.");
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;

            // Verificar si el celular está apagado
            if (!celular.Encendido)
            {
                MessageBox.Show("No se puede llamar porque el celular está apagado.");
                return; // Sale del método para evitar continuar con la operación
            }

            // Verificar si el número ingresado es válido
            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
                return; // Sale del método para evitar continuar con la operación
            }

            // Si el celular está encendido y el número es válido, realizar la llamada
            celular.Llamar(numero);
            MessageBox.Show($"Llamando al número {numero}.");
        }


        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;
            string mensaje = txtMensaje.Text;

            // Verificar si el celular está apagado
            if (!celular.Encendido)
            {
                MessageBox.Show("No se puede enviar el mensaje porque el celular está apagado.");
                return; // Sale del método para evitar continuar con la operación
            }

            // Verificar si el número y el mensaje ingresados son válidos
            if (string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show("Por favor, ingrese un número y un mensaje válidos.");
                return; // Sale del método para evitar continuar con la operación
            }

            // Si el celular está encendido y se ingresaron un número y un mensaje válidos, enviar el mensaje
            celular.EnviarMensaje(numero, mensaje);
            MessageBox.Show($"Enviando mensaje a {numero}: {mensaje}.");
        }
    }
}
