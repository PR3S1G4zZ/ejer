var i = 1;
do { 

Console.Write($"Ingrese el numero:{i} un numero Entero:");
var numString = (Console.ReadLine());
var num = int.Parse( numString );


    if (int.TryParse(numString, out int numInt))
    {
        if (numInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numInt} es par!!");

        }
        else
        {
            Console.WriteLine($"El numero {numInt} es impar!!");
        }
    }
    else 
    {
        Console.WriteLine("El valor '" + $"{numString}" + "' no es un numero Entero !!");

    }
    i++;
}while (i <= 3);
