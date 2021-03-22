using System;
using System.Collections.Generic;

namespace studentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = " ";
            string lastName = " ";
            int grade = 0;
            string comment = " ";
            List<string> details = new List<string>();
            for (int close = 0; close != 1; )
            {
                Console.Write("Enter first name: ");
                firstName = (Console.ReadLine());

                Console.Write("Enter last name: ");
                lastName = (Console.ReadLine());

                Console.Write("Enter your grade: ");
                grade = int.Parse(Console.ReadLine());
                if (grade >= 60)
                {
                    comment = "You Passed";
                }
                else
                {
                    comment = "You failed";
                }

                details.Add(firstName);
                details.Add(lastName);
                details.Add(comment);

                details.ForEach(Console.WriteLine);
                Console.WriteLine("enter 0 to add new one or 1 to Exit ");
                close = int.Parse(Console.ReadLine());
            }
            

        }
       
    }
}