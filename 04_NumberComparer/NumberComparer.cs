using System;

/*
 * Write a program that gets two numbers 
 * from the console and prints the greater of them.
 * Try to implement this without if statements.
 * 
 *          Examples:

        a	    b	    greater
        5	    6	    6
        10	    5	    10
        0	    0	    0
        -5	    -2	    -2
        1.5	    1.6	    1.6
 * 
 * 
 */
class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Ënter Random number one ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Ënter Random number two ");
        double secondNum = double.Parse(Console.ReadLine());

        bool firstLarger = firstNum > secondNum;
        bool isEqual = firstNum == secondNum;
        
        bool allChecked = firstLarger && (!isEqual);
        Console.WriteLine();
        Console.WriteLine(allChecked ? (firstNum) : (secondNum) );

        ///////////////////////////////////// REMEMBER this neat trick below ...
        //firstNum = firstNum + secondNum;
        //secondNum = firstNum - secondNum;
        //firstNum = firstNum - secondNum;

        //Console.WriteLine("firstNUm is now "+firstNum);
        //Console.WriteLine("secondNum is now "+secondNum);

    }
}

