using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            List<string> history = new List<string>();
            string hist;
            string check;
            Console.WriteLine("It's my calculator program");
            Console.WriteLine("Guide for the /, *, -,+ this is work, just enter two numbers and between them just assign the sign of the option that you are to perform ");
            Console.WriteLine("For the Option Write o, show the history  write h");
            check = Console.ReadLine();
            while (runAgain)
            {
                if (check == "o" || check =="y")
                {
                    Console.WriteLine("Enter the first number");
                    string first = Console.ReadLine();
                    Console.WriteLine("Enter the second number");
                    string second = Console.ReadLine();
                    Console.WriteLine("Enter the operation");
                    string operation = Console.ReadLine();
                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = Convert.ToDouble(first) + Convert.ToDouble(second);
                            hist = first + " + " + second + " = " + result;
                            history.Add(hist);
                            break;
                        case "-":
                            result = Convert.ToDouble(first) - Convert.ToDouble(second);
                            hist = first + " + " + second + " = " + result;
                            history.Add(hist);
                            break;
                        case "*":
                            result = Convert.ToDouble(first) * Convert.ToDouble(second);
                            hist = first + " + " + second + " = " + result;
                            history.Add(hist);
                            break;
                        case "/":
                            result = Convert.ToDouble(first) / Convert.ToDouble(second);
                            hist = first + " + " + second + " = " + result;
                            history.Add(hist);
                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            break;
                    }
                    Console.WriteLine($"The result is: {result}");
                    Console.WriteLine("Do you want to run anyother operation? (y/n) or see the history so write h");
                    check = Console.ReadLine();
                }
                else if (check == "h")
                {
                    Console.WriteLine("History of operations:");
                    foreach (string item in history)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Do you want to run anyother operation? (y/n) or see the history so write h");
                    check = Console.ReadLine();
                }
                else if (check == "n")
                {
                    runAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    runAgain = false;
                }
            }
        }
    }
}
