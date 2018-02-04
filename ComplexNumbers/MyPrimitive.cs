using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public struct MyPrimitive
    {
        public double number;

        //Constructor with one parameter
        public MyPrimitive(double _number)
        {
            number = _number;
        }

        //Declaring operator+
        public static MyPrimitive operator +(MyPrimitive n1, MyPrimitive n2)
        {
            return new MyPrimitive(n1.number + n2.number);
        }

        //Declaring operator-
        public static MyPrimitive operator -(MyPrimitive n1, MyPrimitive n2)
        {
            return new MyPrimitive(n1.number - n2.number);
        }

        //Declaring operator*
        public static MyPrimitive operator *(MyPrimitive n1, MyPrimitive n2)
        {
            return new MyPrimitive(n1.number * n2.number);
        }

        //Declaring operator/
        public static MyPrimitive operator /(MyPrimitive n1, MyPrimitive n2)
        {
            return new MyPrimitive(n1.number / n2.number);
        }

        //Declaring Converter
        public static explicit operator MyPrimitive(double i)
        {
            MyPrimitive temp = new MyPrimitive(i);
            // code to convert from double to MyPrimitive...
            return temp;
        }

        //Overriding Method ToString()
        public override string ToString()
        {
            return this.number.ToString();
        }
    }
}
