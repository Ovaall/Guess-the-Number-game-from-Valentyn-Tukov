using System;

    namespace GuessTheNumberGameFromValentynTukov
{
        class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guessNumber = random.Next(1, 101);

            Console.WriteLine("Hi, this is the Guess the Number game!");
            Console.WriteLine("A number from 1 to 100 inclusive was guessed. You have 10 attempts. Try to guess the number!");

            int attempts = 0;
            int allAttempts = 10;

            while (attempts < allAttempts)
            {
               

                attempts = attempts + 1;

                Console.WriteLine("It is your " + attempts + " attemtsw. Type the number and press the ENTER");


                int number = int.Parse(Console.ReadLine());

                if (number == guessNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {guessNumber} in {attempts} attempts.");
                    break;
                }
                else if (number < guessNumber)
                {
                    Console.WriteLine("Your guess is too low. You may try again!");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. You may try again!");
                }
            }

            if (attempts == allAttempts)
            {
                Console.WriteLine($"Sorry, you have all " + allAttempts + "The guess number was " + guessNumber);
            }
            Console.ReadLine();
        }
    }
   

  
}
