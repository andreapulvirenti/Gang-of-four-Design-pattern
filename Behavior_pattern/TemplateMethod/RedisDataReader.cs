using System;

namespace TemplateMethod
{
    public class RedisDataReader : ADataReader
    {

        private int port = 0;
        private int documentMaxCount = 0;
        public RedisDataReader(string connectionstring) : base(connectionstring)
        {

        }

        public override void ConnectToDb()
        {
            Console.WriteLine($"{nameof(RedisDataReader)} is connecting on DB properly");
        }

        public override void SetConfiguration()
        {
            port = 12900;
            documentMaxCount = 1000;
        }

        public override string ReadTable()
        {
            Console.WriteLine($"I'm reading the table on port {port} (max documents showable {this.documentMaxCount})");
            return "REDIS CONTENT";
        }

    }
}