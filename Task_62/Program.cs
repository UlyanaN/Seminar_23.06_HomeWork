// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] CreateMatrixRndInt(int m, int n)
{
    int num = 1;
    int d = 1;
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[0, i] = num;
        num++;
    }
    num--;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[j, 3] = num;
        num++;
    }
    num--;
    for (int i = arr.GetLength(0) - 1; i >= 0; i--)
    {
        arr[3, i] = num;
        num++;
    }
    num--;
    for (int i = arr.GetLength(0) - 1; i >= 1; i--)
    {
        arr[i, 0] = num;
        num++;
    }
    for (int i = 0 + d; i < arr.GetLength(0) - d; i++)
    {
        arr[0 + d, i] = num;
        num++;
    }
    num--;
    for (int i = 0 + d; i < arr.GetLength(0) - d; i++)
    {
        arr[i, 3 - d] = num;
        num++;
    }
    num--;
    for (int i = arr.GetLength(0) - 1 - d; i >= 0 + d; i--)
    {
        arr[3 - d, i] = num;
        num++;
    }

    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(4, 4);
PrintMatrix(arrayResult);