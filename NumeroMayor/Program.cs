Console.WriteLine("Digite primer numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite tercer numero: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"El numero mayor es: {num1}");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"El numero mayor es: {num2}");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"El numero mayor es: {num3}");
}
else
{
    Console.WriteLine("Los tres numeros son iguales");
}
