// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32 (Console.ReadLine());
string [] array = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
int index = num;
if (index < 6)
Console.WriteLine ("нет");
else
Console.WriteLine ("да");
