using System;

namespace Roll_Dice_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int irnd = new int();
            irnd = r.Next(0, 7); //counting randomly from 0 t 6.


            int[] Dice1 = new int[6];
            int[] Dice2 = new int[6];
            Random rnd = new Random();


            Console.WriteLine("This program will allow you to roll 2 dice");
            Console.WriteLine("\nAs many times as you want");
            Console.WriteLine("\n\nWhen you want to exit the program, please type (exit)");
            Console.WriteLine("\nPress any key to begin rolling");
            Console.Read();
            Console.ReadKey();

            for (int i = 0; i < 1; i++)
            {
                int diceRoll = 0;
                diceRoll = rnd.Next(6);
                Dice1[diceRoll]++;
                Console.WriteLine("Dice 1 is rolled a: {0}", diceRoll + 1);
                diceRoll = rnd.Next(6);
                Dice2[diceRoll]++;
                Console.WriteLine("Dice 2 is rolled a: {0}", diceRoll + 1);

                {
                    Console.WriteLine("Allow the user to roll dice");
                }
            }
        }
    }
}
