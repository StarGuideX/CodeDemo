using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._07Bridge
{
    public abstract class RemoteControl : TV
    {
        protected TV _tv;
        public RemoteControl(TV tv) 
        {
            _tv = tv;    
        }

        public void On() 
        {
            _tv.On();
        }
        public void Off() 
        {
            _tv.Off();
        }
        public void SetChannel() 
        {
            _tv.TuneChannel();
        }
    }
}
