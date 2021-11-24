using System.Collections;

namespace SystemDesign.IteratorPattern
{
    public abstract class TreeIteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
