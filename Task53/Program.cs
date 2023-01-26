// Задать двумерный массив. Написать программу, которая поменяет местами первую и последнюю строки массива

int rows = InputInt("Введите число строк: ");
int columns = InputInt("Введите число столбцов: ");
int[,] array = FillArray(rows, columns, 1, 9);

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(string message)
{
    Console.WriteLine(message+": ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

void ReplaceRows()
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

PrintArray("Оригинальный массив");
ReplaceRows();
PrintArray("Изменённый массив");