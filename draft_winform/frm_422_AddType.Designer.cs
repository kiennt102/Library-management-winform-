namespace draft_winform
{
	partial class frm_422_AddType
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
			this.txtTenloai = new System.Windows.Forms.TextBox();
			this.txtMaloai = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTenloai
			// 
			this.txtTenloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenloai.Location = new System.Drawing.Point(207, 109);
			this.txtTenloai.Name = "txtTenloai";
			this.txtTenloai.Size = new System.Drawing.Size(268, 30);
			this.txtTenloai.TabIndex = 7;
			// 
			// txtMaloai
			// 
			this.txtMaloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaloai.Location = new System.Drawing.Point(207, 32);
			this.txtMaloai.Name = "txtMaloai";
			this.txtMaloai.Size = new System.Drawing.Size(268, 30);
			this.txtMaloai.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(424, 198);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(87, 39);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(247, 198);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(87, 39);
			this.btnNew.TabIndex = 10;
			this.btnNew.Text = "&New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnBack
			// 
			this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(50, 198);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(87, 39);
			this.btnBack.TabIndex = 11;
			this.btnBack.Text = "&Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 22);
			this.label2.TabIndex = 8;
			this.label2.Text = "Tên loại : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 22);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mã loại : ";
			// 
			// frm_422_AddType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 269);
			this.Controls.Add(this.txtTenloai);
			this.Controls.Add(this.txtMaloai);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_422_AddType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Type";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTenloai;
		private System.Windows.Forms.TextBox txtMaloai;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}