using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        private double salarioFijo;

        public EmpleadoTiempoCompleto(int id, string nombre, double salarioFijo)
            : base(id, nombre)
        {
            this.salarioFijo = salarioFijo;
        }

        public override double CalcularSalario()
        {
            return salarioFijo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Tiempo Completo");
            Console.WriteLine("Salario: " + CalcularSalario());
            Console.WriteLine("---------------------");
        }
    }
}
