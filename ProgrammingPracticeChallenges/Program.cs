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

        public static int displayMenu() //Method to display the main menu and allow the user to select a solution or quit
        {
            Console.Clear();
            Console.WriteLine("Programming Challenges");
            Console.WriteLine("Select a Solution");
            Console.WriteLine("");
            Console.WriteLine("1. Fizzbuzz");
            Console.WriteLine("2. Unwinnable Single Pile Nim");
            Console.WriteLine("");
            Console.WriteLine("0. Exit");

            try     //Try for exception, incase the user enters something unable to be converted to integer
            {
                menuChoice = Convert.ToInt32(Console.ReadLine());   //User input for the choice variable for selecting an option
            }

            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);   
                Console.WriteLine("Enter a valid selection, press enter to continue");
                Console.ReadLine();             
            }

            return menuChoice;
        }

        public static void fizzBuzz()
        {
            Console.Clear();

            Console.WriteLine("This is a solution to the common test problem, Fizzbuzz");
            Console.WriteLine("The numbers 1 to 100 must be printed");
            Console.WriteLine("Multiples of 3 are replaced by 'Fizz'");
            Console.WriteLine("Multiples of 5 are replaced by 'Buzz'");
            Console.WriteLine("Multiples of 3 and 5 are replaced by 'FizzBuzz'");
            Console.WriteLine("Press Enter to Start the Program");

            Console.ReadLine();

            for(int counter = 1; counter <= 100; counter++)
            {
                if(counter % 3 == 0 || counter % 5 == 0)
                {
                    if(counter % 3 == 0)
                    {
                        Console.Write("Fizz");
                    }

                    if (counter % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine(counter);
                }                
            }

            Console.ReadLine();


        }

        public static void singleNim()
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
            bool playerWin = false;
            int playerChoice;
            int compChoice;

            while(true)
            {
                while(true)
                {
                    for ( int marblePic = marbles; marblePic > 0; marblePic--)
                    {
                        Console.Write("O ");
                    }

                    Console.WriteLine();

                    Console.WriteLine("There are " + marbles + " marbles left");
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
                {
                    Console.WriteLine("You won, somehow...");
                    Console.WriteLine("Press Enter to return to the main menu");
                    Console.ReadLine();
                    break;
                }

                compChoice = 4 - playerChoice;
                marbles = marbles - compChoice;

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
                {
                    Console.WriteLine("You lost!");
                    Console.WriteLine("Don't worry, victory was impossible");
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

                if (menuChoice == 1)
                {
                    fizzBuzz();
                }

                if (menuChoice == 2)
                {
                    singleNim();
                }
            } while (menuChoice != 0);
        }
    }
}
