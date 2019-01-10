using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Tools
{
    internal class ConnectionStringManager
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" + "Initial Catalog=Animals;" + "Integrated Security=True;";
        public static SQLManager NewSQLManager { get { return new SQLManager(connectionString); } }
    }
}
