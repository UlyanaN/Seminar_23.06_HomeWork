// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numst = Convert.ToString (num);
// if (numst.Length > 2)
// {
//     Console.WriteLine ($"Третья цифра: {numst[2]}");
// }
// else
// Console.WriteLine ("Третьей цифры нет");

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
if (num1 < 99)
Console.WriteLine ("Третьей цифры нет");
else
{
    while (num1 > 1000)
    {
        num1 = num1 / 10;
    }
    int thirdDigit = num1 % 10;
    Console.WriteLine ($"Третья цифра: {thirdDigit}");
}