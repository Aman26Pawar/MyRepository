using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class CalculatorFunctions
    {

        public int Addition(int num1, int num2,AccessingClass acc)
        {
            string s = acc.AccessFunction();
            if(s != null)
            {
                num1 = 10;
            }
            int addResult = num1 + num2;
            return addResult;
        }

        public int Division(int num1, int num2)
        {
            int divResult = num1 / num2;
            return divResult;
        }
    }
}
