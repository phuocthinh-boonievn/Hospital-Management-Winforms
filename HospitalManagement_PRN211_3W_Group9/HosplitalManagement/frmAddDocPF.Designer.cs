namespace HosplitalManagement
{
    partial class frmAddDocPF
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtSpec = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            cbAccountList = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(165, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "DoctorName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(165, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 25);
            label2.TabIndex = 0;
            label2.Text = "Specialization";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(338, 69);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(150, 31);
            txtName.TabIndex = 1;
            // 
            // txtSpec
            // 
            txtSpec.Location = new System.Drawing.Point(338, 135);
            txtSpec.Name = "txtSpec";
            txtSpec.Size = new System.Drawing.Size(150, 31);
            txtSpec.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(165, 268);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(112, 34);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(338, 268);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(112, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // cbAccountList
            // 
            cbAccountList.FormattingEnabled = true;
            cbAccountList.Location = new System.Drawing.Point(338, 206);
            cbAccountList.Name = "cbAccountList";
            cbAccountList.Size = new System.Drawing.Size(150, 33);
            cbAccountList.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(165, 214);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(148, 25);
            label3.TabIndex = 4;
            label3.Text = "AvailableAccount";
            // 
            // frmAddDocPF
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cbAccountList);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(txtSpec);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddDocPF";
            Text = "frmAddDocPF";
            Load += frmAddDocPF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbAccountList;
        private System.Windows.Forms.Label label3;
    }
}