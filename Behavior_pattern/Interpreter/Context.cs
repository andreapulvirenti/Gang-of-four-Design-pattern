namespace Interpreter
{
    public class Context
    {
        private string _input;
        private string _output;

        public Context(string input)
        {
            this._input = input;
        }

        public string Input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
            }
        }

        public string Output
        {
            get
            {
                return _output;
            }
            set
            {
                _output = value;
            }
        }

    }
}