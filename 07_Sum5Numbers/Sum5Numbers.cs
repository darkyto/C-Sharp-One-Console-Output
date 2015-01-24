using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 *                              
 *                              Examples:

                        numbers	                sum
                        1 2 3 4 5	            15
                        10 10 10 10 10	        50
                        1.5 3.14 8.2 -1         0
 * 
 */


class Sum5Numbers
{
    static void Main(string[] args)
     {

         string inputNums = Console.ReadLine();
         double sum = 0;
         double sumEvens = 0;
         double sumOdds = 0;
         string[] sequenceNums = inputNums.Split(' ');  //look at new char[''*',',,'.']  => StringSplitEntries

         for (int i = 0, y = 0; i < sequenceNums.Length; i++ , y++)  // foor loop to go through all the member in the string spearated by ' '
         { 
             sum += double.Parse(sequenceNums[i]);      // a short expresion for summing all the members    

             if (double.Parse(sequenceNums[y]) % 2 == 0)
             {
                 sumEvens += double.Parse(sequenceNums[y]);
             }
             else if (double.Parse(sequenceNums[y]) % 2 != 0)
             {
                 sumOdds += double.Parse(sequenceNums[y]);
             }    
         }
         Console.WriteLine("THE SUM OF THIS SEQUENCE ID : "+ sum);
         Console.WriteLine("The sum of all EVEN members in the sequence : " + sumEvens);
         Console.WriteLine("The sum of all ODD members in the sequence : " + sumOdds); 
     }


}

