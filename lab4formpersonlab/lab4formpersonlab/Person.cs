using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4formpersonlab
{
    public class Person
    {

        private string fname;
        private string lname;
        private string dob1;
        private string dob2;
        private string dob3;
        private string phonenumber1;
        private string phonenumber2;
        private string phonenumber3;
        private string hiredate;
        private string salary;
        private string gpa;

        public Person()
        {


        }

        public Person(string fname, string lname, string dob1, string dob2, string dob3, string phonenumber1, string phonenumber2, string phonenumber3, string hiredate, string salary, string gpa)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Dob1 = dob1;
            this.Dob2 = dob2;
            this.Dob3 = dob3;
            this.Phonenumber1 = phonenumber1;
            this.Phonenumber2 = phonenumber2;
            this.Phonenumber3 = phonenumber3;
            this.Hiredate = hiredate;
            this.Salary = salary;
            this.Gpa = gpa;
            

        }

        public string Fname
        {
            get
            {

                return fname;

            }

            set
            {

                fname = value;

            }


        }

        public string Lname
        {
            get
            {

                return lname;

            }

            set
            {

                lname = value;

            }


        }

        public string Dob1
        {
            get
            {

                return dob1;

            }

            set
            {

                dob1 = value;

            }


        }

        public string Dob2
        {
            get
            {

                return dob2;

            }

            set
            {

                dob2 = value;

            }


        }

        public string Dob3
        {
            get
            {

                return dob3;

            }

            set
            {

                dob3 = value;

            }


        }

        public string Phonenumber1
        {
            get
            {

                return phonenumber1;

            }

            set
            {

                phonenumber1 = value;

            }


        }

        public string Phonenumber2
        {
            get
            {

                return phonenumber2;

            }

            set
            {

                phonenumber2 = value;

            }


        }

        public string Phonenumber3
        {
            get
            {

                return phonenumber3;

            }

            set
            {

                phonenumber3 = value;

            }


        }

        public string Hiredate
        {
            get
            {

                return hiredate;

            }

            set
            {

                hiredate = value;
                if (hiredate == string.Empty)
                {
                    DateTime today = DateTime.Today;
                    hiredate = (today.ToString("MM/dd/yyyy"));
                }

            }


        }

        public string Salary
        {
            get
            {

                return salary;

            }

            set
            {

                salary = value;

            }


        }

        public string Gpa
        {
            get
            {

                return gpa;

            }

            set
            {

                gpa = value;

            }


        }



        public string getstuff()
        {

            return ($"Name: {fname} {lname}\nDOB: {dob1}/{dob2}/{dob3}\nPhone Number: 1-({phonenumber1})-{phonenumber2}-{phonenumber3}\nHire Date: {hiredate}\nSalary: ${salary}\nGPA: {gpa}");
             

        }



    }
}
