namespace HosplitalManagement
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcMain = new System.Windows.Forms.TabControl();
            tpAccount = new System.Windows.Forms.TabPage();
            txtSearchAccount = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnDeleteDocAccount = new System.Windows.Forms.Button();
            btnUpdateDocAccount = new System.Windows.Forms.Button();
            btnCreateDocAccount = new System.Windows.Forms.Button();
            dgvDisplayAccounts = new System.Windows.Forms.DataGridView();
            tpProfile = new System.Windows.Forms.TabPage();
            rbPatientPF = new System.Windows.Forms.RadioButton();
            rbDoctorPF = new System.Windows.Forms.RadioButton();
            btnDeletePF = new System.Windows.Forms.Button();
            btnUpdatePF = new System.Windows.Forms.Button();
            btnCreatePF = new System.Windows.Forms.Button();
            txtSearchPF = new System.Windows.Forms.TextBox();
            lbSearchPF = new System.Windows.Forms.Label();
            dgvDisplayProfiles = new System.Windows.Forms.DataGridView();
            tpAppointment = new System.Windows.Forms.TabPage();
            tpMedicine = new System.Windows.Forms.TabPage();
            tcMain.SuspendLayout();
            tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplayAccounts).BeginInit();
            tpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplayProfiles).BeginInit();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpAccount);
            tcMain.Controls.Add(tpProfile);
            tcMain.Controls.Add(tpAppointment);
            tcMain.Controls.Add(tpMedicine);
            tcMain.Location = new System.Drawing.Point(2, 1);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new System.Drawing.Size(878, 481);
            tcMain.TabIndex = 0;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(txtSearchAccount);
            tpAccount.Controls.Add(label1);
            tpAccount.Controls.Add(btnDeleteDocAccount);
            tpAccount.Controls.Add(btnUpdateDocAccount);
            tpAccount.Controls.Add(btnCreateDocAccount);
            tpAccount.Controls.Add(dgvDisplayAccounts);
            tpAccount.Location = new System.Drawing.Point(4, 34);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new System.Windows.Forms.Padding(3);
            tpAccount.Size = new System.Drawing.Size(870, 443);
            tpAccount.TabIndex = 0;
            tpAccount.Text = "Accounts";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.Location = new System.Drawing.Point(224, 19);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new System.Drawing.Size(150, 31);
            txtSearchAccount.TabIndex = 3;
            txtSearchAccount.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(56, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 25);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // btnDeleteDocAccount
            // 
            btnDeleteDocAccount.Location = new System.Drawing.Point(467, 124);
            btnDeleteDocAccount.Name = "btnDeleteDocAccount";
            btnDeleteDocAccount.Size = new System.Drawing.Size(112, 34);
            btnDeleteDocAccount.TabIndex = 1;
            btnDeleteDocAccount.Text = "Delete";
            btnDeleteDocAccount.UseVisualStyleBackColor = true;
            btnDeleteDocAccount.Click += btnDeleteDocAccount_Click;
            // 
            // btnUpdateDocAccount
            // 
            btnUpdateDocAccount.Location = new System.Drawing.Point(277, 124);
            btnUpdateDocAccount.Name = "btnUpdateDocAccount";
            btnUpdateDocAccount.Size = new System.Drawing.Size(112, 34);
            btnUpdateDocAccount.TabIndex = 1;
            btnUpdateDocAccount.Text = "Update";
            btnUpdateDocAccount.UseVisualStyleBackColor = true;
            btnUpdateDocAccount.Click += btnUpdateDocAccount_Click;
            // 
            // btnCreateDocAccount
            // 
            btnCreateDocAccount.Location = new System.Drawing.Point(106, 124);
            btnCreateDocAccount.Name = "btnCreateDocAccount";
            btnCreateDocAccount.Size = new System.Drawing.Size(112, 34);
            btnCreateDocAccount.TabIndex = 1;
            btnCreateDocAccount.Text = "Create";
            btnCreateDocAccount.UseVisualStyleBackColor = true;
            btnCreateDocAccount.Click += btnCreate_Click;
            // 
            // dgvDisplayAccounts
            // 
            dgvDisplayAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplayAccounts.Location = new System.Drawing.Point(6, 207);
            dgvDisplayAccounts.Name = "dgvDisplayAccounts";
            dgvDisplayAccounts.RowHeadersWidth = 62;
            dgvDisplayAccounts.RowTemplate.Height = 33;
            dgvDisplayAccounts.Size = new System.Drawing.Size(855, 225);
            dgvDisplayAccounts.TabIndex = 0;
            dgvDisplayAccounts.RowHeaderMouseClick += dgvDisplayAccounts_RowHeaderMouseClick;
            // 
            // tpProfile
            // 
            tpProfile.Controls.Add(rbPatientPF);
            tpProfile.Controls.Add(rbDoctorPF);
            tpProfile.Controls.Add(btnDeletePF);
            tpProfile.Controls.Add(btnUpdatePF);
            tpProfile.Controls.Add(btnCreatePF);
            tpProfile.Controls.Add(txtSearchPF);
            tpProfile.Controls.Add(lbSearchPF);
            tpProfile.Controls.Add(dgvDisplayProfiles);
            tpProfile.Location = new System.Drawing.Point(4, 34);
            tpProfile.Name = "tpProfile";
            tpProfile.Padding = new System.Windows.Forms.Padding(3);
            tpProfile.Size = new System.Drawing.Size(870, 443);
            tpProfile.TabIndex = 1;
            tpProfile.Text = "Profile";
            tpProfile.UseVisualStyleBackColor = true;
            // 
            // rbPatientPF
            // 
            rbPatientPF.AutoSize = true;
            rbPatientPF.Location = new System.Drawing.Point(687, 28);
            rbPatientPF.Name = "rbPatientPF";
            rbPatientPF.Size = new System.Drawing.Size(98, 29);
            rbPatientPF.TabIndex = 4;
            rbPatientPF.TabStop = true;
            rbPatientPF.Text = "Patients";
            rbPatientPF.UseVisualStyleBackColor = true;
            rbPatientPF.CheckedChanged += rbPatientPF_CheckedChanged;
            // 
            // rbDoctorPF
            // 
            rbDoctorPF.AutoSize = true;
            rbDoctorPF.Location = new System.Drawing.Point(487, 28);
            rbDoctorPF.Name = "rbDoctorPF";
            rbDoctorPF.Size = new System.Drawing.Size(100, 29);
            rbDoctorPF.TabIndex = 4;
            rbDoctorPF.TabStop = true;
            rbDoctorPF.Text = "Doctors";
            rbDoctorPF.UseVisualStyleBackColor = true;
            rbDoctorPF.CheckedChanged += rbDoctorPF_CheckedChanged;
            // 
            // btnDeletePF
            // 
            btnDeletePF.Location = new System.Drawing.Point(569, 142);
            btnDeletePF.Name = "btnDeletePF";
            btnDeletePF.Size = new System.Drawing.Size(112, 34);
            btnDeletePF.TabIndex = 3;
            btnDeletePF.Text = "Delete";
            btnDeletePF.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePF
            // 
            btnUpdatePF.Location = new System.Drawing.Point(344, 142);
            btnUpdatePF.Name = "btnUpdatePF";
            btnUpdatePF.Size = new System.Drawing.Size(112, 34);
            btnUpdatePF.TabIndex = 3;
            btnUpdatePF.Text = "Update";
            btnUpdatePF.UseVisualStyleBackColor = true;
            // 
            // btnCreatePF
            // 
            btnCreatePF.Location = new System.Drawing.Point(95, 142);
            btnCreatePF.Name = "btnCreatePF";
            btnCreatePF.Size = new System.Drawing.Size(112, 34);
            btnCreatePF.TabIndex = 3;
            btnCreatePF.Text = "Create";
            btnCreatePF.UseVisualStyleBackColor = true;
            btnCreatePF.Click += btnCreatePF_Click;
            // 
            // txtSearchPF
            // 
            txtSearchPF.Location = new System.Drawing.Point(246, 22);
            txtSearchPF.Name = "txtSearchPF";
            txtSearchPF.Size = new System.Drawing.Size(150, 31);
            txtSearchPF.TabIndex = 2;
            txtSearchPF.TextChanged += txtSearchPF_TextChanged;
            // 
            // lbSearchPF
            // 
            lbSearchPF.AutoSize = true;
            lbSearchPF.Location = new System.Drawing.Point(92, 28);
            lbSearchPF.Name = "lbSearchPF";
            lbSearchPF.Size = new System.Drawing.Size(64, 25);
            lbSearchPF.TabIndex = 1;
            lbSearchPF.Text = "Search";
            // 
            // dgvDisplayProfiles
            // 
            dgvDisplayProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplayProfiles.Location = new System.Drawing.Point(0, 215);
            dgvDisplayProfiles.Name = "dgvDisplayProfiles";
            dgvDisplayProfiles.RowHeadersWidth = 62;
            dgvDisplayProfiles.RowTemplate.Height = 33;
            dgvDisplayProfiles.Size = new System.Drawing.Size(870, 225);
            dgvDisplayProfiles.TabIndex = 0;
            // 
            // tpAppointment
            // 
            tpAppointment.Location = new System.Drawing.Point(4, 34);
            tpAppointment.Name = "tpAppointment";
            tpAppointment.Size = new System.Drawing.Size(870, 443);
            tpAppointment.TabIndex = 2;
            tpAppointment.Text = "Appointment";
            tpAppointment.UseVisualStyleBackColor = true;
            // 
            // tpMedicine
            // 
            tpMedicine.Location = new System.Drawing.Point(4, 34);
            tpMedicine.Name = "tpMedicine";
            tpMedicine.Size = new System.Drawing.Size(870, 443);
            tpMedicine.TabIndex = 3;
            tpMedicine.Text = "Medicine";
            tpMedicine.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(879, 479);
            Controls.Add(tcMain);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            tcMain.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            tpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplayAccounts).EndInit();
            tpProfile.ResumeLayout(false);
            tpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplayProfiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TabPage tpProfile;
        private System.Windows.Forms.TabPage tpAppointment;
        private System.Windows.Forms.TabPage tpMedicine;
        private System.Windows.Forms.DataGridView dgvDisplayAccounts;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDocAccount;
        private System.Windows.Forms.Button btnUpdateDocAccount;
        private System.Windows.Forms.Button btnCreateDocAccount;
        private System.Windows.Forms.DataGridView dgvDisplayProfiles;
        private System.Windows.Forms.Button btnDeletePF;
        private System.Windows.Forms.Button btnUpdatePF;
        private System.Windows.Forms.Button btnCreatePF;
        private System.Windows.Forms.TextBox txtSearchPF;
        private System.Windows.Forms.Label lbSearchPF;
        private System.Windows.Forms.RadioButton rbPatientPF;
        private System.Windows.Forms.RadioButton rbDoctorPF;
    }
}