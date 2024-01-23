using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.DesignDbConnection
{
    public class OracleConnection :DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void closingConnection()
        {
            Console.WriteLine("closing Oracle connection");
        }

        public override void openingConnection()
        {
            Console.WriteLine("opening Oracle connection");
        }
    }
}
