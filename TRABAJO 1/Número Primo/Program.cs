

class Program
{
    static void Main()
    {
        Console.Write("Introduce el número a averificar: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (EsPrimo(num))
            Console.WriteLine(num + " es un número primo.");
        else
            Console.WriteLine(num + " no es un número primo.");
    }

    static bool EsPrimo(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Sqrt(number);

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}
    }
}

