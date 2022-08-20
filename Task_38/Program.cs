// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble () * (max-min);
    }
    return arr;
}

double DifBetweenMinMax(double[] arr)
{
    double diff = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    diff = (max - min);
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
double[] array = CreateArray (5, 1, 100);
// double[] array = { 3.5, 7.1, 22.9, 2.3, 78.5 };
PrintArray(array);
double res = DifBetweenMinMax(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {res,2}");