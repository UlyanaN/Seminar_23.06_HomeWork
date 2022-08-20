// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int SumofEvenPosis(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)

        summ += arr[i];
        
    }
    return summ;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}
int[] array = CreateArray(4, - 100, 100);
// int[] array = { -4, -6, 89, 6 };
PrintArray(array);
int res = SumofEvenPosis(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res}");
