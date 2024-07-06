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
            openButtonColumn = new DataGridViewButtonColumn();
            refreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchText.Location = new Point(241, 37);
            searchText.Name = "searchText";
            searchText.Size = new Size(578, 31);
            searchText.TabIndex = 0;
            searchText.Font = new Font("Segoe UI", 12F);
            searchText.TextChanged += searchText_TextChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteBtn.BackColor = Color.Crimson;
            deleteBtn.ForeColor = Color.White;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Location = new Point(837, 37);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(177, 40);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Font = new Font("Segoe UI", 12F);
            deleteBtn.MouseEnter += deleteBtn_MouseEnter;
            deleteBtn.MouseLeave += deleteBtn_MouseLeave;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // patientsDataGridView
            // 
            patientsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            patientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientsDataGridView.BackgroundColor = Color.White;
            patientsDataGridView.ColumnHeadersHeight = 34;
            patientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { openButtonColumn });
            patientsDataGridView.GridColor = SystemColors.MenuBar;
            patientsDataGridView.Location = new Point(58, 115);
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.RowHeadersWidth = 62;
            patientsDataGridView.Size = new Size(956, 688);
            patientsDataGridView.TabIndex = 2;
            patientsDataGridView.Font = new Font("Segoe UI", 12F);
            patientsDataGridView.CellContentClick += patientsDataGridView_CellContentClick_1;
            // 
            // openButtonColumn
            // 
            openButtonColumn.HeaderText = "";
            openButtonColumn.MinimumWidth = 8;
            openButtonColumn.Name = "openButtonColumn";
            openButtonColumn.Text = "Open";
            openButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.LightSeaGreen;
            refreshBtn.ForeColor = Color.White;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Location = new Point(58, 37);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(177, 40);
            refreshBtn.TabIndex = 3;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Font = new Font("Segoe UI", 12F);
            refreshBtn.MouseEnter += refreshBtn_MouseEnter;
            refreshBtn.MouseLeave += refreshBtn_MouseLeave;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
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

        private void deleteBtn_MouseEnter(object sender, EventArgs e)
        {
            deleteBtn.BackColor = Color.DarkRed;
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteBtn.BackColor = Color.Crimson;
        }

        private void refreshBtn_MouseEnter(object sender, EventArgs e)
        {
            refreshBtn.BackColor = Color.Teal;
        }

        private void refreshBtn_MouseLeave(object sender, EventArgs e)
        {
            refreshBtn.BackColor = Color.LightSeaGreen;
        }

        #endregion
        private TextBox searchText;
        private Button deleteBtn;
        private DataGridView patientsDataGridView;
        private Button refreshBtn;
        private DataGridViewButtonColumn openButtonColumn;
    }
}
