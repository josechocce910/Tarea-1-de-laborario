
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                   LISTA DE CUADRADOS       ");
Console.WriteLine("-----------------------------------------------------------");

string entrada_de_numeros;
Console.Write("Ingrese los números separados por espacios:");
entrada_de_numeros  = Console.ReadLine();
string[] numeros = entrada_de_numeros .Split(' ');

Array.Sort(numeros, (a, b) => int.Parse(a).CompareTo(int.Parse(b)));

Console.WriteLine("Los números ordenados de menor a mayor:");
Console.WriteLine(string.Join(" ", numeros));
Console.ReadKey();