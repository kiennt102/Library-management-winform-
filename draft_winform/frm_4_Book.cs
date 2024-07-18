using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draft_winform
{
	public partial class management_book : Form
	{
		public management_book()
		{
			InitializeComponent();
		}

		private void AddFormToPanel(Form form)
		{
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			book_display_func.Controls.Clear();
			book_display_func.Controls.Add(form);
			form.Show();
		}

		private void management_book_Load(object sender, EventArgs e)
		{
			if(GlobalVar.position == "reader")
			{
				btnAdd.Enabled = false;
				btnReturn.Enabled = false;
				btnBorrow.Enabled = false;
			}
		}

		private void btnShowall_Click(object sender, EventArgs e)
		{
			frm_41_BookShowAll form = new frm_41_BookShowAll();
			AddFormToPanel(form);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frm_42_AddBook frm = new frm_42_AddBook();
			AddFormToPanel(frm);
		}

		private void btnBorrow_Click(object sender, EventArgs e)
		{
			frm_43_BorowBook frm = new frm_43_BorowBook();
			AddFormToPanel(frm);
		}

		private void btnMyBook_Click(object sender, EventArgs e)
		{
			frm_40_mybooks frm = new frm_40_mybooks();
			AddFormToPanel(frm);
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			frm_44_ReturnBook frm = new frm_44_ReturnBook();
			AddFormToPanel(frm);
		}
	}
}
