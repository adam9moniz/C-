
// Adam Moniz                     01/08/2020            Lab 1, Week 1
// This is a grade average program... The user will be prompted to input 4 different digit grades 
// & the program will assign a letter value depending on the number calculated within it...



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   //Lets introduce the variables...
            String username, grade1, grade2, grade3, grade4, letterGrade, conv;
            Int32 gradeNum1, gradeNum2, gradeNum3, gradeNum4;
            Double gradeResult, gradeTotal, gradedec1, gradedec2, gradedec3, gradedec4;



            Console.WriteLine("Welcome to the grade average calculator!");
            //input to welcome the user to the program by their name...
            Console.Write("\n\nPlease Enter a name: ");
            username = Console.ReadLine();

            //Welcome the user by their name...
            Console.WriteLine($"\n\nHello there {username}, let's get started!");


            //deci option... We wanna know if they are entering dec/ int or just dec
            Console.Write("\n\nWill you be entering only whole numbers?: [y/n]");
            conv = Console.ReadLine();


            //User grade inputs...
            Console.WriteLine("Enter 1st grade: ");
            grade1 = Console.ReadLine();

            Console.WriteLine("Enter 2nd grade: ");
            grade2 = Console.ReadLine();

            Console.WriteLine("Enter 3rd grade: ");
            grade3 = Console.ReadLine();

            Console.WriteLine("Enter 4th grade: ");
            grade4 = Console.ReadLine();

            //Conversion... along will a yes and no cap lock catch

            if (conv == "y") {
                gradeNum1 = Int32.Parse(grade1);
                gradeNum2 = Int32.Parse(grade2);
                gradeNum3 = Int32.Parse(grade3);
                gradeNum4 = Int32.Parse(grade4);
                gradeTotal = (gradeNum1 + gradeNum2 + gradeNum3 + gradeNum4);
                gradeResult = (gradeTotal / 4);
                if (gradeResult >= 101)
                {

                    Console.WriteLine($"\n\nThe Values given exceed 100..Please try again...");
                }
                else if (gradeResult >= 90)
                {
                    letterGrade = ("A");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 80)
                {
                    letterGrade = ("B");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 70)
                {
                    letterGrade = ("C");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 60)
                {
                    letterGrade = ("D");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 1)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult == 0)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nYou need to pass in your work to get a grade you know.. ");
                }


                //Closing Program...
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
            }
            else if (conv == "Y")
            {
                gradeNum1 = Int32.Parse(grade1);
                gradeNum2 = Int32.Parse(grade2);
                gradeNum3 = Int32.Parse(grade3);
                gradeNum4 = Int32.Parse(grade4);
                gradeTotal = (gradeNum1 + gradeNum2 + gradeNum3 + gradeNum4);
                gradeResult = (gradeTotal / 4);
                if (gradeResult >= 101)
                {

                    Console.WriteLine($"\n\nThe Values given exceed 100..Please try again...");
                }
                else if (gradeResult >= 90)
                {
                    letterGrade = ("A");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 80)
                {
                    letterGrade = ("B");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 70)
                {
                    letterGrade = ("C");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 60)
                {
                    letterGrade = ("D");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 1)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult == 0)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nYou need to pass in your work to get a grade you know.. ");
                }


                //Closing Program...
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
            }
            else if (conv == "n")
            {
                gradedec1 = Double.Parse(grade1);
                gradedec2 = Double.Parse(grade2);
                gradedec3 = Double.Parse(grade3);
                gradedec4 = Double.Parse(grade4);
                gradeTotal = (gradedec1 + gradedec2 + gradedec3 + gradedec4);
                gradeResult = (gradeTotal / 4);
                if (gradeResult >= 101)
                {

                    Console.WriteLine($"\n\nThe Values given exceed 100..Please try again...");
                }
                else if (gradeResult >= 90)
                {
                    letterGrade = ("A");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 80)
                {
                    letterGrade = ("B");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 70)
                {
                    letterGrade = ("C");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 60)
                {
                    letterGrade = ("D");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 1)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult == 0)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nYou need to pass in your work to get a grade you know.. ");
                }


                //Closing Program...
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
            }
            else if (conv == "N")
            {
                gradedec1 = Double.Parse(grade1);
                gradedec2 = Double.Parse(grade2);
                gradedec3 = Double.Parse(grade3);
                gradedec4 = Double.Parse(grade4);
                gradeTotal = (gradedec1 + gradedec2 + gradedec3 + gradedec4);
                gradeResult = (gradeTotal / 4);

                if (gradeResult >= 101)
                {

                    Console.WriteLine($"\n\nThe Values given exceed 100..Please try again...");
                }
                else if (gradeResult >= 90)
                {
                    letterGrade = ("A");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 80)
                {
                    letterGrade = ("B");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 70)
                {
                    letterGrade = ("C");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 60)
                {
                    letterGrade = ("D");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult >= 1)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nThe letter grade is {letterGrade} and number grade is {gradeResult}");
                }
                else if (gradeResult == 0)
                {
                    letterGrade = ("F");
                    Console.WriteLine($"\n\nYou need to pass in your work to get a grade you know.. ");
                }


                //Closing Program...
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
            }





           

        }
    }
}
