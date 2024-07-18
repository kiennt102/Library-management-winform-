namespace draft_winform
{
	partial class CreateAccount
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtRePass = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(700, 78);
			this.label1.TabIndex = 0;
			this.label1.Text = "ACCOUNT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 67);
			this.label2.TabIndex = 1;
			this.label2.Text = "UserName :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(46, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 67);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(46, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 67);
			this.label4.TabIndex = 3;
			this.label4.Text = "Re Password :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(238, 111);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.ReadOnly = true;
			this.txtUsername.Size = new System.Drawing.Size(360, 34);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.Location = new System.Drawing.Point(238, 189);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(360, 34);
			this.txtPass.TabIndex = 1;
			// 
			// txtRePass
			// 
			this.txtRePass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRePass.Location = new System.Drawing.Point(238, 276);
			this.txtRePass.Name = "txtRePass";
			this.txtRePass.Size = new System.Drawing.Size(360, 34);
			this.txtRePass.TabIndex = 2;
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(82, 353);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(109, 48);
			this.btnBack.TabIndex = 4;
			this.btnBack.Text = "&Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(510, 353);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(109, 48);
			this.btnRegister.TabIndex = 3;
			this.btnRegister.Text = "&Resgister";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// CreateAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(700, 422);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.txtRePass);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "CreateAccount";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create new account";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtRePass;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnRegister;
	}
}