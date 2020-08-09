namespace Singleton
{
    public sealed class Singleton
    {
        private Singleton _current;

        private Singleton Instance {
            get{
                if(this._current == null)
                    _current = new Singleton();
                return _current;
            }
        }

        private Singleton(){
           
        }

    }
}