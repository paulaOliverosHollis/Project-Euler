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
                method.Invoke(null, null);
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
