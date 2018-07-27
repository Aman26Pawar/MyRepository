using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCsharpDemo1.Mathss
{
    class Calculations
    {
        private int _radius;

        public Calculations(int rad)
        {
            _radius = rad;
        }
        public int Radius
        {
          get { return _radius; }
          set { _radius = value; }
        }






        public void AreaCircum(int rad, out double area, out double circum)
        {
            area =3.14 * rad * rad;
            circum =2 * 3.14 * rad;
            Console.WriteLine("Area of cicle is :{0} \n Circumference of circle is: {1} \n", area, circum);
        }

    }
}
