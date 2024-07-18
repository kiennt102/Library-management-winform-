using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draft_winform
{
	public partial class ForgetpassReader : Form
	{
		public ForgetpassReader()
		{
			InitializeComponent();
		}

		SqlConnection SqlCon;
		SqlCommand SqlCom;
		SqlDataReader SqlRead;
		SqlDataAdapter SqlAdapt;
		DataSet ds;
		void ReOpen()
		{
			if (SqlCon.State == ConnectionState.Open)
			{
				SqlCon.Close();
			}
			if (SqlCon.State == ConnectionState.Closed)
			{
				SqlCon.Open();
			}
		}
		private void ForgetpassReader_Load(object sender, EventArgs e)
		{
			string path = "Data Source=NTDEVICE\\SQLEXPRESS;Initial Catalog=libraryMng;Integrated Security=True";
			SqlCon = new SqlConnection(path);

			ReOpen();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to back to login ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Close();
			}
		}

		private void btnTake_Click(object sender, EventArgs e)
		{
			ReOpen();
			bool check = false;
			SqlCom = new SqlCommand("select dg.gmail,tk.matkhau from tbldocgia dg inner join tbltaikhoan tk on(tk.id=dg.madocgia)", SqlCon);
			SqlRead = SqlCom.ExecuteReader();
			string gmail, pass1;
			while (SqlRead.Read())
			{
				gmail = SqlRead.GetString(0);
				pass1 = SqlRead.GetString(1);

				if (txtGmail.Text == gmail.Trim())
				{
					MessageBox.Show($"Your password is : {pass1}");
					check =true;
					txtGmail.Text = null;
					txtPassword.Text = null;
					txtGmail.Focus();
				}
			}

			if (check != true)
			{
				MessageBox.Show("Gmail is not valid or gmail has not been signed up");
			}
		}
	}
}
