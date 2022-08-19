// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Summ(int number)
{
    int res = 0;
    if (number > 0 && number < 10) res = number;
    else
        res = 0;
       while (number > 0)
        {
            int ost = number % 10;
            res = res + ost;
            number = number / 10;
        }
    return res;
}
int result = Summ (num);
Console.WriteLine($"Сумма цифр в числе {num} = {result}");