namespace draft_winform
{
	partial class admin_Reader_account
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pbReload = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtGhichu = new System.Windows.Forms.TextBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pbSearch = new System.Windows.Forms.PictureBox();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mtxtDob = new System.Windows.Forms.MaskedTextBox();
			this.cbSex = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnADD = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtGmail = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtFullname = new System.Windows.Forms.TextBox();
			this.txtReaderID = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReload)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(838, 52);
			this.label1.TabIndex = 61;
			this.label1.Text = "Reader information";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pbReload);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtGhichu);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.pbSearch);
			this.panel1.Controls.Add(this.cbType);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.mtxtDob);
			this.panel1.Controls.Add(this.cbSex);
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
			this.panel1.Controls.Add(this.txtReaderID);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnUpdate);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(4, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(838, 655);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
			// 
			// pbReload
			// 
			this.pbReload.Image = global::draft_winform.Properties.Resources.func_reload1;
			this.pbReload.Location = new System.Drawing.Point(776, 82);
			this.pbReload.Name = "pbReload";
			this.pbReload.Size = new System.Drawing.Size(31, 27);
			this.pbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbReload.TabIndex = 83;
			this.pbReload.TabStop = false;
			this.pbReload.Click += new System.EventHandler(this.pbReload_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(399, 609);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 25);
			this.label3.TabIndex = 82;
			this.label3.Text = "Note";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtGhichu
			// 
			this.txtGhichu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGhichu.Location = new System.Drawing.Point(461, 609);
			this.txtGhichu.Name = "txtGhichu";
			this.txtGhichu.Size = new System.Drawing.Size(173, 27);
			this.txtGhichu.TabIndex = 81;
			this.txtGhichu.TextChanged += new System.EventHandler(this.txtGhichu_TextChanged);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(339, 66);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(329, 27);
			this.txtSearch.TabIndex = 80;
			this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pbSearch
			// 
			this.pbSearch.Image = global::draft_winform.Properties.Resources.pic_find;
			this.pbSearch.Location = new System.Drawing.Point(670, 66);
			this.pbSearch.Name = "pbSearch";
			this.pbSearch.Size = new System.Drawing.Size(31, 27);
			this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbSearch.TabIndex = 79;
			this.pbSearch.TabStop = false;
			this.pbSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
			this.pbSearch.MouseEnter += new System.EventHandler(this.pbSearch_MouseEnter);
			this.pbSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
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
			this.cbType.Location = new System.Drawing.Point(149, 66);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(157, 27);
			this.cbType.TabIndex = 78;
			this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
			this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 27);
			this.label4.TabIndex = 76;
			this.label4.Text = "Search :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mtxtDob
			// 
			this.mtxtDob.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtDob.Location = new System.Drawing.Point(118, 598);
			this.mtxtDob.Mask = "00/00/0000";
			this.mtxtDob.Name = "mtxtDob";
			this.mtxtDob.Size = new System.Drawing.Size(88, 27);
			this.mtxtDob.TabIndex = 3;
			this.mtxtDob.ValidatingType = typeof(System.DateTime);
			// 
			// cbSex
			// 
			this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSex.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSex.FormattingEnabled = true;
			this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
			this.cbSex.Location = new System.Drawing.Point(461, 556);
			this.cbSex.Name = "cbSex";
			this.cbSex.Size = new System.Drawing.Size(106, 27);
			this.cbSex.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(383, 556);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 25);
			this.label2.TabIndex = 64;
			this.label2.Text = "Sex";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnADD
			// 
			this.btnADD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnADD.Location = new System.Drawing.Point(716, 460);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(92, 38);
			this.btnADD.TabIndex = 7;
			this.btnADD.Text = "Add";
			this.btnADD.UseVisualStyleBackColor = true;
			this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(386, 491);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 25);
			this.label7.TabIndex = 60;
			this.label7.Text = "Phone";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(399, 436);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 25);
			this.label8.TabIndex = 59;
			this.label8.Text = "Gmail";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(56, 546);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 25);
			this.label9.TabIndex = 58;
			this.label9.Text = "Address";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(-11, 598);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(123, 25);
			this.label10.TabIndex = 57;
			this.label10.Text = "MM/dd/yyyy";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(37, 491);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 25);
			this.label11.TabIndex = 56;
			this.label11.Text = "Fullname";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(21, 436);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 25);
			this.label12.TabIndex = 55;
			this.label12.Text = "Reader_id";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(461, 491);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(173, 27);
			this.txtPhone.TabIndex = 5;
			// 
			// txtGmail
			// 
			this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGmail.Location = new System.Drawing.Point(461, 436);
			this.txtGmail.Name = "txtGmail";
			this.txtGmail.Size = new System.Drawing.Size(173, 27);
			this.txtGmail.TabIndex = 4;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(118, 546);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(173, 27);
			this.txtAddress.TabIndex = 2;
			// 
			// txtFullname
			// 
			this.txtFullname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFullname.Location = new System.Drawing.Point(118, 491);
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.Size = new System.Drawing.Size(173, 27);
			this.txtFullname.TabIndex = 1;
			// 
			// txtReaderID
			// 
			this.txtReaderID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReaderID.Location = new System.Drawing.Point(118, 436);
			this.txtReaderID.Name = "txtReaderID";
			this.txtReaderID.ReadOnly = true;
			this.txtReaderID.Size = new System.Drawing.Size(173, 27);
			this.txtReaderID.TabIndex = 0;
			this.txtReaderID.TextChanged += new System.EventHandler(this.txtReaderID_TextChanged);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(716, 587);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(92, 38);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(716, 525);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(92, 38);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(24, 115);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(783, 286);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// admin_Reader_account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 657);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "admin_Reader_account";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_47_Reader_i4";
			this.Load += new System.EventHandler(this.admin_Reader_account_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbReload)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MaskedTextBox mtxtDob;
		private System.Windows.Forms.ComboBox cbSex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnADD;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtGmail;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtFullname;
		private System.Windows.Forms.TextBox txtReaderID;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pbSearch;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtGhichu;
		private System.Windows.Forms.PictureBox pbReload;
	}
}