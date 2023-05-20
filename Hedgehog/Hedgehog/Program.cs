using System;

public class Hedgehog
{
    public static int MaxValue(int a, int b)
    {
        return a > b ? a : b;
    }

    public static int MinValue(int a, int b)
    {
        return a < b ? a : b;
    }
    public static int MinStepsToTargetColor(int[] population, int desiredColor)
    {
        if (population[0] == population[1] && population[0] == population[2] && population[1] == population[2])
            return 0;

        int population1 = 0;
        int population2 = 0;
        if (desiredColor == 0)
        {
            population1 = MaxValue(population[1], population[2]);
            population2 = MinValue(population[1], population[2]);
        }
        else if (desiredColor == 1)
        {
            population1 = MaxValue(population[0], population[2]);
            population2 = MinValue(population[0], population[2]);
        }
        else if (desiredColor == 2)
        {
            population1 = MaxValue(population[0], population[1]);
            population2 = MinValue(population[0], population[1]);
        }

        if ((population1 - population2) % 3 == 0 || population1 == population2)
        {
            return population1;
        }
        else
        {
            return -1;
        }
    }

    public static void Main(string[] args)
    {
        int[] population = new int[3];
        for (int i = 0; i < 3; ++i)
        {
            Console.WriteLine($"Enter the number of elements in the population: {i}");
            population[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Enter the number of the desired color");
        int desiredColor = int.Parse(Console.ReadLine());
        if (desiredColor < 0 || desiredColor > 2) Console.WriteLine("Wrong color number");
        Console.WriteLine(MinStepsToTargetColor(population, desiredColor));

    }
}



