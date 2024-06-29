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
        private string dbRelativePath = @"Resources\Data\database.sqlite";
        private string dbPath;
        public Patients()
        {
            InitializeComponent();
            dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbRelativePath);
            dbConnection = new DataConnection(dbPath);
            string query = "SELECT * FROM Patients";
            DataTable dataTable = dbConnection.GetData(query);

            // Bind DataTable to DataGridView
            patientsDataGridView.DataSource = dataTable;
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
