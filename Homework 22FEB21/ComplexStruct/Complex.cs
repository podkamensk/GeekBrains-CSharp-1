using System;

namespace ComplexStruct
{
    struct Complex
    {
        public double re, im;

        public string Print()
        {
            if (re == 0 && im == 0)
                return "0";
            else if (re == 0)
                return $"{im}*i";
            else if (im == 0)
                return $"{re}";
            else if (im > 0)
                return $"{re} + {Math.Abs(im)}*i";
            else
                return $"{re} - {Math.Abs(im)}*i";
        }

        public static Complex Sum(Complex a, Complex b)
        {
            Complex c;
            c.re = a.re + b.re;
            c.im = a.im + b.im;
            return c;
        }

        public static Complex Subtract(Complex a, Complex b)
        {
            Complex c;
            c.re = a.re - b.re;
            c.im = a.im - b.im;
            return c;
        }

        public static Complex Multiply(Complex a, Complex b)
        {
            Complex c;
            c.re = a.re * b.re - a.im * b.im;
            c.im = a.re * b.im - b.re * a.im;
            return c;
        }

        public static Complex Divide(Complex a, Complex b)
        {
            Complex c;
            c.re = (a.re * b.re + a.im * b.im) / (b.re * b.re + b.im * b.im);
            c.im = (b.re * a.im - a.re * b.im) / (b.re * b.re + b.im * b.im);
            return c;
        }
    }
}
