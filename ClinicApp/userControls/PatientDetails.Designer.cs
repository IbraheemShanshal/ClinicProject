namespace ClinicApp.userControls
{
    partial class PatientDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            detailsPanel = new Panel();
            idLabel = new Label();
            nameLabel = new Label();
            genderLabel = new Label();
            contactLabel = new Label();
            dobLabel = new Label();
            referredLabel = new Label();
            addVisitButton = new Button();
            visitsDataGridView = new DataGridView();
            btn_back = new Button();
            detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // detailsPanel
            // 
            detailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            detailsPanel.BackColor = Color.White;
            detailsPanel.Controls.Add(idLabel);
            detailsPanel.Controls.Add(nameLabel);
            detailsPanel.Controls.Add(genderLabel);
            detailsPanel.Controls.Add(contactLabel);
            detailsPanel.Controls.Add(dobLabel);
            detailsPanel.Controls.Add(referredLabel);
            detailsPanel.Location = new Point(33, 106);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(600, 200);
            detailsPanel.TabIndex = 0;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(17, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(120, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID: [PatientID]";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(17, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(178, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name: [PatientName]";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(17, 89);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(145, 25);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender: [Gender]";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(17, 124);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(218, 25);
            contactLabel.TabIndex = 3;
            contactLabel.Text = "Contact: [ContactNumber]";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(17, 159);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(168, 25);
            dobLabel.TabIndex = 4;
            dobLabel.Text = "Date of Birth: [DOB]";
            // 
            // referredLabel
            // 
            referredLabel.AutoSize = true;
            referredLabel.Location = new Point(17, 194);
            referredLabel.Name = "referredLabel";
            referredLabel.Size = new Size(211, 25);
            referredLabel.TabIndex = 5;
            referredLabel.Text = "Referred: [ReferredStatus]";
            // 
            // addVisitButton
            // 
            addVisitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addVisitButton.Location = new Point(650, 106);
            addVisitButton.Name = "addVisitButton";
            addVisitButton.Size = new Size(150, 50);
            addVisitButton.TabIndex = 1;
            addVisitButton.Text = "Add Visit";
            addVisitButton.UseVisualStyleBackColor = true;
            addVisitButton.Click += addVisitButton_Click;
            // 
            // visitsDataGridView
            // 
            visitsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            visitsDataGridView.BackgroundColor = Color.White;
            visitsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitsDataGridView.Location = new Point(33, 316);
            visitsDataGridView.Name = "visitsDataGridView";
            visitsDataGridView.RowHeadersWidth = 62;
            visitsDataGridView.Size = new Size(800, 400);
            visitsDataGridView.TabIndex = 2;
            visitsDataGridView.CellContentClick += visitsDataGridView_CellContentClick;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(33, 32);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(100, 40);
            btn_back.TabIndex = 3;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // PatientDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            Controls.Add(detailsPanel);
            Controls.Add(addVisitButton);
            Controls.Add(visitsDataGridView);
            Controls.Add(btn_back);
            Name = "PatientDetails";
            Size = new Size(900, 750);
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitsDataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label referredLabel;
        private System.Windows.Forms.Button addVisitButton;
        private System.Windows.Forms.DataGridView visitsDataGridView;
        private System.Windows.Forms.Button btn_back;
    }
}
