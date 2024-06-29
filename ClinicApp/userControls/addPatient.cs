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
    public partial class addPatient : UserControl


    {
        private DataConnection dataConnection;
        private string dbRelativePath = @"Resources\Data\database.sqlite";
        public addPatient()
        {
            InitializeComponent();
            dataConnection = new DataConnection(dbRelativePath);
            combo_gender.Items.Add("Male");
            combo_gender.Items.Add("Female");
            combo_gender.SelectedIndex = 0;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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
            string name = text_name.Text;
            string gender = combo_gender.SelectedItem.ToString(); // Assuming combo_gender is properly populated
            bool referred = radio_referral.Checked; // Assuming radio_referral is a RadioButton for referral selection
            string contact = masked_contact.Text.Trim();
            int age = Convert.ToInt32(text_age.Text);

            // Insert data into database
            dataConnection.InsertPatient(name, gender, referred, contact, age);

            // Optionally clear fields after saving
            ClearFields();
        }
        private void ClearFields()
        {
            text_name.Text = "";
            text_age.Text = "";
            combo_gender.SelectedIndex = -1; // Clear selection in ComboBox
            radio_referral.Checked = false;
            masked_contact.Text = "";
            // Clear other fields as needed
        }
    }
}
