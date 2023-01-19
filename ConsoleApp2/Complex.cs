using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Complex : Pair
    {
        public Complex(double a, double b) : base(a, b)
        {
        }

        public override Pair Add(Pair p)
        {
            return new Complex(this.A+p.A,this.B+p.B);
        }

        public override Pair Sub(Pair p)
        {
            return new Complex(this.A-p.A,this.B-p.B);
        }

        public override Pair Div(Pair p)
        {
            return new Complex((this.A * p.A+ this.B * p.B)/(Math.Pow(p.A, 2) + Math.Pow(p.B, 2)), (this.B * p.A - this.A * this.B)/ (Math.Pow(p.A, 2) + Math.Pow(p.B, 2)));
        }

        public override Pair Mul(Pair p)
        {
            return new Complex((this.A * p.A - this.B * p.B), (this.B * p.B) + (this.B * p.A));
        }
        public override bool Equ(Pair p)
        {
            if (this.A == p.A && this.B == p.B) return true;
            else return false;
        }
        public override Pair Conj()
        {
            return new Complex(this.A, -this.B);
        }
        public override string? ToString()
        {
            return this.A+"+"+this.B+"i";
        }
    }
}
