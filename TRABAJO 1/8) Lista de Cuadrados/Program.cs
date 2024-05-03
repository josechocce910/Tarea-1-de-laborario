
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                   LISTA DE CUADRADOS       ");
Console.WriteLine("-----------------------------------------------------------");

List<int> cuadrados = new List<int>();

for (int i = 1; i <= 10; i++)
{
    int cuadrado = i * i;
    cuadrados.Add(cuadrado);
}

Console.WriteLine("Lista de cuadrados de los primeros 10 números naturales:");
foreach (int cuadrado in cuadrados)
{
    Console.WriteLine(cuadrado);
}

Console.ReadKey();
