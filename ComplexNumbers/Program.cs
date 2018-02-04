using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPrimitive p1 = new MyPrimitive(5);
            MyPrimitive p2 = new MyPrimitive(6);
            MyPrimitive p3 = new MyPrimitive(8);
            MyPrimitive p4 = new MyPrimitive(3);

            Complex c1 = new Complex(p1, p2);
            Complex c2 = new Complex(p3, p4);

            Console.WriteLine("Sumary:\t" + (c1 + c2));
            Console.WriteLine("Subtraction:\t" + (c1 - c2));
            Console.WriteLine("Multiplication:\t" + (c1 * c2));
            Console.WriteLine("Divison:\t" + (c1 / c2));
            Console.WriteLine("Absolute Value:\t" + c1.Absolute());
            Console.WriteLine("Argument:\t" + c1.Argument());
        }
    }
}
