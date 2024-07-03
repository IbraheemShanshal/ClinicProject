using System.Data;
using System.Diagnostics;
using Microsoft.Data.Sqlite;

namespace ClinicApp
{
    public class DataConnection
    {
        private string connectionString;


        public DataConnection()
        {
                string dbRelativePath = @"Resources\Data\database.sqlite";
                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbRelativePath);
                connectionString = $"Data Source={dbPath}";
            //MessageBox.Show($"Database Path: {dbPath}"); // Show the database path for debug

        }

        public bool PatientNameExists(string name)
        {
            bool exists = false;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM Patients WHERE Name = @Name";
                    command.Parameters.AddWithValue("@Name", name);

                    long count = (long)command.ExecuteScalar();
                    if (count > 0)
                    {
                        exists = true;
                    }
                }
            }

            return exists;
        }
        public int ExecuteQuery(string query, object parameters = null)
        {
            int rowsAffected = 0;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    // Add parameters if provided
                    if (parameters != null)
                    {
                        var paramDict = parameters as IDictionary<string, object>;
                        if (paramDict != null)
                        {
                            foreach (var param in paramDict)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                    }

                    // Execute the query and get the number of affected rows
                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        private int GetNextPatientID()
        {
            int nextID = 1;
            string query = "SELECT MAX(Id) FROM Patients";
            DataTable dataTable = GetData(query);

            if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0] != DBNull.Value)
            {
                int lastID = Convert.ToInt32(dataTable.Rows[0][0]);
                nextID = lastID + 1;
            }

            return nextID;
        }


        public DataTable GetData(string query, string searchTerm = null)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    }

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        public void InsertPatient( string name, string gender, bool referredFromOtherDoctors, string contactNumber, int age)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    int Id = GetNextPatientID();

                    command.CommandText = @"INSERT INTO Patients (Id, Name, Gender, ReferredFromOtherDoctors, ContactNumber, Age)
                                            VALUES (@Id, @Name, @Gender, @ReferredFromOtherDoctors, @ContactNumber, @Age)";
                    command.Parameters.AddWithValue("@Id",Id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@ReferredFromOtherDoctors", referredFromOtherDoctors ? 1 : 0); // Store boolean as 1 or 0
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@Age", age);

                    int result = command.ExecuteNonQuery();
                    Debug.WriteLine($"InsertPatient Result: {result}");
                }
            }
        }
    }
}
