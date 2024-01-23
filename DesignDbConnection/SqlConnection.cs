using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.DesignDbConnection
{
    public class SqlConnection : DbConnection

    {
        public SqlConnection(string connectionString):base(connectionString)
        {
            
        }
        public override void closingConnection()
        {
            Console.WriteLine("closing SQL connection");
        }

        public override void openingConnection()
        {
            Console.WriteLine("opening SQL connection");
        }
    }
}
