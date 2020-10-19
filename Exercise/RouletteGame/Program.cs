using System;
using System.ComponentModel;

namespace ex07_william
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }
        static void doWork()
        {
            int[] binColor = RouletteStructure.wheelColorInitialized();
            int[][] binNumber = RouletteStructure.wheelNumberInitialized();
            RouletteStructure.printTable(binNumber, binColor);
            int ballInBin;

            Console.WriteLine();
            Random bets = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"This is Bet {i}");
                
                ballInBin = bets.Next(1, 39);
                WinningBets.printWinningBets(binNumber, binColor, ballInBin);
                Console.WriteLine("------------------");
            }
        }
        

    }
    
    
}
