using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._09Decorate
{
    public class Americano : CondimentDecorate
    {
        public Americano(Beverage beverage) : base(beverage)
        {

        }
        public double AddCoffeeCherry()
        {
            return 10d;
        }

        public override double Cost()
        {
            return base.Cost() + AddCoffeeCherry();

        }
    }
}
