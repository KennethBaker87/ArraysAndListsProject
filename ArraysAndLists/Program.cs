using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            
            
            foreach (var item in num)
                
            {
                
                if (item % 2 == 0)
                {
                    even.Add(item);
                }
                else
                {
                    odd.Add(item);
                }
                
            }



            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Even");
            foreach (var item in even)
                

            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Odd");
            foreach (var item in odd)
                
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
