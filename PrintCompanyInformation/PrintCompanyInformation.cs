using System;

/*
 * A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 *                                                Example input:

                                        program	user
                                        Company name:	        Telerik Academy
                                        Company address:	    31 Al. Malinov, Sofia
                                        Phone number:	        +359 888 55 55 555
                                        Fax number:	            2
                                        Web site:	            http://telerikacademy.com/
                                        Manager first name:	    Nikolay
                                        Manager last name:	    Kostov
                                        Manager age:	        25
                                        Manager phone:	        +359 2 981 981
 */

class PrintCompanyInformation
 {
     static void Main()
     {
         // To make life easier for the ones who dare to look at my homework
         // i have pre-assigned a values insted of using 10 times Console.ReadLine ... 

         Console.WriteLine("Please enter company name :");
         string comName = "Telerik Academy"; //Console.ReadLine();
         Console.WriteLine("Please enter company address :");
         string comAddress = "31 Al. Malinov, Sofia";//Console.ReadLine();
         Console.WriteLine("Please enter Phone number :");
         string comPhone = "+359 888 55 55 555"; //Console.ReadLine();
         Console.WriteLine("Please enter Fax number:");
         string comFax = "No fax"; //Console.ReadLine();
         Console.WriteLine("Please enter Web site:");
         string comSite = "http://telerikacademy.com/"; //Console.ReadLine();

         Console.WriteLine("Please enter Manager first name :");
         string manFirstName = "Nikolay"; //Console.ReadLine();
         Console.WriteLine("Please enter Manager last name :");
         string manLastName = "Kostov"; //Console.ReadLine();
         Console.WriteLine("Please enter Manager's age :");
         string manAge = "25"; //Console.ReadLine();
         Console.WriteLine("Please enter Manager phone");
         string manPhone = "+359 2 981 981"; //Console.ReadLine();

         string manFullName = manFirstName + " " + manLastName;
         manAge = manAge + " years";

         Console.WriteLine();

         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Company name: " , comName);
         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Company Adress:", comAddress);
         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Phone number:", comPhone);
         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Fax number:", comFax);
         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Web site:", comSite);
         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Manager name:", manFullName);
         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Manager age:", manAge);
         Console.WriteLine("{0,-15} |:| {1,32} |#|", "Manager phone:", manPhone);
                                        



     }                      	 
 }                         	     
                              
                             
                            
                             
                                 
                                 