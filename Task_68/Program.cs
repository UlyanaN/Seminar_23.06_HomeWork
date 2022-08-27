// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());


int AkkFun(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num1 > 0 && num2 == 0)
        return AkkFun(num1 - 1, n = 1);
    else if ((num1 > 0) && (num2 > 0))
        return AkkFun(num1 - 1, AkkFun(num1, num2 - 1));
    else
        return num2 + 1;
}

int res = AkkFun(m, n);
Console.WriteLine(res);
