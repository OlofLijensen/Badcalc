using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal class calculator
    {
        private int num1;
        internal calculator(int basenum)
        {
            this.num1 = basenum;
        }

        internal int addition(int num2)  { num1 += num2; return num1;  }
        internal int subtraktion (int num2) { num1 -= num2; return num1; }
        internal int multiplication(int num2) {num1 *= num2; return num1; }
        internal int division(int num2) { num1 /= num2; return num1; }
    }
}
