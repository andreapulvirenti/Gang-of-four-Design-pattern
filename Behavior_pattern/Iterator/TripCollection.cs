
using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class TripCollection : AIteratorAggregate
    {
        private bool _direction = false;
        List<Trip> _collection = new List<Trip>();

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<Trip> getItems()
        {
            return _collection;
        }

        public void AddItem(Trip item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}