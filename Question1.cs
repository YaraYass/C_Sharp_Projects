class Question1
{
    public static int UserEnterNumber()
    {
        Console.WriteLine("Enter a Number to calculate its Factorial!");
        string? numberString = Console.ReadLine();

        bool isInputValidInt = int.TryParse(numberString, out int numberParsed);

        if (!isInputValidInt)
        {
            Console.WriteLine("Invalid input");
            return -1;
        }

        return numberParsed;
    }

    public static void GetFactorial(int x)
    {
        int factorialValue = 1;
        int maxFactorialCalc = 12;
        int minFactorialCalc = 0;

        if(x < minFactorialCalc || x > maxFactorialCalc)
        {
            Console.WriteLine("Factorial Limit Hit");
            return;
        }

        for(int i=x;i>=1;i--)
        {
            factorialValue *= i;
        }

        Console.WriteLine($"The Factorial for {x}, is: {factorialValue}");
    }

    public static void Factorial()
    {
        GetFactorial(UserEnterNumber());
    }
}