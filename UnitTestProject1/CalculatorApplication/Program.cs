using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            int addResult;
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            CalculatorFunctions cfun = new CalculatorFunctions();
            cfun.Addition(a, b, out addResult);

            Console.WriteLine(addResult);
        }

        //public static string addResult { get; set; }
    }
}
