using System;

//Namespace
namespace guessnumber
{
    // Main class
    class Program
    {
        // Entry program method
        static void Main(string[] args)
        {

            // Set app vars
            string appName = "Guess Number";

            string appVersion = "1.0.0";
            string appAuthor = "Salman Yahya";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            //Writeout app info
            Console.WriteLine("{0}:\n Version {1}\n by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get Users input
            string inputName = Console.ReadLine();

            Console.WriteLine("Assalam alaikum, {0}, lets play a game....", inputName);

            while (true)
            {

                // Set correct number
                //int correctNumber = 17;

                //Create a Random Number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init Guess Var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 to 19");

                // While guess is not correct
                while (guess != correctNumber)
                {

                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its wrong number
                        Console.WriteLine("Please enter a actual number");

                        //Reset text color
                        Console.ResetColor();
                        //Keep going
                        continue;
                    }

                    // Cast to int and put in Guess
                    guess = Int32.Parse(input);

                    // Match guess to correct Number
                    if (guess != correctNumber)
                    {

                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;


                        //Tell user its wrong number
                        Console.WriteLine("Wrong Number, Please try again");

                        //Reset text color
                        Console.ResetColor();

                    }

                }





                // Output Sucess message

                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;


                //Tell user you are correct
                Console.WriteLine("Congratulations, your answered correct");

                //Reset text color
                Console.ResetColor();

                // Ask player to play again
                Console.WriteLine("Do you want to play again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }




    }
}
