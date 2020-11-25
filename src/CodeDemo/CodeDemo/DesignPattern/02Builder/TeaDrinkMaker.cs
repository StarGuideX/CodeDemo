using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._02Builder
{
    public class TeaDrinkMaker : DrinkMaker
    {
        private TeaDrinkMaker teaDrinkMaker = new TeaDrinkMaker();
        private TeaDrink teaDrink = new TeaDrink();

        public override DrinkMaker AddHoney()
        {
            teaDrink.HasHoney = true;
            return teaDrinkMaker;
        }

        public override DrinkMaker AddLemon()
        {
            teaDrink.HasLemon = true;
            return teaDrinkMaker;
        }

        public override DrinkMaker AddTea()
        {
            teaDrink.HasTea = true;
            return teaDrinkMaker;
        }

        public override TeaDrink GetDrink()
        {
            return teaDrink;
        }
    }
}
