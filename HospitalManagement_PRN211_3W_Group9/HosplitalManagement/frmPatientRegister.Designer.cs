namespace HosplitalManagement
{
    partial class frmPatientRegister
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
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            dtpBoB = new System.Windows.Forms.DateTimePicker();
            btnCreate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            rbMale = new System.Windows.Forms.RadioButton();
            rbFemale = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(73, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 25);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(73, 187);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 25);
            label5.TabIndex = 0;
            label5.Text = "DateOfBirth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(73, 236);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 25);
            label6.TabIndex = 0;
            label6.Text = "Gender";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(184, 117);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(300, 31);
            txtName.TabIndex = 1;
            // 
            // dtpBoB
            // 
            dtpBoB.Location = new System.Drawing.Point(184, 182);
            dtpBoB.Name = "dtpBoB";
            dtpBoB.Size = new System.Drawing.Size(300, 31);
            dtpBoB.TabIndex = 2;
            dtpBoB.ValueChanged += dtpBoB_ValueChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(184, 305);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(112, 34);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(372, 305);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(112, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new System.Drawing.Point(184, 236);
            rbMale.Name = "rbMale";
            rbMale.Size = new System.Drawing.Size(75, 29);
            rbMale.TabIndex = 5;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new System.Drawing.Point(334, 236);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new System.Drawing.Size(93, 29);
            rbFemale.TabIndex = 5;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // frmPatientRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(643, 411);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(dtpBoB);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "frmPatientRegister";
            Text = "frmPatientRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBoB;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
    }
}