using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean guessed = false;
        int numberOfGuess = 0;
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        while (!guessed)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            numberOfGuess += 1;
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                guessed = true;
                Console.WriteLine($"You took {numberOfGuess} times to guess");
                Console.WriteLine("Do you want to play again? (yes/no) ");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "yes")
                {
                    guessed = false;
                    numberOfGuess = 0;
                    magicNumber = random.Next(1, 101);
                }
            }
        }
    }
}