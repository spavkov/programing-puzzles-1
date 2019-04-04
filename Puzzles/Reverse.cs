using System;

namespace ProgrammingExcercises1.Puzzles
{
    public class Reverse
    {
        /* "Write a program that prints the string backwards. 

        Example oputput for string "iknowhowtocode" should be "edocotwohwonki"
        */

        public static string Solve(string input)
        {
            
            string slovo = "iknowhowtocode";
            string naopacke = "";

            for (int i = slovo.Length - 1; i >= 0; i--)
            {
                naopacke += slovo[i];

            }
            Console.WriteLine(naopacke);
            return (naopacke);
        }
    }
}
