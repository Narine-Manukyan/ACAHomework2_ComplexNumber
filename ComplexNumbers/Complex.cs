using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class Complex
    {
        public MyPrimitive real;
        public MyPrimitive imaginary;

        //Parameterless Constructor
        public Complex()
        {
            this.real = (MyPrimitive)0;
            this.imaginary = (MyPrimitive)0;
        }

        //Constructor with 2 parameters
        public Complex(MyPrimitive real, MyPrimitive imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        //Declaring operator+
        public static Complex operator+(Complex number1, Complex number2)
        {
            return new Complex(number1.real + number2.real, number1.imaginary + number2.imaginary);
        }

        //Declaring operator-
        public static Complex operator -(Complex number1, Complex number2)
        {
            return new Complex(number1.real - number2.real, number1.imaginary - number2.imaginary);
        }

        //Declaring operator*
        public static Complex operator *(Complex number1, Complex number2)
        {
            return new Complex(number1.real * number2.real - number1.imaginary * number2.imaginary,
                number1.real * number2.imaginary + number1.imaginary * number2.real);
        }

        //Declaring operator/
        public static Complex operator /(Complex number1, Complex number2)
        {
            MyPrimitive Denominator = number2.real * number2.real + number2.imaginary * number2.imaginary;
            if (Denominator.number != 0)
            {
                return new Complex((number1.real * number2.real + number1.imaginary * number2.imaginary) / Denominator,
                    (number2.real * number1.imaginary - number2.imaginary * number1.real) / Denominator);
            }
            else
                return null;//Division by 0
        }

        //Calculating an Absolute Value
        public MyPrimitive Absolute()
        {
            return (MyPrimitive)Math.Sqrt(imaginary.number * imaginary.number + real.number * real.number); 
        }

        //Find Argument
        public MyPrimitive Argument()
        {
                return (MyPrimitive)Math.Atan2(imaginary.number, real.number);
        }

        //Overriding Method ToString()
        public override string ToString()
        {
            return this.real + " + " + this.imaginary + "i";
        }
    }
}