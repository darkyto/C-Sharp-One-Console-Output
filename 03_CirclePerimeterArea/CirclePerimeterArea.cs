using System;

/*
 * 
 * Write a program that reads the radius r of a circle 
 * and prints its perimeter and area formatted with 2 digits after the decimal point.
 * 
 *                  Examples:

        r	        perimeter	    area
        2	        12.57	        12.57
        3.5	        21.99	        38.48
 * 
 */


class CirclePerimeterArea
 {
     static void Main()
     {

         Console.WriteLine("Enter R for radius of curce:");
         double radius = double.Parse(Console.ReadLine());

         double area = Math.PI * (radius * radius);
         double perimeter = Math.PI * (radius + radius);

         Console.WriteLine("Radius is {2} - {0}{1:F2}", "The AREA is ", area, radius);
         Console.WriteLine("Radius is {2} - {0}{1:F2}", "The PERIMETER is ", perimeter, radius);
     }
 }

