using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int guessesGiven = 0;
            int secretNum = rand.Next(1, 101);
            int guessesRemaining = 4;
            while (guessesGiven < 4)
            {
                Console.WriteLine($"Guess a number. Remaining guesses: {guessesRemaining}");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (secretNum == userGuessInt)
                {
                    Console.WriteLine("Correct! You guessed it!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again!");
                }
                guessesRemaining--;
                guessesGiven++;
            }
        }
    }
}