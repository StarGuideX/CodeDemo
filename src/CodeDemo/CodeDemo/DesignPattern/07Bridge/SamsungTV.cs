using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._07Bridge
{
    public class SamsungTV : TV
    {
        public override void Off()
        {
            Console.WriteLine("Excuting SamsungTV Off");
        }

        public override void On()
        {
            Console.WriteLine("Excuting SamsungTV On");
        }

        public override void TuneChannel(Channel channel)
        {
            Console.WriteLine("Excuting SamsungTV TuneChannel,Channel:{0}", channel.Name);
        }
    }
}
