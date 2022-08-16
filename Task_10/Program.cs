// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int Num1 = Convert.ToInt32 (Console.ReadLine());
int MiddleDigit(int num)
{
int digit1 = num / 100;
int digit3 = num % 10;
return (num - digit1*100 - digit3)/10;
}
int result = MiddleDigit(Num1);
Console.WriteLine($"Вторая цифра => {result}");