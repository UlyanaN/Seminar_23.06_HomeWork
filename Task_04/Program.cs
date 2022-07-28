// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 1е число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите 2е число: ");
int num2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите 3е число: ");
int num3 = Convert.ToInt32 (Console.ReadLine());
int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine ($"Максимальное число: {max}");