using System;

class Program
{
    const decimal SALARIO_MINIMO = 1500000M;
    const int HORAS_MENSUALES = 160;
    const int MAX_HORAS_DOMINGO = 96;

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombreEmpleado = Console.ReadLine();

        int horasSemanales = 0;
        bool valido = false;
        while (!valido)
        {
            Console.WriteLine("Ingrese las horas trabajadas en la semana:");
            if (int.TryParse(Console.ReadLine(), out horasSemanales) && horasSemanales >= 0)
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor válido (número positivo)");
            }
        }

        int horasDomingo = 0;
        valido = false;
        while (!valido)
        {
            Console.WriteLine("¿Trabajó el domingo? (si/no):");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si" || respuesta == "sí")
            {
                bool horasValidas = false;
                while (!horasValidas)
                {
                    Console.WriteLine($"Ingrese las horas trabajadas el domingo (máximo {MAX_HORAS_DOMINGO}):");
                    if (int.TryParse(Console.ReadLine(), out horasDomingo))
                    {
                        if (horasDomingo >= 0 && horasDomingo <= MAX_HORAS_DOMINGO)
                        {
                            horasValidas = true;
                            valido = true;
                        }
                        else
                        {
                            Console.WriteLine($"Error: Las horas dominicales deben estar entre 0 y {MAX_HORAS_DOMINGO}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un número válido");
                    }
                }
            }
            else if (respuesta == "no")
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("Error: Responda 'si' o 'no'");
            }
        }

        decimal tarifaPorHora = SALARIO_MINIMO / HORAS_MENSUALES;
        decimal pagoNormal = tarifaPorHora * horasSemanales;
        decimal pagoDomingo = tarifaPorHora * 2 * horasDomingo;
        decimal total = pagoNormal + pagoDomingo;

        if (total < SALARIO_MINIMO)
        {
            total = SALARIO_MINIMO;
        }

        Console.WriteLine("\nResumen de Nómina");
        Console.WriteLine("------------------");
        Console.WriteLine($"Nombre: {nombreEmpleado}");
        Console.WriteLine($"Horas totales: {horasSemanales + horasDomingo}");
        Console.WriteLine($"Valor hora normal: {tarifaPorHora:N2}");
        Console.WriteLine($"Valor hora dominical: {tarifaPorHora * 2:N2}");
        Console.WriteLine($"Pago horas normales: {pagoNormal:N2}");
        Console.WriteLine($"Pago horas domingo: {pagoDomingo:N2}");
        Console.WriteLine($"TOTAL A PAGAR: {total:N2}");
    }
}
