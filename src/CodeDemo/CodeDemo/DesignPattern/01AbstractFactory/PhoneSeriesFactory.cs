using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._01AbstractFactory
{
    public abstract class PhoneSeriesFactory
    {
        public abstract Cpu CreateCpu();
        public abstract Camera CreateCamera();
        public abstract RAM CreateRAM();
        public abstract OperatingSystem CreateOperatingSystem();
    }
}
