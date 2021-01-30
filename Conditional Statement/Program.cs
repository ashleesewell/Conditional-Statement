/*
Author: Ashlee Sewell
Date: 1/29/2021
Comments: Deliverable 1 Conditional Statements
*/
using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            Console.WriteLine("Please enter expected Grade for ISM 4300...");
            //try catch
            // start of try
            try
            {
                //This variable gathers input
                string input = Console.ReadLine();
                /*
                 This variable will be used to store grade
                after input variable is parsed to integer
                */
                int grade = int.Parse(input);
                //This if else statement is used to give the respective letter grade
                if (grade < 60.0)

                { Console.WriteLine(" Your grade is an F"); }


                else if ((grade < 70.0) && (grade > 59.0))
                {
                    Console.WriteLine(" Your grade is a D");
                }
                else if ((grade < 80.0) && (grade > 69.0))
                {
                    Console.WriteLine(" Your grade is a C");
                }
                else if ((grade < 90.0) && (grade > 70.0))
                {
                    Console.WriteLine(" Your grade is a B");

                }
                else if ((grade < 100.0) && (grade > 80.0))
                {
                    Console.WriteLine(" Your grade is an A");
                }
            }
            //Catch
            catch
            {
                Console.WriteLine("Please enter integer between 100 and 0");
            }
            //End of catch

            
        }
    }
}
