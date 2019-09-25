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
            PrintMenuOptions();//Eventually this method will not be called in main directly. This is for testing purposes.
        }

        public static void PrintIntro()
        {
            Console.WriteLine("\nWelcome To My Project Euler Repository!");
            //Add a couple more lines, maybe?
        }

        public static void PrintMenuOptions() //This method will be private once I write the method that will call it. blah blah
        {
            Console.WriteLine("\n\n\tSelect One Of The Following Options:\n" +
                              "\n\tA - See All Problems and Solutions" +
                              "\n\tB - See One Specific Problem and Solution" +
                              "\n\tQ - Quit");

            Console.ReadLine();
        }

        private static bool IsMenuSelectionValid()
        {
            return false; // todito.
        }
    }
}
