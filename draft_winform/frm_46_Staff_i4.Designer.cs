namespace draft_winform
{
	partial class admin_Account_staff
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtStaffCode = new System.Windows.Forms.TextBox();
			this.txtFullname = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtGmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnADD = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmpSex = new System.Windows.Forms.ComboBox();
			this.mtxtDob = new System.Windows.Forms.MaskedTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGhichu = new System.Windows.Forms.TextBox();
			this.pbReload = new System.Windows.Forms.PictureBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pbSearch = new System.Windows.Forms.PictureBox();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReload)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(29, 123);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(780, 283);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(704, 520);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(105, 41);
			this.btnUpdate.TabIndex = 53;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(704, 588);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(105, 41);
			this.btnDelete.TabIndex = 54;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtStaffCode
			// 
			this.txtStaffCode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStaffCode.Location = new System.Drawing.Point(137, 427);
			this.txtStaffCode.Name = "txtStaffCode";
			this.txtStaffCode.ReadOnly = true;
			this.txtStaffCode.Size = new System.Drawing.Size(197, 27);
			this.txtStaffCode.TabIndex = 47;
			this.txtStaffCode.TextChanged += new System.EventHandler(this.txtStaffCode_TextChanged);
			// 
			// txtFullname
			// 
			this.txtFullname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFullname.Location = new System.Drawing.Point(137, 494);
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.Size = new System.Drawing.Size(197, 27);
			this.txtFullname.TabIndex = 48;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(137, 554);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(197, 27);
			this.txtAddress.TabIndex = 50;
			// 
			// txtGmail
			// 
			this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGmail.Location = new System.Drawing.Point(453, 428);
			this.txtGmail.Name = "txtGmail";
			this.txtGmail.Size = new System.Drawing.Size(197, 27);
			this.txtGmail.TabIndex = 51;
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(453, 487);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(197, 27);
			this.txtPhone.TabIndex = 52;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(45, 427);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(86, 27);
			this.label12.TabIndex = 55;
			this.label12.Text = "Staff_id";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(45, 494);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(86, 27);
			this.label11.TabIndex = 56;
			this.label11.Text = "Fullname";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(25, 614);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(106, 27);
			this.label10.TabIndex = 57;
			this.label10.Text = "MM/dd/yyyy";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(66, 554);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 27);
			this.label9.TabIndex = 58;
			this.label9.Text = "Address";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(382, 428);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 27);
			this.label8.TabIndex = 59;
			this.label8.Text = "Gmail";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(367, 487);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 27);
			this.label7.TabIndex = 60;
			this.label7.Text = "Phone";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnADD
			// 
			this.btnADD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnADD.Location = new System.Drawing.Point(704, 447);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(105, 41);
			this.btnADD.TabIndex = 62;
			this.btnADD.Text = "Add";
			this.btnADD.UseVisualStyleBackColor = true;
			this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(364, 549);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 27);
			this.label2.TabIndex = 64;
			this.label2.Text = "Sex";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmpSex
			// 
			this.cmpSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmpSex.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmpSex.FormattingEnabled = true;
			this.cmpSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
			this.cmpSex.Location = new System.Drawing.Point(453, 549);
			this.cmpSex.Name = "cmpSex";
			this.cmpSex.Size = new System.Drawing.Size(121, 27);
			this.cmpSex.TabIndex = 65;
			// 
			// mtxtDob
			// 
			this.mtxtDob.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtDob.Location = new System.Drawing.Point(137, 615);
			this.mtxtDob.Mask = "00/00/0000";
			this.mtxtDob.Name = "mtxtDob";
			this.mtxtDob.Size = new System.Drawing.Size(100, 27);
			this.mtxtDob.TabIndex = 67;
			this.mtxtDob.ValidatingType = typeof(System.DateTime);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtGhichu);
			this.panel1.Controls.Add(this.pbReload);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.pbSearch);
			this.panel1.Controls.Add(this.cbType);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.mtxtDob);
			this.panel1.Controls.Add(this.cmpSex);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnADD);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.txtGmail);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.txtFullname);
			this.panel1.Controls.Add(this.txtStaffCode);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(839, 654);
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(367, 602);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 27);
			this.label4.TabIndex = 79;
			this.label4.Text = "Note";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtGhichu
			// 
			this.txtGhichu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGhichu.Location = new System.Drawing.Point(453, 602);
			this.txtGhichu.Name = "txtGhichu";
			this.txtGhichu.Size = new System.Drawing.Size(197, 27);
			this.txtGhichu.TabIndex = 78;
			this.txtGhichu.TextChanged += new System.EventHandler(this.txtGhichu_TextChanged);
			// 
			// pbReload
			// 
			this.pbReload.Image = global::draft_winform.Properties.Resources.func_reload1;
			this.pbReload.Location = new System.Drawing.Point(778, 90);
			this.pbReload.Name = "pbReload";
			this.pbReload.Size = new System.Drawing.Size(31, 27);
			this.pbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbReload.TabIndex = 77;
			this.pbReload.TabStop = false;
			this.pbReload.Click += new System.EventHandler(this.pbReload_Click);
			this.pbReload.MouseEnter += new System.EventHandler(this.pbReload_MouseEnter);
			this.pbReload.MouseLeave += new System.EventHandler(this.pbReload_MouseLeave);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(335, 69);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(329, 27);
			this.txtSearch.TabIndex = 76;
			this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
			this.txtSearch.TabStopChanged += new System.EventHandler(this.txtSearch_TabStopChanged);
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pbSearch
			// 
			this.pbSearch.Image = global::draft_winform.Properties.Resources.pic_find;
			this.pbSearch.Location = new System.Drawing.Point(665, 69);
			this.pbSearch.Name = "pbSearch";
			this.pbSearch.Size = new System.Drawing.Size(31, 27);
			this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbSearch.TabIndex = 75;
			this.pbSearch.TabStop = false;
			this.pbSearch.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pbSearch.MouseEnter += new System.EventHandler(this.pbSearch_MouseEnter);
			this.pbSearch.MouseLeave += new System.EventHandler(this.pbSearch_MouseLeave);
			// 
			// cbType
			// 
			this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbType.FormattingEnabled = true;
			this.cbType.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Address"});
			this.cbType.Location = new System.Drawing.Point(156, 69);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(157, 27);
			this.cbType.TabIndex = 74;
			this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
			this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 27);
			this.label3.TabIndex = 71;
			this.label3.Text = "Search :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(839, 55);
			this.label1.TabIndex = 61;
			this.label1.Text = "Staff information";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// admin_Account_staff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 657);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "admin_Account_staff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form9";
			this.Load += new System.EventHandler(this.admin_Account_staff_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReload)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtStaffCode;
		private System.Windows.Forms.TextBox txtFullname;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtGmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnADD;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmpSex;
		private System.Windows.Forms.MaskedTextBox mtxtDob;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pbSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.PictureBox pbReload;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGhichu;
	}
}