using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
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

        public void InsertPatient(string name, string gender, bool referredFromOtherDoctors, string contactNumber, int age)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    int Id = GetNextPatientID();

                    command.CommandText = @"INSERT INTO Patients (Id, Name, Gender, ReferredFromOtherDoctors, ContactNumber, Age)
                                            VALUES (@Id, @Name, @Gender, @ReferredFromOtherDoctors, @ContactNumber, @Age)";
                    command.Parameters.AddWithValue("@Id", Id);
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

        public void InsertVisit(int patientId, DateTime visitDate, string doctorNotes, string prescription)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Visits (PatientId, VisitDate, DoctorNotes, Prescription) " +
                               "VALUES (@PatientId, @VisitDate, @DoctorNotes, @Prescription)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientId", patientId);
                    cmd.Parameters.AddWithValue("@VisitDate", visitDate);
                    cmd.Parameters.AddWithValue("@DoctorNotes", doctorNotes);
                    cmd.Parameters.AddWithValue("@Prescription", prescription);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataVisit(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }
        public int GetLastVisitId()
        {
            int lastVisitId = 0;
            string query = "SELECT Id FROM Visits ORDER BY Id DESC LIMIT 1";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lastVisitId = Convert.ToInt32(reader["Id"]);
                        }
                    }
                }
            }

            return lastVisitId;
        }
        public DataTable GetVisits(int patientId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Id, VisitDate FROM Visits WHERE PatientID = @patientId";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataRow GetVisitDetails(int visitId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Visits WHERE Id = @visitId";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@visitId", visitId);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}
