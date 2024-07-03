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
        private void InitializeVisitsDataGridView()
        {
            visitsDataGridView.Columns.Clear();

            // Add VisitDate column
            DataGridViewTextBoxColumn visitDateColumn = new DataGridViewTextBoxColumn
            {
                Name = "visitDateColumn",
                HeaderText = "Visit Date",
                DataPropertyName = "VisitDate",
                ReadOnly = true
            };
            visitsDataGridView.Columns.Add(visitDateColumn);

            // Add Open Button column
            DataGridViewButtonColumn openButtonColumn = new DataGridViewButtonColumn
            {
                Name = "openButtonColumn",
                HeaderText = "Open",
                Text = "Open",
                UseColumnTextForButtonValue = true
            };
            visitsDataGridView.Columns.Add(openButtonColumn);
        }
        private void addVisitButton_Click(object sender, EventArgs e)
        {
            Visits visitControl = new Visits(patientId);
            //visitControl.SetPatientId(patientId); // Pass the patient ID to the Visits user control
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
                // Example: Get the visit date of the clicked row
                DataGridViewRow selectedRow = visitsDataGridView.Rows[e.RowIndex];
                string visitDate = selectedRow.Cells["visitDateColumn"].Value.ToString();

                // Example action: Show visit details in a MessageBox
                MessageBox.Show($"Visit Date: {visitDate}", "Visit Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LoadVisits(int patientId)
        {
            visitsDataGridView.Rows.Clear();
            try
            {
                DataTable visits = dbConnection.GetVisits(patientId);

                foreach (DataRow row in visits.Rows)
                {
                    DateTime visitDate = Convert.ToDateTime(row["VisitDate"]);
                    int rowIndex = visitsDataGridView.Rows.Add();
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
