using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    public class Empleado // Pública para que pueda ser usada en cualquier instancia del proyecto
    {
        private string nombre; // Primer atributo
        public string Nombre // Propiedad asociada al atributo nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string identificacion; // Segundo atributo
        public string Identificacion // Propiedad asociada al atributo identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private decimal salarioDiario; // Tercer atributo
        public decimal SalarioDiario // Propiedad asociada al atributo salarioDiario
        {
            get { return salarioDiario; }
            set { salarioDiario = value; }
        }
    }

}
