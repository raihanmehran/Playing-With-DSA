using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp6
{
    public class Generics1<T>
    {
        // public void Add<T>(T a, T b) : when you want a function to be generic, but in this case the class is generic
        public void Add(T a, T b)
        {
            /* var vs dynamic
                var defines the the type in compile while dynamic defines the type in run-time

            */
            dynamic d1 = a;
            dynamic d2 = b;

            Console.WriteLine($"{a} + {b} = {d1 + d2}");
        }

        public void Sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;

            Console.WriteLine($"{a} - {b} = {d1 - d2}");
        }

    }
}