using GestionEmpleados;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();

        empleados.Add(new EmpleadoTiempoCompleto(1, "Tomás", 2500000));
        empleados.Add(new EmpleadoPorHoras(2, "Alejandro", 160, 15000));
        empleados.Add(new EmpleadoTiempoCompleto(3, "Laura", 3000000));
        empleados.Add(new EmpleadoPorHoras(4, "Meisser", 120, 18000));

        for (int i = 0; i < empleados.Count; i++)
        {
            empleados[i].MostrarInformacion();
        }

        Console.ReadLine();
    }
}
