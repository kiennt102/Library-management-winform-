namespace draft_winform
{
	partial class frm_44_ReturnBook
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
			this.txtMatra = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.cbMadocgia = new System.Windows.Forms.ComboBox();
			this.txtMasach = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTensach = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNgaymuon = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMamuon = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnTra = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.txtManv = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTenDG = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.radMuon = new System.Windows.Forms.RadioButton();
			this.radKhac = new System.Windows.Forms.RadioButton();
			this.txtKhac = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label8 = new System.Windows.Forms.Label();
			this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã trả : ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtMatra
			// 
			this.txtMatra.Location = new System.Drawing.Point(109, 21);
			this.txtMatra.Name = "txtMatra";
			this.txtMatra.Size = new System.Drawing.Size(136, 28);
			this.txtMatra.TabIndex = 1;
			this.txtMatra.TextChanged += new System.EventHandler(this.txtMatra_TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 129);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(761, 183);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(469, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mã độc giả : ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// cbMadocgia
			// 
			this.cbMadocgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMadocgia.FormattingEnabled = true;
			this.cbMadocgia.Location = new System.Drawing.Point(578, 21);
			this.cbMadocgia.Name = "cbMadocgia";
			this.cbMadocgia.Size = new System.Drawing.Size(149, 28);
			this.cbMadocgia.TabIndex = 4;
			this.cbMadocgia.SelectedIndexChanged += new System.EventHandler(this.cbMadocgia_SelectedIndexChanged);
			this.cbMadocgia.TextChanged += new System.EventHandler(this.cbMadocgia_TextChanged);
			// 
			// txtMasach
			// 
			this.txtMasach.Location = new System.Drawing.Point(131, 433);
			this.txtMasach.Name = "txtMasach";
			this.txtMasach.ReadOnly = true;
			this.txtMasach.Size = new System.Drawing.Size(150, 28);
			this.txtMasach.TabIndex = 6;
			this.txtMasach.TextChanged += new System.EventHandler(this.txtMasach_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 437);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Mã sách : ";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtTensach
			// 
			this.txtTensach.Location = new System.Drawing.Point(136, 501);
			this.txtTensach.Name = "txtTensach";
			this.txtTensach.ReadOnly = true;
			this.txtTensach.Size = new System.Drawing.Size(145, 28);
			this.txtTensach.TabIndex = 8;
			this.txtTensach.TextChanged += new System.EventHandler(this.txtTensach_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 505);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tên sách : ";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtNgaymuon
			// 
			this.txtNgaymuon.Location = new System.Drawing.Point(453, 346);
			this.txtNgaymuon.Name = "txtNgaymuon";
			this.txtNgaymuon.ReadOnly = true;
			this.txtNgaymuon.Size = new System.Drawing.Size(136, 28);
			this.txtNgaymuon.TabIndex = 10;
			this.txtNgaymuon.TextChanged += new System.EventHandler(this.txtNgaymuon_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(344, 349);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Ngày mượn : ";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtMamuon
			// 
			this.txtMamuon.Location = new System.Drawing.Point(453, 403);
			this.txtMamuon.Name = "txtMamuon";
			this.txtMamuon.ReadOnly = true;
			this.txtMamuon.Size = new System.Drawing.Size(136, 28);
			this.txtMamuon.TabIndex = 12;
			this.txtMamuon.TextChanged += new System.EventHandler(this.txtMamuon_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(354, 406);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Mã mượn : ";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(354, 470);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "Ghi chú : ";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// btnTra
			// 
			this.btnTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTra.Location = new System.Drawing.Point(702, 394);
			this.btnTra.Name = "btnTra";
			this.btnTra.Size = new System.Drawing.Size(95, 37);
			this.btnTra.TabIndex = 17;
			this.btnTra.Text = "&Return";
			this.btnTra.UseVisualStyleBackColor = true;
			this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(702, 486);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(95, 37);
			this.btnNew.TabIndex = 18;
			this.btnNew.Text = "&New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// txtManv
			// 
			this.txtManv.Location = new System.Drawing.Point(145, 364);
			this.txtManv.Name = "txtManv";
			this.txtManv.ReadOnly = true;
			this.txtManv.Size = new System.Drawing.Size(136, 28);
			this.txtManv.TabIndex = 20;
			this.txtManv.TextChanged += new System.EventHandler(this.txtManv_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(17, 368);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(122, 20);
			this.label9.TabIndex = 19;
			this.label9.Text = "Mã nhân viên : ";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// txtTenDG
			// 
			this.txtTenDG.Location = new System.Drawing.Point(578, 72);
			this.txtTenDG.Name = "txtTenDG";
			this.txtTenDG.ReadOnly = true;
			this.txtTenDG.Size = new System.Drawing.Size(136, 28);
			this.txtTenDG.TabIndex = 22;
			this.txtTenDG.TextChanged += new System.EventHandler(this.txtTenDG_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(469, 75);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(108, 20);
			this.label10.TabIndex = 21;
			this.label10.Text = "Tên độc giả : ";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// radMuon
			// 
			this.radMuon.AutoSize = true;
			this.radMuon.Location = new System.Drawing.Point(448, 471);
			this.radMuon.Name = "radMuon";
			this.radMuon.Size = new System.Drawing.Size(91, 24);
			this.radMuon.TabIndex = 23;
			this.radMuon.TabStop = true;
			this.radMuon.Text = "Quá hạn";
			this.radMuon.UseVisualStyleBackColor = true;
			this.radMuon.CheckedChanged += new System.EventHandler(this.radMuon_CheckedChanged);
			// 
			// radKhac
			// 
			this.radKhac.AutoSize = true;
			this.radKhac.Location = new System.Drawing.Point(448, 522);
			this.radKhac.Name = "radKhac";
			this.radKhac.Size = new System.Drawing.Size(77, 24);
			this.radKhac.TabIndex = 24;
			this.radKhac.TabStop = true;
			this.radKhac.Text = "Khác :";
			this.radKhac.UseVisualStyleBackColor = true;
			this.radKhac.CheckedChanged += new System.EventHandler(this.radKhac_CheckedChanged);
			// 
			// txtKhac
			// 
			this.txtKhac.BackColor = System.Drawing.SystemColors.Menu;
			this.txtKhac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtKhac.Location = new System.Drawing.Point(531, 520);
			this.txtKhac.Name = "txtKhac";
			this.txtKhac.Size = new System.Drawing.Size(109, 28);
			this.txtKhac.TabIndex = 25;
			this.txtKhac.TextChanged += new System.EventHandler(this.txtKhac_TextChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 79);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 20);
			this.label8.TabIndex = 26;
			this.label8.Text = "Ngày trả : ";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// dtpNgaytra
			// 
			this.dtpNgaytra.CustomFormat = "MM/dd/yyyy";
			this.dtpNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaytra.Location = new System.Drawing.Point(114, 75);
			this.dtpNgaytra.Name = "dtpNgaytra";
			this.dtpNgaytra.Size = new System.Drawing.Size(131, 28);
			this.dtpNgaytra.TabIndex = 27;
			this.dtpNgaytra.ValueChanged += new System.EventHandler(this.dtpNgaytra_ValueChanged);
			// 
			// frm_44_ReturnBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 567);
			this.Controls.Add(this.dtpNgaytra);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtKhac);
			this.Controls.Add(this.radKhac);
			this.Controls.Add(this.radMuon);
			this.Controls.Add(this.txtTenDG);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtManv);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnTra);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtMamuon);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNgaymuon);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTensach);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMasach);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbMadocgia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtMatra);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_44_ReturnBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_44_ReturnBook";
			this.Load += new System.EventHandler(this.frm_44_ReturnBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMatra;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbMadocgia;
		private System.Windows.Forms.TextBox txtMasach;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTensach;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNgaymuon;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMamuon;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnTra;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.TextBox txtManv;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTenDG;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RadioButton radMuon;
		private System.Windows.Forms.RadioButton radKhac;
		private System.Windows.Forms.TextBox txtKhac;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.DateTimePicker dtpNgaytra;
		private System.Windows.Forms.Label label8;
	}
}