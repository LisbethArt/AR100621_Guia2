using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2_Ejercicio_01
{
    public class Celular
    {

        // Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
        public bool Encendido { get; private set; }

        // Constructor
        public Celular(string marca, string modelo, string color, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Precio = precio;
            Encendido = false;
        }

        // Métodos
        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                Console.WriteLine("El celular está encendido.");
            }
            else
            {
                Console.WriteLine("El celular ya está encendido.");
            }
        }

        public void Apagar()
        {
            if (Encendido)
            {
                Encendido = false;
                Console.WriteLine("El celular está apagado.");
            }
            else
            {
                Console.WriteLine("El celular ya está apagado.");
            }
        }

        public void Llamar(string numero)
        {
            if (Encendido)
            {
                Console.WriteLine("Llamando al número: {0}...", numero);
            }
            else
            {
                Console.WriteLine("No se puede llamar porque el celular está apagado.");
            }
        }

        public void EnviarMensaje(string numero, string mensaje)
        {
            if (Encendido)
            {
                Console.WriteLine("Enviando mensaje a {0}: {1}", numero, mensaje);
            }
            else
            {
                Console.WriteLine("No se puede enviar el mensaje porque el celular está apagado.");
            }
        }
    }

}

