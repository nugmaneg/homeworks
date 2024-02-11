/*
Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
*/


using System;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isDivisibleBy7And23 = (number % 7 == 0) && (number % 23 == 0);
if (isDivisibleBy7And23)
    Console.WriteLine($"{number} кратно и 7, и 23.");
else
    Console.WriteLine($"{number} не кратно одновременно 7 и 23.");