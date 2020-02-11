// ADAM MONIZ                               C#                      Debugging Assignment                    01/26/2020
// FOR THIS ASSIGNMENT I CHANGED UP A FEW THINGS UP... I CHANGED THE VALUE FOR THE FOR LOOP FROM 7 TO WHATEVER THE USER INPUTS 
// BECAUSE THEN THE PROGRAM WILL ONLY AS FOR THE REQUESTED AMOUNT OF DAYS... I ALSO ADDED IN ERROR CATCHES THE THE USER CANNOT INPUT
// LETTERS WHERE NUMBERS ARE ASKED FOR... I ALSO FIXED THE DISPLAYING ISSUE. NOW IT WILL ONLY SHOW THE DAYS THE USER ENTERED ALONG WITH
// HOURS THEY WORKED... ALSO A TOTAL HOUR DISPLAYED ONCE AT THE VERY END. 








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debug_week3
{
    class Program
    {
        // FUNCTIONS

        static bool IsTheInputValid(String strNum) //ERROR CAATTCHHH
        {
            double doublenum = 0;
            bool blnResult = Double.TryParse(strNum, out doublenum);

            return blnResult;

        }






        static void Main(string[] args)
        {

            // Declaring Vars...
            String Day, strNumofDays, strHour;
            Int32 intNumofDays = 0;
            bool resultDay = false, resultHour = false;
            Double Hour = 0, totalHours = 0;
            // BASE PROGRAM ------------------------------------------------------------------------->

            do { 
            Console.WriteLine("Enter the number of days you worked: ");
            strNumofDays = Console.ReadLine(); // Users input for number of days worked...

            resultDay = IsTheInputValid(strNumofDays);

                Console.Clear();

                    
                //CATCH
                if (resultDay == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid value!...");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
                else
                {
                    intNumofDays = Convert.ToInt32(strNumofDays);
                }
            }while (resultDay == false) ;



            Double[] Hours = new Double[intNumofDays]; // Creating Array for Hours being entered in...
            String[] Days = new String[intNumofDays]; // Creating Array for Days being entered in...
            
            for (int i = 0; i < intNumofDays; i++) // This loop will run as many times as entered by the user...
            {
                Console.WriteLine("Enter the Day of the week: "); // USER INPUT FOR DAYS THEY WORKED (MONDAY, TUESDAY, WEDNESDAY, ETC)
                Day = Console.ReadLine();
                Days[i] = Day;


                do { 

                Console.WriteLine("Enter the number of hours worked: "); // USER INPUT FOR HOURS THEY WORKED
                strHour = Console.ReadLine();
                resultHour = IsTheInputValid(strHour);
                
                    if (resultHour == false) {
                        Console.WriteLine(" ");
                        Console.WriteLine("Please enter a valid value!...");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                    else {

                        Hour = Convert.ToDouble(strHour); // IF INPUT PASSES CATCH ITLL DO THE CONVERSION AND STORAGE THE GIVEN HOURS 

                        Hours[i] = Hour;

                        totalHours = totalHours + Hour;
                        Console.Clear();
                    }
                }while (resultHour == false) ;
                

            }



            for (int i = 0; i < intNumofDays; i++)
            {

                Console.WriteLine(Days[i] + " " + Hours[i]); // DISPLAYS THE DAYS AND HOURS ENTERED FOR EACH INPUT 


            }
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Total Hours:" + totalHours); // DISPLAYS THE TOTAL HOURS



            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();












        }
    }
}
