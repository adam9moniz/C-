using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String stringGrade1, stringGrade2, stringGrade3, stringGrade4;
        Int32 intGrade1, intGrade2, intGrade3, intGrade4;



        Double gradeResult1, gradeResult, gradeletterResult;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            stringGrade1 = textBox1.Text;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            stringGrade4 = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            stringGrade2 = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            stringGrade3 = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intGrade1 = Convert.ToInt32(stringGrade1);
            intGrade2 = Convert.ToInt32(stringGrade2);
            intGrade3 = Convert.ToInt32(stringGrade3);
            intGrade4 = Convert.ToInt32(stringGrade4);

            gradeResult1 = (intGrade1 + intGrade2 + intGrade3 + intGrade4);
            gradeletterResult = gradeResult1 / 4;
            gradeResult = gradeResult1 / 4;

            if (gradeResult == 0)
            {
                textBox5.Text = ("-");

            }
            else if (gradeResult <= 100)
            {
                textBox5.Text = gradeResult.ToString();
            }
            else 
            {
                textBox5.Text = ("-");
                MessageBox.Show("**Grades usually dont exceed 100... Clear screen and retry**");
            }



            if (gradeletterResult >= 101)
            {
                textBox6.Text = ("-");
            }



            else if (gradeletterResult >= 90)
            {
                textBox6.Text = ("A");
            }
            else if (gradeletterResult >= 80)
            {
                textBox6.Text = ("B");
            }
            else if (gradeletterResult >= 70)
            {
                textBox6.Text = ("C");
            }
            else if (gradeletterResult >= 60)
            {
                textBox6.Text = ("D");
            }
            else if (gradeletterResult >= 1)
            {
                textBox6.Text = ("F");
            }
            else if (gradeletterResult == 0)
            {
                textBox6.Text = ("-");
                MessageBox.Show("**Please Enter grade values...Clear screen and retry**");
            }

        }
         

        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
