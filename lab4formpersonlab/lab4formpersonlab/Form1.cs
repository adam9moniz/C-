using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4formpersonlab
{
    public partial class Form1 : Form
    {

        public static bool IsTheInputValid(string strnum) //ERROR CAATTCHHH
        {
            int num = 0;
            bool blnResult = int.TryParse(strnum, out num);

            return blnResult;

        }

        public static bool IsTheInputValidDouble(string strnum) //ERROR CAATTCHHH
        {
            Double num = 0;
            bool blnResult = Double.TryParse(strnum, out num);

            return blnResult;

        }

        public static bool TestRange(Double numberToCheck, Double bottom, Double top)//NUMBER RANGE
        {
            return (numberToCheck >= bottom && numberToCheck <= top);
        }




        public Form1()
        {
            InitializeComponent();
        }

        PersonList  N2 = new PersonList();
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            string name = firstnametextbox.Text;
            string lname = lastnametextbox.Text;
            string dob1 = birthdatetextbox1.Text;
            string dob2 = birthdatetextbox2.Text;
            string dob3 = birthdatetextbox3.Text;
            string phone1 = phonenumbertextbox1.Text;
            string phone2 = phonenumbertextbox2.Text;
            string phone3 = phonenumbertextbox3.Text;
            string hire = hiredatetextbox.Text;
            string salary = salarytextbox.Text;
            string gpa = gpatextbox.Text;



            Person Z3 = new Person();


            Z3.Fname = name;
            Z3.Lname = lname;
            Z3.Dob1 = dob1;
            Z3.Dob2 = dob2;
            Z3.Dob3 = dob3;
            Z3.Phonenumber1 = phone1;
            Z3.Phonenumber2 = phone2;
            Z3.Phonenumber3 = phone3;
            Z3.Hiredate = hire;
            Z3.Salary = salary;
            Z3.Gpa = gpa;
            

            N2.add(Z3);

            count = N2.count;



            if (firstnametextbox.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter a value to First Name!");

                return;
            }
            else

            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();

            }

            if (lastnametextbox.Text == string.Empty)
            {
                pictureBoxgrey.Visible =false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter a value to Last Name!");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }

            if (birthdatetextbox1.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter Month Of Birth ex. (1-12)");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }

            if (birthdatetextbox2.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter Day Of Birth ex.(1-31)");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }

            if (birthdatetextbox3.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter Year Of Birth ex.(94, 95, 96)");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }

            if (phonenumbertextbox1.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter a value to Phone Number!");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }

            if (phonenumbertextbox2.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter a value to Phone Number!");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }

            if (phonenumbertextbox3.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter a value to Phone Number!");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }


            if (salarytextbox.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter a value to Salary!");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }

            if (gpatextbox.Text == string.Empty)
            {
                pictureBoxgrey.Visible = false;
                confirmlabel.Visible = false;
                addedlabel.Visible = false;
                label8.Text = String.Empty;
                MessageBox.Show("Please enter a value to GPA!");

                return;
            }
            else
            {
                pictureBoxgrey.Visible = true;
                confirmlabel.Visible = true;
                addedlabel.Visible = true;
                label8.Text = Z3.getstuff();
            }




        }




        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            bool result = false;

            result = IsTheInputValid(firstnametextbox.Text);



            if (result == true)
            {

                firstnametextbox.Text = String.Empty;
            }






            if (firstnametextbox.Text == String.Empty)
            {

                firstname.ForeColor = Color.Red;
                firstnamechecklabel.ForeColor = Color.Red;
                firstnamechecklabel.Text = "✖";
            }
            else
            {
                firstname.ForeColor = Color.Black;
                firstnamechecklabel.ForeColor = Color.Green;

                firstnamechecklabel.Text = "✔️";

            }



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            bool result = false;

            result = IsTheInputValid(lastnametextbox.Text);



            if (result == true)
            {

                lastnametextbox.Text = String.Empty;

            }


            if (lastnametextbox.Text == String.Empty)
            {

                lastname.ForeColor = Color.Red;
                lastnamechecklabel.ForeColor = Color.Red;
                lastnamechecklabel.Text = "✖";
            }
            else
            {
                lastname.ForeColor = Color.Black;
                lastnamechecklabel.ForeColor = Color.Green;
                lastnamechecklabel.Text = "✔️";

            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int birth = 0;
            bool result = false;

            result = IsTheInputValid(birthdatetextbox1.Text);



            if (result == false)
            {

                birthdatetextbox1.Text = String.Empty;

            }



            if (birthdatetextbox1.Text == String.Empty)
            {

                birthdate.ForeColor = Color.Red;
                birthdatechecklabel.ForeColor = Color.Red;
                birthdatechecklabel.Text = "✖";
            }
            else
            {

                birthdate.ForeColor = Color.Black;
                birthdatechecklabel.ForeColor = Color.Green;
                birthdatechecklabel.Text = "✔️";
                birth = Convert.ToInt32(birthdatetextbox1.Text);

            }

            bool birth1 = TestRange(birth, 0,12);

            if (birth1 == false)
            {

                birthdatetextbox1.Text = String.Empty;

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            bool result = false;

            result = IsTheInputValid(phonenumbertextbox1.Text);



            if (result == false)
            {

                phonenumbertextbox1.Text = String.Empty;

            }
            if (phonenumbertextbox1.Text == String.Empty)
            {

                phonenumber.ForeColor = Color.Red;
                phonenumberchecklabel.ForeColor = Color.Red;
                phonenumberchecklabel.Text = "✖";
            }
            else
            {
                phonenumber.ForeColor = Color.Black;
                phonenumberchecklabel.ForeColor = Color.Green;
                phonenumberchecklabel.Text = "✔️";

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (hiredatetextbox.Text == String.Empty)
            {
                hiredatechecklabel.ForeColor = Color.Black;
                hiredatechecklabel.Text = "(Optional)";
            }
            else
            {
                hiredate.ForeColor = Color.Black;
                hiredatechecklabel.ForeColor = Color.Green;
                hiredatechecklabel.Text = "✔️";

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool result = false;

            result = IsTheInputValid(salarytextbox.Text);



            if (result == false)
            {

                salarytextbox.Text = String.Empty;
            }








            if (salarytextbox.Text == String.Empty)
            {

                salary.ForeColor = Color.Red;
                salarychecklabel.ForeColor = Color.Red;
                salarychecklabel.Text = "✖";
            }
            else
            {
                salary.ForeColor = Color.Black;
                salarychecklabel.ForeColor = Color.Green;
                salarychecklabel.Text = "✔️";

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Double gpatest = 0;
            bool result = false, gparesult = false;


                result = IsTheInputValidDouble(gpatextbox.Text);

                if (result == false)
                {

                    gpatextbox.Text = String.Empty;

                }
                else
                {

                    gpatest = Convert.ToDouble(gpatextbox.Text);
                }



                gparesult = false;

                gparesult = TestRange(gpatest, 0.0, 4.0 );

                if (gparesult == false)
                {

                    gpatextbox.Text = String.Empty;

                }


            if (gpatextbox.Text == String.Empty)
            {

                gpa.ForeColor = Color.Red;
                gpachecklabel.ForeColor = Color.Red;
                gpachecklabel.Text = "✖";
            }
            else
            {
                gpa.ForeColor = Color.Black;
                gpachecklabel.ForeColor = Color.Green;
                gpachecklabel.Text = "✔️";

            }


        }

        private void firstnamechecklabel_Click(object sender, EventArgs e)
        {

        }

        private void lastnamechecklabel_Click(object sender, EventArgs e)
        {

        }

        private void birthdatechecklabel_Click(object sender, EventArgs e)
        {

        }

        private void phonenumberchecklabel_Click(object sender, EventArgs e)
        {

        }

        private void hiredatechecklabel_Click(object sender, EventArgs e)
        {

        }

        private void salarychecklabel_Click(object sender, EventArgs e)
        {

        }

        private void gpachecklabel_Click(object sender, EventArgs e)
        {

        }

        private void phonenumbertextbox2_TextChanged(object sender, EventArgs e)
        {

            bool result = false;

            result = IsTheInputValid(phonenumbertextbox2.Text);



            if (result == false)
            {

                phonenumbertextbox2.Text = String.Empty;

            }

            if (phonenumbertextbox2.Text == String.Empty)
            {

                phonenumber.ForeColor = Color.Red;
                phonenumberchecklabel.ForeColor = Color.Red;
                phonenumberchecklabel.Text = "✖";
            }
            else
            {
                phonenumber.ForeColor = Color.Black;
                phonenumberchecklabel.ForeColor = Color.Green;
                phonenumberchecklabel.Text = "✔️";

            }

        }

        private void phonenumbertextbox3_TextChanged(object sender, EventArgs e)
        {
            bool result = false;

            result = IsTheInputValid(phonenumbertextbox3.Text);



            if (result == false)
            {

                phonenumbertextbox3.Text = String.Empty;

            }


            if (phonenumbertextbox3.Text == String.Empty)
            {

                phonenumber.ForeColor = Color.Red;
                phonenumberchecklabel.ForeColor = Color.Red;
                phonenumberchecklabel.Text = "✖";
            }
            else
            {
                phonenumber.ForeColor = Color.Black;
                phonenumberchecklabel.ForeColor = Color.Green;
                phonenumberchecklabel.Text = "✔️";

            }

        }

        private void birthdatetextbox2_TextChanged(object sender, EventArgs e)
        {
                int birth2 = 0;
                bool result = false;

                result = IsTheInputValid(birthdatetextbox2.Text);



                if (result == false)
                {

                    birthdatetextbox2.Text = String.Empty;

                }



                if (birthdatetextbox2.Text == String.Empty)
                {

                    birthdate.ForeColor = Color.Red;
                    birthdatechecklabel.ForeColor = Color.Red;
                    birthdatechecklabel.Text = "✖";
                }
                else
                {

                    birthdate.ForeColor = Color.Black;
                    birthdatechecklabel.ForeColor = Color.Green;
                    birthdatechecklabel.Text = "✔️";
                    birth2 = Convert.ToInt32(birthdatetextbox2.Text);
                }

            bool birthz = TestRange(birth2, 0, 31);

            if (birthz == false)
            {

                birthdatetextbox2.Text = String.Empty;

            }

        }

        

        private void birthdatetextbox3_TextChanged(object sender, EventArgs e)
        {
            int birth3 = 0;
            bool result = false;

            result = IsTheInputValid(birthdatetextbox3.Text);



            if (result == false)
            {

                birthdatetextbox3.Text = String.Empty;

            }



            if (birthdatetextbox3.Text == String.Empty)
            {

                birthdate.ForeColor = Color.Red;
                birthdatechecklabel.ForeColor = Color.Red;
                birthdatechecklabel.Text = "✖";
            }
            else
            {

                birthdate.ForeColor = Color.Black;
                birthdatechecklabel.ForeColor = Color.Green;
                birthdatechecklabel.Text = "✔️";
                birth3 = Convert.ToInt32(birthdatetextbox3.Text);
            }

            bool birthr = TestRange(birth3, 0, 99);

            if (birthr == false)
            {

                birthdatetextbox3.Text = String.Empty;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            firstnametextbox.Text = String.Empty;
            lastnametextbox.Text = String.Empty;
            birthdatetextbox1.Text = String.Empty;
            birthdatetextbox2.Text = String.Empty;
            birthdatetextbox3.Text = String.Empty;
            phonenumbertextbox1.Text = String.Empty;
            phonenumbertextbox2.Text = String.Empty;
            phonenumbertextbox3.Text = String.Empty;
            hiredatetextbox.Text = String.Empty;
            salarytextbox.Text = String.Empty;
            gpatextbox.Text = String.Empty;

            label8.Text = String.Empty;

            birthdatechecklabel.Text = String.Empty;
            gpachecklabel.Text = String.Empty;
            salarychecklabel.Text = String.Empty;
            phonenumberchecklabel.Text = String.Empty;
            lastnamechecklabel.Text = String.Empty;
            firstnamechecklabel.Text = String.Empty;

            birthdate.ForeColor = Color.Black;
            phonenumber.ForeColor = Color.Black;
            lastname.ForeColor = Color.Black;
            firstname.ForeColor = Color.Black;
            salary.ForeColor = Color.Black;
            gpa.ForeColor = Color.Black;

            pictureBoxgrey.Visible = false;
            confirmlabel.Visible = false;
            addedlabel.Visible = false;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            string searchname = searchbox.Text;
            Person L2 = new Person();
            L2 = N2[searchname];

            if (L2 == null)
            {
                MessageBox.Show( "Name doesnt exist!");
            }
            else
            {
                pictureBox1.Visible = true;
                label11.Text = L2.getstuff();
                searchbox.Text = String.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label11.Text = String.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
