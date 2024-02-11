/*
Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

Console.Write("Введите двузначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int tensDigit = number / 10;
int unitsDigit = number % 10;
int maxDigit = Math.Max(tensDigit, unitsDigit);
Console.WriteLine($"Наибольшая цифра числа {number}: {maxDigit}");
