using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Pair
    {
        private double a;
        private double b;
        

        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }


        public Pair(double a, double b)
        {
            A = a;
            B = b;
        }

        public abstract Pair Add(Pair p);
        public abstract Pair Sub(Pair p);
        public abstract Pair Mul(Pair p);
        public abstract Pair Div(Pair p);
    }
}
