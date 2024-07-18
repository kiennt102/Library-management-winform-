namespace draft_winform
{
	partial class mainMenu_Admin
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
			this.plDisplay = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbLogout = new System.Windows.Forms.PictureBox();
			this.pbSetting = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbAccount = new System.Windows.Forms.PictureBox();
			this.plDisplay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
			this.SuspendLayout();
			// 
			// plDisplay
			// 
			this.plDisplay.Controls.Add(this.pictureBox4);
			this.plDisplay.Location = new System.Drawing.Point(142, 0);
			this.plDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.plDisplay.Name = "plDisplay";
			this.plDisplay.Size = new System.Drawing.Size(1011, 659);
			this.plDisplay.TabIndex = 0;
			this.plDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::draft_winform.Properties.Resources.pic_login;
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(1011, 659);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pbLogout);
			this.panel2.Controls.Add(this.pbSetting);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pbAccount);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(135, 659);
			this.panel2.TabIndex = 1;
			this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(31, 628);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "LOG OUT";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 440);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "STATISTICS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(35, 249);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "BOOKS";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "ACCOUNT";
			// 
			// pbLogout
			// 
			this.pbLogout.Image = global::draft_winform.Properties.Resources.func_log_out11;
			this.pbLogout.Location = new System.Drawing.Point(17, 517);
			this.pbLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pbLogout.Name = "pbLogout";
			this.pbLogout.Size = new System.Drawing.Size(100, 100);
			this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogout.TabIndex = 3;
			this.pbLogout.TabStop = false;
			this.pbLogout.Click += new System.EventHandler(this.pictureBox3_Click);
			this.pbLogout.MouseEnter += new System.EventHandler(this.pbLogout_MouseEnter);
			this.pbLogout.MouseLeave += new System.EventHandler(this.pbLogout_MouseLeave);
			// 
			// pbSetting
			// 
			this.pbSetting.Image = global::draft_winform.Properties.Resources.func_statistic;
			this.pbSetting.Location = new System.Drawing.Point(10, 329);
			this.pbSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pbSetting.Name = "pbSetting";
			this.pbSetting.Size = new System.Drawing.Size(115, 107);
			this.pbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbSetting.TabIndex = 2;
			this.pbSetting.TabStop = false;
			this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
			this.pbSetting.MouseEnter += new System.EventHandler(this.pbSetting_MouseEnter);
			this.pbSetting.MouseLeave += new System.EventHandler(this.pbSetting_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::draft_winform.Properties.Resources.func_book;
			this.pictureBox1.Location = new System.Drawing.Point(10, 162);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
			this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
			// 
			// pbAccount
			// 
			this.pbAccount.Image = global::draft_winform.Properties.Resources.PIC_USER;
			this.pbAccount.Location = new System.Drawing.Point(10, 11);
			this.pbAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pbAccount.Name = "pbAccount";
			this.pbAccount.Size = new System.Drawing.Size(115, 107);
			this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAccount.TabIndex = 0;
			this.pbAccount.TabStop = false;
			this.pbAccount.Click += new System.EventHandler(this.pbAccount_Click);
			this.pbAccount.MouseEnter += new System.EventHandler(this.pbAccount_MouseEnter);
			this.pbAccount.MouseLeave += new System.EventHandler(this.pbAccount_MouseLeave);
			this.pbAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbAccount_MouseMove);
			// 
			// mainMenu_Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1154, 658);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.plDisplay);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "mainMenu_Admin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "menu";
			this.Load += new System.EventHandler(this.mainMenu_Admin_Load);
			this.plDisplay.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plDisplay;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pbAccount;
		private System.Windows.Forms.PictureBox pbLogout;
		private System.Windows.Forms.PictureBox pbSetting;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}