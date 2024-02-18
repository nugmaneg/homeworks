/*
Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

Random random = new Random();
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100, 1000);
}

int countEven = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        countEven++;
    }
}

// Console.WriteLine($"{string.Join(", ", numbers)}");
Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
