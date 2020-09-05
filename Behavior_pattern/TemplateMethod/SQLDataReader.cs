using System;

namespace TemplateMethod
{
    public class SQLDataReader : ADataReader
    {

        private string dataBaseName = "";
        private string tableName = "";
        public SQLDataReader(string connectionstring) : base(connectionstring)
        {

        }

        public override void ConnectToDb()
        {
            Console.WriteLine($"{nameof(SQLDataReader)} is connecting on DB properly");
        }
        public override void SetConfiguration()
        {
            dataBaseName = "CoreDb";
            tableName = "Table1";
        }
        public override string ReadTable()
        {
            Console.WriteLine($"I'm reading the table on db {dataBaseName} {this.tableName}");
            return "SQL TABLE CONTENT";
        }




    }
}