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
                int userSelection = GetMenuSelection();

                if (userSelection == 0)
                {
                    DynamicProblemSelector.PrintAllProblems();
                }
                else if (userSelection == 1)
                {
                    DynamicProblemSelector.PrintProblem(GetProblemNumber(), typeof(Problems));
                }
                else
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

        public static int GetMenuSelection()
        {
            PrintMenuOptions();

            while (true)
            {
                string userSelection = Console.ReadLine().ToUpper();

                if (!string.IsNullOrEmpty(userSelection) && userSelection.Length == 1)
                {
                    char menuSelection = userSelection[0];

                    if (menuSelection == 'A')
                    {
                        return 0;
                    }
                    else if (menuSelection == 'S')
                    {
                        return 1;
                    }
                    else if (menuSelection == 'Q')
                    {
                        return 2;
                    }
                }
                else
                {
                    Console.WriteLine("The option you entered is not valid. Please try again!");
                    PrintMenuOptions();
                }
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
