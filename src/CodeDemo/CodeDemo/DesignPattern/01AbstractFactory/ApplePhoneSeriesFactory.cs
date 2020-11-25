using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._01AbstractFactory
{
    public class ApplePhoneSeriesFactory : PhoneSeriesFactory
    {
        public override Camera CreateCamera()
        {
            return new SonyCamera();
        }

        public override Cpu CreateCpu()
        {
            return new IntelCpu();
        }

        public override OperatingSystem CreateOperatingSystem()
        {
            return new IOSOperatingSystem();
        }

        public override RAM CreateRAM()
        {
            return new SamSungRAM();
        }
    }
}
