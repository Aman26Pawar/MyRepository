using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Program
    {
        //public int swap(int , int );
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2st number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Before swapping a is {0} and b is {1}",a,b);
           /* c = a + b;
            Console.WriteLine(c);*/

            swapping s = new swapping();
            s.swap(a, b);
           // Console.WriteLine("\n Before swapping a is {0} and b is {1}", a, ref b);
          
            Console.Read();
        }
      
    }

    class swapping
    {
        public void swap(int n1, int n2)
        {
            int temp = 0;

            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("\n After swapping a is {0} and b is {1}", n1, n2);
        }
    }
}
