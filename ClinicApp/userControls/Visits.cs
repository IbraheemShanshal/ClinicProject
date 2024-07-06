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
    public partial class Visits : UserControl
    {
        private DataConnection dataConnection;
        private int patientId;
        private int visitId;
        public Visits(int id, int visitId)
        {
            InitializeComponent();
            dataConnection = new DataConnection();
            patientId = id;
            this.visitId = visitId;
            LoadVisitDetails();
        }
        private UserControl previousControl;
        // Method to set the previous control that needs to be navigated back to
        public void SetPreviousControl(UserControl control)
        {
            previousControl = control;
        }
        private void LoadVisitDetails()
        {
            // Load visit details based on visitId
            DataRow visitRow = dataConnection.GetVisitDetails(visitId);
            if (visitRow != null)
            {
                visitDatePicker.Value = Convert.ToDateTime(visitRow["VisitDate"]);
                doctorNotesTextBox.Text = visitRow["DoctorNotes"].ToString();
                prescriptionTextBox.Text = visitRow["Prescription"].ToString();
            }
        }
        private void labelPrescription_Click(object sender, EventArgs e)
        {

        }

        private void doctorNotesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (previousControl != null)
            {
                HomePage mainForm = (HomePage)this.ParentForm;
                mainForm.LoadUserControl(previousControl);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from UI elements
                DateTime visitDate = visitDatePicker.Value;
                string doctorNotes = doctorNotesTextBox.Text.Trim();
                string prescription = prescriptionTextBox.Text.Trim();

                // Validate required fields (if necessary)

                // Insert visit data into database and get the new visit ID
                int newVisitId = dataConnection.InsertVisit(patientId, visitDate, doctorNotes, prescription);

                MessageBox.Show("Visit added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload the Visits control with the new visit ID
                Visits visitControl = new Visits(patientId, newVisitId);
                visitControl.SetPreviousControl(this);
                HomePage mainForm = (HomePage)this.ParentForm;
                mainForm.LoadUserControl(visitControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void prescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
