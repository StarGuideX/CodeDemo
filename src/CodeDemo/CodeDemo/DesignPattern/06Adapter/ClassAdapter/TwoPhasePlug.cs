using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._06Adapter.ClassAdapter
{
    public abstract class TwoPhasePlug
    {
        public void ToPowerUseTwoPhasePlug() 
        {
            Console.WriteLine("Use TwoPhasePlug");
        }
    }
}
