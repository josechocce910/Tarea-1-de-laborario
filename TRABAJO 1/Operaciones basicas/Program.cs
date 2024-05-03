
Console.WriteLine("---------------------------------");
Console.WriteLine("       OPERACIONES BÁSICAS"       );
Console.WriteLine("---------------------------------");

 double num1, num2;

Console.Write("Ingrese el primer numero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("La suma de " + num1 + " + " + num2 + " = " + (num1 + num2));
Console.WriteLine("La resta de " + num1 + " - " + num2 + " = " + (num1 - num2));
Console.WriteLine("La suma de " + num1 + " * " + num2 + " = " + (num1 * num2));
Console.WriteLine("La suma de " + num1 + " / " + num2 + " = " + Math.Round(num1/ num2, 3));

Console.ReadKey();