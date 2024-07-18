namespace draft_winform
{
	partial class frm_421_AddAuthor
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtMtg = new System.Windows.Forms.TextBox();
			this.txtHoten = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã tác giả : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ tên : ";
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(36, 197);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(87, 39);
			this.btnBack.TabIndex = 4;
			this.btnBack.Text = "&Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(233, 197);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(87, 39);
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "&New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(410, 197);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(87, 39);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtMtg
			// 
			this.txtMtg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMtg.Location = new System.Drawing.Point(193, 31);
			this.txtMtg.Name = "txtMtg";
			this.txtMtg.Size = new System.Drawing.Size(268, 30);
			this.txtMtg.TabIndex = 0;
			// 
			// txtHoten
			// 
			this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoten.Location = new System.Drawing.Point(193, 108);
			this.txtHoten.Name = "txtHoten";
			this.txtHoten.Size = new System.Drawing.Size(268, 30);
			this.txtHoten.TabIndex = 1;
			// 
			// frm_421_AddAuthor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(560, 269);
			this.Controls.Add(this.txtHoten);
			this.Controls.Add(this.txtMtg);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_421_AddAuthor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Author";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtMtg;
		private System.Windows.Forms.TextBox txtHoten;
	}
}