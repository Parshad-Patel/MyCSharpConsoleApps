using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Simple_Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            int[] num;
            int playerpoints = 0;
            int comppoints = 0;
            int turn = 0;
            Random random = new Random();

            Console.WriteLine("Welcome to the Simple Dice Game!\r\n\r\n");
            Console.WriteLine("This is a two-player game where you can choose to play against the computer\r\n\r\n");
            Console.WriteLine("How to Play:\r\n\r\nChoose either Even or Odd.\r\n\r\nA dice will be rolled.\r\n\r\nIf the number rolled matches your choice (even or odd), you earn 1 point.\r\n\r\nIf it doesn't match, your opponent gets 1 point.\r\n\r\nYou can set a winning point limit at the start.\r\n\r\nThe game continues until either player reaches the winning points.\r\n\r\nThe first to reach the target is declared the winner!");
            Console.WriteLine("\r\n\r\nPress any key to start the game...");
            Console.ReadKey();
            Console.Clear();
            
            while (playAgain)
            {
                Console.Write("Enter the winning points limit (1-10): ");
                int winningPoints = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Choose either Even or Odd (e/o)");
                string evenorodd = Console.ReadLine();
                Console.WriteLine();
                if (evenorodd == "e")
                {
                    num = new int[] { 2, 4, 6 };
                }
                else if(evenorodd=="o") {
                    num = new int[] { 1, 3, 5 };
                }
                else {
                    Console.WriteLine("Invalid input. Please enter 'e' for Even or 'o' for Odd.");
                    continue;
                }
                for (int i = 0; i <= winningPoints*2; i++)
                {
                    int dicenumber = random.Next(1, 7);
                    if (turn == 0) 
                    {
                        Console.Write("\r\nPress any key to roll the dice...");
                        Console.ReadKey();
                        Console.WriteLine($"\r\nThe dice rolled: {dicenumber}");
                        turn =1;
                    }
                    else
                    {
                        Console.WriteLine("\r\n...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine($"The computer rolled: {dicenumber}");
                        turn = 0;
                    }
                    
                    if (num.Contains(dicenumber))
                    {
                        playerpoints += 1;
                        
                    }
                    else
                    {
                        comppoints += 1;
                    }
                    if (playerpoints == winningPoints)
                    {
                        Console.WriteLine("You win!");
                        Console.WriteLine($"You: {playerpoints} | Computer: {comppoints}");
                        break;
                    }
                    else if (comppoints == winningPoints)
                    {
                        Console.WriteLine("Computer wins!");
                        Console.WriteLine($"You: {playerpoints} | Computer: {comppoints}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You: {playerpoints} | Computer: {comppoints}");
                    }

                }
                Console.WriteLine("Do you want to play again? (y/n)");
                string ispayagain = Console.ReadLine();
                if (ispayagain == "n")
                {
                    playAgain = false;
                }
                else
                {
                    playAgain = true;
                    playerpoints = 0;
                    comppoints = 0;
                    Console.Clear();
                }
            }
        }
    }
}
