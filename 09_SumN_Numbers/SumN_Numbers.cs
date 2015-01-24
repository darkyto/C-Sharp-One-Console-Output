using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that enters a number n and after that enters 
 * more n numbers and calculates and prints their sum. 
 * Note: You may need to use a for-loop.
 * 
 *              Examples:
        numbers	        sum
 * 
        3	90
        20	
        60	
        10	
                        5	    6.5
                        2	
                        -1	
                        -0.5	
                        4	
                        2	
        1	1
        1

 */
class SumN_Numbers
{
    static void Main()
    {
        Console.WriteLine("Pleasse enter number N:");
        int userNum = int.Parse(Console.ReadLine());                    //this will be the counter
        double totalSum = 0;                                            // declare the sum of the elements again in double

        double[] myArray = new double[userNum];                         // declaring double array - will work inside and int for loop

        for (int i = 0; i < userNum; i++)
        {
            Console.WriteLine("we need {0} more numbers:",userNum);
            myArray[i] = double.Parse(Console.ReadLine());              // feeding the loop with n values
            Console.WriteLine("Element[{0}] = {1}", i, myArray[i]);     // bonus (+5 mana)
            totalSum += myArray[i];                                     // summing all the members from an array

        } 
        Console.WriteLine("The SUM of all elements :"+ totalSum);
    }
}

