﻿// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 || number <= 7)
{
    if (number == 6 | number == 7) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Сегодня рабочий день");
}
else Console.WriteLine("Не верное число");