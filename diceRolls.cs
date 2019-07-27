using System;

namespace Roll
{
    public class Dice // Dice Object
    {
        private Random random; // Randomness aka Random Class :)
        public Dice()
        {
            random = new Random();
        }
        public int Rolls() // Dice Rolls
        {
            int firstDiceRoll = random.Next(1, 20);
            int secondDiceRoll = random.Next(1, 20);
            int total = firstDiceRoll + secondDiceRoll;
            return total;
        }
        public double RollSequence(int times) // Average score of Dice Rolls
        {
            int totalofRolls = 0;
            for (int i = 1; i <= times; i++)
            {
                totalofRolls += Rolls();
            }
            double avg = (double)totalofRolls / times;
            return avg;
        }
    }
    public class Program // Execute of Dice Roll Averages 
    {
        static void Main() // Total Average of Dice Rolls
        {
            Dice d = new Dice();
            for (int i = 1; i <= 10; i++)
            {
                double avg = d.RollSequence(10); // Ten rolls per sequence
                Console.WriteLine("Roll sequence {0} average: {1}", i, avg);
                Console.ReadLine();
            }
        }
    }
}