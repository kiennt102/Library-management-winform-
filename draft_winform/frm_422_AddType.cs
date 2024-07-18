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
	public partial class frm_422_AddType : Form
	{
		public frm_422_AddType()
		{
			InitializeComponent();
		}

		classDataBase cl = new classDataBase();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string command = "select * from tbltheloai where maloai = '" + txtMaloai.Text + "'";
			if(cl.execSQLCommand(command).Rows.Count == 0)
			{
				if(txtTenloai.Text == null)
				{
					MessageBox.Show("Type name is not empty!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					string command1 = "insert into tbltheloai values('" + txtMaloai.Text + "',N'" + txtTenloai.Text + "')";
					cl.execSQLCommand(command1);
					MessageBox.Show("Add type successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtMaloai.Text = null;
					txtTenloai.Text = null;
				}

			}
			else
			{
				MessageBox.Show("Type_id has existed!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				txtMaloai.Text = null;
				txtTenloai.Text = null;
				txtMaloai.Focus();
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtMaloai.Text = null;
			txtTenloai.Focus();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("If you back, your data will lost. Do you want back?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
			{
				this.Hide();
			}
		}
	}
}
