// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] MatrixConvertIntoSumLines(int[,] arr1)
{
    int[] averages = new int [arr1.GetLength(0)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            sum = sum + arr1[i, j];
        }
        averages [i] = sum;
    }

    return averages;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("|");
        if (i < arr.Length - 1) Console.Write($"{arr[i],3} | ");
        else Console.Write($"{arr[i],3} |");
    }
}

int FindNumOfMinSumLine (int [] arr2)
{
    int min = arr2[0];
    int lin = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
    if (min > arr2[i])
        {
            min = arr2[i];
            lin = i;
        }   
    }
    return lin + 1;
}

int[,] arrayResult = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(arrayResult);
Console.WriteLine ();
Console.Write ("Суммы строк массива: ");
int[] arrayResult1 = MatrixConvertIntoSumLines(arrayResult);
PrintArray (arrayResult1);
Console.WriteLine ();
int line = FindNumOfMinSumLine (arrayResult1);
Console.WriteLine ($"Строка с наименьшей суммой элементов: {line}");