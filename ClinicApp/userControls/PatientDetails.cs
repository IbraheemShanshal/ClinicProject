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
        
        public PatientDetails()
        {
            InitializeComponent();
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
        
        
    }
}
