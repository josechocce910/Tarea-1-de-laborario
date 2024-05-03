
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("      PROGRMA PARA SABER SI UN NÚMERO ES PRIMO O NO        ");
Console.WriteLine("-----------------------------------------------------------");

int num, contador, divisor;
contador = 0;
divisor = 1;
Console.Write("Ingrese el número a verificar: ");
num = Convert.ToInt32(Console.ReadLine());

while(divisor <= num)
{
    if (num % divisor == 0)
    {
        contador++;
    }
    divisor ++;
}
if (contador == 2)
{
    Console.WriteLine("El número ingresado es un número primo");
}
else
{
    Console.WriteLine("El número ingresado no es un número primo ");
}
Console.ReadKey();