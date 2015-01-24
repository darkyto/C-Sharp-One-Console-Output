using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads two positive integer numbers and prints 
 * how many numbers p exist between them such that the reminder of the division by 5 is 0.
 * 
 *            Examples:
  
    start	end	    p	    comments
    17	    25	    2	    20, 25
    5	    30	    6	    5, 10, 15, 20, 25, 30
    3	    33	    6	    5, 10, 15, 20, 25, 30
    3	    4	    0	    -
    99	    120	    5	    100, 105, 110, 115, 120
    107	    196	    18	    110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
 * 
 */

class NumbersDividableGivenNumber
  {
      static void Main()
      {
          Console.WriteLine("Please enter the start of the sequence :");
          int a = int.Parse(Console.ReadLine());
          Console.WriteLine("Please enter the end of the sequence :");
          int b = int.Parse(Console.ReadLine());

          int countMembers = (b - a)+1;             // using small math to get the number of members of the array
          int bestMembers = 0;                      // variable for the final result
          int[] myArray = new int[countMembers];    // array with lenght equal to countMembers
          myArray[0] = a;                           // declaring the first member of the array  - a

          if ((myArray[0] % 5) == 0)                // special check when first member is in the game
          {
              bestMembers++;                        // if yes - add value to counter
              // Console.WriteLine(myArray[0]);        
          }

          for (int i = 1; i < countMembers ; ++i)   // loop for all the other players starting from second
          {
              myArray[i] = myArray[i - 1] + 1;      // every time the loop goes a value is added for the new member

              if ((myArray[i] % 5) == 0)            // THE CHECK POINT
              {
                  bestMembers++;                    // if yes - add value to counter
                                                    // Console.WriteLine(myArray[i]);
              }
          }
          Console.WriteLine(bestMembers);
          
      }
  }

