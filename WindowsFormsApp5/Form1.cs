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
        bool firstinit = true;
        bool opperatoradd = false;
        bool opperatorsub = false;
        bool opperatormult = false;
        bool opperatordiv = false;
        int num2 = 0;
        int num1 = 0;
        bool firstinitCalc = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (firstinit) {num1 = 9;  firstinit = false; this.Display.Text = num1.ToString();}
            else
            {
                num2 = 9;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 8; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 8;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 7; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 7;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 6; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 6;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 5; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 5;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 4; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 4;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 3; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 3;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 2; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 2;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 1; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 1;
                this.Display.Text = num2.ToString();
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (firstinit) { num1 = 0; firstinit = false; this.Display.Text = num1.ToString(); }
            else
            {
                num2 = 0;
                this.Display.Text = num2.ToString();
            }
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            opperatormult = true;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            opperatordiv = true;
        }

        private void subtrakt_Click(object sender, EventArgs e)
        {
            opperatorsub = true;
        }
        private void add_Click(object sender, EventArgs e)
        {
            opperatoradd = true;
        }

        private void Equalopperator_Click(object sender, EventArgs e)
        {

            if (opperatoradd) { Console.WriteLine("1, " + num1 + "," + num2); opperatoradd = false; calculator calculator = new calculator(num1); num1 = calculator.addition(num2); this.Display.Text = num1.ToString(); }
            else if (opperatorsub) { Console.WriteLine("2," + num1 + "," + num2); opperatorsub = false; calculator calculator = new calculator(num1); num1 = calculator.subtraktion(num2); this.Display.Text = num1.ToString(); }
            else if (opperatormult) { Console.WriteLine("3, " + num1 + "," + num2); opperatormult = false; calculator calculator = new calculator(num1); num1 = calculator.multiplication(num2); this.Display.Text = num1.ToString(); }
            else if (opperatordiv) { Console.WriteLine("4, " + num1 + "," + num2); opperatordiv = false; calculator calculator = new calculator(num1); num1 = calculator.division(num2); this.Display.Text = num1.ToString(); }
        }

        //ALTERNATIV LÖSNING: ta hela inputstring, konvertera till en lista, granska innehållet i listan . [tal1, operand, tal2], [1, +, 1], 
        //beräkna (input1, operand, input2)
    }
}
