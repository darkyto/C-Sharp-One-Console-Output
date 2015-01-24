using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *
 * Write a program that reads a number n and prints on the console 
 * the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) 
 * : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 * 
 * Note: You may need to learn how to use loops.
 *          
 *            Examples:

            n	    comments
            1	    0
            3	    0 1 1
            10	    0 1 1 2 3 5 8 13 21 34
 * 
 */
class FibonachiNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("ENter end of sequence to count all the Fibonacci members :");
        int n = int.Parse(Console.ReadLine());         // the user counter
        long[] fibonacci = new long[n + 1];            // the main part - creating array n+1
        long sumFibonacci = 0;                         // bonus achivment (+ 5 mana)
        fibonacci[0] = 0;                              // the first two members are feeded with milk manually
        fibonacci[1] = 1;                              // some more milk for the little brother too
             
        for (int x = 2; x <= n ; ++x)                 // we want the loop to start from member 3 (i=2) and to end one member earlier (n-1)
        {
            fibonacci[x] = fibonacci[x - 1] + fibonacci[x - 2];            // this is how monsters are born- feeding the new member with the previos two... 
                                                                           //Console.WriteLine("Element[{0}] = {1}", x, fibonacci[x]);
             sumFibonacci += fibonacci[x];                                  // sum of all fibonacci members in the sequence
        }

        Array.Resize<long>(ref fibonacci, fibonacci.Length - 1);            //in the loop we initialize 11 elements inst4ed of 10.. 
                                                                            // so now i am removing one (it was impossible earlier as it was in conflic with String.Join)
        Console.WriteLine(string.Join(", ", fibonacci));
        
        Console.WriteLine("The sum of all Fibonacci members is :{0}", sumFibonacci);
    }
}

