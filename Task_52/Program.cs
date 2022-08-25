﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double [] FindAverage (int[,] arr1)
{
    double [] averages = new double [arr1.GetLength(1)];
   for (int j = 0; j < arr1.GetLength(1); j++)
    {
        double sum = 0;
        double count = 0;
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
          sum = sum + arr1 [i, j];
          count ++;
        }
       double average =  sum / count;
       averages [j] = Math.Round (average, 2);
    } 
    
    return averages;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}

int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 20);
PrintMatrix(arrayResult);
Console.WriteLine ();
double[] arrayResultAverage = FindAverage(arrayResult);
PrintArray (arrayResultAverage);

