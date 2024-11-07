using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class Complex
    {
        private int real;
        private int img;

        public Complex(/*this,*/int _real=0, int img=0)
        {
            real = _real;
            this.img = img;

        }

        public Complex(int num)
        {
            real = num;
            img = num;
        }
        public void SetReal(int Real)
        {
            real = Real;
        }
        public void SetImaginary(int Img)
        {
            img = Img;
        }

        public int GetReal()
        {
            return real;
        }
        public int GetImaginary()
        {
            return img;
        }

        public Complex AddComplex(Complex right, Complex left)
        {
            Complex result = new();
            result.real = right.real + left.real;
            result.img = right.img + left.img;
            return result;
            // we can also simply do 
            // return new Complex(right.real + left.real, right.img + left.img);

        }

        public override string ToString()
        {
            string r = "", i = "";
            r = real != 0 ? $"{real}" : "";
            i = img != 0 ? $"{img}i" : "";

            if (img > 0 && real != 0)
            {
                i = $"+{i}";
            }
            return $"{r}{i}";
        }

    }
}
