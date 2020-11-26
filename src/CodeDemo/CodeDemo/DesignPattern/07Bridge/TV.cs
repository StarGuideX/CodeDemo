using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._07Bridge
{
    public interface TV
    {
        public void On() { }
        public void Off() { }
        public void TuneChannel() { }
    }
}
