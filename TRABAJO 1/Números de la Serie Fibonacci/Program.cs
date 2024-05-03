
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("              NÚMERO DE LA SERIE FIBONACCI        ");
Console.WriteLine("-----------------------------------------------------------");


int a, b;
a = 0;
b = 1;
Console.WriteLine("El número de la serie fibonacci de los 10 primeros números es :");
Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 2; i < 10; i++)
{
    int c = a + b;
    Console.WriteLine(c);
    a = b;
    b = c;
}

Console.ReadKey();