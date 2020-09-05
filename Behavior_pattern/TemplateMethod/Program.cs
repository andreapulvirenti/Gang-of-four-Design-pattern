using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ADataReader dr1 = new SQLDataReader("provider=Microsoft.JET.OLEDB.4.0;data source=..\\..\\..\\db1.mdb");
            ADataReader dr2 = new RedisDataReader("redis://localhost:6379?ConnectTimeout=5000&IdleTimeOutSecs=180");

            dr1.ReadData();
            dr2.ReadData();
        }
    }
}
