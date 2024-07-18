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
	public partial class frm_49_change_Acc : Form
	{
		public frm_49_change_Acc()
		{
			InitializeComponent();
		}

		classDataBase cl = new classDataBase();
		private void frm_48_change_Acc_Load(object sender, EventArgs e)
		{
			string command = "select * from tbltaikhoan where id = '"+GlobalVar.rootCode+"'";
			string user = "", pass = "";
			
			foreach(DataRow row in cl.execSQLCommand(command).Rows)
			{
				user = row[1].ToString().Trim();
				pass = row[2].ToString().Trim();
			}
			
			txtUsername.Text = user;	
			txtPassword.Text = pass;

		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string[] nv = new string[3];

			nv[0] = txtUsername.Text.Trim();
			nv[1] = txtPassword.Text.Trim();
			nv[2] = GlobalVar.position;
			string command = "select * from tbltaikhoan where tentaikhoan = '" + nv[0] + "'";
			if(cl.execSQLCommand(command).Rows.Count == 0)
			{
				if (MessageBox.Show("This action can not redo. Do you want to change !", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					cl.Update_Acc(GlobalVar.rootCode, nv);
					MessageBox.Show("Update successfully!", "Notification");
					frm_48_change_Acc_Load(sender, e);
					txtPassword.ReadOnly = true;
					txtUsername.ReadOnly = true;
				}
			}
			else
			{
				MessageBox.Show("Username has existed!", "Error");
			}


		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtUsername.ReadOnly = false;
			txtPassword.ReadOnly = false;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
