using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public abstract class AIterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract object Current();
        public abstract int Key();
        public abstract bool MoveNext();
        public abstract void Reset();


    }
}