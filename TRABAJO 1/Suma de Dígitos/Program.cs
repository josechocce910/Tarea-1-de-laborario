
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("           SUMA DE DIGITOS DE UN NÚMERO ENTERO      ");
Console.WriteLine("-----------------------------------------------------------");



int numero, suma;
Console.Write("Ingresa un número entero: ");
numero = Convert.ToInt32(Console.ReadLine());
suma = CalcularSumaDigitos(numero );
Console.WriteLine("La suma de los dígitos del número es: " + suma);
Console.ReadKey();

static int CalcularSumaDigitos(int numero)
{
    int suma = 0;
    while (numero > 0)
    {
        suma += numero % 10;
        numero /= 10;
    }
    return suma;
}