using System.Windows.Forms;

namespace ClinicApp.userControls
{
    partial class Patients
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchText = new TextBox();
            deleteBtn = new Button();
            patientsDataGridView = new DataGridView();
            refreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchText.Location = new Point(241, 42);
            searchText.Name = "searchText";
            searchText.Size = new Size(578, 31);
            searchText.TabIndex = 0;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteBtn.BackColor = Color.White;
            deleteBtn.Location = new Point(837, 37);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(177, 40);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // patientsDataGridView
            // 
            patientsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            patientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientsDataGridView.BackgroundColor = Color.White;
            patientsDataGridView.ColumnHeadersHeight = 34;
            patientsDataGridView.GridColor = SystemColors.MenuBar;
            patientsDataGridView.Location = new Point(58, 115);
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.RowHeadersWidth = 62;
            patientsDataGridView.Size = new Size(956, 688);
            patientsDataGridView.TabIndex = 2;
            patientsDataGridView.CellContentClick += patientsDataGridView_CellContentClick;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.White;
            refreshBtn.Location = new Point(58, 37);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(157, 36);
            refreshBtn.TabIndex = 3;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(refreshBtn);
            Controls.Add(searchText);
            Controls.Add(deleteBtn);
            Controls.Add(patientsDataGridView);
            Name = "Patients";
            Size = new Size(1064, 845);
            Load += Patients_Load;
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private Button refreshBtn;
    }
}
