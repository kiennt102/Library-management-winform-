namespace draft_winform
{
	partial class ForgetPass
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtGmail = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnTake = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.txtGmail);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.btnTake);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(7, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(539, 217);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 26);
			this.label2.TabIndex = 11;
			this.label2.Text = "Your password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "Gmail";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(211, 101);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(276, 34);
			this.txtPassword.TabIndex = 1;
			// 
			// txtGmail
			// 
			this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGmail.Location = new System.Drawing.Point(211, 23);
			this.txtGmail.Name = "txtGmail";
			this.txtGmail.Size = new System.Drawing.Size(276, 34);
			this.txtGmail.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(408, 161);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(101, 39);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "&Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnTake
			// 
			this.btnTake.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTake.Location = new System.Drawing.Point(280, 161);
			this.btnTake.Name = "btnTake";
			this.btnTake.Size = new System.Drawing.Size(101, 39);
			this.btnTake.TabIndex = 2;
			this.btnTake.Text = "&Take";
			this.btnTake.UseVisualStyleBackColor = true;
			this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(15, 93);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(494, 53);
			this.panel3.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(15, 14);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(494, 53);
			this.panel2.TabIndex = 0;
			// 
			// ForgetPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.btnBack;
			this.ClientSize = new System.Drawing.Size(558, 235);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ForgetPass";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Retake password";
			this.Load += new System.EventHandler(this.ForgetPass_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtGmail;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnTake;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
	}
}