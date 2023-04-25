namespace HosplitalManagement
{
    partial class BillDetail
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
            dgvCart = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            txtTotalPrice = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtDate = new System.Windows.Forms.TextBox();
            txtAppointmentID = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtAmount = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtDiscription = new System.Windows.Forms.TextBox();
            txtDosage = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnCheckout = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            cbMedList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new System.Drawing.Point(2, 226);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 62;
            dgvCart.RowTemplate.Height = 33;
            dgvCart.Size = new System.Drawing.Size(796, 225);
            dgvCart.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(81, 198);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "TotalPrice";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new System.Drawing.Point(173, 195);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new System.Drawing.Size(150, 31);
            txtTotalPrice.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 25);
            label2.TabIndex = 1;
            label2.Text = "AppointmentID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 25);
            label3.TabIndex = 1;
            label3.Text = "AppointmentDate";
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(173, 42);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new System.Drawing.Size(150, 31);
            txtDate.TabIndex = 2;
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Location = new System.Drawing.Point(173, 9);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.ReadOnly = true;
            txtAppointmentID.Size = new System.Drawing.Size(150, 31);
            txtAppointmentID.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 25);
            label4.TabIndex = 1;
            label4.Text = "Medicine";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 146);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 25);
            label5.TabIndex = 1;
            label5.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new System.Drawing.Point(101, 143);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new System.Drawing.Size(222, 31);
            txtAmount.TabIndex = 2;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(439, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(73, 25);
            label6.TabIndex = 1;
            label6.Text = "Dosage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(439, 48);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 25);
            label7.TabIndex = 1;
            label7.Text = "Discription";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new System.Drawing.Point(542, 48);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new System.Drawing.Size(256, 31);
            txtDiscription.TabIndex = 2;
            // 
            // txtDosage
            // 
            txtDosage.Location = new System.Drawing.Point(542, 11);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new System.Drawing.Size(256, 31);
            txtDosage.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(439, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new System.Drawing.Point(557, 186);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(112, 34);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(676, 186);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cbMedList
            // 
            cbMedList.FormattingEnabled = true;
            cbMedList.Location = new System.Drawing.Point(101, 104);
            cbMedList.Name = "cbMedList";
            cbMedList.Size = new System.Drawing.Size(222, 33);
            cbMedList.TabIndex = 4;
            // 
            // BillDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cbMedList);
            Controls.Add(btnExit);
            Controls.Add(btnCheckout);
            Controls.Add(btnAdd);
            Controls.Add(txtAppointmentID);
            Controls.Add(txtAmount);
            Controls.Add(txtDate);
            Controls.Add(txtDosage);
            Controls.Add(txtDiscription);
            Controls.Add(txtTotalPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(dgvCart);
            Name = "BillDetail";
            Text = "BillDetail";
            Load += BillDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbMedList;
    }
}