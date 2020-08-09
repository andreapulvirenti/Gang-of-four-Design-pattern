namespace Singleton
{
    public class SingletonThreadSafe2
    {

        private SingletonThreadSafe2 _current;
        private readonly object padLock = new object();

        public SingletonThreadSafe2 Instance
        {
            get
            {
                if (this._current == null)
                    _current = new SingletonThreadSafe2();
                return _current;
            }
        }

        private SingletonThreadSafe2()
        {

        }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonThreadSafe2()
        {

        }
    }
}