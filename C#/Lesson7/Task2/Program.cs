﻿/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine($"A({m}, {n}) = {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
