namespace draft_winform
{
	partial class admin_Account
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
			this.btnFindAcc = new System.Windows.Forms.Button();
			this.btnReaderaccount = new System.Windows.Forms.Button();
			this.btnProfile = new System.Windows.Forms.Button();
			this.btnManageaccount = new System.Windows.Forms.Button();
			this.admin_Account_functionDisplay = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.btnFindAcc);
			this.panel1.Controls.Add(this.btnReaderaccount);
			this.panel1.Controls.Add(this.btnProfile);
			this.panel1.Controls.Add(this.btnManageaccount);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(137, 657);
			this.panel1.TabIndex = 0;
			// 
			// btnFindAcc
			// 
			this.btnFindAcc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFindAcc.Location = new System.Drawing.Point(7, 505);
			this.btnFindAcc.Name = "btnFindAcc";
			this.btnFindAcc.Size = new System.Drawing.Size(116, 67);
			this.btnFindAcc.TabIndex = 5;
			this.btnFindAcc.Text = "Manage account";
			this.btnFindAcc.UseVisualStyleBackColor = true;
			this.btnFindAcc.Click += new System.EventHandler(this.btnFindAcc_Click);
			// 
			// btnReaderaccount
			// 
			this.btnReaderaccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReaderaccount.Location = new System.Drawing.Point(7, 353);
			this.btnReaderaccount.Name = "btnReaderaccount";
			this.btnReaderaccount.Size = new System.Drawing.Size(116, 67);
			this.btnReaderaccount.TabIndex = 3;
			this.btnReaderaccount.Text = "Reader account";
			this.btnReaderaccount.UseVisualStyleBackColor = true;
			this.btnReaderaccount.Click += new System.EventHandler(this.btnReaderaccount_Click);
			// 
			// btnProfile
			// 
			this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProfile.Location = new System.Drawing.Point(7, 36);
			this.btnProfile.Name = "btnProfile";
			this.btnProfile.Size = new System.Drawing.Size(116, 67);
			this.btnProfile.TabIndex = 0;
			this.btnProfile.Text = "Profile";
			this.btnProfile.UseVisualStyleBackColor = true;
			this.btnProfile.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnManageaccount
			// 
			this.btnManageaccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageaccount.Location = new System.Drawing.Point(7, 192);
			this.btnManageaccount.Name = "btnManageaccount";
			this.btnManageaccount.Size = new System.Drawing.Size(116, 67);
			this.btnManageaccount.TabIndex = 1;
			this.btnManageaccount.Text = "Staff account";
			this.btnManageaccount.UseVisualStyleBackColor = true;
			this.btnManageaccount.Click += new System.EventHandler(this.btnManageaccount_Click);
			// 
			// admin_Account_functionDisplay
			// 
			this.admin_Account_functionDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.admin_Account_functionDisplay.BackgroundImage = global::draft_winform.Properties.Resources.pic_main;
			this.admin_Account_functionDisplay.Location = new System.Drawing.Point(158, 2);
			this.admin_Account_functionDisplay.Name = "admin_Account_functionDisplay";
			this.admin_Account_functionDisplay.Size = new System.Drawing.Size(841, 657);
			this.admin_Account_functionDisplay.TabIndex = 1;
			// 
			// admin_Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1011, 659);
			this.Controls.Add(this.admin_Account_functionDisplay);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "admin_Account";
			this.Text = "Account manager";
			this.Load += new System.EventHandler(this.admin_Account_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnReaderaccount;
		private System.Windows.Forms.Button btnProfile;
		private System.Windows.Forms.Button btnManageaccount;
		private System.Windows.Forms.Button btnFindAcc;
		private System.Windows.Forms.Panel admin_Account_functionDisplay;
	}
}