using System.Collections;
using System.Collections.Generic;

namespace SystemDesign.IteratorPattern
{
    public abstract class TreeIterator : IEnumerator
    {
        protected Tree tree;
        protected List<Node> traversalList;
        protected int _index = -1;

        public TreeIterator(Tree tree)
        {
            this.tree = tree;
        }

        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }
}
