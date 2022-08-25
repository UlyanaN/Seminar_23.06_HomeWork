// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("|");
        if (i < arr.Length - 1) Console.Write($"{arr[i], 3} | ");
        else Console.Write($"{arr[i], 3} |");
    }
}

void ConvertMatrixLinesIntoArray(int[,] arr1)
{
    int[] arrayMatr1 = new int[arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arrayMatr1 [j] = arr1 [i, j];
        }
        
        Array.Sort(arrayMatr1);
        Array.Reverse (arrayMatr1);
        PrintArray (arrayMatr1);
        Console.WriteLine ();
    }
    return;
}

int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(arrayResult);
Console.WriteLine();
ConvertMatrixLinesIntoArray(arrayResult);
