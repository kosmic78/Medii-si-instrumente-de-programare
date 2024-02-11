using System;
using System.Collections.Generic;

class App
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (input.EndsWith("00"))
            {
                break;
            }

            if (int.TryParse(input, out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }

        Console.WriteLine("Numbers entered:");

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
