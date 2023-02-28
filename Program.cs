using System;

namespace SoftUni
{
    class RockPaperScissors
    {
        static int[] moveTable =
        {
            0, 1, -1,
            -1, 0, 1,
            1, -1, 0
        };

        static string[] moveNames =
        {
            "Rock",
            "Paper",
            "Scissors"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors:");

            string userInput = Console.ReadLine();

            int moveIndex = -1;

            if (userInput == "r" || userInput == "rock") moveIndex = 0;
            if (userInput == "p" || userInput == "paper") moveIndex = 1;
            if (userInput == "s" || userInput == "scissors") moveIndex = 2;

            Random random = new Random();

            int computerMoveIndex = random.Next(0, 3);

            Console.WriteLine(moveNames[computerMoveIndex]);

            int result = moveTable[moveIndex * 3 + computerMoveIndex];

            switch(result)
            {
                case -1:
                    Console.WriteLine("Computer lost!");
                    break;

                case 0:
                    Console.WriteLine("Draw");
                    break;

                case 1:
                    Console.WriteLine("Computer won!");
                    break;
            }
        }
    }
}