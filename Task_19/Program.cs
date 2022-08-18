// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 9999)
    Console.WriteLine("Число не является пятизначным ");
else
{
    int Num1 = Num / 10000;
    int Num5 = Num % 10;
    Num = Num - Num1 * 10000;
    int Num2 = Num / 1000;
    int Num4 = (Num / 10) % 10;
    if (Num1 == Num5)
    {
        if (Num2 == Num4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        Console.WriteLine("Число не является палиндромом ");
    }
    else
    Console.WriteLine("Число не является палиндромом ");

}