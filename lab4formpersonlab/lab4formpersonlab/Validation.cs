using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4formpersonlab
{
    public  static class Validation
    {
        

        public  static bool IsTheInputValid( string strnum) //ERROR CAATTCHHH
        {
            int num = 0;
            bool blnResult = int.TryParse(strnum, out num);

            return blnResult;

        }

        public static bool IsTheInputValidDouble (string strnum) //ERROR CAATTCHHH
        {
            int num = 0;
            bool blnResult = int.TryParse(strnum, out num);

            return blnResult;

        }

        public static bool IsTheInputValidNeg(string strNum) //NEG NUM CHECK
        {
            uint num = 0;
            bool blnResult = uint.TryParse(strNum, out num);

            return blnResult;

        }



        public static bool TestRange(int numberToCheck, int bottom, int top)//NUMBER RANGE
        {
            return (numberToCheck >= bottom && numberToCheck <= top);
        }



        public static string DateConverter(int month, int day, int year)// DATE CONVERTER
        {
            string displaypanel;
            displaypanel = ($"{month} / {day} / {year}");

            return displaypanel;
        }


        public static bool IsItFilledIn(string temp) // is it filled

        {
            bool result = false;
            if (temp.Length > 0)
            {
                result = true;

            }

            return result;


        }











    }
}
