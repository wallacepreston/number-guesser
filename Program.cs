using System;


// Namespace
namespace NumberGuesser
{
    // Main Class
    class MainClass
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();


            while (true)
            {

                //int correctNumber = 7;
                
                // Creat a new Random object
                Random random = new Random();
                
                // Set correct number
                int correctNumber = random.Next(1, 10);
                
                // Init guess var
                int guess = 0;
                
                Console.WriteLine("Guess a number between 1 and 10");
                
                // While guess is not correct
                while(guess != correctNumber)
                {
                    // Get Users Input
                    string input = Console.ReadLine();
                    
                    // Make sure it's a number
                    if(!int.TryParse(input, out guess))
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        
                        //Write out app info
                        Console.WriteLine("Please enter an actual number");
                        
                        // Reset Text Color 
                        Console.ResetColor();
                        
                        continue;
                    }
                    
                    // Cast to int and put in guess
                    guess = Int32.Parse(input);
                    
                    if(guess != correctNumber)
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        
                        //Write out app info
                        Console.WriteLine("Wrong number, please try again");
                        
                        // Reset Text Color 
                        Console.ResetColor();
                    }
                }
                
                // Output success message
                
                // Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                //Write out app info
                Console.WriteLine("You are CORRECT!");
                
                // Reset Text Color 
                Console.ResetColor();
                
                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");
                
                // Get answer
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

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Preston Wallace";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Color 
            Console.ResetColor();
        }

        // Get user name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");

        }
    }
}
