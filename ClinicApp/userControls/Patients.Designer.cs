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
            searchBtn = new Button();
            patientsDataGridView = new DataGridView();
            backBtn = new Button();
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
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.BackColor = Color.White;
            searchBtn.Location = new Point(837, 37);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(177, 40);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // patientsDataGridView
            // 
            patientsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            patientsDataGridView.BackgroundColor = Color.White;
            patientsDataGridView.ColumnHeadersHeight = 34;
            patientsDataGridView.GridColor = SystemColors.MenuBar;
            patientsDataGridView.Location = new Point(58, 115);
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.RowHeadersWidth = 62;
            patientsDataGridView.Size = new Size(956, 688);
            patientsDataGridView.TabIndex = 2;
            patientsDataGridView.CellContentClick += patientsDataGridView_CellContentClick;
            patientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // backBtn
            // 
            backBtn.BackColor = Color.White;
            backBtn.Location = new Point(58, 37);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(157, 36);
            backBtn.TabIndex = 3;
            backBtn.Text = "back";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(backBtn);
            Controls.Add(searchText);
            Controls.Add(searchBtn);
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
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private Button backBtn;
    }
}
