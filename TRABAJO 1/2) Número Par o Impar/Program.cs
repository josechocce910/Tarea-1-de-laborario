

Console.WriteLine("---------------------------------");
Console.WriteLine("      NUMERO PAR O IMPAR         ");
Console.WriteLine("---------------------------------");

int num1;

Console.Write("Ingrese el numero a saber si es par o impar: ");
num1 = Convert.ToInt32(Console.ReadLine());

if(num1 % 2==0)
{
    Console.WriteLine("El numero " + num1 + " es par.");
}
else
{
    Console.WriteLine("El numero " + num1 + " es impar.");
}
Console.ReadKey();
    