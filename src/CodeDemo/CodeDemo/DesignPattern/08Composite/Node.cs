using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._08Composite
{
    /// <summary>
    /// Component
    /// </summary>
    public interface Node
    {
        void Add(Node node);
        void Remove(Node node);
        Node GetChild(int index);
        void Operation();
    }
}
