using System.ComponentModel;

namespace LargestNumberFinder
{
    public class NumberProgram
    {
        static void Main(string[] args)
        {
            int number;
            int largest = 0;
            string total = "";
            int counter = 0;

            while (true)
            {
                try
                {
                    for (; counter < 10;)
                    {
                        Console.WriteLine("Please input a positive number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number <= 0)
                        {
                            Console.WriteLine("You did not enter a number above zero. Try again.");
                        }
                        else
                        {
                            if (number > largest)
                            {
                                largest = number;
                            }
                            total = $"{total}" + $" {number}";
                            counter++;
                        }
                    }
                    Console.WriteLine($"You entered: {total}");
                    Console.WriteLine($"The largest number is: {largest}");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a correct input. Try again.");
                }
            }
        }

         public static int ProcessInput(string input, ref int largest)
        {
            if (Convert.ToInt32(input) > largest)
            {
                largest = Convert.ToInt32(input);
                return largest;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }
    }
}
