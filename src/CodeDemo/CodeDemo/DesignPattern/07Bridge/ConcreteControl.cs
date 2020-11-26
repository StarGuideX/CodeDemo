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

        public override void On()
        {
            _tv.On();
        }

        public override void Off()
        {
            _tv.Off();
        }

        //public override void SetChannel(int )
        //{
        //    _tv.SetChannel();
        //}
    }
}
