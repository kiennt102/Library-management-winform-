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
	public partial class frm_421_AddAuthor : Form
	{
		public frm_421_AddAuthor()
		{
			InitializeComponent();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtHoten.Text = null;
			txtMtg.Text = null;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if( (txtHoten.Text != null && txtMtg.Text != null) || txtHoten.Text != null || txtMtg.Text != null)
			{
				if(MessageBox.Show("If you back, this data will lost. Do you want to back?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					this.Hide();
				}
			}
		}

		classDataBase cl = new classDataBase();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string command = "select * from tbltacgia where matacgia = '" + txtMtg.Text + "'";
			if(cl.execSQLCommand(command).Rows.Count == 0)
			{
				if(txtHoten.Text == null)
				{
					MessageBox.Show("Author name is not empty!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					string command2 = "insert into tbltacgia values('" + txtMtg.Text.ToString().Trim().ToLower() + "',N'" + txtHoten.Text.ToString() + "')";
					cl.execSQLCommand(command2);
					MessageBox.Show("Add author successful!", "Notification");
					txtMtg.Text = null;
					txtHoten.Text = null;
					txtMtg.Focus();
				}
			}
			else
			{
				MessageBox.Show("Author id has existed!", "Error");
				txtMtg.Text = null;
				txtHoten.Text = null;
				txtMtg.Focus();
			}
		}
	}
}
