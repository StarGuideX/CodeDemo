using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._02Builder
{
    public class BuilderClient
    {
        public void ConstructDrink()
        {
            DrinkMaker drinkMaker = new TeaDrinkMaker();

            TeaDrink teaDrink = drinkMaker
                .AddHoney()
                .AddLemon()
                .AddTea()
                .GetDrink();

            teaDrink.ToString();
        }
    }
}
