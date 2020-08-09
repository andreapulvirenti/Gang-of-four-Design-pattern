namespace Singleton
{
    public class SingletonThreadSafe
    {

        private SingletonThreadSafe _current;
        private readonly object padLock = new object();

        public SingletonThreadSafe Instance
        {
            get
            {
                lock (padLock)
                {
                    if (this._current == null)
                        _current = new SingletonThreadSafe();
                }

                return _current;
            }
        }

        private SingletonThreadSafe()
        {

        }
    }
}