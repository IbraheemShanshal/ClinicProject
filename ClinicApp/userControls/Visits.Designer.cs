namespace ClinicApp.userControls
{
    partial class Visits
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
            visitDatePicker = new DateTimePicker();
            doctorNotesTextBox = new TextBox();
            prescriptionTextBox = new TextBox();
            saveButton = new Button();
            backButton = new Button();
            labelVisitDate = new Label();
            labelDoctorNotes = new Label();
            labelPrescription = new Label();
            SuspendLayout();
            // 
            // visitDatePicker
            // 
            visitDatePicker.Anchor = AnchorStyles.Top;
            visitDatePicker.Location = new Point(72, 65);
            visitDatePicker.Margin = new Padding(5, 6, 5, 6);
            visitDatePicker.Name = "visitDatePicker";
            visitDatePicker.Size = new Size(400, 31);
            visitDatePicker.TabIndex = 0;
            // 
            // doctorNotesTextBox
            // 
            doctorNotesTextBox.Anchor = AnchorStyles.Top;
            doctorNotesTextBox.Location = new Point(72, 185);
            doctorNotesTextBox.Margin = new Padding(5, 6, 5, 6);
            doctorNotesTextBox.Multiline = true;
            doctorNotesTextBox.Name = "doctorNotesTextBox";
            doctorNotesTextBox.Size = new Size(931, 152);
            doctorNotesTextBox.TabIndex = 1;
            doctorNotesTextBox.TextChanged += doctorNotesTextBox_TextChanged;
            // 
            // prescriptionTextBox
            // 
            prescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            prescriptionTextBox.Location = new Point(72, 454);
            prescriptionTextBox.Margin = new Padding(5, 6, 5, 6);
            prescriptionTextBox.Multiline = true;
            prescriptionTextBox.Name = "prescriptionTextBox";
            prescriptionTextBox.Size = new Size(931, 216);
            prescriptionTextBox.TabIndex = 2;
            prescriptionTextBox.TextChanged += prescriptionTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom;
            saveButton.Location = new Point(232, 712);
            saveButton.Margin = new Padding(5, 6, 5, 6);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(167, 58);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom;
            backButton.Location = new Point(572, 712);
            backButton.Margin = new Padding(5, 6, 5, 6);
            backButton.Name = "backButton";
            backButton.Size = new Size(167, 58);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += clearButton_Click;
            // 
            // labelVisitDate
            // 
            labelVisitDate.Anchor = AnchorStyles.Top;
            labelVisitDate.AutoSize = true;
            labelVisitDate.Location = new Point(72, 25);
            labelVisitDate.Margin = new Padding(5, 0, 5, 0);
            labelVisitDate.Name = "labelVisitDate";
            labelVisitDate.Size = new Size(87, 25);
            labelVisitDate.TabIndex = 5;
            labelVisitDate.Text = "Visit Date";
            // 
            // labelDoctorNotes
            // 
            labelDoctorNotes.Anchor = AnchorStyles.Top;
            labelDoctorNotes.AutoSize = true;
            labelDoctorNotes.Location = new Point(72, 133);
            labelDoctorNotes.Margin = new Padding(5, 0, 5, 0);
            labelDoctorNotes.Name = "labelDoctorNotes";
            labelDoctorNotes.Size = new Size(119, 25);
            labelDoctorNotes.TabIndex = 6;
            labelDoctorNotes.Text = "Doctor Notes";
            // 
            // labelPrescription
            // 
            labelPrescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelPrescription.AutoSize = true;
            labelPrescription.Location = new Point(72, 404);
            labelPrescription.Margin = new Padding(5, 0, 5, 0);
            labelPrescription.Name = "labelPrescription";
            labelPrescription.Size = new Size(105, 25);
            labelPrescription.TabIndex = 7;
            labelPrescription.Text = "Prescription";
            labelPrescription.Click += labelPrescription_Click;
            // 
            // Visits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            Controls.Add(labelPrescription);
            Controls.Add(labelDoctorNotes);
            Controls.Add(labelVisitDate);
            Controls.Add(backButton);
            Controls.Add(saveButton);
            Controls.Add(prescriptionTextBox);
            Controls.Add(doctorNotesTextBox);
            Controls.Add(visitDatePicker);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Visits";
            Size = new Size(1064, 845);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker visitDatePicker;
        private System.Windows.Forms.TextBox doctorNotesTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label labelVisitDate;
        private System.Windows.Forms.Label labelDoctorNotes;
        private System.Windows.Forms.Label labelPrescription;
    }
}
