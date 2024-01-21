namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // POUNDS TO KILOGRAMS //
            Console.WriteLine("Weight in Pounds (lbs): " );
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kilograms = pounds * 0.453592;
            Console.WriteLine("Weight Converted in Kilograms (kg): " + kilograms);


            Console.WriteLine("==================================================");


            // MILES TO KILOMETERS //
            Console.WriteLine("Lengt in Miles (mi): " );
            double miles = Convert.ToDouble(Console.ReadLine());

            double kilometers = miles * 1.60934;
            Console.WriteLine("Lengt in Kilometers (km): " + kilometers);

            Console.WriteLine("==================================================");


            // FAHRENHEIT TO CELCIUS //
            Console.WriteLine("Temperature in Fahrenheit: " );
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celcius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("Temperature in Celius (°C): " + celcius);


            Console.WriteLine("==================================================");

            // AGES OF STUDENTS //
            Console.WriteLine("Age of Student 1: " );
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 2: ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 3: ");
            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 4: ");
            int age4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 5: ");
            int age5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 6: ");
            int age6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 7: ");
            int age7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 8: ");
            int age8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 9: ");
            int age9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age of Student 10: ");
            int age10 = Convert.ToInt32(Console.ReadLine());

            int average_age = (age1 + age2 + age3 + age4 + age5 + age6 + age7 + age8 + age9 + age10) / 10;
            Console.WriteLine("The average age of student is: " + average_age);


            Console.WriteLine("==================================================");

            // STORY //
            string char1 = "Lady";
            string char2 = "Ananchelle";
            string char3 = "Rambo";
            string char4 = "Yando";
            string char5 = "Tiger";
            string sword = "Sword of Radiance";
            string enchantress = "Enchantress of Shadows";
            string shield = "Shield of Eternity";
            string bow = "Bow of the Wind";
            string staff = "Thunderstaff";

            Console.WriteLine("In the small town of Hadassa, there lived 5 fearless warriors:");
            Console.WriteLine($"{char1}, {char2}, {char3}, {char4}, and {char5} embarked on a quest to locate the Enchanted Crystal, " +
                "a gem capable of restoring harmony and peace to their world.");
            Console.WriteLine("Along the way, they encountered talking mountains, fiery creatures, and deadly mirages.");
            Console.WriteLine($"{char1}, equipped with the mystical {sword}, showcased her skill in swiftly cutting through the challenges.");
            Console.WriteLine($"{char2}, the {enchantress}, used her magical abilities to manipulate the shadows and protect the group.");
            Console.WriteLine($"{char3}, the Ironclad Defender, wielded the {shield}, guarding his companions against the fiercest attacks.");
            Console.WriteLine($"{char4}, the Swift Archer, shot arrows with incredible precision using his legendary {bow}.");
            Console.WriteLine($"{char5}, the Elemental Sorcerer, harnessed the power of the {staff} to control lightning and unleash devastating storms.");
            Console.WriteLine("As they neared the crystal, they discovered its power to heal, igniting a spark of hope within them.");
            Console.WriteLine("At the journey's final step, just outside the Enchanted Crystal, there was an Ogre guarding the gem.");
            Console.WriteLine("Despite the ogre being the most dangerous creature in their world, their teamwork prevailed, and they slayed it.");
            Console.WriteLine("After obtaining the Enchanted Crystal, they returned home and resolved all the issues in their world.");
            Console.WriteLine("Finally, they all lived happily with peace and harmony in their world.");



            Console.WriteLine("==================================================");

            // INPUT OUTPUT 1 //
            Console.Write("Enter a number to print a triangle of those numbers: ");
            int number1 = int.Parse(Console.ReadLine());
            if (number1 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= number1; i+= 1)
                {
                    for (int j = 1; j <= i; j+= 1)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("==================================================");

            // INPUT OUTPUT 2 //

            Console.Write("Enter a number to print the arithmetic sum of it: ");
            int number2 = int.Parse(Console.ReadLine());
            if (number2 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int result = 0;
                for (int i = 1; i <= number2; i+=1)
                {
                    result += i;
                }
                Console.WriteLine($"The sum of numbers from 1 to {number2} is {result}.");
            }

            Console.WriteLine("==================================================");

            // INPUT OUTPUT 13 //
            Console.Write("Enter a number to print an inverted triangle of those numbers: ");
            int number3 = int.Parse(Console.ReadLine());
            if (number3 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = number3; i > 0; i-= 1)
                {
                    Console.WriteLine(string.Join(" ", Enumerable.Range(1, i)));
                }
            }

            Console.WriteLine("==================================================");
        }
    }
}




