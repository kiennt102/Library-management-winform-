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
	public partial class admin_Account_profile : Form
	{
		classDataBase cldb = new classDataBase();

		public admin_Account_profile()
		{
			InitializeComponent();
		}
		private void admin_Account_profile_Load(object sender, EventArgs e)
		{
			string code="",name ="",dob="",address="",gmail = "",phone = "",sex="";

			if(GlobalVar.position == "manager")
			{
				foreach (DataRow row in cldb.load_privateI4(GlobalVar.rootCode).Rows)
				{
					code += row[0].ToString().Trim();
					name += row[1].ToString().Trim();
					dob += row[2].ToString().Trim();
					address += row[3].ToString().Trim();
					gmail += row[4].ToString().Trim();
					phone += row[6].ToString().Trim();
					sex += row[7].ToString().Trim();
				}
			}
			else
			{
				foreach (DataRow row in cldb.load_privateI4_reader(GlobalVar.rootCode).Rows)
				{
					code += row[0].ToString().Trim();
					name += row[1].ToString().Trim();
					dob += row[2].ToString().Trim();
					address += row[3].ToString().Trim();
					gmail += row[4].ToString().Trim();
					phone += row[6].ToString().Trim();
					sex += row[7].ToString().Trim();
				}
			}

			txtAddress.Text = address;
			txtName.Text = name;
			txtDob.Text = dob;
			txtGmail.Text = gmail;
			txtPhone.Text = phone;
			txtID.Text = code;
			lblUsername.Text = name.ToUpper().Trim();	
			txtSex.Text = sex;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//if(MessageBox.Show("Do you want to delete"))
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			
		}

		private void btnUpdate_Click_1(object sender, EventArgs e)
		{
		
		}
	}
}
