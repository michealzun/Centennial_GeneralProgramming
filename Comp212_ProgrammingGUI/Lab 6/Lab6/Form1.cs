using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        //a) 
        public Form1()
        {
            InitializeComponent();
        }
        //b) calculate factorial asyncronously
        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            try{
                long userInput = Convert.ToInt64(tbFactor.Text);
                //if user enter an invalid n number
                if (userInput < 0) { throw new FormatException(); }
                if (userInput > 20) { throw new OverflowException(); }
                tbFactor.Text = "Calculating...";
                //run the factorial task
                Task<long> factorial = Task.Run(()=>calculateFactorial(userInput));
                await factorial;
                //check for validty of the number returned
                if (factorial.Result <= 0){throw new OverflowException();}
                tbFactor.Text = userInput+"! = " + factorial.Result.ToString();
            }
            catch (OverflowException)
            {
                tbFactor.Text = "number too long for a long integer variable";
            }
            catch (FormatException)
            {
                tbFactor.Text = "please enter an integer";
            }
        }
        //the calculation task
        private long calculateFactorial(long n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                //check if sum overflow
                try {
                    return checked(n * calculateFactorial(n - 1));
                }
                //returns 0 if it overflow, triggering the OverflowException in btnCalculate_Click
                catch (OverflowException)
                {
                    return 0;
                } 
            }
        }

        //c)check for even or odd
        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(tbEvenOdd.Text);
                //check for even with delegate
                EvenDelegate isEvenDelegate = checkForEven;
                bool isEven = isEvenDelegate(value);
                //checked for off with lambda
                bool IsOdd(int number) => number % 2 == 1;
                //write to textbox accourding to the results 
                if (isEven)
                {
                    tbEvenOdd.Text += " is Even";
                }
                if (IsOdd(value))
                {
                    tbEvenOdd.Text += " is odd";
                }

            }
            //incase if the user enters the wrong format
            catch (FormatException)
            {
                tbEvenOdd.Text = "please enter an integer";
            }
        }
        //for the delegate declaration and method for testing if even
        delegate bool EvenDelegate(int number);
        private bool checkForEven(int num) {
            return (num % 2 == 0);
        }
        //d)i) generte a list of values
        private void btnGenerateValue_Click(object sender, EventArgs e)
        {
            //clear previous
            lbValues.Items.Clear();
            //for randomness
            Random random = new Random();
            //integer generation
            if (radioInteger.Checked)
            {
                int randInteger;
                for (int i = 0; i < 10; i++)
                {
                    randInteger = random.Next(10, 100);
                    lbValues.Items.Add(randInteger);
                }
            }
            //integer generation
            else if (radioDouble.Checked)
            {
                double randDouble;
                for (int i = 0; i < 10; i++)
                {
                    //set the range 0 to 89.9999 then we add 10 to get 10 to 99.999
                    randDouble = random.NextDouble()*90+10;
                    //round the double so we can show it on listbox
                    randDouble = Math.Round(randDouble,2);
                    lbValues.Items.Add(randDouble);
                }
            }
            //char generation
            else
            {
                char randChar;
                for (int i = 0; i < 10; i++)
                {
                    //all the chars i found on the internet
                    string allChars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
                    int postion = random.Next(0, allChars.Length);
                    randChar= allChars[postion];
                    lbValues.Items.Add(randChar);
                }
            }
        }
        //d)ii) sreach
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //adding the listbox.object collection into a list
                List<string> list = new List<string>();
                for (int i = 0; i < lbValues.Items.Count; i++)
                {
                    list.Add(lbValues.Items[i].ToString());
                }
                //search for the value in the list
                bool search = SearchData(list, tbSearceValue.Text);
                tbSearceValue.Text += (search) ? " Found" : " Not Found";
            }
            catch (Exception)
            {
                tbSearceValue.Text = "list box object type not of int, double or char, and cant be converted";
            }
        }
        private bool SearchData<T>(List<T> list, T searchValue) where T: IComparable<T>
        {
            bool found = false;
            foreach (var item in list)
            {
                if ((item.CompareTo(searchValue) == 0))
                {
                    found=true;
                }
            }
            return found;
        }
        //d)iii)
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //adding the listbox.object collection into a list
            List<string> list = new List<string>();
            for (int i = 0; i < lbValues.Items.Count; i++)
            {
                list.Add(lbValues.Items[i].ToString());
            }
            //check for values between
            List<string> between = PrintData<string>(tbLowIndex.Text, tbHighIndex.Text,list);
            tbRangedValue.Text = "";
            foreach (var item in between)
            {
                tbRangedValue.Text += item + " ,";
            }
        }
        private List<T> PrintData<T>(T min,T max,List<T> list) where T : IComparable<T>
        {
            List<T> between = new List<T>();
            try {
                if (max.CompareTo(min) < 0) throw new Exception();
                //compare each item
                foreach (var item in list)
                {    
                    if(item.CompareTo(min)>0 && item.CompareTo(max) < 0)
                    {
                        between.Add(item);
                    }
                }
            }
            catch(Exception)
            {
                tbRangedValue.Text = "max min range error";
            }
            return between;
        }
    }
}
