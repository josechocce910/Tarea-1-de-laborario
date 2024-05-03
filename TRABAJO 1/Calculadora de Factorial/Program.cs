

Console.WriteLine("---------------------------------");
Console.WriteLine("      FACTORIAL DE UN NUMERO        ");
Console.WriteLine("---------------------------------");

int num1, resultado;

Console.Write("Ingrese el numero a saber su factorial: ");
num1 = Convert.ToInt32(Console.ReadLine());

resultado = 1;
for (int i = 1; i <= num1; i++)
{
    resultado *= i;
}


Console.WriteLine("El factorial (!) de "+num1 + " es "+resultado );
Console.ReadKey();

