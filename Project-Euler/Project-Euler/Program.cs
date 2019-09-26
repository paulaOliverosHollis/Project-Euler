using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        public enum MenuOptions { AllProblems, SelectProblem, Quit };

        static void Main()
        {
            PrintIntro();

            while (true)
            {
                MenuOptions userSelection = GetMenuSelection();

                if (userSelection == MenuOptions.AllProblems)
                {
                    DynamicProblemSelector.PrintAllProblems();
                }
                else if (userSelection == MenuOptions.SelectProblem)
                {
                    DynamicProblemSelector.PrintProblem(GetProblemNumber(), typeof(Problems));
                }
                else // User Chose to Quit
                {
                    return;
                }
            }
        }

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

                string userSelection = Console.ReadLine()?.ToUpper();

                if (!string.IsNullOrWhiteSpace(userSelection) && userSelection.Length == 1)
                {
                    char menuSelection = userSelection[0];

                    if (menuSelection == 'A')
                    {
                        return MenuOptions.AllProblems;
                    }
                    else if (menuSelection == 'S')
                    {
                        return MenuOptions.SelectProblem;
                    }
                    else if (menuSelection == 'Q')
                    {
                        return MenuOptions.Quit;
                    }
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
