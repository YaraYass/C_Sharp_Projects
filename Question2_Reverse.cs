class Question2_Reverse
{
    public static void UserEnterNumber()
    {
        Console.WriteLine("Enter a Number to Reverse it!");
        string? numberString = Console.ReadLine();

        bool isInputValidInt = int.TryParse(numberString, out _);

        if (!isInputValidInt)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        ReverseNumber(numberString!);
    }

    public static void ReverseNumber(string number)
    {
        char[] charArray = number.ToCharArray();
        int charArrayLength = charArray.Length;
        char[] charArrayReversed = new char[charArrayLength];

        for(int i = 0; i < charArrayLength; i++)
        {
            charArrayReversed[charArrayLength - i - 1] = charArray[i];
        }

        Console.WriteLine($"Reversed Number is: {new string(charArrayReversed)}");

    }

}