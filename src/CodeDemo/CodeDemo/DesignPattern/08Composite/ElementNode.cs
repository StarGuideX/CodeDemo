using System;
using System.Collections.Generic;
using System.Text;

namespace CodeDemo.DesignPattern._08Composite
{
    /// <summary>
    /// Composite
    /// </summary>
    public class ElementNode : Node
    {
        private List<Node> children = new List<Node>();
        public void Add(Node node)
        {
            children.Add(node);
        }

        public Node GetChild(int index)
        {
            return children[index];
        }

        public void Operation()
        {
            foreach (var item in children)
            {
                item.Operation();
            }
        }

        public void Remove(Node node)
        {
            children.Remove(node);
        }
    }
}
