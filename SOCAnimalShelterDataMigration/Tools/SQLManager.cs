using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Tools
{
    internal class SQLManager
    {
        private string _connectionString;

        public SQLManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<string> ReadData(string sql)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();

            var result = new List<string>();

            while (dataReader.Read())
            {
                string row = "";
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    row += Convert.ToString(dataReader.GetValue(i)) + ";";
                }
                result.Add(row);
            }

            dataReader.Close();
            command.Dispose();
            connection.Close();

            return result;
        }

        public int WriteData(string sql)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            int modifiedRows = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();

            return modifiedRows;
        }
    }
}
