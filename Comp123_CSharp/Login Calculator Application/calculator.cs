using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class calculator : Form
    {
        string num;
        string symbol;
        public calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //top side buttons
        private void button1_Click(object sender, EventArgs e)//clear
        {
            textBoxInput.Text = "";
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            XValues.Text = "X₁=____    and    X₂=_____";
        }

        private void button2_Click(object sender, EventArgs e)//Calc
        {
            if (textBoxA.Text != "" && textBoxB.Text != "" && textBoxC.Text != "")
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double c = Convert.ToDouble(textBoxC.Text);
                double sqrt = Math.Sqrt((b * b) - (4 * a * c));
                double xOne = (-b + sqrt) / 2 / a;
                double xTwo = (-b - sqrt) / 2 / a;
                XValues.Text = "X₁=" + xOne + "    and    X₂=" + xTwo;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//factorial
        {
            int input=Convert.ToInt32(textBoxInput.Text);
            int sum = 1;
            for (int i = input; i > 1; i--)
            {
                sum = sum * i;
            }
            textBoxInput.Text = Convert.ToString(sum);
        }

        private void button1_Click_2(object sender, EventArgs e)//square
        {
            double input = Convert.ToDouble(textBoxInput.Text);
            input = input * input;
            textBoxInput.Text = Convert.ToString(input);
        }
        //for the number buttons
        private void ifZero()
        {
            if (textBoxInput.Text == "0")
            {
                textBoxInput.Text = "";
            }
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnOne.Text;
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnThree.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnZero.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            ifZero();
            textBoxInput.Text = textBoxInput.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)//9
        {
            ifZero();
            string display = textBoxInput.Text;
            runNine(ref display);
            textBoxInput.Text = display;
            textBoxInput.Text = display;
        }
        private static void runNine(ref string display)
        {
            display = display + "9";
        }
        //for the left side buttons
        private void BtnC_Click(object sender, EventArgs e)
        {
            string original = textBoxInput.Text;
            int length = original.Length;
            if(length>0)
            {
                textBoxInput.Text=original.Substring(0, length - 1);
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(textBoxInput.Text);
            input = Math.Sqrt(input);
            textBoxInput.Text=Convert.ToString(input);
        }

        private void btnAddAndMinus_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            int length = input.Length-1;
            if (input.Substring(0, 1) != "-")
            {
                input = "-" + input;
            }
            else
            {
                input = input.Substring(1, length);
            }
            textBoxInput.Text=input;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            double rem = Convert.ToDouble(textBoxInput.Text) % 1;
            if (rem == 0) {
                textBoxInput.Text = input + ".";
            }
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(textBoxInput.Text);
            input = 1 / input;
            textBoxInput.Text = Convert.ToString(input);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (btnX.Text == "Normal")
            {
                labelA.Visible = false;
                labelB.Visible = false;
                labelC.Visible = false;
                textBoxA.Visible = false;
                textBoxB.Visible = false;
                textBoxC.Visible = false;
                XValues.Visible = false;
                btnCalc.Visible = false;
                textBoxInput.Visible = true;
                btnFactorial.Enabled = true;
                btnRoot.Enabled = true;
                btnSquare.Enabled = true;
                btnOneOverX.Enabled = true;
                btnZero.Enabled = true;
                btnOne.Enabled = true;
                btnTwo.Enabled = true;
                btnThree.Enabled = true;
                btnFour.Enabled = true;
                btnFive.Enabled = true;
                btnSix.Enabled = true;
                btnSeven.Enabled = true;
                btnEight.Enabled = true;
                btnNine.Enabled = true;
                btnAddAndMinus.Enabled = true;
                btnDot.Enabled = true;
                BtnC.Enabled = true;
                btnRemainder.Enabled = true;
                btnDivide.Enabled = true;
                btnMultiply.Enabled = true;
                btnMinus.Enabled = true;
                btnAdd.Enabled = true;
                btnEqual.Enabled = true;
                btnX.Text = "Ax²+Bx+C=0";
            }
            else
            {
                labelA.Visible = true;
                labelB.Visible = true;
                labelC.Visible = true;
                textBoxA.Visible = true;
                textBoxB.Visible = true;
                textBoxC.Visible = true;
                XValues.Visible = true;
                btnCalc.Visible = true;
                textBoxInput.Visible = false;
                btnFactorial.Enabled = false;
                btnRoot.Enabled = false;
                btnSquare.Enabled = false;
                btnOneOverX.Enabled = false;
                btnZero.Enabled = false;
                btnOne.Enabled = false;
                btnTwo.Enabled = false;
                btnThree.Enabled = false;
                btnFour.Enabled = false;
                btnFive.Enabled = false;
                btnSix.Enabled = false;
                btnSeven.Enabled = false;
                btnEight.Enabled = false;
                btnNine.Enabled = false;
                btnAddAndMinus.Enabled = false;
                btnDot.Enabled = false;
                BtnC.Enabled = false;
                btnRemainder.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnMinus.Enabled = false;
                btnAdd.Enabled = false;
                btnEqual.Enabled = false;
                btnX.Text = "Normal";
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }
        //right bottom side buttons
        private void btnRemainder_Click(object sender, EventArgs e)
        {
            num = textBoxInput.Text;
            symbol = "%";
            textBoxInput.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num = textBoxInput.Text;
            symbol = "/";
            textBoxInput.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num = textBoxInput.Text;
            symbol = "*";
            textBoxInput.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num = textBoxInput.Text;
            symbol = "-";
            textBoxInput.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num = textBoxInput.Text;
            symbol = "+";
            textBoxInput.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(num);
            double secendNum = Convert.ToDouble(textBoxInput.Text);
            switch (symbol)
            {
                case "+":
                    textBoxInput.Text = Convert.ToString(firstNum + secendNum) ;
                    break;
                case "-":
                    textBoxInput.Text = Convert.ToString(firstNum - secendNum);
                    break;
                case "/":
                    textBoxInput.Text = Convert.ToString(firstNum / secendNum);
                    break;
                case "*":
                    textBoxInput.Text = Convert.ToString(firstNum * secendNum);
                    break;
                case "%":
                    textBoxInput.Text = Convert.ToString(firstNum % secendNum);
                    break;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Yueyang Sun", "COMP 123 Assignment 4");
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelA.Visible = false;
            labelB.Visible = false;
            labelC.Visible = false;
            textBoxA.Visible = false;
            textBoxB.Visible = false;
            textBoxC.Visible = false;
            XValues.Visible = false;
            btnCalc.Visible = false;
            textBoxInput.Visible = true;
            btnFactorial.Enabled = true;
            btnRoot.Enabled = true;
            btnSquare.Enabled = true;
            btnOneOverX.Enabled = true;
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnAddAndMinus.Enabled = true;
            btnDot.Enabled = true;
            BtnC.Enabled = true;
            btnRemainder.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnMinus.Enabled = true;
            btnAdd.Enabled = true;
            btnEqual.Enabled = true;
            btnX.Text = "Ax²+Bx+C=0";

            textBoxInput.Size = new System.Drawing.Size(214, 35);
            btnReset.Visible = true;
            btnFactorial.Visible = true;
            btnX.Visible = true;
            btnRemainder.Visible = true;
            btnRoot.Visible = true;
            btnSquare.Visible = true;
            btnOneOverX.Visible = true;
            BtnC.Location= new System.Drawing.Point(204, 118);
            btnDivide.Location = new System.Drawing.Point(204, 211);
            btnMultiply.Location = new System.Drawing.Point(204, 257);
            btnMinus.Location = new System.Drawing.Point(204, 303);
            btnAdd.Location = new System.Drawing.Point(204, 350);
            btnEqual.Location = new System.Drawing.Point(204, 396);
            btnSeven.Location = new System.Drawing.Point(30, 257);
            btnEight.Location = new System.Drawing.Point(85, 257);
            btnNine.Location = new System.Drawing.Point(144, 257);
            btnFour.Location = new System.Drawing.Point(30, 303);
            btnFive.Location = new System.Drawing.Point(85, 303);
            btnSix.Location = new System.Drawing.Point(144, 303);
            btnOne.Location = new System.Drawing.Point(30, 350);
            btnTwo.Location = new System.Drawing.Point(85, 350);
            btnThree.Location = new System.Drawing.Point(144, 350);
            btnAddAndMinus.Location = new System.Drawing.Point(30, 396);
            btnZero.Location = new System.Drawing.Point(85, 396);
            btnDot.Location = new System.Drawing.Point(144, 396);

            this.Size = new Size(303, 517);
        }
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelA.Visible = false;
            labelB.Visible = false;
            labelC.Visible = false;
            textBoxA.Visible = false;
            textBoxB.Visible = false;
            textBoxC.Visible = false;
            XValues.Visible = false;
            btnCalc.Visible = false;
            textBoxInput.Visible = true;
            btnFactorial.Enabled = true;
            btnRoot.Enabled = true;
            btnSquare.Enabled = true;
            btnOneOverX.Enabled = true;
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnAddAndMinus.Enabled = true;
            btnDot.Enabled = true;
            BtnC.Enabled = true;
            btnRemainder.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnMinus.Enabled = true;
            btnAdd.Enabled = true;
            btnEqual.Enabled = true;
            btnX.Text = "Ax²+Bx+C=0";

            textBoxInput.Size = new System.Drawing.Size(150, 35);
            btnCalc.Visible = false;
            btnReset.Visible = false;
            btnFactorial.Visible = false;
            btnX.Visible = false;
            btnRemainder.Visible = false;
            btnRoot.Visible = false;
            btnSquare.Visible = false;
            btnOneOverX.Visible = false;
            BtnC.Location = new System.Drawing.Point(204, 52);
            btnDivide.Location = new System.Drawing.Point(204, 118);
            btnMultiply.Location = new System.Drawing.Point(204, 164);
            btnMinus.Location = new System.Drawing.Point(204, 210);
            btnAdd.Location = new System.Drawing.Point(204, 257);
            btnEqual.Location = new System.Drawing.Point(204, 303);
            btnSeven.Location = new System.Drawing.Point(28, 138);
            btnEight.Location = new System.Drawing.Point(85, 138);
            btnNine.Location = new System.Drawing.Point(144, 138);
            btnFour.Location = new System.Drawing.Point(28, 188);
            btnFive.Location = new System.Drawing.Point(85, 188);
            btnSix.Location = new System.Drawing.Point(144, 188);
            btnOne.Location = new System.Drawing.Point(28, 238);
            btnTwo.Location = new System.Drawing.Point(85, 238);
            btnThree.Location = new System.Drawing.Point(144, 238);
            btnAddAndMinus.Location = new System.Drawing.Point(30, 285);
            btnZero.Location = new System.Drawing.Point(85, 285);
            btnDot.Location = new System.Drawing.Point(144, 285);

            this.Size = new Size(303, 389);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
