namespace draft_winform
{
	partial class admin_manage_acc
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
			this.components = new System.ComponentModel.Container();
			this.manageAccount = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.mtxtDob = new System.Windows.Forms.MaskedTextBox();
			this.cbSex = new System.Windows.Forms.ComboBox();
			this.btnChangepass = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtGmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.manageAccount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// manageAccount
			// 
			this.manageAccount.Controls.Add(this.label1);
			this.manageAccount.Controls.Add(this.mtxtDob);
			this.manageAccount.Controls.Add(this.cbSex);
			this.manageAccount.Controls.Add(this.btnChangepass);
			this.manageAccount.Controls.Add(this.btnUpdate);
			this.manageAccount.Controls.Add(this.label8);
			this.manageAccount.Controls.Add(this.txtAddress);
			this.manageAccount.Controls.Add(this.txtGmail);
			this.manageAccount.Controls.Add(this.txtPhone);
			this.manageAccount.Controls.Add(this.txtName);
			this.manageAccount.Controls.Add(this.label6);
			this.manageAccount.Controls.Add(this.label5);
			this.manageAccount.Controls.Add(this.label4);
			this.manageAccount.Controls.Add(this.label3);
			this.manageAccount.Controls.Add(this.label2);
			this.manageAccount.Controls.Add(this.txtUsername);
			this.manageAccount.Controls.Add(this.pictureBox1);
			this.manageAccount.Location = new System.Drawing.Point(0, 0);
			this.manageAccount.Name = "manageAccount";
			this.manageAccount.Size = new System.Drawing.Size(824, 610);
			this.manageAccount.TabIndex = 0;
			this.manageAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.manageAccount_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(91, 294);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 20);
			this.label1.TabIndex = 75;
			this.label1.Text = "ID :";
			// 
			// mtxtDob
			// 
			this.mtxtDob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtDob.Location = new System.Drawing.Point(518, 132);
			this.mtxtDob.Mask = "00/00/0000";
			this.mtxtDob.Name = "mtxtDob";
			this.mtxtDob.Size = new System.Drawing.Size(111, 30);
			this.mtxtDob.TabIndex = 1;
			this.mtxtDob.ValidatingType = typeof(System.DateTime);
			this.mtxtDob.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			// 
			// cbSex
			// 
			this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSex.FormattingEnabled = true;
			this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
			this.cbSex.Location = new System.Drawing.Point(518, 412);
			this.cbSex.Name = "cbSex";
			this.cbSex.Size = new System.Drawing.Size(238, 30);
			this.cbSex.TabIndex = 5;
			// 
			// btnChangepass
			// 
			this.btnChangepass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangepass.Location = new System.Drawing.Point(505, 499);
			this.btnChangepass.Name = "btnChangepass";
			this.btnChangepass.Size = new System.Drawing.Size(213, 47);
			this.btnChangepass.TabIndex = 7;
			this.btnChangepass.Text = "CHANGE PASSWORD";
			this.btnChangepass.UseVisualStyleBackColor = true;
			this.btnChangepass.Click += new System.EventHandler(this.btnChangepass_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(100, 499);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(213, 47);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(391, 416);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 20);
			this.label8.TabIndex = 70;
			this.label8.Text = "Sex :";
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(518, 200);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(238, 30);
			this.txtAddress.TabIndex = 2;
			// 
			// txtGmail
			// 
			this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGmail.Location = new System.Drawing.Point(518, 269);
			this.txtGmail.Name = "txtGmail";
			this.txtGmail.Size = new System.Drawing.Size(238, 30);
			this.txtGmail.TabIndex = 3;
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(518, 341);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(238, 30);
			this.txtPhone.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(518, 64);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(238, 30);
			this.txtName.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(391, 204);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 20);
			this.label6.TabIndex = 63;
			this.label6.Text = "Address :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(391, 273);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 20);
			this.label5.TabIndex = 62;
			this.label5.Text = "Gmail :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(391, 345);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 20);
			this.label4.TabIndex = 61;
			this.label4.Text = "Phone number";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(391, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 20);
			this.label3.TabIndex = 60;
			this.label3.Text = "Date of birth :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(391, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 59;
			this.label2.Text = "Full name :";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(130, 289);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.ReadOnly = true;
			this.txtUsername.Size = new System.Drawing.Size(154, 30);
			this.txtUsername.TabIndex = 57;
			this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::draft_winform.Properties.Resources.oic_username;
			this.pictureBox1.Location = new System.Drawing.Point(82, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(218, 219);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 56;
			this.pictureBox1.TabStop = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// admin_manage_acc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 610);
			this.Controls.Add(this.manageAccount);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "admin_manage_acc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.admin_manage_acc_Load);
			this.manageAccount.ResumeLayout(false);
			this.manageAccount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel manageAccount;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtGmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnChangepass;
		private System.Windows.Forms.ComboBox cbSex;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.MaskedTextBox mtxtDob;
		private System.Windows.Forms.Label label1;
	}
}