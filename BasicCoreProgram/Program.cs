namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of times to flip the coin: ");
            string input = Console.ReadLine();

            // Validate input
            int FlipCoin;
            if (!int.TryParse(input, out FlipCoin) || FlipCoin <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Flip the coin and count heads/tails
            int numHeads = 0;
            Random random = new Random();
            for (int i = 0; i < FlipCoin; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    numHeads++;
                }
            }

            // Print results
            double percentHeads = (double)numHeads / FlipCoin * 100;
            double percentTails = 100 - percentHeads;
            Console.WriteLine("Heads: {0:f2}%", percentHeads);
            Console.WriteLine("Tails: {0:f2}%", percentTails);
        }
    }
}
    
