using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    public class Salario // Pública para que pueda ser usada en cualquier instancia del proyecto
    {
        private int diasLaborados; // Atributo
        public int DiasLaborados // Propiedad del atributo
        { get; set; }
        // Método para calcular salario
        public decimal CalcularSalario(int diaslab, decimal valordia)
        {
            decimal totalsalario = diaslab * valordia;
            return totalsalario;
        }
    }
}
