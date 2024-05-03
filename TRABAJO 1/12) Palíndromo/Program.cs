
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                   PALINDROMO       ");
Console.WriteLine("-----------------------------------------------------------");


string palabra;
bool es_palindromo;

Console.Write("Ingrese una palabra: ");
palabra = Console.ReadLine().ToLower();

es_palindromo = palabra.Equals(new string(palabra.Reverse().ToArray()));

Console.WriteLine(es_palindromo ? "Es un palíndromo" : "No es un palíndromo");
Console.ReadKey();