using System.Collections.Generic;

namespace SystemDesign.IteratorPattern
{
    // multiple concrete class inherits a abstract base class which may implement a interface
    // 
    public class TreeLevelorderIterator : TreeIterator
    {
        public TreeLevelorderIterator(Tree tree) : base(tree)
        {
            traversalList = tree.GetLevelorder();
        }

        public override object Current()
        {
            return traversalList[_index];
        }

        public override int Key()
        {
            return this._index;
        }

        public override bool MoveNext()
        {
            _index++;
            if (_index >= 0 && _index < traversalList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _index = -1;
        }
    }

    public class TreeInorderIterator : TreeIterator
    {
        public TreeInorderIterator(Tree tree) : base(tree)
        {

        }

        public override object Current()
        {
            throw new System.NotImplementedException();
        }

        public override int Key()
        {
            throw new System.NotImplementedException();
        }

        public override bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public override void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
