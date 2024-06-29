namespace ClinicApp.userControls
{
    partial class PatientDetails
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
            detailsPanel = new Panel();
            idLabel = new Label();
            nameLabel = new Label();
            genderLabel = new Label();
            contactLabel = new Label();
            dobLabel = new Label();
            addVisitButton = new Button();
            visitsDataGridView = new DataGridView();
            btn_back = new Button();
            detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // detailsPanel
            // 
            detailsPanel.BackColor = Color.White;
            detailsPanel.Controls.Add(idLabel);
            detailsPanel.Controls.Add(nameLabel);
            detailsPanel.Controls.Add(genderLabel);
            detailsPanel.Controls.Add(contactLabel);
            detailsPanel.Controls.Add(dobLabel);
            detailsPanel.Location = new Point(33, 106);
            detailsPanel.Margin = new Padding(5, 6, 5, 6);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(500, 288);
            detailsPanel.TabIndex = 0;
            detailsPanel.Paint += detailsPanel_Paint;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(17, 19);
            idLabel.Margin = new Padding(5, 0, 5, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(120, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID: [PatientID]";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(17, 77);
            nameLabel.Margin = new Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(178, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name: [PatientName]";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(17, 135);
            genderLabel.Margin = new Padding(5, 0, 5, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(145, 25);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender: [Gender]";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(17, 192);
            contactLabel.Margin = new Padding(5, 0, 5, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(218, 25);
            contactLabel.TabIndex = 3;
            contactLabel.Text = "Contact: [ContactNumber]";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(17, 250);
            dobLabel.Margin = new Padding(5, 0, 5, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(168, 25);
            dobLabel.TabIndex = 4;
            dobLabel.Text = "Date of Birth: [DOB]";
            // 
            // addVisitButton
            // 
            addVisitButton.Location = new Point(33, 416);
            addVisitButton.Margin = new Padding(5, 6, 5, 6);
            addVisitButton.Name = "addVisitButton";
            addVisitButton.Size = new Size(167, 58);
            addVisitButton.TabIndex = 1;
            addVisitButton.Text = "Add Visit";
            addVisitButton.UseVisualStyleBackColor = true;
            // 
            // visitsDataGridView
            // 
            visitsDataGridView.BackgroundColor = Color.White;
            visitsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitsDataGridView.GridColor = Color.White;
            visitsDataGridView.Location = new Point(33, 512);
            visitsDataGridView.Margin = new Padding(5, 6, 5, 6);
            visitsDataGridView.Name = "visitsDataGridView";
            visitsDataGridView.RowHeadersWidth = 62;
            visitsDataGridView.Size = new Size(1000, 385);
            visitsDataGridView.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.None;
            btn_back.Location = new Point(33, 32);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(89, 31);
            btn_back.TabIndex = 9;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // PatientDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(btn_back);
            Controls.Add(visitsDataGridView);
            Controls.Add(addVisitButton);
            Controls.Add(detailsPanel);
            Margin = new Padding(5, 6, 5, 6);
            Name = "PatientDetails";
            Size = new Size(1144, 934);
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
        private System.Windows.Forms.Button addVisitButton;
        private System.Windows.Forms.DataGridView visitsDataGridView;
        private Button btn_back;
    }

        #endregion

    }

