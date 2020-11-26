using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._07Bridge
{
    /// <summary>
    /// Implementor
    /// </summary>
    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void TuneChannel();
    }
}
