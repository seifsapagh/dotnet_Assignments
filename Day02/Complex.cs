///2-complex class , fields,S&G,P
///print   real +  img i
///

////r   i
///3    4   3+4i
///3   -4   3-4i
///3    1   3+i
///3   -1   3-i
///0    1   i
///0   -1   -i
///0   -4   -4i
///0   0    0
///10  0    10

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Complex
    {
        private int real;
        private int img;

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

        public override string ToString()
        {
            string r="", i="";
            r = real != 0 ? $"{real}" : "";
            i = img != 0 ? $"{img}i" : "";

            if(img > 0 && real != 0)
            {
                i = $"+{i}";
            }
            return $"{r}{i}";
        }

    }
}
