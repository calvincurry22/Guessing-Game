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

            Console.WriteLine("Select a difficulty: Easy, Medium, Hard, or Cheater");
            string userDifficulty = Console.ReadLine();
            if (userDifficulty.Contains("Easy") || userDifficulty.Contains("easy"))
            {
                int guessesRemaining = 8;

                while (guessesGiven < 8)
                {
                    Console.WriteLine($"Guess a number. Remaining guesses: {guessesRemaining}");

                    string userGuess = Console.ReadLine();
                    int userGuessInt = Int32.Parse(userGuess);

                    if (secretNum == userGuessInt)
                    {
                        Console.WriteLine("Correct! You guessed it!");
                        break;
                    }
                    else if (secretNum < userGuessInt)
                    {
                        Console.WriteLine("Too high! Try Again!");
                    }
                    else if (secretNum > userGuessInt)
                    {
                        Console.WriteLine("Too low! Try Again!");
                    }
                    guessesRemaining--;
                    guessesGiven++;
                }
            }
            else if (userDifficulty.Contains("Medium") || userDifficulty.Contains("medium"))
            {
                int guessesRemaining = 6;

                while (guessesGiven < 6)
                {
                    Console.WriteLine($"Guess a number. Remaining guesses: {guessesRemaining}");

                    string userGuess = Console.ReadLine();
                    int userGuessInt = Int32.Parse(userGuess);

                    if (secretNum == userGuessInt)
                    {
                        Console.WriteLine("Correct! You guessed it!");
                        break;
                    }
                    else if (secretNum < userGuessInt)
                    {
                        Console.WriteLine("Too high! Try Again!");
                    }
                    else if (secretNum > userGuessInt)
                    {
                        Console.WriteLine("Too low! Try Again!");
                    }
                    guessesRemaining--;
                    guessesGiven++;
                }
            }
            else if (userDifficulty.Contains("Hard") || userDifficulty.Contains("hard"))
            {
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
                    else if (secretNum < userGuessInt)
                    {
                        Console.WriteLine("Too high! Try Again!");
                    }
                    else if (secretNum > userGuessInt)
                    {
                        Console.WriteLine("Too low! Try Again!");
                    }
                    guessesRemaining--;
                    guessesGiven++;
                }
            }
            else if (userDifficulty.Contains("Cheater") || userDifficulty.Contains("cheater"))
            {
                while (true)
                {
                    Console.WriteLine($"Guess a number");

                    string userGuess = Console.ReadLine();
                    int userGuessInt = Int32.Parse(userGuess);

                    if (secretNum == userGuessInt)
                    {
                        Console.WriteLine("Correct! You guessed it!");
                        return;
                    }
                    else if (secretNum < userGuessInt)
                    {
                        Console.WriteLine("Too high! Try Again!");
                    }
                    else if (secretNum > userGuessInt)
                    {
                        Console.WriteLine("Too low! Try Again!");
                    }
                }
            }

        }
    }
}