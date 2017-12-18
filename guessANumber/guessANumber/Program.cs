using System;

namespace guessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guessCounter = 1;
            int chosenNum = rnd.Next(1, 10);
            var running = true;

            Console.WriteLine("Guess a number between 1 and 10!");
            Console.WriteLine("You have three guesses:");
            Console.WriteLine("======");

            try
            {
                //var entry = Console.ReadLine();
                //int guess = int.Parse(entry);
                while (running)
                {

                    while (guessCounter < 4)
                    {
                        Console.WriteLine("Guess Number #" + guessCounter + ": ");
                        var entry = Console.ReadLine();
                        int guess = int.Parse(entry);
                        if (guess == chosenNum)
                        {
                            Console.WriteLine("You win!  It was " + chosenNum + "!  Good Job :)");
                            break;

                        }
                        else if (guess > chosenNum)
                        {
                            Console.WriteLine("Too high!!!");
                            guessCounter++;

                        }
                        else
                        {
                            Console.WriteLine("Your guess is too low!!!");
                            guessCounter++;
                        }


                    }
                    //Console.WriteLine("You're out of guesses. The answer was: "+chosenNum);
                    //Console.WriteLine("=====");
                    Console.WriteLine("Press 1 to play again.  Any other key to quit. ");
                    var again = Console.ReadLine();
                    if (again != "1") {
                        break;
                    } else {
                        continue;
                    }
                }




            }
            catch (FormatException)
            {

            }

        }
    }
}
