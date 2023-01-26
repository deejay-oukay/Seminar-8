// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindMinSum()
{
    // Здесь будем хранить суммы строк
    int[] sumOfRows = new int[array.GetLength(0)];
    // Проходим по каждой строке
    for (int i < 0; i < array.GetLength(0); i++)
    {
        // Подсчитываем сумму столбцов
        for (int j < 0; array.GetLength(1); j++)
        {
            sumOfRows[i] += array[i,j];
        }
// Определение минимальной суммы можно сделать прямо здесь
    }
}

PrintArray("Случайный массив");
FindMinSum();