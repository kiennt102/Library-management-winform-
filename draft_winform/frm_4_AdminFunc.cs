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
	public partial class admin_Account : Form
	{
		public admin_Account()
		{
			InitializeComponent();
		}

		private void AddFormToPanel(Form form)
		{
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			admin_Account_functionDisplay.Controls.Clear();
			admin_Account_functionDisplay.Controls.Add(form);
			form.Show();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(GlobalVar.rootCode);
			admin_Account_profile form = new admin_Account_profile();
			AddFormToPanel(form);
		}

		private void btnManageaccount_Click(object sender, EventArgs e)
		{
			admin_Account_staff form = new admin_Account_staff();
			AddFormToPanel(form);
		}

		private void btnReaderaccount_Click(object sender, EventArgs e)
		{
			admin_Reader_account form = new admin_Reader_account();
			AddFormToPanel(form);
		}

		private void btnFindAcc_Click(object sender, EventArgs e)
		{
			admin_manage_acc form = new admin_manage_acc();
			AddFormToPanel(form);
	
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//errorProvider1.SetError(btn)
			MessageBox.Show("Please choose function!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			btnUpdate_Click(sender, e);
		}

		private void admin_Account_Load(object sender, EventArgs e)
		{
			if(GlobalVar.position == "reader")
			{
				btnReaderaccount.Enabled = false;
				btnManageaccount.Enabled = false;
			}
		}
	}
}
