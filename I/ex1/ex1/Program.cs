using System;

class App
{
    static void Main()
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
            Console.WriteLine(num1 + num2);
        else
            Console.WriteLine("Wrong input!");
    }
}
