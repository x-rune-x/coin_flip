using System;

namespace CoinFlip
{
    class Coin
    {
        public int headsCount = 0;
        public int tailsCount = 0;

        public string Flip()
        {
            Random rnd = new Random();
            int side = rnd.Next(0, 2);
            string result = null;
            if (side == 0)
            {
                result = "Heads";
                headsCount += 1;
            }
            else if (side == 1)
            {
                result =  "Tails";
                tailsCount += 1;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coin coin = new Coin();
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Press any key to flip a coin or type exit to quit.");
                string userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine(coin.Flip());
                    Console.WriteLine("Number of heads is {0}, number of tails is {1}.", coin.headsCount, coin.tailsCount);
                }
            }
        }
    }
}
