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
            clearButton = new Button();
            SuspendLayout();
            // 
            // visitDatePicker
            // 
            visitDatePicker.Location = new Point(33, 38);
            visitDatePicker.Margin = new Padding(5, 6, 5, 6);
            visitDatePicker.Name = "visitDatePicker";
            visitDatePicker.Size = new Size(331, 31);
            visitDatePicker.TabIndex = 0;
            // 
            // doctorNotesTextBox
            // 
            doctorNotesTextBox.Location = new Point(33, 115);
            doctorNotesTextBox.Margin = new Padding(5, 6, 5, 6);
            doctorNotesTextBox.Multiline = true;
            doctorNotesTextBox.Name = "doctorNotesTextBox";
            doctorNotesTextBox.Size = new Size(497, 189);
            doctorNotesTextBox.TabIndex = 1;
            // 
            // prescriptionTextBox
            // 
            prescriptionTextBox.Location = new Point(33, 346);
            prescriptionTextBox.Margin = new Padding(5, 6, 5, 6);
            prescriptionTextBox.Multiline = true;
            prescriptionTextBox.Name = "prescriptionTextBox";
            prescriptionTextBox.Size = new Size(497, 189);
            prescriptionTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(33, 577);
            saveButton.Margin = new Padding(5, 6, 5, 6);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(167, 58);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(233, 577);
            clearButton.Margin = new Padding(5, 6, 5, 6);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(167, 58);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // Visits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Controls.Add(prescriptionTextBox);
            Controls.Add(doctorNotesTextBox);
            Controls.Add(visitDatePicker);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Visits";
            Size = new Size(667, 673);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker visitDatePicker;
        private System.Windows.Forms.TextBox doctorNotesTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
    }

        #endregion
    }

