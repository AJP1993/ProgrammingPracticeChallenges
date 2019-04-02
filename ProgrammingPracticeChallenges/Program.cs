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

        static void Main(string[] args)
        {
            do
            {
                displayMenu();

                if (menuChoice == 1)
                {
                    fizzBuzz();
                }

            } while (menuChoice != 0);
        }
    }
}
