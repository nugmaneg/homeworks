/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sumOfDigits = 0;

        while (number != 0)
        {
            sumOfDigits += number % 10;
            number /= 10;
        }

        Console.WriteLine($"Сумма цифр числа: {sumOfDigits}");
    }
}