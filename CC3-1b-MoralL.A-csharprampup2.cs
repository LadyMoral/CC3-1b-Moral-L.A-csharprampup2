using System;

class Program
{
    static void Main()
    {
        // Weight conversion
        Console.Write("Enter weight in pounds: ");
        int lbs = int.Parse(Console.ReadLine());
        double kgConv = 0.45359237;
        double kg = lbs * kgConv;
        Console.WriteLine($"Weight in Kilograms: {kg} kg.");
        Console.WriteLine("------------------------------------------");

        // Distance conversion
        Console.Write("Enter distance in miles: ");
        int mi = int.Parse(Console.ReadLine());
        double kmConv = 1.60934;
        double km = mi * kmConv;
        Console.WriteLine($"Distance in kilometers: {km} km.");
        Console.WriteLine("------------------------------------------");

        // Temperature conversion
        Console.Write("Enter temperature in Fahrenheit: ");
        string tempFar = Console.ReadLine();
        double tempCel = (double.Parse(tempFar) - 32) / 1.8;
        Console.WriteLine($"Temperature in Celsius: {tempCel}");
        Console.WriteLine("------------------------------------------");

        // Average age calculation
        int[] ages = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter a number for student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Student Age {i + 1}: {ages[i]}");
        }
        double ageAvg = ages.Sum() / 10.0;
        Console.WriteLine($"The average age of the 10 students is {ageAvg}\n");

        // Story characters
        string char1 = "Lady";
        string char2 = "Ananchelle";
        string char3 = "Mila";
        string char4 = "Mias";
        string char5 = "Mel";

        Console.WriteLine("In the small town of Hadassa, there lived 5 fearless warriors:");
        Console.WriteLine($"{char1}, {char2}, {char3}, {char4}, and {char5} embarked on a quest to locate the Enchanted Crystal, " +
            "a gem capable of restoring harmony and peace to their world.");
        Console.WriteLine("Along the way, they encountered talking mountains, fiery creatures, and deadly mirages.");
        Console.WriteLine("As they neared the crystal, they discovered its power to heal, igniting a spark of hope within them.");
        Console.WriteLine($"At the journey's final step, just outside the Enchanted Crystal, there was an Ogre guarding the gem.");
        Console.WriteLine("Despite the ogre being the most dangerous creature in their world, their teamwork prevailed, and they slayed it.");
        Console.WriteLine($"After obtaining the Enchanted Crystal, they returned home and resolved all the issues in their world.");
        Console.WriteLine("Finally, they all lived happily with peace and harmony in their world.");

        // Experiment 1
        Console.Write("Enter a number for experiment 1: ");
        int number1 = int.Parse(Console.ReadLine());
        if (number1 <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = 1; i <= number1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("------------------------------------------");

        // Experiment 2
        Console.Write("Enter a number for experiment 2: ");
        int number2 = int.Parse(Console.ReadLine());
        if (number2 <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            int result = 0;
            for (int i = 1; i <= number2; i++)
            {
                result += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {number2} is {result}.");
        }
        Console.WriteLine("------------------------------------------");

        // Experiment 3
        Console.Write("Enter a number for experiment 3: ");
        int number3 = int.Parse(Console.ReadLine());
        if (number3 <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = number3; i > 0; i--)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(1, i)));
            }
        }
        Console.WriteLine("------------------------------------------");
    }
}
