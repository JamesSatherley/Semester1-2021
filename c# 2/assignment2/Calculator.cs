using System;
using System.Numerics;

namespace assignment2
{
    public class Calculator
    {
        public Complex Add(double[] in_x, double[] in_y) // defines x,y with given inputs, returns addition using Complex
        {
            Complex x = new Complex(in_x[0], in_x[1]);
            Complex y = new Complex(in_y[0], in_y[1]);
            return Complex.Add(x, y);
        }

        public Complex Subtract(double[] in_x, double[] in_y) // defines x,y with given inputs, returns subtraction using Complex
        {
            Complex x = new Complex(in_x[0], in_x[1]);
            Complex y = new Complex(in_y[0], in_y[1]);
            return Complex.Subtract(x, y);
        }
        public Complex Multiply(double[] in_x, double[] in_y) // defines x,y with given inputs, returns multiplication using Complex
        {
            Complex x = new Complex(in_x[0], in_x[1]);
            Complex y = new Complex(in_y[0], in_y[1]);
            return Complex.Multiply(x, y);
        }
        public Complex Divide(double[] in_x, double[] in_y) // defines x,y with given inputs, returns division using Complex
        {
            if (in_x[0] == 0 && in_x[1] == 0 && in_y[0] == 0 && in_y[1] == 0) // checks if numbers are zero. if they are all zero returns 0
            {
                return new Complex(0, 0);
            }
            else
            {
                Complex x = new Complex(in_x[0], in_x[1]); // else returns normal calculation
                Complex y = new Complex(in_y[0], in_y[1]);
                return Complex.Divide(x, y);
            }
        }
        public Complex Sqrt(double[] in_x) // defines x with given input, returns sqrt using Complex
        {
            Complex x = new Complex(in_x[0], in_x[1]);
            return Complex.Sqrt(x);
        }
    }
}
