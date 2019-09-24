using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class DynamicProblemPrinter
    {
        public static void PrintProblem(int problemNumber, Type objectType)
        {
            var method = objectType.GetMethod($"Problem{problemNumber}");

            method.Invoke(null, null);
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
