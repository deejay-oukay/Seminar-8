// Задать двумерный массив. Написать программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя

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

void ReplaceRowsAndColumns()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i < j) && (array[i,j] != array[j,i]))
                {
                    int temp = array[i, j];
Console.WriteLine($"Меняем [{i},{j}] = {array[i,j]} на [{j},{i}] на {array[j,i]}");
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
        }
    }
}

if (array.GetLength(0) == array.GetLength(1))
{
    PrintArray("Оригинальный массив");
    ReplaceRowsAndColumns();
    PrintArray("Изменённый массив");
}
else
    System.Console.WriteLine("Число строк не равно числу столбоц");
