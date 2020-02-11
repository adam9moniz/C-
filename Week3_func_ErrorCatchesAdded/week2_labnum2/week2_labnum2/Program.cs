
// ADAM M MONIZ                 JAN 24,2020                         WEEK 3 / LAB 3
// THIS PROGRAM WILL ALLOW A USER TO INPUT 5 GRADES FOR MULTI STUDENTS .. THIS PROGRAM WILL DEPEND ON HOW MANY GRADES ARE BEING ENTERED FOR A NUMBER OF STUDENTS....
// AT THE END OF THIS PROGRAM IT WILL DISPLAY EACH STUDENTS GRADE AVERAGE ALONG WITH A ASSIGNED LETTER GRADE AND ALSO THE CLASSES OVERRALL GRADE....
//ADDING IN FUNCTIONS WHERE I BELIEVE THEYD MAKE SENSE
//------------------------------------------------------------------------------UPDATED 1/24/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_labnum2
{
    class Program
    {
        //Functions

            static Decimal AddingTheLabs(Decimal num1, Decimal num2) // THIS FUNCTION WILL ADD THE LABS TOGETHER
            {
                Decimal sum = 0;
                sum = (num1 + num2);
                return sum;

            }

        static Decimal StudentSumCal(Decimal grade, Decimal gradepool) //THIS FUNTION WILL ADD TOGETHER THE LAB GRADES
        {
            
            gradepool = (gradepool + grade);
            return gradepool;


        }

        static bool IsTheInputValid(String strNum) //ERROR CAATTCHHH
        {
            double doublenum = 0;
            bool blnResult = Double.TryParse(strNum, out doublenum);

            return blnResult;

        }

        static int Checker(string strnum) //NOT IN USE
        {
            int newnum = 0;
            newnum = Convert.ToInt32(strnum);
            return newnum;


        }



        static void Main(string[] args)
        {

            //------------------------------------------------------------> Dec Variables ! (BELOW)
            int studentHeadCnt =0, gradeLabel = 1, studentLabel = 1;
            String studentHeadCntStr;
            Decimal num1dl =0, num2dl=0, num3dl=0, num4dl=0, num5dl=0, studentSum, classSum = 0, classAvgstr = 0, classAvg = 0;
            Decimal  lab1Avg = 0, lab2Avg = 0, lab3Avg = 0, lab4Avg = 0, lab5Avg = 0;
            bool head = false;
            //------------------------------------------------------------> Dec Variables ! (ABOVE)













            //------------------------------------------------------------< BASE PROGRAM START (BELOW)

            Console.WriteLine("Welcome To The Student Grade Avg Cal!");

            do { 
                Console.Write("\nHow Many Students Are You Entering Grades For?: "); // Fetching the amount of students there will be grades put in for....
                studentHeadCntStr = Console.ReadLine();
                head = IsTheInputValid(studentHeadCntStr);

                if (head == false)
                {

                    Console.WriteLine("Please Enter a valid value...");
                }
                else
                {

                    studentHeadCnt = Convert.ToInt32(studentHeadCntStr);
                }
                }while (head == false) ;



            //------------------------------------------------------------> Creating Lists/ Arrays (BELOW)

            Decimal[] studentGradeArray = new Decimal[5];// Array for 5 lab grades to be entered in 

            //------------------------------------------------------------> Creating Lists/ Arrays (ABOVE)



            Console.Clear();//clear console




            String[] studentName = new string[studentHeadCnt];//------------------------------->student name array
            String[] letterGrade = new string[studentHeadCnt];//------------------------------->letter grade array
            
            Decimal lab1 = 0, lab2 = 0, lab3 = 0, lab4 = 0, lab5 = 0 ;//------------------------> declaring variables
            String strnum1, strnum2, strnum3, strnum4, strnum5;
            bool results = false;


            for (int x = 0; x < studentHeadCnt; x++) { //start of the first for loop



                Console.Write("-----------------------------------------");
                Console.Write($"\nPlease Enter #{studentLabel++} Student's First Name: ");// Student Name input 
                studentName[x] = Console.ReadLine();
                Decimal gradepool = 0;
                //----------------------------------------------------------------------> Grade input & calculations #1
                do
                {
                    do
                    {
                        Console.Write($"\nEnter Grade #{gradeLabel++}: ");
                        strnum1 = Console.ReadLine();
                        results = IsTheInputValid(strnum1);
                        if (results == false)
                        {
                            gradeLabel = (gradeLabel - 1);
                            Console.WriteLine("Sorry, your input was invaild...");
                        }
                        else
                        {



                            num1dl = Convert.ToDecimal(strnum1);


                        }
                    } while (results == false);
                    if (num1dl >= 101)
                    {
                        gradeLabel = (gradeLabel - 1);
                        Console.WriteLine("Please Enter a grade value between 0-100");
                    }
                    else { 
                        lab1 = AddingTheLabs(lab1, num1dl);

                        gradepool = StudentSumCal(num1dl, gradepool);
                    }

                    } while (num1dl >= 101) ;



                //---------------------------------------------------------------------------------------------------------------------#2


                do
                {
                    do
                    {
                        Console.Write($"\nEnter Grade #{gradeLabel++}: ");
                        strnum2 = Console.ReadLine();
                        results = IsTheInputValid(strnum2);
                        if (results == false)
                        {
                            gradeLabel = (gradeLabel - 1);
                            Console.WriteLine("Sorry, your input was invaild...");
                        }
                        else
                        {



                            num2dl = Convert.ToDecimal(strnum2);


                        }
                    } while (results == false);

                    if (num2dl >= 101)
                    {
                        gradeLabel = (gradeLabel - 1);
                        Console.WriteLine("Please Enter a grade value between 0-100");
                    }
                    else
                    {
                        lab2 = AddingTheLabs(lab2, num2dl);

                        gradepool = StudentSumCal(num2dl, gradepool);
                    }

                } while (num2dl >= 101);



                //---------------------------------------------------------------------------------------------------------------------#3



                do
                {
                    do
                    {
                        Console.Write($"\nEnter Grade #{gradeLabel++}: ");
                        strnum3 = Console.ReadLine();
                        results = IsTheInputValid(strnum3);
                        if (results == false)
                        {
                            gradeLabel = (gradeLabel - 1);
                            Console.WriteLine("Sorry, your input was invaild...");
                        }
                        else
                        {



                            num3dl = Convert.ToDecimal(strnum3);


                        }
                    } while (results == false);
                    if (num3dl >= 101)
                    {
                        gradeLabel = (gradeLabel - 1);
                        Console.WriteLine("Please Enter a grade value between 0-100");
                    }
                    else
                    {
                        lab3 = AddingTheLabs(lab3, num3dl);

                        gradepool = StudentSumCal(num3dl, gradepool);
                    }

                } while (num3dl >= 101);


                //---------------------------------------------------------------------------------------------------------------------#4

                do
                {
                    do
                    {
                        Console.Write($"\nEnter Grade #{gradeLabel++}: ");
                        strnum4 = Console.ReadLine();
                        results = IsTheInputValid(strnum4);
                        if (results == false)
                        {
                            gradeLabel = (gradeLabel - 1);
                            Console.WriteLine("Sorry, your input was invaild...");
                        }
                        else
                        {



                            num4dl = Convert.ToDecimal(strnum4);


                        }
                    } while (results == false);
                    if (num4dl >= 101)
                    {
                        gradeLabel = (gradeLabel - 1);
                        Console.WriteLine("Please Enter a grade value between 0-100");
                    }
                    else
                    {
                        lab4 = AddingTheLabs(lab4, num4dl);

                        gradepool = StudentSumCal(num4dl, gradepool);
                    }

                } while (num4dl >= 101);

                //---------------------------------------------------------------------------------------------------------------------#5




                do
                {
                    do
                    {
                        Console.Write($"\nEnter Grade #{gradeLabel++}: ");
                        strnum5 = Console.ReadLine();
                        results = IsTheInputValid(strnum5);
                        if (results == false)
                        {
                            gradeLabel = (gradeLabel - 1);
                            Console.WriteLine("Sorry, your input was invaild...");
                        }
                        else
                        {



                            num5dl = Convert.ToDecimal(strnum5);


                        }
                    } while (results == false);
                    if (num5dl >= 101)
                    {
                        gradeLabel = (gradeLabel - 1);
                        Console.WriteLine("Please Enter a grade value between 0-100");
                    }
                    else
                    {
                        lab5 = AddingTheLabs(lab5, num5dl);

                        gradepool = StudentSumCal(num5dl, gradepool);
                    }

                } while (num5dl >= 101);


                studentGradeArray[x] = (gradepool / 5);






                //Loop if for grade letter assignment----------------------------------------------------------------------------------------->


                if (studentGradeArray[x] >= 90)
                {
                    letterGrade[x] = ("A");

                }
                else if (studentGradeArray[x] >= 80)
                {
                    letterGrade[x] = ("B");

                }
                else if (studentGradeArray[x] >= 70)
                {
                    letterGrade[x] = ("C");

                }
                else if (studentGradeArray[x] >= 60)
                {
                    letterGrade[x] = ("D");

                }
                else if (studentGradeArray[x] >= 1)
                {
                    letterGrade[x] = ("F");

                }
                else if (studentGradeArray[x] == 0)
                {
                    letterGrade[x] = ("F");

                }


                Console.Clear();


                gradeLabel = 1;

            }//closes the first for loop .... 






            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine($"[Name]: {studentName[i]} \n[Grade]: {studentGradeArray[i]} = {letterGrade[i]} ");
                Console.WriteLine("------------------------------------------------------------");
            }


            lab1Avg = (lab1 / studentHeadCnt);
            lab2Avg = (lab2 / studentHeadCnt);
            lab3Avg = (lab3 / studentHeadCnt);
            lab4Avg = (lab4 / studentHeadCnt);
            lab5Avg = (lab5 / studentHeadCnt);



            //Displays class overall avgerages 
            Console.WriteLine($"\n\nLab #1 Average Score: {lab1Avg}");
            Console.WriteLine($"Lab #2 Average Score: {lab2Avg}");
            Console.WriteLine($"Lab #3 Average Score: {lab3Avg}");
            Console.WriteLine($"Lab #4 Average Score: {lab4Avg}");
            Console.WriteLine($"Lab #5 Average Score: {lab5Avg}");
            //foreach (int z in studentGradeArray)
            //{

            //    Console.Write($"Grade: {z} ");

            //}




            Console.Write("\n\nPress a key to continue...");
            Console.ReadKey();


        }
    }
}
