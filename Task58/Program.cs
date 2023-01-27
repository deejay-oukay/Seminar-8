// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void PrintArray(string message, int[,] array)
{
    Console.WriteLine(message + ": ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

int[,] array1 = FillArray(2, 2, 1, 9);
int[,] array2 = FillArray(2, 2, 1, 9);

int[,] MatrixProduct()
{
    int[,] product = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            for (int k = 0; k < product.GetLength(0); k++)
            {
                product[i, j] += (array1[i, k] * array2[k, j]);
            }
        }
    }

    return product;
}

PrintArray("Матрица 1", array1);
PrintArray("Матрица 2", array2);
PrintArray("Результирующая матрица", MatrixProduct());
