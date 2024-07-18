using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace draft_winform
{
	public partial class CreateAccount : Form
	{
		public CreateAccount()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if ((txtPass.Text.Length > 0 || txtUsername.Text.Length > 0 || txtRePass.Text.Length > 0 ))
			{
				if (MessageBox.Show("If you are back, this data will lost. Do you want to back?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					//this.Close();
					//CreateNew form2 = new CreateNew();
					//form2.Show();
					this.Hide();
				}
			}
			else
			{
				//this.Close();
				//CreateNew acc = new CreateNew();
				//acc.Show();
				this.Hide();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{

		}
	}
}
