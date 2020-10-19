using System;
using System.Collections.Generic;
using System.Linq;

namespace ex08_william
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = new int[10];
            for (int i = 0; i < sampleArray.Length; i++)
            {
                sampleArray[i] = i+1;
            }
            Random num = new Random();
            List<int> humanTryCount = new List<int>();
            Console.WriteLine("Welcome to the number gussing game! Are you smarter than the computer? Lets find out!");
            int exceptionCounter = 0;
            int round = 0;
                do
                {
                    try
                    {
                        exceptionCounter = 0;
                        Console.WriteLine($"How many rounds do you want to play?");
                        round = int.Parse(Console.ReadLine());
                        if (round <= 0)
                            throw new OperationCanceledException("come on, play at least one round.");
                    }
                    catch (OperationCanceledException oCe)
                    {
                        ++exceptionCounter;
                        Console.WriteLine(oCe.Message);
                    }
                    catch(FormatException)
                    {
                        ++exceptionCounter;
                        Console.WriteLine("Enter a positive numeric number please.");
                    }
                } while (exceptionCounter > 0);
            Console.WriteLine($"The computer has picked a number between 1 to {sampleArray.Length}, guess what number did it pick?");
            for (int i = 0; i < round; i++)
            {
                Console.WriteLine($"\nRound {i + 1}, ready... GO!");
                int comGuessedNum = num.Next(sampleArray.Min(), sampleArray.Max() + 1);
                guessNum humanGuessNum = new guessNum();
                humanTryCount.Add(humanGuess(sampleArray, comGuessedNum, humanGuessNum));
            }
            double humanAVG = 0;
            foreach (var tryNum in humanTryCount)
            {
                humanAVG += tryNum;
            }
            Console.WriteLine("Now you should pick a number and see how many times does it take the computer to guess your number.");
            List<int> compTryCount = new List<int>();

            for (int i = 0; i < round; i++)
            {
                do
                {
                    try
                    {
                        exceptionCounter = 0;
                        Console.WriteLine($"\nRound {i + 1}, ready... GO!");
                        Console.WriteLine("what's your pick?");
                        string sHumanGuessedNum = Console.ReadLine();
                        int humanGuessedNum = int.Parse(sHumanGuessedNum);
                        if (humanGuessedNum > sampleArray.Max())
                            throw new OperationCanceledException("enter a number between 1 and 1000.");
                        guessNum comGuessNum = new guessNum();
                        compTryCount.Add(computerGuess(sampleArray, humanGuessedNum, comGuessNum));
                    }
                    catch (OperationCanceledException oCe)
                    {
                        exceptionCounter++;
                        Console.WriteLine(oCe.Message);
                    }
                } while (exceptionCounter > 0);
            }
            double compAVG = 0;
            foreach (var tryNum in compTryCount)
            {
                compAVG += tryNum;
            }
            Console.WriteLine($"It took a human being an average of {humanAVG / round:g2} tries to guess the number");
            Console.WriteLine($"It took the computer an average of {compAVG / round:g2} tries to guess the number");
            if ((humanAVG / round) <(compAVG / round))
                Console.WriteLine("Good job! You are smarter than the computer!");
            if ((humanAVG / round) > (compAVG / round))
                Console.WriteLine("The computer is smarter than you.");
            else
                Console.WriteLine("You are as smart as a computer.");
        }
        private static int humanGuess(int[] sampleArray, int comGuessedNum, guessNum humanGuessNum)
        {
            int exceptionCounter;
            do
            {
                exceptionCounter = 0;
                try
                {
                    Console.WriteLine($"Pick a number between {sampleArray.Min()} to {sampleArray.Max()}");
                    string stringPickNum = Console.ReadLine();
                    int pickNum = int.Parse(stringPickNum);
                    if (pickNum > sampleArray.Max())
                        throw new OperationCanceledException($"The number you pick is higher than {sampleArray.Max()}");
                    if (pickNum < sampleArray.Min())
                        throw new OperationCanceledException($"The number you pick is lower than {sampleArray.Min()}");
                    else
                    {
                        if (pickNum > comGuessedNum)
                        {
                            int startIndx = sampleArray.Min();
                            int endIndx = pickNum - 1;
                            sampleArray = new int[endIndx - startIndx + 1];
                            for (int i = 0; i < sampleArray.Length; i++)
                            {
                                sampleArray[i] = startIndx;
                                startIndx++;
                            }
                            Console.WriteLine($"\nRound {humanGuessNum.tryNumbers += 1} was incorrect. Your pick is higher than the correct number, try again.");
                            humanGuess(sampleArray, comGuessedNum, humanGuessNum);
                        }
                        if (pickNum < comGuessedNum)
                        {
                            int startIndx = pickNum;
                            int endIndx = sampleArray.Max();
                            sampleArray = new int[endIndx - pickNum];
                            for (int i = 0; i < sampleArray.Length; i++)
                            {
                                sampleArray[i] = startIndx + 1;
                                startIndx++;
                            }
                            Console.WriteLine($"\nRound {humanGuessNum.tryNumbers += 1} was incorrect. Your pick is lower than the correct number, try again.");
                            humanGuess(sampleArray, comGuessedNum, humanGuessNum);
                        }
                        if (pickNum == comGuessedNum)
                        {
                            Console.WriteLine($"\nWhat a guess! It took you {humanGuessNum.tryNumbers += 1} tries to guess the right number, which is {comGuessedNum}\n");
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered a non-numeric character.");
                    exceptionCounter++;
                }
                catch (OperationCanceledException aOr)
                {
                    Console.WriteLine(aOr.Message);
                    exceptionCounter++;
                }
            } while (exceptionCounter > 0);
            return humanGuessNum.tryNumbers;
        }
        private static int computerGuess(int[] sampleArray, int humanGuessedNum, guessNum comGuessNum)
        {
            int exceptionCounter;
            do
            {
                exceptionCounter = 0;
                try
                {
                    Console.WriteLine($"range is between {sampleArray.Min()} and {sampleArray.Max()}");
                    int pickNum = sampleArray.Min() + ((sampleArray.Max() - sampleArray.Min())/2);
                    Console.WriteLine($"Computer has picked {pickNum}.");
                    if (pickNum > humanGuessedNum)
                    {
                        int startIndx = sampleArray.Min();
                        int endIndx = pickNum - 1;
                        sampleArray = new int[endIndx - startIndx + 1];
                        for (int i = 0; i < sampleArray.Length; i++)
                        {
                            sampleArray[i] = startIndx;
                            startIndx++;
                        }
                        Console.WriteLine($"\nRound {comGuessNum.tryNumbers += 1} was incorrect. Computer picked {pickNum}, which is higher than the {humanGuessedNum}.\n");
                        computerGuess(sampleArray, humanGuessedNum, comGuessNum);
                    }
                    if (pickNum < humanGuessedNum)
                    {
                        int startIndx = pickNum;
                        int endIndx = sampleArray.Max();
                        sampleArray = new int[endIndx - pickNum];
                        for (int i = 0; i < sampleArray.Length; i++)
                        {
                            sampleArray[i] = startIndx + 1;
                            startIndx++;
                        }
                        Console.WriteLine($"\nRound {comGuessNum.tryNumbers += 1} was incorrect. Computer picked {pickNum}, which is lower than the {humanGuessedNum}.\n");
                        computerGuess(sampleArray, humanGuessedNum, comGuessNum);
                    }
                    if (pickNum == humanGuessedNum)
                        Console.WriteLine($"\nCorrect guess, it took the computer {comGuessNum.tryNumbers += 1} tries. The number is: {humanGuessedNum}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered a non-numeric character.");
                    exceptionCounter++;
                }
            } while (exceptionCounter > 0);
            return comGuessNum.tryNumbers;
        }
    }
}
