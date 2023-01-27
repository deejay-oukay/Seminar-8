// Создать частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

int[] dictionary = new int[10];
int[,] array = FillArray(3, 3, 1, 9);

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
            dictionary[array[i, j]]++;
        }
    }
    return array;
}

void PrintArray(string message)
{
    Console.WriteLine(message + ": ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

void PrintDictionary(string message)
{
    Console.WriteLine(message + ": ");
    for (int i = 0; i < dictionary.Length; i++)
    {
        if (dictionary[i] > 0)
            Console.WriteLine($"{i} встречается раз: {dictionary[i]}");
    }

}

PrintArray("Массив");
PrintDictionary("Словарь");