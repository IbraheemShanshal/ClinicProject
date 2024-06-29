namespace ClinicApp
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            minimizeButton = new Button();
            maximizeButton = new Button();
            closeButton = new Button();
            addPatient_btn = new Button();
            Patient_btn = new Button();
            pictureBox1 = new PictureBox();
            titlePanel = new Panel();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            printDialog1 = new PrintDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Right;
            minimizeButton.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimizeButton.Location = new Point(1282, 12);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(50, 37);
            minimizeButton.TabIndex = 1;
            minimizeButton.Text = "-";
            minimizeButton.TextAlign = ContentAlignment.TopCenter;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += MinimizeButton_Click;
            // 
            // maximizeButton
            // 
            maximizeButton.Anchor = AnchorStyles.Right;
            maximizeButton.Location = new Point(1338, 12);
            maximizeButton.Name = "maximizeButton";
            maximizeButton.Size = new Size(50, 37);
            maximizeButton.TabIndex = 2;
            maximizeButton.Text = "□";
            maximizeButton.TextAlign = ContentAlignment.TopCenter;
            maximizeButton.UseVisualStyleBackColor = true;
            maximizeButton.Click += MaximizeButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Right;
            closeButton.Location = new Point(1394, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 37);
            closeButton.TabIndex = 3;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // addPatient_btn
            // 
            addPatient_btn.BackColor = Color.Black;
            addPatient_btn.FlatStyle = FlatStyle.Flat;
            addPatient_btn.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPatient_btn.ForeColor = SystemColors.ButtonHighlight;
            addPatient_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addPatient_btn.Location = new Point(3, 319);
            addPatient_btn.Name = "addPatient_btn";
            addPatient_btn.Size = new Size(389, 121);
            addPatient_btn.TabIndex = 0;
            addPatient_btn.Text = "Add Patient";
            addPatient_btn.UseVisualStyleBackColor = false;
            addPatient_btn.Click += addPatient_Click;
            // 
            // Patient_btn
            // 
            Patient_btn.BackColor = Color.Black;
            Patient_btn.FlatStyle = FlatStyle.Flat;
            Patient_btn.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Patient_btn.ForeColor = Color.WhiteSmoke;
            Patient_btn.Location = new Point(3, 446);
            Patient_btn.Name = "Patient_btn";
            Patient_btn.Size = new Size(389, 121);
            Patient_btn.TabIndex = 1;
            Patient_btn.Text = "Patients";
            Patient_btn.UseVisualStyleBackColor = false;
            Patient_btn.Click += searchPatient_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = SystemColors.ActiveCaptionText;
            titlePanel.Controls.Add(minimizeButton);
            titlePanel.Controls.Add(maximizeButton);
            titlePanel.Controls.Add(closeButton);
            titlePanel.Controls.Add(pictureBox2);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1456, 66);
            titlePanel.TabIndex = 4;
            titlePanel.MouseDown += TitleBarPanel_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(addPatient_btn);
            flowLayoutPanel1.Controls.Add(Patient_btn);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(392, 845);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(392, 66);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1064, 845);
            mainPanel.TabIndex = 6;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1456, 911);
            Controls.Add(mainPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(titlePanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            Text = "Clinic";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addPatient_btn;
        private Button Patient_btn;
        private PictureBox pictureBox1;
        private Panel titlePanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private PrintDialog printDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
        private Panel mainPanel;
    }
}
