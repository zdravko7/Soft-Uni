using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());

            //throws exception if number is negative
            if (number < 0) throw new ArgumentOutOfRangeException();

            double sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
