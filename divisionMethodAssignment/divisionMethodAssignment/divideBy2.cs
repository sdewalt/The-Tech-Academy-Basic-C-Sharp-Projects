using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisionMethodAssignment
{
    class divideBy2
    {
        public int Divide(int Input)
        {
            return Input / 2
            ;
        }

        //Method with output parameters and overload
        public void Multiplication(int a, out int b)

        {
            a = 6;
            b = 4;
           
        }

        public void Multiplication(double x, float y, int a)
        {
            x = .78;
            y = .97696f;

            Console.WriteLine("x Value: {0}", x);
            Console.WriteLine("y Value: {0}", y);
            Console.ReadLine();
        }

    }
}
