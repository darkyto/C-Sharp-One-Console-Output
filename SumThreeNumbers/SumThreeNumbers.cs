using System;

/*
 * Write a program that reads 3 real numbers from the console and prints their sum.
                                    
 *                                   Examples:

                            a	    b	    c	    sum
                            3	    4	    11	    18
                            -2	    0	    3	    1
                            5.5	    4.5	    20.1    30.1
 * 
 */

class SumThreeNumbers
 {
     static void Main()
     {

         Console.WriteLine("Please enter A :");
         double a = double.Parse(Console.ReadLine());
         Console.WriteLine("Please enter B :");
         double b = double.Parse(Console.ReadLine());
         Console.WriteLine("Please enter C :");
         double c = double.Parse(Console.ReadLine());

         Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
     }
 }

