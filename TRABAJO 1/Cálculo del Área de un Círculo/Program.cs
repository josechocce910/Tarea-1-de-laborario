
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                   ÁREA DE UN CIRCÚLO     ");
Console.WriteLine("-----------------------------------------------------------");


Console.Write("Ingrese el radio del círculo:");
double radio = Convert.ToDouble(Console.ReadLine());

double area = 3.14159 * radio * radio;

Console.WriteLine("El área del círculo es: " + area);
Console.ReadKey();