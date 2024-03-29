﻿// See https://aka.ms/new-console-template for more information

// ------------------------------------------------------------------------------------------------
// EXERCISE 2
// ------------------------------------------------------------------------------------------------

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

// ------------------------------------------------------------------------------------------------
// EXERCISE 3
// ------------------------------------------------------------------------------------------------

static double GetAverage(int[] numbers)
{
    double sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4, 5};
double average = GetAverage(numbers);
Console.WriteLine(average);

// ------------------------------------------------------------------------------------------------
// EXERCISE 4
// ------------------------------------------------------------------------------------------------

static double FindMax(int[] numbers)
{
    double sum = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > sum)
        {
            sum = numbers[i];
        }
    }

    return sum;
}

int[] numbers2 = {2, 8, 4, 6};
Console.WriteLine(FindMax(numbers2));