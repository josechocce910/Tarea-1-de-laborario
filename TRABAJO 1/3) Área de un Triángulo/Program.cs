
Console.WriteLine("---------------------------------");
Console.WriteLine("       Área de un triangulo      ");
Console.WriteLine("---------------------------------");

double base_del_triangulo, altura;

Console.Write("Ingrese la base del triangulo: ");
base_del_triangulo = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la altura del triangulo: ");
altura  = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("El área del triángulo es: " + Math.Round(((base_del_triangulo * altura) / 2),3));
Console.ReadKey();