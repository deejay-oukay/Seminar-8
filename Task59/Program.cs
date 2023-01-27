// Задать двумерный массив из целых чисел. Написать программу, которая удалит строку и столец, на пересечении которых расположен наименьший элемент массива

int minRow = -1;
int minColumn = -1;
int[,] array = FillArray(4, 4, 1, 9);

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
            if ((minRow < 0) || (array[i, j] < array[minRow,minColumn]))
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return array;
}

void PrintArray(string message,int[,] array)
{
    Console.WriteLine(message + ": ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

int[,] OtherArray()
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    int nextRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != minRow)
        {
            int nextColumn = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != minColumn)
                {
                    newArray[nextRow,nextColumn] = array[i,j];
                    nextColumn++;
                }
            }
            nextRow++;
        }
    }
    return newArray;
}

PrintArray("Оригинальный массив",array);
PrintArray("Обрезанный массив",OtherArray());