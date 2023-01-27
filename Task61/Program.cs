// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int n = InputInt("Введите число строк треугольника: ");

int Factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
        result *= i;
    return result;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= (n - i); j++)
        Console.Write(" ");
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" " + (Factorial(i) / (Factorial(j) * Factorial(i - j))));
    }
    Console.WriteLine("\n");
}
