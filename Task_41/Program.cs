// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
int amount = Convert.ToInt32(Console.ReadLine());
void PosNum(int numb)
{
    int res = 0;
    for (int i = 0; i < numb; i++)
    {
        Console.WriteLine("Введите число ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
            res = res + 1;
        Console.WriteLine(res);
    }
}
PosNum(amount);

