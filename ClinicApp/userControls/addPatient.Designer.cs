namespace ClinicApp.userControls
{
    partial class addPatient
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
            text_name = new TextBox();
            text_age = new TextBox();
            combo_gender = new ComboBox();
            radio_referral = new RadioButton();
            masked_contact = new MaskedTextBox();
            visitDatePicker = new DateTimePicker();
            btn_save = new Button();
            btn_clear = new Button();
            label_name = new Label();
            label_gender = new Label();
            label_contact = new Label();
            label_date = new Label();
            label_age = new Label();
            label_ID = new Label();
            showID_label = new Label();
            SuspendLayout();
            // 
            // text_name
            // 
            text_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            text_name.Location = new Point(403, 151);
            text_name.Name = "text_name";
            text_name.Size = new Size(566, 31);
            text_name.TabIndex = 0;
            // 
            // text_age
            // 
            text_age.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            text_age.Location = new Point(403, 329);
            text_age.Name = "text_age";
            text_age.Size = new Size(566, 31);
            text_age.TabIndex = 1;
            // 
            // combo_gender
            // 
            combo_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_gender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            combo_gender.FormattingEnabled = true;
            combo_gender.Location = new Point(403, 215);
            combo_gender.Name = "combo_gender";
            combo_gender.Size = new Size(566, 33);
            combo_gender.TabIndex = 2;
            combo_gender.Text = "choose gender";
            combo_gender.SelectedIndexChanged += combo_gender_SelectedIndexChanged;
            // 
            // radio_referral
            // 
            radio_referral.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radio_referral.AutoSize = true;
            radio_referral.Location = new Point(403, 278);
            radio_referral.Name = "radio_referral";
            radio_referral.Size = new Size(92, 29);
            radio_referral.TabIndex = 3;
            radio_referral.TabStop = true;
            radio_referral.Text = "referral";
            radio_referral.UseVisualStyleBackColor = true;
            radio_referral.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // masked_contact
            // 
            masked_contact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            masked_contact.Location = new Point(403, 396);
            masked_contact.Name = "masked_contact";
            masked_contact.Size = new Size(566, 31);
            masked_contact.TabIndex = 4;
            // 
            // visitDatePicker
            // 
            visitDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            visitDatePicker.Location = new Point(403, 471);
            visitDatePicker.Name = "visitDatePicker";
            visitDatePicker.Size = new Size(566, 31);
            visitDatePicker.TabIndex = 5;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(242, 624);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(148, 68);
            btn_save.TabIndex = 6;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_clear.Location = new Point(529, 624);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(148, 68);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // label_name
            // 
            label_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_name.AutoSize = true;
            label_name.Location = new Point(213, 157);
            label_name.Name = "label_name";
            label_name.Size = new Size(59, 25);
            label_name.TabIndex = 9;
            label_name.Text = "Name";
            label_name.Click += label1_Click;
            // 
            // label_gender
            // 
            label_gender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_gender.AutoSize = true;
            label_gender.Location = new Point(203, 223);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(69, 25);
            label_gender.TabIndex = 10;
            label_gender.Text = "Gender";
            // 
            // label_contact
            // 
            label_contact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_contact.AutoSize = true;
            label_contact.Location = new Point(129, 402);
            label_contact.Name = "label_contact";
            label_contact.Size = new Size(143, 25);
            label_contact.TabIndex = 12;
            label_contact.Text = "Contact Number";
            // 
            // label_date
            // 
            label_date.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_date.AutoSize = true;
            label_date.Location = new Point(218, 477);
            label_date.Name = "label_date";
            label_date.Size = new Size(54, 25);
            label_date.TabIndex = 13;
            label_date.Text = "Date ";
            // 
            // label_age
            // 
            label_age.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_age.AutoSize = true;
            label_age.Location = new Point(228, 335);
            label_age.Name = "label_age";
            label_age.Size = new Size(44, 25);
            label_age.TabIndex = 14;
            label_age.Text = "Age";
            // 
            // label_ID
            // 
            label_ID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_ID.AutoSize = true;
            label_ID.Location = new Point(242, 95);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(30, 25);
            label_ID.TabIndex = 15;
            label_ID.Text = "ID";
            // 
            // showID_label
            // 
            showID_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showID_label.AutoSize = true;
            showID_label.BackColor = Color.White;
            showID_label.Location = new Point(403, 95);
            showID_label.Name = "showID_label";
            showID_label.Size = new Size(72, 25);
            showID_label.TabIndex = 17;
            showID_label.Text = "            ";
            showID_label.Click += showID_label_Click;
            // 
            // addPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(showID_label);
            Controls.Add(label_ID);
            Controls.Add(label_age);
            Controls.Add(label_date);
            Controls.Add(label_contact);
            Controls.Add(label_gender);
            Controls.Add(label_name);
            Controls.Add(btn_clear);
            Controls.Add(btn_save);
            Controls.Add(visitDatePicker);
            Controls.Add(masked_contact);
            Controls.Add(radio_referral);
            Controls.Add(combo_gender);
            Controls.Add(text_age);
            Controls.Add(text_name);
            Name = "addPatient";
            Size = new Size(1064, 845);
            Load += addPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_name;
        private TextBox text_age;
        private ComboBox combo_gender;
        private RadioButton radio_referral;
        private MaskedTextBox masked_contact;
        private DateTimePicker visitDatePicker;
        private Button btn_save;
        private Button btn_clear;
        private Label label_name;
        private Label label_gender;
        private Label label_contact;
        private Label label_date;
        private Label label_age;
        private Label label_ID;
        private Label showID_label;
    }
}
