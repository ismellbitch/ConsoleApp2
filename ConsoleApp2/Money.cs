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
            else return new Money(this.A + p.A + 1, (this.B + p.B));
        }

        public override Pair Div(Pair p)
        {
                return new Money(this.A / p.A, this.B / p.B);
        }

        public override Pair Mul(Pair p)
        {
            if (this.B * p.B < 100)
            {
                return new Money(this.A * p.A, this.B * p.B);
            }
            else
            {
                double temp = this.B * p.B / 100;
                return new Money(this.A * p.A + temp, (this.B * p.B) - temp * 100);
            }
        }

        public override Pair Sub(Pair p)
        {
            if (this.A - p.A >= 0 && this.B - p.B < 0)
            {
                return new Money(this.A - p.A - 1, ((this.B + 100) - p.B));
            }
            else if (this.A - p.A < 0)
            {
                return new Money(0, 0);
            }
            else return new Money(this.A + p.A + 1, (this.B + p.B));
        }
    }
}
