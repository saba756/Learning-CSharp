using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.DesignDbConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }

        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString) { 
            this.ConnectionString = connectionString;
        }

        public abstract void  openingConnection();
        public abstract void closingConnection();
    }
}
