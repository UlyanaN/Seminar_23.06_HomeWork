// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и 
//выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите количество элементов массива: ");
int number = int.Parse(Console.ReadLine());

int[] FillArray(int num)
{
int[] array = new int[num];
int length = array.Length;
int index = 0;
while (index < length)
{
array[index] = new Random().Next(0, 100);
index++;
}
return array;
}

void PrintArray(int[] collect)
{
Console.Write("[");
int count = collect.Length;
int position = 0;
while (position < count)
{
Console.Write($"{collect[position]}, ");
position++;
}
Console.Write("]");
}

int[] arr = FillArray(number);
PrintArray(arr);

