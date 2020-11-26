using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._06Adapter.ObjectAdapter
{
    public class TwoPhasePlugAdapter : ThreePhasePlug
    {
        TwoPhasePlug twoPhasePlug;

        public TwoPhasePlugAdapter(TwoPhasePlug two)
        {
            twoPhasePlug = two;
        }

        public void ToPowerUseThreePhasePlug()
        {
            twoPhasePlug.ToPowerUseTwoPhasePlug();
        }
    }
}
