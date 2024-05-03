
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                  INVERSIÓN DE CADENA       ");
Console.WriteLine("-----------------------------------------------------------");


string palabra = "INGENIERIA DE SISTEMAS";
string inversa_de_la_palabra = InvertirCadena(palabra);
Console.WriteLine("La cadena invertida es: " + inversa_de_la_palabra);
Console.ReadKey();

static string InvertirCadena(string text)
{
    char[] charArray = text.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}


