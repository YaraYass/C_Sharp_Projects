using System;

class Program{
    static void Main()
    {
        Console.WriteLine("Enter a Number to calculate its Factorial!");
        string? numberString = Console.ReadLine();

        bool isInputValidInt = int.TryParse(numberString, out int numberParsed);

        if (!isInputValidInt)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Question1.Factorial(numberParsed);

    }
}