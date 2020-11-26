using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._06Adapter.ClassAdapter
{
    public class PlugAdapter : TwoPhasePlug, ThreePhasePlug
    {
        public void ToPowerUseThreePhasePlug()
        {
            base.ToPowerUseTwoPhasePlug();
        }
    }
}
