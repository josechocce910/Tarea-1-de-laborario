
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                   TABLA DE MULTIPLICAR       ");
Console.WriteLine("-----------------------------------------------------------");

int variable = 0;
Console.WriteLine("La tabla creada por el programa solo sera hasta el número 12");
Console.Write("ingrese el numero para la tabla de  multiplicar: ");
variable = int.Parse(Console.ReadLine());

for (int i = 0; i <= 12; i++)
{
    Console.WriteLine(variable + " * " + i + " = " + (variable * i));
}
Console.ReadKey();
