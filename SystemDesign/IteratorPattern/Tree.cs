using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SystemDesign.IteratorPattern
{

    public class Tree : TreeIteratorAggregate
    {
        public Node root;

        public Tree(Node root)
        {
            this.root = root;
        }

        public override IEnumerator GetEnumerator()
        {
            return new TreeLevelorderIterator(this);
        }

        public List<Node> GetLevelorder()
        {
            List<Node> list = new List<Node>
            {
                root
            };

            LevelOrder(root, list);

            return list;
        }

        private void LevelOrder(Node current, List<Node> list)
        {
            if (current == null)
                return;
            foreach (var node in current.Childs)
            {
                list.Add(node);
            }
            foreach (var node in current.Childs)
            {
                LevelOrder(node, list);
            }
        }
    }
}
