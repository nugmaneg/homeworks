/*
Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
*/

using System;

class Program
{
    static void Main()
    {
        string inputString = "Hello World C#";
        string reversedString = ReverseWords(inputString);
        Console.WriteLine(reversedString);
    }

    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
