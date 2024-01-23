using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.DesignDbConnection
{
    public class DbCommand
    {
        public string instruction { get; set; }
        public DbConnection dbConnection { get; set; }
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if(!dbConnection.Equals(null) && !string.IsNullOrEmpty(instruction))
            {
                this.instruction = instruction;
                this.dbConnection = dbConnection;
            }
            
           
        }
        public void Execute() {

            dbConnection.openingConnection();
            Console.WriteLine("Running instructions {0}", instruction);
            dbConnection.closingConnection();
        }

    }
}
