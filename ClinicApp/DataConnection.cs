using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ClinicApp
{

    public class DataConnection
    {
        private string connectionString;

        public DataConnection(string dbPath)
        {
            connectionString = $"Data Source={dbPath}";
        }

        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        public void InsertPatient(string name, string gender, bool referredFromOtherDoctors, string contactNumber, int age)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO Patients (Name, Gender, ReferredFromOtherDoctors, ContactNumber, Age)
                                    VALUES (@Name, @Gender, @ReferredFromOtherDoctors, @ContactNumber, @Age)";
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@ReferredFromOtherDoctors", referredFromOtherDoctors ? 1 : 0); // Store boolean as 1 or 0
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@Age", age);

                    command.ExecuteNonQuery();
                }
            }
        }

    }


}
