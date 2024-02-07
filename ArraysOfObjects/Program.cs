using System.Collections.Generic;

namespace ArraysOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Die> bagOfDice = new List<Die>();
            Console.Write("How many dice?: ");
            int numDice = int.Parse(Console.ReadLine());    

            for(int i = 0; i < numDice; i++)
            {
                //Die tempDie = new Die(6);
                //bagOfDice.Add(tempDie);

                bagOfDice.Add(new Die(4));
            }

            for(int i = 0; i < bagOfDice.Count; i++)
            {
                bagOfDice[i].Roll();
            }

            for(int i = 0; i < bagOfDice.Count; i++)
            {
                if (bagOfDice[i].GetSideUp() == 1)
                {
                    //Console.WriteLine("Removing: " + i);
                    //bagOfDice.Remove(bagOfDice[i]);
                    bagOfDice[i] = null;
                }
            }

            int sumOfDice = 0;
            for (int i = 0; i < bagOfDice.Count; i++)
            {
                if (bagOfDice[i] != null)
                {
                    int sideUp = bagOfDice[i].GetSideUp();
                    sumOfDice += sideUp;
                    Console.WriteLine((i + 1) + " is showing " + sideUp);
                }
            }
            Console.WriteLine("Sum of dice is: " + sumOfDice);

            if(bagOfDice.Count == 0)
            {
                Console.WriteLine("Game Over");
            }

        }
    }
}
