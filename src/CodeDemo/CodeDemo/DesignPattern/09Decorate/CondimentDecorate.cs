using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._09Decorate
{
    /// <summary>
    /// Decorate
    /// </summary>
    public abstract class CondimentDecorate : Beverage
    {
        private Beverage _beverage;
        public CondimentDecorate(Beverage beverage) 
        {
            _beverage = beverage;
        }
        public virtual double Cost()
        {
            return _beverage.Cost();
        }
    }
}
