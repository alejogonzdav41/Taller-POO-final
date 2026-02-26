using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados
{
    public class EmpleadoPorHoras : Empleado
    {
        private int horasTrabajadas;
        private double valorPorHora;

        public EmpleadoPorHoras(int id, string nombre, int horasTrabajadas, double valorPorHora)
            : base(id, nombre)
        {
            this.horasTrabajadas = horasTrabajadas;
            this.valorPorHora = valorPorHora;
        }

        public override double CalcularSalario()
        {
            return horasTrabajadas * valorPorHora;
        }

        public double CalcularSalario(double bono)
        {
            return (horasTrabajadas * valorPorHora) + bono;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Por Horas");
            Console.WriteLine("Salario: " + CalcularSalario());
            Console.WriteLine("---------------------");
        }
    }
}
