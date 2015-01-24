using System;
using System.Collections.Generic;
using System.Linq;

/*
 *
 * Write a program that reads the coefficients a, b and c 
 * of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 * 
 *              Examples:

        a	    b	    c	     roots
        2	    5	    -3	    x1=-3; x2=0.5
        -1	    3	    0	    x1=3; x2=0
        -0.5	4	    -8	    x1=x2=4
        5	    2	    8	    no real roots
 *
 *          Quadratic Formula
 *          -----------------
 *          ax2 + bx + c = 0 
 *          Δ = b2 - 4ac
 *      
 *          Spicial cases:
            When Δ>0, there are 2 real roots x1=(-b+√Δ)/(2a) and x2=(-b-√Δ)/(2a).
            When Δ=0, there is one root x1=x2=-b/(2a). / take this for condition root=0
            When Δ<0, there are no real roots, there are 2 complex roots x1=(-b+i√-Δ)/(2a) and x2=(-b-i√-Δ)/(2a).
 * 
 *          The quadratic formula with discriminant notation:
 *          -------------------------------------------------
 *          Δ = 0 then x= -b sqrtΔ/2a  = -b/2a

 *          x = [ -b + sqrt(b^2 - 4ac) ] / 2a
 *          x = [ -b - sqrt(b^2 - 4ac) ] / 2a
 */

class QuadraticEquation
  {
      static void Main()
      {
          // then replace with double.Parse(Console.ReadLine());
          double a = double.Parse(Console.ReadLine());
          double b = double.Parse(Console.ReadLine());
          double c = double.Parse(Console.ReadLine());

          double root = (b*b) - 4*a*c;

          bool realRoot = root >= 0;

          if (!realRoot)
          {
              Console.WriteLine("NO REAL ROOTS!");
              double x1 = (-b + Math.Sqrt(root) ) / (2 * a);
              double x2 = (-b - Math.Sqrt(root) ) / (2 * a);
              Console.WriteLine("The complex roots of this case are hard to represnt in C#:");
              Console.WriteLine("x1 ={0}", x1); //retunrs NaN - the complex root is x1 = -2 + sqrt(-16)
              Console.WriteLine("x2 ={0}", x2); //retunrs NaN - the complex root is x1 = -2 - sqrt(-16)
          }
          else if (root > 0)
          {
              double x1 = (-b + Math.Sqrt(root)  ) / (2 * a);
              double x2 = (-b - Math.Sqrt(root) ) / (2 * a);
              Console.WriteLine("x1={0} , x2={1}",x2 , x1);
          }
          else if (root == 0)
          {
              double x1 = -b /(2 * a);
              Console.WriteLine("x1=x2={0}", x1);
          }
                        

      }
  }

