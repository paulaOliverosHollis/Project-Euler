using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main()
        {
            PrintIntro();

            while (true)
            {
                MenuOptions userSelection = GetMenuSelection();

                if (userSelection == MenuOptions.A)
                {
                    DynamicProblemSelector.PrintAllProblems();
                }
                else if (userSelection == MenuOptions.S)
                {
                    DynamicProblemSelector.PrintProblem(GetProblemNumber(), typeof(Problems));
                }
                else // User Chose to Quit
                {
                    return;
                }
            }
        }

        public enum MenuOptions { A, S, Q };

        public static void PrintIntro()
        {
            Console.WriteLine("\nWelcome To My Project Euler Repository!");
            //Add a couple more lines, maybe?
        }

        public static MenuOptions GetMenuSelection()
        {
            while (true)
            {
                PrintMenuOptions();

                try
                {
                    string userSelection = Console.ReadLine()?.ToUpper();

                    if (!string.IsNullOrWhiteSpace(userSelection) && userSelection.Length == 1)
                    {
                        char menuSelection = userSelection[0];

                        if (menuSelection == 'A')
                        {
                            return MenuOptions.A;
                        }
                        else if (menuSelection == 'S')
                        {
                            return MenuOptions.S;
                        }
                        else if (menuSelection == 'Q')
                        {
                            return MenuOptions.Q;
                        }
                    }
                }
                catch
                {
                    // null exeption will be handled by the line below and by continuing the loop.
                }

                Console.WriteLine("The option you entered is not valid. Please try again!");
            }               
        }

        private static void PrintMenuOptions()
        {
            Console.WriteLine("\n\n\tSelect One Of The Following Options:\n" +
                              "\n\tA - See All Problems and Solutions" +
                              "\n\tS - See One Specific Problem and Solution" +
                              "\n\tQ - Quit");
        }

        private static int GetProblemNumber()
        {
            Console.Write("\nProblem Number: ");

            bool isNumberConvertible = int.TryParse(Console.ReadLine(), out int problemNumber);

            while (!isNumberConvertible)
            {
                Console.WriteLine("Please enter a valid number: ");

                isNumberConvertible = int.TryParse(Console.ReadLine(), out problemNumber);
            }

            return problemNumber;
        }
    }
}
