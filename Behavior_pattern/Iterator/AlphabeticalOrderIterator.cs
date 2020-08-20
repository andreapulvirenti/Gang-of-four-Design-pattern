using System;

namespace Iterator
{
    public class AlphabeticalOrderIterator : AIterator
    {
        private int _position = -1;
        private bool _reverse = false;
        private TripCollection _collection;
        public AlphabeticalOrderIterator(TripCollection collection, bool reverse)
        {
            _collection = collection ;
            _reverse  = reverse;
            if (reverse)
                this._position = collection.getItems().Count;
        }

        public override object Current()
        {
            return this._collection.getItems()[_position];
        }
        public override int Key()
        {
            return this._position;
        }
        public override bool MoveNext()
        {
            int newPosition = this._position + (this._reverse ? -1 : 1);
            if (newPosition >= 0 && newPosition < this._collection.getItems().Count)
            {
                this._position = newPosition;
                return true;
            }

            return false;
        }
        public override void Reset()
        {
            this._position = _reverse ? this._collection.getItems().Count - 1 : 0;
        }

    }
}