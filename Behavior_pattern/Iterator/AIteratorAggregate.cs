
using System;
using System.Collections;

namespace Iterator
{
    public abstract class AIteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}