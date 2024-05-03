Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                   CONTADOR DE VOCALES       ");
Console.WriteLine("-----------------------------------------------------------");

string palabra;
int contador_de_vocales;

Console.Write("Ingrese una cadena de texto:");
palabra = Console.ReadLine();
contador_de_vocales  = palabra .ToLower().Count(c => "aeiouáéíóú".Contains(c));

Console.WriteLine("El número de vocales en la cadena es: " + contador_de_vocales );
Console.ReadKey();
