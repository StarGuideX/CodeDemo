using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._02Builder
{
    public abstract class DrinkMaker
    {
        public abstract DrinkMaker AddTea();
        public abstract DrinkMaker AddLemon();
        public abstract DrinkMaker AddHoney();
        public abstract TeaDrink GetDrink();
    }
}
