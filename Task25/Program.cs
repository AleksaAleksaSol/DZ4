﻿// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Num = ReadInt("Введите число: ");
int Pow = ReadInt("Введите степень: ");
Stepen(Num, Pow);

void Stepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + "^" + b + " = " + result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}