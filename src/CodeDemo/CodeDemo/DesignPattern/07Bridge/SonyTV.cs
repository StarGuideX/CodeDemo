using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._07Bridge
{
public class SonyTV : TV
{
    public override void Off()
    {
        Console.WriteLine("Excuting SonyTV Off");
    }

    public override void On()
    {
        Console.WriteLine("Excuting SonyTV On");
    }

    public override void TuneChannel(Channel channel)
    {
        Console.WriteLine("Excuting SonyTV TuneChannel,Channel:{0}", channel.Name);
    }
}
}
