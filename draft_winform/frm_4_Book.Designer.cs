namespace draft_winform
{
	partial class management_book
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
			this.btnMyBook = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnBorrow = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnShowall = new System.Windows.Forms.Button();
			this.book_display_func = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMyBook);
			this.panel1.Controls.Add(this.btnReturn);
			this.panel1.Controls.Add(this.btnBorrow);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.btnShowall);
			this.panel1.Location = new System.Drawing.Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(135, 604);
			this.panel1.TabIndex = 0;
			// 
			// btnMyBook
			// 
			this.btnMyBook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMyBook.Location = new System.Drawing.Point(3, 141);
			this.btnMyBook.Name = "btnMyBook";
			this.btnMyBook.Size = new System.Drawing.Size(129, 67);
			this.btnMyBook.TabIndex = 4;
			this.btnMyBook.Text = "My books";
			this.btnMyBook.UseVisualStyleBackColor = true;
			this.btnMyBook.Click += new System.EventHandler(this.btnMyBook_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.Location = new System.Drawing.Point(0, 504);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(129, 67);
			this.btnReturn.TabIndex = 3;
			this.btnReturn.Text = "Return books";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnBorrow
			// 
			this.btnBorrow.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrow.Location = new System.Drawing.Point(3, 383);
			this.btnBorrow.Name = "btnBorrow";
			this.btnBorrow.Size = new System.Drawing.Size(129, 67);
			this.btnBorrow.TabIndex = 2;
			this.btnBorrow.Text = "Borrow books";
			this.btnBorrow.UseVisualStyleBackColor = true;
			this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(0, 262);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(129, 67);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add books";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnShowall
			// 
			this.btnShowall.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowall.Location = new System.Drawing.Point(3, 20);
			this.btnShowall.Name = "btnShowall";
			this.btnShowall.Size = new System.Drawing.Size(129, 67);
			this.btnShowall.TabIndex = 0;
			this.btnShowall.Text = "All books";
			this.btnShowall.UseVisualStyleBackColor = true;
			this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
			// 
			// book_display_func
			// 
			this.book_display_func.BackgroundImage = global::draft_winform.Properties.Resources.main_book21;
			this.book_display_func.Location = new System.Drawing.Point(140, 3);
			this.book_display_func.Name = "book_display_func";
			this.book_display_func.Size = new System.Drawing.Size(849, 614);
			this.book_display_func.TabIndex = 2;
			// 
			// management_book
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 612);
			this.Controls.Add(this.book_display_func);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "management_book";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_4_Book";
			this.Load += new System.EventHandler(this.management_book_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnShowall;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnBorrow;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel book_display_func;
		private System.Windows.Forms.Button btnMyBook;
	}
}