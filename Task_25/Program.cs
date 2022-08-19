// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int numB = int.Parse(Console.ReadLine());

int Degree (int num1, int num2)
{
    int prod = 1;
    for (int i = 0; i < num2; i++)
    {
        prod = prod * num1;
    }
    return prod;
}

int result = Degree (numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = {result}");