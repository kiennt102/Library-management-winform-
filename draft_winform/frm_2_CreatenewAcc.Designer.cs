namespace draft_winform
{
	partial class CreateNew
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtGmail = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.dtpDOB = new System.Windows.Forms.DateTimePicker();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbSex = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(609, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "Personal information";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 227);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 41);
			this.label2.TabIndex = 1;
			this.label2.Text = "Full name : ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 41);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date of birth :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(30, 385);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 41);
			this.label4.TabIndex = 4;
			this.label4.Text = "Phone number :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(30, 464);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(168, 41);
			this.label5.TabIndex = 3;
			this.label5.Text = "Gmail :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(30, 543);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 41);
			this.label6.TabIndex = 5;
			this.label6.Text = "Address :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(204, 230);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(333, 34);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(204, 388);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(333, 34);
			this.txtPhone.TabIndex = 4;
			// 
			// txtGmail
			// 
			this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGmail.Location = new System.Drawing.Point(204, 467);
			this.txtGmail.Name = "txtGmail";
			this.txtGmail.Size = new System.Drawing.Size(333, 34);
			this.txtGmail.TabIndex = 5;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(204, 546);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(333, 34);
			this.txtAddress.TabIndex = 6;
			// 
			// dtpDOB
			// 
			this.dtpDOB.Checked = false;
			this.dtpDOB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDOB.Location = new System.Drawing.Point(204, 309);
			this.dtpDOB.Name = "dtpDOB";
			this.dtpDOB.Size = new System.Drawing.Size(333, 34);
			this.dtpDOB.TabIndex = 3;
			this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(66, 699);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(107, 42);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "&Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(430, 699);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(107, 42);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = "&Register";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.button2_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::draft_winform.Properties.Resources.oic_username;
			this.pictureBox1.Location = new System.Drawing.Point(75, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(63, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(204, 151);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(333, 34);
			this.txtId.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(30, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 41);
			this.label7.TabIndex = 9;
			this.label7.Text = "Id : ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "manager",
            "reader"});
			this.cmbType.Location = new System.Drawing.Point(416, 78);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(122, 30);
			this.cmbType.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(361, 82);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Type";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(31, 620);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(168, 41);
			this.label9.TabIndex = 12;
			this.label9.Text = "Sex :";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbSex
			// 
			this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSex.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSex.FormattingEnabled = true;
			this.cmbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
			this.cmbSex.Location = new System.Drawing.Point(205, 623);
			this.cmbSex.Name = "cmbSex";
			this.cmbSex.Size = new System.Drawing.Size(173, 34);
			this.cmbSex.TabIndex = 7;
			// 
			// CreateNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(609, 783);
			this.Controls.Add(this.cmbSex);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dtpDOB);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtGmail);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.Name = "CreateNew";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create new account";
			this.Load += new System.EventHandler(this.CreateNew_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtGmail;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.DateTimePicker dtpDOB;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbSex;
		private System.Windows.Forms.Label label9;
	}
}