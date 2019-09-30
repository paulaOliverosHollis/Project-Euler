using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public static class DynamicProblemSelector
    {
        public static void PrintProblem(int problemNumber, Type objectType)
        {
            var method = objectType.GetMethod($"Problem{problemNumber}");

            if (method != null)
            {
                DateTime startTime = DateTime.Now;

                object obj = method.Invoke(null, null);
                 
                if(obj != null && obj is string answer)
                {
                    Console.WriteLine($"\n\t\tAnswer: {answer}");
                    Console.WriteLine($"\n\t\tIt took {DateTime.Now - startTime} to find the answer to this problem.\n\n\tPress <Enter> if you wish to continue...");
                }
                else
                {
                    Console.WriteLine("\n\t\tAn error occurred and we were unable to find the answer to this problem.\n\n\tPress <Enter> if you wish to continue...");                    
                }
               
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Sorry, Problem {problemNumber} is not available. Please try another problem!");
            }
        }

        public static void PrintAllProblems()
        {
            for (int i = 1; i < 26; i++)
            {
                PrintProblem(i, typeof(Problems));
            }
        }
    }
}
