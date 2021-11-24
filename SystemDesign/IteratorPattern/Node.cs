using System.Collections.Generic;

namespace SystemDesign.IteratorPattern
{
    public class Node
    {
        public int value;
        public Node parent;

        public List<Node> Childs { get; set; } = new List<Node>();

        public Node(int value, Node parent)
        {
            this.value = value;
            this.parent = parent;

            if (parent != null)
            {
                parent.Childs.Add(this);
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
