/*
Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
*/

using System;

class Program
{
    static void Main()
    {
        string inputString = "level";
        bool isPalindrome = IsPalindrome(inputString);
        
        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }

    static bool IsPalindrome(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        return input.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
    }
}
