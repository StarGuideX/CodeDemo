using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._08Composite
{
    /// <summary>
    /// Leaf
    /// </summary>
    public class TextNode : Node
    {
        public void Add(Node node)
        {
            throw new NotSupportedException();
        }

        public Node GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public void Operation()
        {
            Console.WriteLine(this.GetHashCode());
        }

        public void Remove(Node node)
        {
            throw new NotSupportedException();
        }
    }
}
