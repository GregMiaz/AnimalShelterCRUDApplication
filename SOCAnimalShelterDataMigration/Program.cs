using SOCAnimalShelterDataMigration.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            var migrationController = new MigrationController();
            migrationController.FileToDatabaseMigration("c:\\data\\animals.txt");
            Console.WriteLine("Well done, data is successfully transfered to database.");
        }
    }
}
