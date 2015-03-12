using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Write a program that prints the numbers from 1 to 100. 
            //But for multiples of three print “Fizz” instead of the number and
            //for the multiples of five print “Buzz”. For numbers which are 
            //multiples of both three and five print “FizzBuzz”."

            //for i fromm 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                System.Console.WriteLine(FizzBuzz(i));
                
            }
                System.Console.WriteLine("Press any key to exit...");
                System.Console.ReadKey();
        }

        public static string FizzBuzz(int i)
        {
            if (i % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if ( i % 5 == 0)
            {
                return "Buzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else
            { 
                return i.ToString();
            }


        }
        public static string FizzBuzz1(int i)
        {
            //if multiple of 3 print Fizz
            //if multiple of 5 print Buzz
            //if multiple of 3 & 5 print FizzBuzz
            StringBuilder sb = new StringBuilder();
            if (i % 3 == 0)
            {
                sb.Append("Fizz");
            }
            if (i % 5 == 0)
            {
                sb.Append("Buzz");
            }
            if (sb.Length == 0)
            {
                sb.Append(i);
            }
            return sb.ToString();
        
        }
    }
}
