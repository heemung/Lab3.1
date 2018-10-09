using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, userName;
            int userNumber = 0;

            Console.WriteLine("Whats Your Name?");
            userName = Console.ReadLine();
            //yes no loop
            do
            {
                do
                {
                    userNumber = 0;
                    Console.WriteLine("Enter a number 1 and 100: ");
                    userInput = Console.ReadLine();

                    //test user input
                    if (userInput.Length <= 3)
                    {
                        userNumber = int.Parse(userInput);
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                    }

                } while (userNumber <= 0 || userNumber > 100);

                //run logic
                InclusiveChecks(userNumber, userName);
                Console.WriteLine("Do you want to run the program again. y/n ?");

            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Goodbye. Press Any Key To Exit");
            Console.ReadLine();
        }

        //logic for even or odd number
        static string EvenTrue(int tempUserNumber)
        {
            tempUserNumber = tempUserNumber % 2;

            if (tempUserNumber == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        //logic and print for case
        static void InclusiveChecks(int tempCheckNumber, string name)
        {
            if (EvenTrue(tempCheckNumber) == "odd")
            {
                if (tempCheckNumber > 60)
                {
                    Console.WriteLine("Hi {0}, {1} is {2} and greater than 60.", name,
                        tempCheckNumber, EvenTrue(tempCheckNumber));
                }
                else
                {
                    Console.WriteLine("Hi {0}, {1} is {2}.", name,
                        tempCheckNumber, EvenTrue(tempCheckNumber));
                }
            }

            else if((tempCheckNumber >= 2 && tempCheckNumber <= 25) &&
                (EvenTrue(tempCheckNumber) == "even"))
            {
                Console.WriteLine("Hi {0}, {1} is {2} and less than 25.", name,
                    tempCheckNumber, EvenTrue(tempCheckNumber));
            }

            else if ((tempCheckNumber >= 26 && tempCheckNumber <= 60) &&
                (EvenTrue(tempCheckNumber) == "even"))
            {
                Console.WriteLine("Hi {0}, {1} is {2} and 26-60.", name,
                    tempCheckNumber, EvenTrue(tempCheckNumber));
            }

            else
                Console.WriteLine("Hi {0}, {1} is {2} and greater 60.", name,
                    tempCheckNumber, EvenTrue(tempCheckNumber));
        }
    }
}
