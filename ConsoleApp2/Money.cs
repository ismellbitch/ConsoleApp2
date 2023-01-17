using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Money : Pair
    {
        public Money(double a, double b) : base(a, b)
        {
        }
        public override Pair Add(Pair p)
        {
            
            if(this.B + p.B >= 100)
            {
                return new Money(this.A + p.A+1, (this.B + p.B) -100);
            }
        }

        public override Pair Div(Pair p)
        {
            return this.A / this.B;
        }

        public override Pair Mul(Pair p)
        {
            throw new NotImplementedException();
        }

        public override Pair Sub(Pair p)
        {
            throw new NotImplementedException();
        }
    }
}
