namespace draft_winform
{
	partial class frm_42_AddBook
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.txtGia = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtManv = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.pbAdd = new System.Windows.Forms.PictureBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cbTheloai = new System.Windows.Forms.ComboBox();
			this.cbTacgia = new System.Windows.Forms.ComboBox();
			this.txtSoluong = new System.Windows.Forms.TextBox();
			this.txtBookname = new System.Windows.Forms.TextBox();
			this.txtMathem = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtMota = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtMota);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.dtpDate);
			this.panel1.Controls.Add(this.txtGia);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtManv);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.btnNew);
			this.panel1.Controls.Add(this.pbAdd);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.cbTheloai);
			this.panel1.Controls.Add(this.cbTacgia);
			this.panel1.Controls.Add(this.txtSoluong);
			this.panel1.Controls.Add(this.txtBookname);
			this.panel1.Controls.Add(this.txtMathem);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(831, 564);
			this.panel1.TabIndex = 0;
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "MM/dd/yyyy";
			this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(586, 176);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(183, 30);
			this.dtpDate.TabIndex = 1;
			// 
			// txtGia
			// 
			this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGia.Location = new System.Drawing.Point(586, 444);
			this.txtGia.Name = "txtGia";
			this.txtGia.Size = new System.Drawing.Size(183, 30);
			this.txtGia.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(445, 515);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 22);
			this.label8.TabIndex = 21;
			this.label8.Text = "Quantity : ";
			// 
			// txtManv
			// 
			this.txtManv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtManv.Location = new System.Drawing.Point(586, 109);
			this.txtManv.Name = "txtManv";
			this.txtManv.ReadOnly = true;
			this.txtManv.Size = new System.Drawing.Size(183, 30);
			this.txtManv.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::draft_winform.Properties.Resources.add_func;
			this.pictureBox2.Location = new System.Drawing.Point(741, 379);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(85, 321);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(215, 66);
			this.btnNew.TabIndex = 8;
			this.btnNew.Text = "&New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// pbAdd
			// 
			this.pbAdd.Image = global::draft_winform.Properties.Resources.add_func;
			this.pbAdd.Location = new System.Drawing.Point(739, 312);
			this.pbAdd.Name = "pbAdd";
			this.pbAdd.Size = new System.Drawing.Size(30, 26);
			this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAdd.TabIndex = 17;
			this.pbAdd.TabStop = false;
			this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
			this.pbAdd.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
			this.pbAdd.MouseLeave += new System.EventHandler(this.pbAdd_MouseLeave);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(85, 429);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(215, 66);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::draft_winform.Properties.Resources.pic_book2;
			this.pictureBox1.Location = new System.Drawing.Point(85, 46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 227);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// cbTheloai
			// 
			this.cbTheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTheloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTheloai.FormattingEnabled = true;
			this.cbTheloai.Location = new System.Drawing.Point(547, 377);
			this.cbTheloai.Name = "cbTheloai";
			this.cbTheloai.Size = new System.Drawing.Size(186, 30);
			this.cbTheloai.TabIndex = 4;
			this.cbTheloai.SelectedIndexChanged += new System.EventHandler(this.cbTheloai_SelectedIndexChanged);
			this.cbTheloai.Click += new System.EventHandler(this.cbTheloai_Click);
			// 
			// cbTacgia
			// 
			this.cbTacgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTacgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTacgia.FormattingEnabled = true;
			this.cbTacgia.Location = new System.Drawing.Point(547, 310);
			this.cbTacgia.Name = "cbTacgia";
			this.cbTacgia.Size = new System.Drawing.Size(186, 30);
			this.cbTacgia.TabIndex = 3;
			this.cbTacgia.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
			this.cbTacgia.Click += new System.EventHandler(this.cbTacgia_Click);
			// 
			// txtSoluong
			// 
			this.txtSoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoluong.Location = new System.Drawing.Point(586, 511);
			this.txtSoluong.Name = "txtSoluong";
			this.txtSoluong.Size = new System.Drawing.Size(183, 30);
			this.txtSoluong.TabIndex = 6;
			// 
			// txtBookname
			// 
			this.txtBookname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookname.Location = new System.Drawing.Point(547, 243);
			this.txtBookname.Name = "txtBookname";
			this.txtBookname.Size = new System.Drawing.Size(222, 30);
			this.txtBookname.TabIndex = 2;
			// 
			// txtMathem
			// 
			this.txtMathem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMathem.Location = new System.Drawing.Point(615, 42);
			this.txtMathem.Name = "txtMathem";
			this.txtMathem.Size = new System.Drawing.Size(154, 30);
			this.txtMathem.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(445, 381);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 22);
			this.label7.TabIndex = 6;
			this.label7.Text = "Type : ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(445, 314);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "Author : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(445, 448);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "Price : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(445, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Book : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(445, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(445, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee ID : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(445, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Book Added Code : ";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtMota
			// 
			this.txtMota.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMota.Location = new System.Drawing.Point(215, 515);
			this.txtMota.Name = "txtMota";
			this.txtMota.Size = new System.Drawing.Size(183, 30);
			this.txtMota.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(74, 519);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 22);
			this.label9.TabIndex = 22;
			this.label9.Text = "Mo ta : ";
			// 
			// frm_42_AddBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 567);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frm_42_AddBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_42_AddBook";
			this.Load += new System.EventHandler(this.frm_42_AddBook_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbTheloai;
		private System.Windows.Forms.ComboBox cbTacgia;
		private System.Windows.Forms.TextBox txtSoluong;
		private System.Windows.Forms.TextBox txtBookname;
		private System.Windows.Forms.TextBox txtMathem;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.PictureBox pbAdd;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtManv;
		private System.Windows.Forms.TextBox txtGia;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtMota;
		private System.Windows.Forms.Label label9;
	}
}