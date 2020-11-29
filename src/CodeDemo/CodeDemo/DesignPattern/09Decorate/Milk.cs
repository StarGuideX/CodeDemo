using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._09Decorate
{
    public class Milk : CondimentDecorate
    {
        public Milk(Beverage beverage) : base(beverage)
        {

        }

        public double AddMilk()
        {
            return 5d;
        }

        public override double Cost()
        {
            return base.Cost() + AddMilk();
        }
    }
}
