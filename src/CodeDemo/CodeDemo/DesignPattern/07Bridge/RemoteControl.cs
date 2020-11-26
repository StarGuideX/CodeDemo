﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._07Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public class RemoteControl
    {
        protected TV _tv;
        public RemoteControl(TV tv)
        {
            _tv = tv;
        }

        public virtual void On()
        {
            _tv.On();
        }
        public virtual void Off()
        {
            _tv.Off();
        }
        public virtual void SetChannel()
        {
            _tv.TuneChannel();
        }
    }
}
