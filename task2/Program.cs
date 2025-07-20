namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is the simple c# program that print the addition from 1 to N numbers

            Console.WriteLine("enter the maximum number to calculate::  ");
            string? input = Console.ReadLine();
            if (int.TryParse(input , out int numberAfterParsing))
            {
                int sumByForLoop = 0;
                int sumByFormula = (numberAfterParsing * (numberAfterParsing + 1)) / 2;
                for (int i = 1; i <= numberAfterParsing; i++)
                {
                    sumByForLoop += i;
                }
                Console.WriteLine($"the sum of numbers from 1 to {numberAfterParsing} with for loop is {sumByForLoop} and the time complexity is O(N)");
                Console.WriteLine($"the sum of numbers from 1 to {numberAfterParsing} with Folmula is {sumByFormula} and the time complexity is O(C)");
            }
            else
            {
                Console.WriteLine("please enter a vaild number !!");
            }
        }
    }
}
