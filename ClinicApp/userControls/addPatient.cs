using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.userControls
{
    public partial class addPatient : UserControl


    {
        private DataConnection dataConnection;
        private string dbRelativePath = @"Resources\Data\database.sqlite";
        public addPatient()
        {
            InitializeComponent();
            dataConnection = new DataConnection();
            combo_gender.Items.Add("Male");
            combo_gender.Items.Add("Female");
            combo_gender.SelectedIndex = 0;
            ShowNextPatientID();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ShowNextPatientID()
        {
            int nextID = GetNextPatientID();
            showID_label.Text = nextID.ToString();
        }

        private int GetNextPatientID()
        {
            int nextID = 1;
            string query = "SELECT MAX(Id) FROM Patients";
            DataTable dataTable = dataConnection.GetData(query);

            if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0] != DBNull.Value)
            {
                int lastID = Convert.ToInt32(dataTable.Rows[0][0]);
                nextID = lastID + 1;
            }

            return nextID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void addPatient_Load(object sender, EventArgs e)
        {

        }

        private void combo_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the fields
                string name = text_name.Text.Trim();
                string gender = combo_gender.SelectedItem?.ToString(); // Assuming combo_gender is properly populated
                bool referred = radio_referral.Checked; // Assuming radio_referral is a RadioButton for referral selection
                string contact = masked_contact.Text.Trim();
                string ageText = text_age.Text.Trim();

                // Validate the inputs
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(gender) ||
                    string.IsNullOrEmpty(contact) ||
                    string.IsNullOrEmpty(ageText))
                {
                    throw new ArgumentException("Please fill in all required fields.");
                }

                if (!int.TryParse(ageText, out int age))
                {
                    throw new ArgumentException("Please enter a valid age.");
                }

                // Check if patient name already exists
                if (dataConnection.PatientNameExists(name))
                {
                    throw new ArgumentException("Patient name already exists. Please enter a different name.");
                }

                // Insert data into database
                dataConnection.InsertPatient(name, gender, referred, contact, age);

                // Optionally clear fields after saving
                ClearFields();

                MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowNextPatientID();
        }
        private void ClearFields()
        {
            text_name.Text = "";
            text_age.Text = "";
            combo_gender.SelectedIndex = 0; // Clear selection in ComboBox
            radio_referral.Checked = false;
            masked_contact.Text = "";
            // Clear other fields as needed
        }

        private void showID_label_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
