// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    Console.WriteLine(message + ": ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

void SortColumns()
{
    // Повторяем всё это необходимое количество раз
    for (int k = 0; k < array.GetLength(1); k++)
    {
        // Проходим по строкам
        for (int i = 0; i < array.GetLength(0); i++)
        {
            // Проходим от первого до предпоследнего элемента в строке
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
}

PrintArray("Оригинальный массив");
SortColumns();
PrintArray("Изменённый массив");
