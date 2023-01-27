// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string[,] array = new string[9,9]; // 9,9 вместо 4,4 - отсебятина, но процесс заполнения смотрится лучше
int currentRow = 0;
int currentColumn = 0;
int nextValue = 0;
string direction = "right";

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = "  ";// Для анимации заполнения
        }
    }
}


void SpiralFilling()
{
    while(CanMove("right") || CanMove("down") || CanMove("left") || CanMove("up"))
    {
        if (CanMove(direction))
            Move();
        else
            ChangeDirection();
    }
    Move();
}

void ChangeDirection()
{
    if (direction == "right")
        direction = "down";
    else if (direction == "down")
        direction = "left";
    else if (direction == "left")
        direction = "up";
    else
        direction = "right";
}

bool CanMove(string direction)
{
    if ((direction == "right") && (currentColumn < (array.GetLength(1)-1)) && (array[currentRow,currentColumn+1] == "  "))
        return true;
    else if ((direction == "down") && (currentRow < (array.GetLength(0)-1)) && (array[currentRow+1,currentColumn] == "  "))
        return true;
    else if ((direction == "left") && (currentColumn > 0) && (array[currentRow,currentColumn-1] == "  "))
        return true;
    else if ((direction == "up") && (currentRow > 0) && (array[currentRow-1,currentColumn] == "  "))
        return true;
    return false;
}

void Move()
{
    if (direction == "right")
        array[currentRow,currentColumn++] = NextValue();
    else if (direction == "down")
        array[currentRow++,currentColumn] = NextValue();
    else if (direction == "left")
        array[currentRow,currentColumn--] = NextValue();
    else
        array[currentRow--,currentColumn] = NextValue();
    PrintArray();
}

string NextValue()
{
    // Предполагаем, что числа могут быть только однозначные (с ведущим нулём) или двузначные
    if (nextValue >= 9)
        return($"{++nextValue}");
    else
        return($"0{++nextValue}");
}

void PrintArray()
{
    Console.Clear();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    System.Threading.Thread.Sleep(200);
}

FillArray();
SpiralFilling();
