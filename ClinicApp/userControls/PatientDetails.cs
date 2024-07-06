using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.userControls
{
    public partial class PatientDetails : UserControl
    {
        private int patientId;
        private DataConnection dbConnection;
        public PatientDetails(int id)
        {
            InitializeComponent();
            patientId = id;
            dbConnection = new DataConnection();
            InitializeVisitsDataGridView();
            LoadVisits(patientId);

        }

        private void detailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void SetPatientDetails(int id, string name, string gender, bool referredFromOtherDoctors, string contactNumber, int age)
        {
            idLabel.Text = "ID: " + id.ToString();
            nameLabel.Text = "Name: " + name;
            genderLabel.Text = "Gender: " + gender;
            contactLabel.Text = "Contact: " + contactNumber;
            dobLabel.Text = "Age: " + age.ToString();
            referredLabel.Text = $"Referred: {(referredFromOtherDoctors ? "Yes" : "No")}";
            // Additional details can be set here
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            HomePage mainForm = (HomePage)this.ParentForm;
            mainForm.LoadUserControl(patients);
        }

        private void addVisitButton_Click(object sender, EventArgs e)
        {
            Visits visitControl = new Visits(patientId, -1); // Passing -1 for new visit
            visitControl.SetPreviousControl(this);
            HomePage mainForm = (HomePage)this.ParentForm;
            mainForm.LoadUserControl(visitControl);
        }



        private void visitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the button cell
            if (e.RowIndex >= 0 && e.ColumnIndex == visitsDataGridView.Columns["openButtonColumn"].Index)
            {
                // Handle button click action
                DataGridViewRow selectedRow = visitsDataGridView.Rows[e.RowIndex];
                int visitId = Convert.ToInt32(selectedRow.Cells["visitIdColumn"].Value);

                // Open the visit details in the Visits user control
                Visits visitControl = new Visits(patientId, visitId);
                visitControl.SetPreviousControl(this);
                HomePage mainForm = (HomePage)this.ParentForm;
                mainForm.LoadUserControl(visitControl);
            }
        }



        private void InitializeVisitsDataGridView()
        {
            visitsDataGridView.Columns.Clear();
            visitsDataGridView.AllowUserToAddRows = false;

            // Add VisitID column
            DataGridViewTextBoxColumn visitIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "visitIdColumn",
                HeaderText = "Visit ID",
                DataPropertyName = "Id",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            visitsDataGridView.Columns.Add(visitIdColumn);

            // Add VisitDate column
            DataGridViewTextBoxColumn visitDateColumn = new DataGridViewTextBoxColumn
            {
                Name = "visitDateColumn",
                HeaderText = "Visit Date",
                DataPropertyName = "VisitDate",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            visitsDataGridView.Columns.Add(visitDateColumn);

            // Add Open Button column
            DataGridViewButtonColumn openButtonColumn = new DataGridViewButtonColumn
            {
                Name = "openButtonColumn",
                HeaderText = "",
                Text = "Open",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
            visitsDataGridView.Columns.Add(openButtonColumn);
        }


        public void LoadVisits(int patientId)
        {
            visitsDataGridView.Rows.Clear();
            try
            {
                DataTable visits = dbConnection.GetVisits(patientId);
                Debug.WriteLine($"Visits count: {visits.Rows.Count}");

                // Sort the DataTable by VisitDate in descending order
                visits.DefaultView.Sort = "VisitDate DESC";
                visits = visits.DefaultView.ToTable();

                foreach (DataRow row in visits.Rows)
                {
                    int visitId = Convert.ToInt32(row["Id"]);
                    DateTime visitDate = Convert.ToDateTime(row["VisitDate"]);
                    int rowIndex = visitsDataGridView.Rows.Add();
                    visitsDataGridView.Rows[rowIndex].Cells["visitIdColumn"].Value = visitId.ToString();
                    visitsDataGridView.Rows[rowIndex].Cells["visitDateColumn"].Value = visitDate.ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading visits: {ex.Message}");
            }
        }


    }
}
