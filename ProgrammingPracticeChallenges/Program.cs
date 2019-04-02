using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPracticeChallenges
{
    class Program
    {
        static int menuChoice = 0;

        public static int displayMenu() 
        //Method to display the main menu and allow the user to select a solution or quit
        {
            Console.Clear();

            Console.WriteLine("Programming Challenges");
            Console.WriteLine("Select a Solution");
            Console.WriteLine("");
            Console.WriteLine("1. Fizzbuzz");
            Console.WriteLine("2. Unwinnable Single Pile Nim");
            Console.WriteLine("3. Winnable Single Pile Nim");
            Console.WriteLine("");
            Console.WriteLine("0. Exit");
            //Displays the menu on the console

            try     
            //Trys for an exception, incase the user enters something unable to be converted to integer
            {
                menuChoice = Convert.ToInt32(Console.ReadLine());   
                //User input for the choice variable for selecting an option
            }

            catch (Exception e)
            //If there's an exception with the user's input, displays an error message.
            {
                Console.Clear();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);   
                Console.WriteLine("Enter a valid selection, press enter to continue"); 
                Console.ReadLine();             
            }

            return menuChoice;
            //Ends the method and returns the user's input, allowing the application to select the appropriate choice.
        }

        public static void fizzBuzz() 
        //Method to run FizzBuzz, a common programming challenge
        {
            Console.Clear();

            Console.WriteLine("This is a solution to the common test problem, Fizzbuzz");
            Console.WriteLine("The numbers 1 to 100 must be printed");
            Console.WriteLine("Multiples of 3 are replaced by 'Fizz'");
            Console.WriteLine("Multiples of 5 are replaced by 'Buzz'");
            Console.WriteLine("Multiples of 3 and 5 are replaced by 'FizzBuzz'");
            Console.WriteLine("Press Enter to Start the Program");
            //Description of FizzBuzz

            Console.ReadLine();

            for(int counter = 1; counter <= 100; counter++)
            //Loop that runs 100 times, starting at one and ending at 100.
            //Counter is the number that is going to be checked.
            {
                if(counter % 3 == 0 || counter % 5 == 0)
                //Checks if the number is an appropriate multiple for Fizz or Buzz
                {
                    if(counter % 3 == 0)
                    //Writes Fizz if the number is a multiple of 3
                    {
                        Console.Write("Fizz");
                    }

                    if (counter % 5 == 0)
                    //Writes Buzz is the number is a multiple of 5
                    {
                        Console.Write("Buzz");
                    }
                    Console.WriteLine();
                    //Ends the line each loop writes on a single line
                    //Fizz and Buzz not ending the line allows them to combine where appropriate
                }

                else
                //Writes the number if it isn't a multiple of 3 or 5
                {
                    Console.WriteLine(counter);
                }                
            }

            Console.WriteLine("Finished, press enter to return to the menu.");
            Console.ReadLine();


        }

        public static void singleNim()
        //Method to play a simple game of Single Pile Nim
        //This variant of Nim is unwinnable if you go first and the opponent plays perfectly, which the computer will
        {
            Console.Clear();

            Console.WriteLine("In single pile nim, there is a pile of 12 marbles");
            Console.WriteLine("Each player can take between 1 and 3 marbles");
            Console.WriteLine("The player to take the last marble wins");
            Console.WriteLine("As the 'superior' Human, you may go first");
            Console.WriteLine("Press Enter to begin");
            Console.ReadLine();

            Console.Clear();

            int marbles = 12;
            int playerChoice;
            int compChoice;
            bool playerWin = false;
            //Variables for the number of marbles, the choice of both the player and the computer
            //As well as a flag for if the player wins, which should be impossible in this variant.

            while (true)
            //Infinite loop for the game to run in
            //Broken by the Player or Computer winning
            {
                while(true)
                //Infinite loop for Player input
                //Broken by valid input
                {
                    for ( int marblePic = marbles; marblePic > 0; marblePic--)
                    //For loop to display simple graphics with Characters representing the remaining marbles.
                    {
                        Console.Write("O ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("There are " + marbles + " marbles left");
                    //Displays the number of marbles in text so the player doesn't have to count.
                    Console.WriteLine("How Many Marbles are you going to take?");

                    try
                    //Trys for an exception, incase the user enters something unable to be converted to integer
                    {
                        playerChoice = Convert.ToInt32(Console.ReadLine());
                        //The players input is stored in the playerChoice variable before being checked
                    }

                    catch
                    //Checks for any exceptions
                    {
                        playerChoice = 0;
                    }
                                       
                    if (playerChoice > 0 && playerChoice < 4)
                    //Checks that the player's choice is a valid input between 1 and 3
                    {
                        marbles = marbles - playerChoice;
                        //Applies the player's choice to the marble count

                        if (marbles < 1)
                        //Checks if the player has one
                        {
                            playerWin = true;
                            //Flags the player's victory
                        }

                        break;
                        //Ends the input loop and allows the program to proceed to the computer's choice
                    }

                    Console.Clear();
                    Console.WriteLine("Invalid choice, please take between 1 and 3 marbles.");
                    //Displays error message if there was no valid input and restarts the loop.
                }

                if (playerWin == true)
                //If the player won, displays a victory message and ends the game's loop.
                {
                    Console.WriteLine("You won, somehow...");
                    Console.WriteLine("Press Enter to return to the main menu");
                    Console.ReadLine();
                    break;
                }

                //The goal of the computer adjust the marble count so that it is a multiple of 4 on the player's turn
                
                compChoice = 4 - playerChoice;
                //Subtracts 4 by the player's input, allowing the computer to know what choice to make

                marbles = marbles - compChoice;
                //Applies the computer's choice to the marble count

                Console.Clear();

                if (compChoice == 1)
                //If statement for grammatical correctness
                {
                    Console.WriteLine("The Computer took " + compChoice + " marble");
                }

                else
                {
                    Console.WriteLine("The Computer took " + compChoice + " marbles");
                }              

                if (marbles < 1)
                //Checks to see if the computer has one
                //Displays a losing message and ends the game's loop
                {
                    Console.WriteLine("You lost!");
                    Console.WriteLine("Don't worry, victory was impossible");
                    Console.WriteLine("Press Enter to return to the main menu");
                    Console.ReadLine();
                    break;
                }
            } 

        }

        public static void winnableNim()
        //Method to play a simple game of Single Pile Nim
        //This variant of Nim is winnable 100% of the time since the computer goes first
        //Though if a mistake is made, the computer will be able to win.
        {
            Console.Clear();

            Console.WriteLine("In single pile nim, there is a pile of 12 marbles");
            Console.WriteLine("Each player can take between 1 and 3 marbles");
            Console.WriteLine("The player to take the last marble wins");
            Console.WriteLine("In this version, the computer will go first, allowing you the chance to win");
            Console.WriteLine("Make a Mistake however, and it will capitalize on it.");
            Console.WriteLine("Press Enter to begin");
            Console.ReadLine();

            Console.Clear();

            int marbles = 12;
            int playerChoice;
            bool playerWin = false;
            //Variables for the number of marbles, player's choice
            //As well as a flag for if the player wins

            Random random = new Random();
            int compChoice = random.Next(1, 4);
            //Variables for the Computer's choice. 
            //The Computer's first choice is random, but it makes decisions in future choices

            marbles = marbles - compChoice;
            //Applies the computer's first, random choice

            if (compChoice == 1)
            //If statement for grammatical correctness
            {
                Console.WriteLine("The Computer took " + compChoice + " marble");
            }

            else
            {
                Console.WriteLine("The Computer took " + compChoice + " marbles");
            }

            while (true)
            //Infinite loop for the game to run in
            //Broken by the Player or Computer winning
            {
                while (true)
                //Infinite loop for Player input
                //Broken by valid input
                {
                    for (int marblePic = marbles; marblePic > 0; marblePic--)
                    //For loop to display simple graphics with Characters representing the remaining marbles.
                    {
                        Console.Write("O ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("There are " + marbles + " marbles left");
                    //Displays the number of marbles in text so the player doesn't have to count.
                    Console.WriteLine("How Many Marbles are you going to take?");

                    try
                    {
                        playerChoice = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        playerChoice = 0;
                    }



                    if (playerChoice > 0 && playerChoice < 4)
                    {
                        marbles = marbles - playerChoice;

                        if (marbles < 1)
                        {
                            playerWin = true;
                        }

                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please take between 1 and 3 marbles.");
                }

                if (playerWin == true)
                //Displays a victory message and ends the loop if the player wins.
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine("It's a lot easier going second.");
                    Console.WriteLine("Press Enter to return to the main menu");
                    Console.ReadLine();
                    break;
                }

                //The following statements 

                if (marbles % 4 == 0)
                //plays correctly, the computer will pick a random number
                {
                    compChoice = random.Next(1, 4);
                    //Picks a random number between 1 and 3

                    marbles = marbles - compChoice;
                    //Applies that choice to the marble count

                }

                else
                //If the player hasn't played perfectly, the computer makes the winning move
                {
                    compChoice = marbles % 4;
                    //Determines what number is needed to make a multiple of 4
                    //Using the remainder of the marble count divided by 4

                    marbles = marbles - compChoice;
                    //Applies that choice to the marble count
                }

                Console.Clear();

                

                if (compChoice == 1)
                {
                    Console.WriteLine("The Computer took " + compChoice + " marble");
                }

                else
                {
                    Console.WriteLine("The Computer took " + compChoice + " marbles");
                }

                if (marbles < 1)
                //Displays a defeat message and ends the loop if the computer wins
                {
                    Console.WriteLine("You lost!");
                    Console.WriteLine("The computer won't let you make a mistake");
                    Console.WriteLine("Press Enter to return to the main menu");
                    Console.ReadLine();
                    break;
                }
            }

        }
        static void Main(string[] args)
        {
            do
            {
                displayMenu();
                //Uses the displayMenu method to present the menu to the user
                //If statements to check run the appropriate choice

                if (menuChoice == 1)
                {
                    fizzBuzz();
                    //Runs the FizzBuzz method
                }

                if (menuChoice == 2)
                {
                    singleNim();
                    //Runs the Unwinnable Nim method
                }

                if (menuChoice == 3)
                {
                    winnableNim();
                    //Runs the Winnable Nim method
                }
            } while (menuChoice != 0);
            //Ends the loop and the program if user choose 0.
        }
    }
}
