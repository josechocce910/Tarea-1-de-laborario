
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("                  SUMA DE NÚMEROS PARES     ");
Console.WriteLine("-----------------------------------------------------------");

int inicio, fin, contador;
contador = 0;

Console.Write("Ingrese un rango estimado desde donde desea sumar los numeros pares");

Console.Write("Ingrese el número inicial del rango: ");
inicio = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el número final del rango: ");
fin = Convert.ToInt32(Console.ReadLine());

for (int i = inicio; i <= fin; i++)
{
    if (i % 2 == 0)
    {
        contador += i;
    }
}
Console.WriteLine("La suma de los pares del rango especificado es: " + contador);
Console.ReadKey();