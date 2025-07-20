using System.Diagnostics;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this his is the simple c# program that print the numbers from 1 to N 

            //with immutable string

            Console.WriteLine("Enter the maximum number to print: ");
            string? input = Console.ReadLine();
            //if (int.TryParse(input , out int numberafterParsing))
            //{
            //    Stopwatch stopwatch = Stopwatch.StartNew();
            //    string numberAsString = string.Empty;
            //    for (int i = 1; i <= numberafterParsing; i++)
            //    {

            //        //condition to remove the last comma from the string
            //        if (i<numberafterParsing)
            //        {
            //            numberAsString += $"{i},";
            //        }
            //        else{
            //            numberAsString += $"{i}";
            //        }
            //    }
            //    stopwatch.Stop();
            //    double elapsedSeconds = Convert.ToDouble( stopwatch.Elapsed.TotalSeconds);
            //    Console.WriteLine($"The number {numberAsString} is printed");
            //    Console.WriteLine($"the time where the process is completed is: {elapsedSeconds} \nand the time Complexity with normal loop and immutable string is O(N*N) ");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number!!");
            //}

            //==============================================================================================

            //with StringBuilder

            if(int.TryParse(input, out int numberAfterParsing))
            {
                StringBuilder numberAsString = new StringBuilder();
                Stopwatch stopwatch = Stopwatch.StartNew();

                for (int i = 1; i <= numberAfterParsing; i++)
                {
                    //condition to remove the last comma from the string
                    if (i < numberAfterParsing)
                    {
                        numberAsString.Append($"{i},");
                    }
                    else
                    {
                        numberAsString.Append($"{i}");
                    }
                }
                stopwatch.Stop();
                double elapsedSeconds = Convert.ToDouble(stopwatch.Elapsed.TotalSeconds);  
                Console.WriteLine($"The number {numberAsString} is printed");   
                Console.WriteLine($"The time where the process is completed is: {elapsedSeconds} \nand the time Complexity with normal loop and StringBuilder is O(N) ");
            }
            else
            {
                Console.WriteLine("Please enter a valid number!!");
            }

        }
    }
}
