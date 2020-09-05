namespace TemplateMethod
{
    public abstract class ADataReader
    {
        protected string Connectionstring { get; private set; }

        public ADataReader(string connString)
        {
            this.Connectionstring = connString;
        }

        public abstract void ConnectToDb();
        public abstract void SetConfiguration();
        public abstract string ReadTable();

        public string ReadData()
        {
            this.ConnectToDb();
            this.SetConfiguration();
            var res = this.ReadTable();
            this.Disconnect();

            return res;
        }

        public void Disconnect()
        {
            this.Connectionstring = string.Empty;
        }


    }
}