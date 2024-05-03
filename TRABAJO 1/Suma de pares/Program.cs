Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                  SUMA DE LOS NUMEROS PARES");
Console.WriteLine("-----------------------------------------------------------");

int inicio, fin, contador;
contador = 0;
Console.WriteLine("Ingrese un rango especifico para la suma de numeros pares");
Console.Write("Ingrese el número inicial del rango:");
inicio = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el número final del rango:");
fin = Convert.ToInt32(Console.ReadLine());


for (int i = inicio; i <= fin; i++)
{
    if (i % 2 == 0)
    {
        contador += i;
    }
}

Console.WriteLine("La suma de los números pares en el rango es: " + contador);
Console.ReadKey();