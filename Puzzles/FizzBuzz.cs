﻿using System;

namespace ProgrammingExcercises1.Puzzles
{
    public class FizzBuzz
    {
        /* "Write a program that prints the numbers from 1 to 100. 
        But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
        For numbers which are multiples of both three and five print “FizzBuzz”."

        Example oputput for numbers from 1 to 5 would be: 
        "1 2 Fizz 4 Buzz"

        Program needs to print output for numbers 1 to 100
        */

        public static string Solve()
        {

            string resultat = "";

            int i = 1;
            do
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    string fizzbuzz = "FizzBuzz";

                    resultat = resultat + fizzbuzz;
                }
                else if(i % 3 == 0)
                {
                    string fizz = "Fizz";
                    resultat = resultat + fizz;
                }
                else if (i % 5 == 0)
                {
                    string buzz = "Buzz";
                    resultat = resultat + buzz;
                }               
                else
                {
                    resultat = resultat + i;
                }

                resultat = resultat + " ";
                   
                i++;
            }
            while (i <= 100);
            return resultat.TrimEnd(new char[] { ' ' });
        }
    }
    
}
