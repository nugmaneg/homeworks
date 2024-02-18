/*
Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
*/

int[] numbers = new int[] { 1, 2, 3, 4, 5 };

for (int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
