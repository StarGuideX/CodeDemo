using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._02Builder
{
    public class TeaDrink
    {
        public bool HasTea { get; set; }
        public bool HasLemon { get; set; }
        public bool HasHoney { get; set; }

        public override string ToString()
        {
            return String.Format("HasTea:{0};HasLemon:{1};HasHoney:{2}", HasTea, HasLemon, HasHoney);
        }
    }
}
