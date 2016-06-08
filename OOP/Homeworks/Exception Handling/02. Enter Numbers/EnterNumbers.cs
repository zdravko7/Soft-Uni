using System;

class EnterNumbers
{
    public static void ReadNumber(int start, int end)
    {
        int input = int.Parse(Console.ReadLine());

        if ((input < start) || (input > end))
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    static void Main(string[] args)
    {
        int length = 10;

        Console.Write("Please enter start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Please enter end number: ");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < length; i++)
        {
            try
            {
                Console.Write("Enter your {0} number between {1} and {2}: ", i+1, start, end);
                ReadNumber(start, end);
            }
            catch
            {
                Console.WriteLine("Invalid number, please try again!");
                if (i > 0)  i--;
            }
        }
    }
}
