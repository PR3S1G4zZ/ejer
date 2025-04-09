using System;

class Program
{
    const decimal SALARIO_MINIMO = 1500000M;
    const int HORAS_MENSUALES = 160;

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombreEmpleado = Console.ReadLine();

        Console.WriteLine("Ingrese las horas trabajadas en la semana:");
        int horasSemanales = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese las horas trabajadas el domingo:");
        int horasDomingo = int.Parse(Console.ReadLine());

        decimal tarifaPorHora = SALARIO_MINIMO / HORAS_MENSUALES;
        decimal pagoHorasRegulares = tarifaPorHora * horasSemanales;
        decimal pagoHorasDomingo = tarifaPorHora * horasDomingo * 2;
        decimal pagoTotal = pagoHorasRegulares + pagoHorasDomingo;

       
        if (pagoTotal < SALARIO_MINIMO)
        {
            pagoTotal = SALARIO_MINIMO;
        }

        Console.WriteLine("\nResumen de Nómina");
        Console.WriteLine("------------------");
        Console.WriteLine($"Nombre del Empleado: {nombreEmpleado}");
        Console.WriteLine($"Total de Horas Trabajadas: {horasSemanales + horasDomingo}");
        Console.WriteLine($"Tarifa por Hora Regular: ${tarifaPorHora:N2}");
        Console.WriteLine($"Tarifa por Hora Dominical: ${tarifaPorHora * 2:N2}");
        Console.WriteLine($"Pago por Horas Normales: ${pagoHorasRegulares:N2}");
        Console.WriteLine($"Pago por Horas Dominicales: ${pagoHorasDomingo:N2}");
        Console.WriteLine($"Pago Total: ${pagoTotal:N2}");
    }
}
