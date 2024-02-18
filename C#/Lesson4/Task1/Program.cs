/*
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/

while (true)
{
    Console.Write("Введите целое число: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    int sum = 0;
    foreach (char c in input)
    {
        sum += c - '0';
    }

    if (sum % 2 == 0)
    {
        Console.WriteLine("Сумма цифр чётная. Завершение программы.");
        break;
    }
}
