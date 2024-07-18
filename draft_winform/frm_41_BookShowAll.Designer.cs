namespace draft_winform
{
	partial class frm_41_BookShowAll
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
			this.pbSearch = new System.Windows.Forms.PictureBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.cbSearch = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pbSearch);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.cbSearch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(829, 562);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// pbSearch
			// 
			this.pbSearch.BackColor = System.Drawing.Color.White;
			this.pbSearch.Image = global::draft_winform.Properties.Resources.pic_find;
			this.pbSearch.Location = new System.Drawing.Point(642, 34);
			this.pbSearch.Name = "pbSearch";
			this.pbSearch.Size = new System.Drawing.Size(31, 27);
			this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbSearch.TabIndex = 80;
			this.pbSearch.TabStop = false;
			this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
			this.pbSearch.MouseEnter += new System.EventHandler(this.pbSearch_MouseEnter);
			this.pbSearch.MouseLeave += new System.EventHandler(this.pbSearch_MouseLeave);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(349, 32);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(324, 30);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// cbSearch
			// 
			this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSearch.FormattingEnabled = true;
			this.cbSearch.Items.AddRange(new object[] {
            "Id",
            "Book name",
            "Author name",
            "Type"});
			this.cbSearch.Location = new System.Drawing.Point(190, 32);
			this.cbSearch.Name = "cbSearch";
			this.cbSearch.Size = new System.Drawing.Size(136, 30);
			this.cbSearch.TabIndex = 2;
			this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
			this.cbSearch.TextChanged += new System.EventHandler(this.cbSearch_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(33, 112);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(759, 395);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frm_41_BookShowAll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 567);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frm_41_BookShowAll";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_41_BookShowAll";
			this.Load += new System.EventHandler(this.frm_41_BookShowAll_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ComboBox cbSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbSearch;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}