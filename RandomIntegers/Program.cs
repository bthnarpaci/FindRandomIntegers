using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int attempts = 10;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Try to guess the number between 1 and 100 in 10 attempts.");

        for (int i = 1; i <= attempts; i++)
        {
            Console.Write($"\nAttempt {i}. Enter your guess: ");
            if (!int.TryParse(Console.ReadLine(), out int guess) || guess < 1 || guess > 100)
            {
                Console.WriteLine("Please enter a valid number between 1 and 100.");
                i--; // Not counting this invalid attempt
                continue;
            }

            if (guess == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number!");
                return;
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("The number is higher.");
            }
            else
            {
                Console.WriteLine("The number is lower.");
            }
        }

        Console.WriteLine($"\nSorry, you didn't guess the number. The correct number was {randomNumber}.");
    }
}
