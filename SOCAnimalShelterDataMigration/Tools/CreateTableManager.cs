using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Tools
{
    public class CreateTableManager
    {
        private SQLManager _sqlManager;

        public CreateTableManager()
        {
            _sqlManager = ConnectionStringManager.NewSQLManager;
        }

        public void CreateAnimalTable()
        {     
                string sql = "If not exists (select name from sysobjects where name = 'Animals')" + 
                " create table Animals (Id int primary key identity (1,1) NOT NULL, Name nvarchar(50) NOT NULL," + 
                " Species nvarchar(50) NOT NULL, Weight int NOT NULL, Date_Of_Birth datetime2 NULL)";
                _sqlManager.WriteData(sql);            
        }
    }
}
