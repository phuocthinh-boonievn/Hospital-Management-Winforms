namespace HosplitalManagement
{
    partial class frmAddDoctorAccount
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
            lbUsername = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtSpecialization = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new System.Drawing.Point(103, 33);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(91, 25);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(103, 85);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(87, 25);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(103, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 25);
            label3.TabIndex = 0;
            label3.Text = "DocName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(103, 185);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 25);
            label4.TabIndex = 0;
            label4.Text = "Specialization";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(264, 33);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(253, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(264, 85);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(253, 31);
            txtPassword.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(264, 138);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(253, 31);
            txtName.TabIndex = 1;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new System.Drawing.Point(264, 185);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new System.Drawing.Size(253, 31);
            txtSpecialization.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(110, 267);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(405, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(112, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmAddDoctor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(683, 342);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(txtSpecialization);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Name = "frmAddDoctor";
            Text = "frmAddDoctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}