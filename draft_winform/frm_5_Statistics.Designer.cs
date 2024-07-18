namespace draft_winform
{
	partial class frm_5_Statistics
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pbStaPerson = new System.Windows.Forms.PictureBox();
			this.pbReloadType = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbStaPerson)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbReloadType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pbStaPerson);
			this.panel1.Controls.Add(this.pbReloadType);
			this.panel1.Controls.Add(this.cbYear);
			this.panel1.Controls.Add(this.cbMonth);
			this.panel1.Controls.Add(this.dataGridView2);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.cbType);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(989, 605);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(738, 569);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(241, 22);
			this.label2.TabIndex = 9;
			this.label2.Text = "Statistic books added by type";
			// 
			// cbYear
			// 
			this.cbYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Location = new System.Drawing.Point(307, 60);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(175, 30);
			this.cbYear.TabIndex = 6;
			this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
			// 
			// cbMonth
			// 
			this.cbMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMonth.FormattingEnabled = true;
			this.cbMonth.Location = new System.Drawing.Point(153, 60);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(100, 30);
			this.cbMonth.TabIndex = 5;
			this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(30, 118);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(452, 470);
			this.dataGridView2.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(572, 121);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(407, 445);
			this.dataGridView1.TabIndex = 3;
			// 
			// cbType
			// 
			this.cbType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbType.FormattingEnabled = true;
			this.cbType.Location = new System.Drawing.Point(646, 79);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(196, 30);
			this.cbType.TabIndex = 1;
			this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(568, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(87, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 22);
			this.label3.TabIndex = 10;
			this.label3.Text = "Month";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(259, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 22);
			this.label4.TabIndex = 11;
			this.label4.Text = "Year";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(116, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(292, 32);
			this.label5.TabIndex = 12;
			this.label5.Text = "Golden board of honour";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::draft_winform.Properties.Resources.fun_sta1;
			this.pictureBox2.Location = new System.Drawing.Point(891, 28);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(88, 83);
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			// 
			// pbStaPerson
			// 
			this.pbStaPerson.Image = global::draft_winform.Properties.Resources.fun_sta;
			this.pbStaPerson.Location = new System.Drawing.Point(488, 60);
			this.pbStaPerson.Name = "pbStaPerson";
			this.pbStaPerson.Size = new System.Drawing.Size(32, 30);
			this.pbStaPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbStaPerson.TabIndex = 8;
			this.pbStaPerson.TabStop = false;
			this.pbStaPerson.Click += new System.EventHandler(this.pictureBox2_Click);
			this.pbStaPerson.MouseEnter += new System.EventHandler(this.pbStaPerson_MouseEnter);
			this.pbStaPerson.MouseLeave += new System.EventHandler(this.pbStaPerson_MouseLeave);
			// 
			// pbReloadType
			// 
			this.pbReloadType.Image = global::draft_winform.Properties.Resources.fun_sta;
			this.pbReloadType.Location = new System.Drawing.Point(848, 79);
			this.pbReloadType.Name = "pbReloadType";
			this.pbReloadType.Size = new System.Drawing.Size(32, 30);
			this.pbReloadType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbReloadType.TabIndex = 7;
			this.pbReloadType.TabStop = false;
			this.pbReloadType.Click += new System.EventHandler(this.pbReloadType_Click);
			this.pbReloadType.MouseEnter += new System.EventHandler(this.pbReloadType_MouseEnter);
			this.pbReloadType.MouseLeave += new System.EventHandler(this.pbReloadType_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::draft_winform.Properties.Resources.func_honor;
			this.pictureBox1.Location = new System.Drawing.Point(10, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 83);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// frm_5_Statistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 612);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frm_5_Statistics";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_5_Statistics";
			this.Load += new System.EventHandler(this.frm_5_Statistics_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbStaPerson)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbReloadType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.PictureBox pbReloadType;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.ComboBox cbMonth;
		private System.Windows.Forms.PictureBox pbStaPerson;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}