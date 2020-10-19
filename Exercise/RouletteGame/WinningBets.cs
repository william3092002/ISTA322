using System;


namespace ex07_william
{
    class WinningBets
    {
        public static void printEvenOrOdds(int ballInBin)
        {
            if (ballInBin % 2 == 1)
                Console.WriteLine("Even/Odds: Odds");
            else
                Console.WriteLine("Even/Odds: Even");
        }
        public static void printRedsOrBlacks(int[] binColor, int ballInBin)
        {
            Console.WriteLine($"Reds/Blacks: {RouletteStructure.printColor(binColor[ballInBin - 1])}");
        }
        public static void printLowHigh(int ballInBin)
        {
            if (ballInBin > 0 & ballInBin <= 18)
                Console.WriteLine($"Lows/Highs: Lows");
            if (ballInBin > 18 & ballInBin <= 36)
                Console.WriteLine($"Lows/Highs: High");
        }
        public static void printDozen(int ballInBin)
        {
            if (ballInBin > 0 & ballInBin <= 12)
                Console.WriteLine($"Dozens: 1-12 dozen");
            if (ballInBin > 12 & ballInBin <= 24)
                Console.WriteLine($"Dozens: 13-24 dozen");
            if (ballInBin > 24 & ballInBin <= 36)
                Console.WriteLine($"Dozens: 25-36 dozen");
        }
        public static void printColumns(int ballInBin)
        {
            if (ballInBin % 3 == 0)
                Console.WriteLine($"Column: Third Column");
            if (ballInBin % 3 == 1)
                Console.WriteLine($"Column: First Column");
            if (ballInBin % 3 == 2)
                Console.WriteLine($"Column: Second Column");
        }
        public static void printStreet(int[][] binNumber, int ballInBin)
        {
            Console.Write($"Street: ");
            foreach (var item in binNumber[(ballInBin - 1) / 3])
            {
                Console.Write($"[{RouletteStructure.printNumber(binNumber, item - 1)}]");
            }
            Console.WriteLine();
        }
        public static void printDoubleStreet(int[][] binNumber, int ballInBin)
        {
            Console.Write($"Double Street: ");
            if (((ballInBin - 1) / 3) == 11)
            {
                foreach (var item in binNumber[((ballInBin - 1) / 3) - 1])
                {
                    Console.Write($"[{RouletteStructure.printNumber(binNumber, item - 1)}]");
                }
                Console.Write(",");
            }
            foreach (var item in binNumber[(ballInBin - 1) / 3])
            {
                Console.Write($"[{RouletteStructure.printNumber(binNumber, item - 1)}]");
            }
            Console.Write(",");

            if (((ballInBin - 1) / 3) != 11)
            {
                foreach (var item in binNumber[((ballInBin - 1) / 3) + 1])
                {
                    Console.Write($"[{RouletteStructure.printNumber(binNumber, item - 1)}]");
                }
            }
            Console.WriteLine("");
        }
        public static void printSplit(int ballInBin)
        {
            Console.Write($"Split: ");
            if (ballInBin % 3 == 1)
            {
                if (ballInBin == 1)
                    Console.Write($"[{ballInBin}][{ballInBin + 1}],[{ballInBin}][{ballInBin + 3}]");
                if (ballInBin == 34)
                    Console.Write($"[{ballInBin - 3}][{ballInBin}],[{ballInBin}][{ballInBin + 1}]");
                if (ballInBin > 3 & ballInBin < 34)
                    Console.Write($"[{ballInBin - 3}][{ballInBin}],[{ballInBin}][{ballInBin + 1}],[{ballInBin}][{ballInBin + 3}]");
            }
            if (ballInBin % 3 == 2)
            {
                if (ballInBin == 2)
                    Console.Write($"[{ballInBin - 1}][{ballInBin}],[{ballInBin}][{ballInBin + 1}],[{ballInBin}][{ballInBin + 3}] ");
                if (ballInBin == 35)
                    Console.Write($"[{ballInBin - 1}][{ballInBin}],[{ballInBin}][{ballInBin + 1}],[{ballInBin}][{ballInBin + -3}] ");
                if (ballInBin > 3 & ballInBin < 34)
                    Console.Write($"[{ballInBin - 3}][{ballInBin}],[{ballInBin - 1}][{ballInBin}],[{ballInBin}][{ballInBin + 1}],[{ballInBin}][{ballInBin + 3}]");
            }
            if (ballInBin % 3 == 0)
            {
                if (ballInBin == 3)
                    Console.Write($"[{ballInBin - 1}][{ballInBin}],[{ballInBin}][{ballInBin + 3}]");
                if (ballInBin == 36)
                    Console.Write($"[{ballInBin - 3}][{ballInBin}],[{ballInBin - 1}][{ballInBin}]");
                if (ballInBin > 3 & ballInBin < 34)
                    Console.Write($"[{ballInBin - 3}][{ballInBin}],[{ballInBin - 1}][{ballInBin}],[{ballInBin}][{ballInBin + 3}]");
            }
            Console.WriteLine();
        }
        public static void printCorner(int ballInBin)
        {
            Console.Write($"Corner: ");
            if (ballInBin % 3 == 1)
            {
                switch (ballInBin)
                {
                    case 1:
                        Console.Write($"[{ballInBin}][{ballInBin + 1}][{ballInBin + 3}][{ballInBin + 4}]");
                        break;
                    case 34:
                        Console.Write($"[{ballInBin - 3}][{ballInBin - 2}][{ballInBin}][{ballInBin + 1}]");
                        break;
                    default:
                        Console.Write($"[{ballInBin - 3}][{ballInBin - 2}][{ballInBin}][{ballInBin + 1}],[{ballInBin}][{ballInBin + 1}][{ballInBin + 3}][{ballInBin + 4}]");
                        break;
                }

                //if (ballInBin == 1)
                //    Console.Write($"[{ballInBin}][{ballInBin + 1}][{ballInBin + 3}][{ballInBin + 4}]");
                //if (ballInBin == 34)
                //    Console.Write($"[{ballInBin - 3}][{ballInBin - 2}][{ballInBin}][{ballInBin + 1}]");
                //if (ballInBin > 3 & ballInBin < 34)
                //    Console.Write($"[{ballInBin - 3}][{ballInBin - 2}][{ballInBin}][{ballInBin + 1}],[{ballInBin}][{ballInBin + 1}][{ballInBin + 3}][{ballInBin + 4}]");
            }
            if (ballInBin % 3 == 2)
            {
                if (ballInBin == 2)
                    Console.Write($"[{ballInBin - 1}][{ballInBin}][{ballInBin + 2}][{ballInBin + 3}],[{ballInBin}][{ballInBin + 1}][{ballInBin + 3}][{ballInBin + 4}]");
                if (ballInBin == 35)
                    Console.Write($"[{ballInBin - 4}][{ballInBin - 3}][{ballInBin - 1}][{ballInBin}],[{ballInBin - 3}][{ballInBin - 2}][{ballInBin}][{ballInBin + 1}]");
                if (ballInBin > 3 & ballInBin < 34)
                    Console.Write($"[{ballInBin - 4}][{ballInBin - 3}][{ballInBin - 1}][{ballInBin}],[{ballInBin - 3}][{ballInBin - 2}][{ballInBin}][{ballInBin + 1}],[{ballInBin - 1}][{ballInBin}][{ballInBin + 2}][{ballInBin + 3}],[{ballInBin}][{ballInBin + 1}][{ballInBin + 3}][{ballInBin + 4}]");
            }
            if (ballInBin % 3 == 0)
            {
                if (ballInBin == 3)
                    Console.Write($"[{ballInBin - 1}][{ballInBin}][{ballInBin + 2}][{ballInBin + 3}]");
                if (ballInBin == 36)
                    Console.Write($"[{ballInBin - 4}][{ballInBin - 3}][{ballInBin - 1}][{ballInBin}]");
                if (ballInBin > 3 & ballInBin < 34)
                    Console.Write($"[{ballInBin - 4}][{ballInBin - 3}][{ballInBin - 1}][{ballInBin}],[{ballInBin - 1}][{ballInBin}][{ballInBin + 2}][{ballInBin + 3}]");
            }
            Console.WriteLine();
        }
        public static void printWinningBets(int[][] binNumber, int[] binColor, int ballInBin)
        {
            Console.WriteLine($"The ball lands in bin {RouletteStructure.printNumber(binNumber, ballInBin - 1)}");

            if (ballInBin < 37)
            {
                Console.WriteLine($"Number: {ballInBin}");
                printEvenOrOdds(ballInBin);
                printRedsOrBlacks(binColor, ballInBin);
                printLowHigh(ballInBin);
                printDozen(ballInBin);
                printColumns(ballInBin);
                printStreet(binNumber, ballInBin);
                printDoubleStreet(binNumber, ballInBin);
                printSplit(ballInBin);
                printCorner(ballInBin);
            }
            else
            {
                Console.WriteLine($"Number: {RouletteStructure.printNumber(binNumber, ballInBin - 1)}");
            }
        }
    }
}
