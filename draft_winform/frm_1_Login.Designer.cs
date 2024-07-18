namespace draft_winform
{
	partial class Login
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.llblForgetPass = new System.Windows.Forms.LinkLabel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnHide = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.llblCreateNew = new System.Windows.Forms.LinkLabel();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.btnLog = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightGray;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbType);
			this.groupBox1.Controls.Add(this.llblForgetPass);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.btnHide);
			this.groupBox1.Controls.Add(this.btnShow);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.llblCreateNew);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.txtPass);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.btnLog);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(141, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(507, 364);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(186, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 26);
			this.label1.TabIndex = 20;
			this.label1.Text = "You are";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "manager",
            "reader"});
			this.cmbType.Location = new System.Drawing.Point(276, 33);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(168, 34);
			this.cmbType.TabIndex = 2;
			// 
			// llblForgetPass
			// 
			this.llblForgetPass.ActiveLinkColor = System.Drawing.Color.Blue;
			this.llblForgetPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llblForgetPass.LinkColor = System.Drawing.Color.Black;
			this.llblForgetPass.Location = new System.Drawing.Point(46, 227);
			this.llblForgetPass.Name = "llblForgetPass";
			this.llblForgetPass.Size = new System.Drawing.Size(145, 24);
			this.llblForgetPass.TabIndex = 5;
			this.llblForgetPass.TabStop = true;
			this.llblForgetPass.Text = "Forget password ?";
			this.llblForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblForgetPass_LinkClicked);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::draft_winform.Properties.Resources.pic_hide;
			this.pictureBox4.Location = new System.Drawing.Point(421, 158);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(36, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 18;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::draft_winform.Properties.Resources.pic_hide1;
			this.pictureBox3.Location = new System.Drawing.Point(421, 158);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(36, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::draft_winform.Properties.Resources.pic_password;
			this.pictureBox2.Location = new System.Drawing.Point(50, 158);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(36, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// btnHide
			// 
			this.btnHide.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHide.Location = new System.Drawing.Point(421, 158);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(36, 32);
			this.btnHide.TabIndex = 1;
			this.btnHide.Text = "Hide";
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnShow
			// 
			this.btnShow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShow.Location = new System.Drawing.Point(421, 158);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(36, 32);
			this.btnShow.TabIndex = 0;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::draft_winform.Properties.Resources.oic_username;
			this.pictureBox1.Location = new System.Drawing.Point(50, 93);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// llblCreateNew
			// 
			this.llblCreateNew.ActiveLinkColor = System.Drawing.Color.Blue;
			this.llblCreateNew.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llblCreateNew.LinkColor = System.Drawing.Color.Black;
			this.llblCreateNew.Location = new System.Drawing.Point(292, 227);
			this.llblCreateNew.Name = "llblCreateNew";
			this.llblCreateNew.Size = new System.Drawing.Size(165, 24);
			this.llblCreateNew.TabIndex = 4;
			this.llblCreateNew.TabStop = true;
			this.llblCreateNew.Text = "&Create new account ?";
			this.llblCreateNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCreateNew_LinkClicked_1);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(333, 291);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(100, 43);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "&Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
			// 
			// txtPass
			// 
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.Location = new System.Drawing.Point(91, 158);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(342, 32);
			this.txtPass.TabIndex = 1;
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(91, 93);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(353, 32);
			this.txtUsername.TabIndex = 0;
			// 
			// btnLog
			// 
			this.btnLog.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLog.Location = new System.Drawing.Point(87, 291);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(100, 43);
			this.btnLog.TabIndex = 3;
			this.btnLog.Text = "&Login";
			this.btnLog.UseVisualStyleBackColor = true;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click_1);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::draft_winform.Properties.Resources.pic_hide1;
			this.pictureBox5.Location = new System.Drawing.Point(448, 224);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(36, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 17;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.LightGray;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(141, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(507, 47);
			this.label2.TabIndex = 18;
			this.label2.Text = "LOGIN INFORMATION";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BackgroundImage = global::draft_winform.Properties.Resources.login_backgroung;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(800, 565);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox5);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login ";
			this.Load += new System.EventHandler(this.Login_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel llblCreateNew;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.LinkLabel llblForgetPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label2;
	}
}

