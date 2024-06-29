using System.Runtime.InteropServices;
using ClinicApp.userControls;

namespace ClinicApp
{
    public partial class HomePage : Form
    {


        userControls.addPatient addPatient = new userControls.addPatient();
        userControls.Patients patients = new userControls.Patients();
        public HomePage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // To allow dragging the window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            addPatient.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(addPatient);
        }

        private void searchPatient_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            patients.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(patients);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
