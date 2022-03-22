using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }

        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }

        public void Multiply(Complex x)
        {
            Real *= x.Real;
            Imag *= x.Imag;
        }

        public void Divide(Complex x)
        {
            Real /= x.Real;
            Imag /= x.Imag;
        }
    }
}
