using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.userControls


{
    public partial class Patients : UserControl
    {

        private DataConnection dbConnection;

        public Patients()
        {
            InitializeComponent();
            dbConnection = new DataConnection();
            string query = "SELECT * FROM Patients";
            DataTable dataTable = dbConnection.GetData(query);

            // Bind DataTable to DataGridView
            patientsDataGridView.DataSource = dataTable;
            LoadData(searchText.Text.Trim());
            patientsDataGridView.AllowUserToAddRows = false;
            patientsDataGridView.ReadOnly = true;
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

    

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            LoadData(searchText.Text.Trim());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = patientsDataGridView.SelectedRows[0];

                // Get patient details
                int patientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string patientName = selectedRow.Cells["Name"].Value.ToString();

                // Show confirmation dialog
                DialogResult result = MessageBox.Show($"Do you want to delete patient '{patientName}'?",
                                                      "Delete Patient",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform deletion logic
                    DeletePatient(patientId);

                    // Reload data after deletion
                    LoadData(searchText.Text.Trim());
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadData(string searchTerm)
        {
            string query = "SELECT Id, Name, Gender, ReferredFromOtherDoctors, ContactNumber, Age FROM Patients";

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " WHERE Name LIKE @searchTerm OR ContactNumber LIKE @searchTerm";
            }

            DataTable dataTable = dbConnection.GetData(query, searchTerm);

            // Transform the ReferredFromOtherDoctors column
            dataTable.Columns.Add("Referred", typeof(string));
            foreach (DataRow row in dataTable.Rows)
            {
                int referredValue = Convert.ToInt32(row["ReferredFromOtherDoctors"]);
                bool referredBool = (referredValue == 1);

                row["Referred"] = referredBool ? "true" : "false";
            }

            // Remove the original ReferredFromOtherDoctors column if you want
            dataTable.Columns.Remove("ReferredFromOtherDoctors");
            patientsDataGridView.DataSource = dataTable;
        }
        private void LoadPatientDetails(int id, string name, string gender, bool referredFromOtherDoctors, string contactNumber, int age)
        {
            PatientDetails patientDetails = new PatientDetails(id);

            // Set the patient details in the PatientDetails control
            patientDetails.SetPatientDetails(id, name, gender, referredFromOtherDoctors, contactNumber, age);

            // Assuming the parent form or control has a method to switch user controls
            HomePage mainForm = (HomePage)this.ParentForm;
            mainForm.LoadUserControl(patientDetails);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadData(searchText.Text.Trim());
        }
        public void DeletePatient(int patientId)
        {
            string query = "DELETE FROM Patients WHERE Id = @PatientId";

            // Create a dictionary to store parameters
            var parameters = new Dictionary<string, object>();
            parameters.Add("@PatientId", patientId);

            // Call the ExecuteQuery method to execute the delete query
            int rowsAffected = dbConnection.ExecuteQuery(query, parameters);

            // Optionally, you can check the rowsAffected value and handle success or failure accordingly
            if (rowsAffected > 0)
            {
                MessageBox.Show("Patient deleted successfully.");
                LoadData(searchText.Text.Trim()); // Refresh the patient list after deletion
            }
            else
            {
                MessageBox.Show("Failed to delete patient.");
            }
        }

        private void patientsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid cell and the cell is a button cell
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = sender as DataGridView;

                // Make sure dataGridView is not null
                if (dataGridView != null && dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // Get the row and column values
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                    int patientId = Convert.ToInt32(row.Cells["Id"].Value);
                    string patientName = row.Cells["Name"].Value.ToString();
                    string gender = row.Cells["Gender"].Value.ToString();
                    bool referredFromOtherDoctors = Convert.ToBoolean(row.Cells["Referred"].Value);
                    string contactNumber = row.Cells["ContactNumber"].Value.ToString();
                    int age = Convert.ToInt32(row.Cells["Age"].Value);

                    // Load the PatientDetails user control with the selected patient data
                    LoadPatientDetails(patientId, patientName, gender, referredFromOtherDoctors, contactNumber, age);
                }
            }
        }
    }
}
