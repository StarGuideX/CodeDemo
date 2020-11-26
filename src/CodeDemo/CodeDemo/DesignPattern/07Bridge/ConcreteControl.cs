using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._07Bridge
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class ConcreteControl : RemoteControl
    {
        public ConcreteControl(TV tv) : base(tv) 
        {
        }
    }
}
