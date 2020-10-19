using System;


namespace ex07_william
{
    class RouletteStructure
    {
        public static void printTable(int[][] binNumber, int[] binColor)
        {
            for (int i = 0; i < 38; i++)
            {
                int input = i;
                string number = printNumber(binNumber, input);
                string numberColor = printColor(binColor[input]);
                Console.Write($"{numberColor}[{number}]");
                if ((i + 1) % 3 == 0 | i == 35)
                {
                    if (i != 0)
                        Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public static int getNumber(int[][] binNumber, int input)
        {
            return binNumber[(input - 1) / 3][(input - 1) % 3];
        }
        public static string printNumber(int[][] binNumber, int input)
        {
            if (input == 36)
                return "0";
            if (input == 37)
                return "00";
            else
                return (binNumber[input / 3][input % 3]).ToString();
        }
        public static string printColor(int input)
        {
            if (input == 0)
                return "Black";
            if (input == 1)
                return "Red";
            else
                return "Green";
        }
        public static int[][] wheelNumberInitialized()
        {
            int[][] bins;
            bins = new int[13][];
            bins[12] = new int[2];
            bins[12][0] = 37;
            bins[12][1] = 38;
            //Console.WriteLine($"[0][00]");
            int binCounter = 1;
            for (int rowNum = 0; rowNum < 12; rowNum++)
            {
                bins[rowNum] = new int[3];
                for (int colNum = 0; colNum < 3; colNum++)
                {
                    bins[rowNum][colNum] = binCounter;
                    //Console.Write($"[{binCounter}]");
                    binCounter++;
                }
                //Console.WriteLine();
            }
            return bins;
        }
        public static int[] wheelColorInitialized()
        {
            int[] bins;
            bins = new int[38];
            bins[36] = 2;
            bins[37] = 2;
            Random binCNumber = new Random();
            for (int i = 0; i < 18; i++)
            {
                int x = binCNumber.Next(0, 36);
                while (bins[x] == 1)
                {
                    x = binCNumber.Next(0, 36);
                }
                bins[x] = 1;
            }
            return bins;
        }
    }
}
