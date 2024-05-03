public static int Factorial(int number)
{
    if (number < 0)
    {
        throw new ArgumentException("El número debe ser mayor o igual a cero.");
    }

    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
}