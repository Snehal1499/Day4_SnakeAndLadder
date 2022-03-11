using System;
//UC2_RollTheDie
namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerPosition = 0;
            //it is using to genetate random numbers
            Random random = new Random();
            int die = random.Next(0, 7);

            {
                Console.WriteLine("welcome to Snake And Ladder Programe");
                Console.WriteLine("Starting Position is " + PlayerPosition);
                Console.WriteLine("Dice roll: " + die);

            }
        }
    }
}
