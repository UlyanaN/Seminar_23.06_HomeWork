// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());

int NumFromNToOne(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 > num2) 
    return num1 + NumFromNToOne(num1, num2 - 1);
    else 
    return num1 + NumFromNToOne(num1 + 1, num2);   
}

int res = NumFromNToOne(m, n);
Console.WriteLine (res);