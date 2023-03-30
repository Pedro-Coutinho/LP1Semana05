using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();

            int n;
            Int32.TryParse(input, out n);

            Random dice = new Random();

            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += dice.Next(1, 7);
            }

            Console.WriteLine(sum);
        }
    }
}
