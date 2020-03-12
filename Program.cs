using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exit option
            Console.WriteLine("Enter xx to exit the app or any key to continue.");
            string line;
            while ((line = Console.ReadLine()) != "xx")
            {
                Console.WriteLine("How many times should we flip the coin?");
                string numberOfFlips = Console.ReadLine();

                int numberHeads = 0;
                int numberTails = 0;

                /* If user inputs a number in the range of UInt32's min and max values,  
                 * this program flips a coin that number of times and prints the result to the console.
                 * It also keeps a tally of results and displays them at the end.
                 */
                
                if (UInt32.TryParse(numberOfFlips, out UInt32 flipsNumber) && flipsNumber >= 1)
                {
                    {
                        Console.WriteLine($"Flipping the coin {flipsNumber} times.");
                        for (int i = 0; i < flipsNumber; i++)
                        {
                            Random coin = new Random();
                            double coinFlip = coin.NextDouble();

                            if (coinFlip < 0.5)
                            {
                                Console.WriteLine("Heads!");
                                numberHeads++;
                            }
                            else
                            {
                                Console.WriteLine("Tails!");
                                numberTails++;
                            }
                        }

                        Console.WriteLine("Finished!");
                        decimal headsPercent = (decimal)numberHeads / flipsNumber;
                        decimal tailsPercent = (decimal)numberTails / flipsNumber;
                        Console.WriteLine($"Number of coin flips: {flipsNumber}\nTotal number of heads: {numberHeads} ({headsPercent:P2})\nTotal number of tails: {numberTails} ({tailsPercent:P2})");
                        Console.WriteLine("Enter xx to exit or any key to continue.");
                    }
                }
                else
                {
                    Console.WriteLine("No number entered OR number out of bounds! Must be a whole number, using numeric characters (0-9) only.\nEnter xx to exit or any key to continue.");
                }
            }
        }
    }
}
