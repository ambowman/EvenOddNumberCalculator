using System;


namespace OddEvenCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter a number:");
            number = Int32.Parse(Console.ReadLine());
            OddEvenCalculatorConsoleApp.PlayWithNumbers playWithNumbers = new OddEvenCalculatorConsoleApp.PlayWithNumbers();
            if (playWithNumbers.DetermineOddOrEven(number))
            {
                Console.WriteLine("Number is even");
                return;
            }
            Console.WriteLine("Number is odd");
        }
    }

    public class PlayWithNumbers
    {
        public bool DetermineOddOrEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
