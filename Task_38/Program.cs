﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

double DifBetweenMinMax(double[] arr)
{
    double diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        double max = arr[0];
        double min = arr[0];
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
        diff = max - min;
    }
    return diff;
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
// int[] array = CreateArray(4, - 100, 100);
double[] array = { 2.3, 7.1, 22.9, 3.5, 78.5 };
PrintArray(array);
double res = DifBetweenMinMax(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {res,2}");