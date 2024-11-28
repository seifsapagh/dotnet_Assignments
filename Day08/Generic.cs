using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Generic<T>
    {
        public void show(T x)
        {
            Console.WriteLine($"{x}, type = {x.GetType()}");
        }
    }
}
