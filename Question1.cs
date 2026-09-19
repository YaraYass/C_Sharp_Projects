class Question1
{
    public static void Factorial(int x)
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
}