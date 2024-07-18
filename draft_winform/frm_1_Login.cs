using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace draft_winform
{
	public partial class Login : Form
	{
		public static string temp;
		public Login()
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
			if (SqlCon.State != ConnectionState.Open)
			{
				SqlCon.Close();
			}
			if (SqlCon.State == ConnectionState.Closed)
			{
				SqlCon.Open();
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			txtUsername.Focus();
			string path = "Data Source=NTDEVICE\\SQLEXPRESS;Initial Catalog=libraryMng;Integrated Security=True";
			SqlCon = new SqlConnection(path);
			ReOpen();


			pictureBox4.Visible = false;

			btnHide.Visible = false;
			txtPass.UseSystemPasswordChar = true;

			string command = "select * from tbltaikhoan ";
			cldb.execSQLCommand(command);
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		classDataBase cldb = new classDataBase();

		private void btnLog_Click_1(object sender, EventArgs e)
		{
			//ReOpen();
			//bool check = false;

			//if(txtUsername.Text.Length != 0 && txtPass.Text.Length != 0)
			//{
			//	if(cmbType.Text.Length != 0)
			//	{
			//		if (cmbType.Text.Trim() == "manager")
			//		{
			//			SqlCom = new SqlCommand("select * from tblNhanVien", SqlCon);
			//			SqlRead = SqlCom.ExecuteReader();
			//			string username, password;
			//			while (SqlRead.Read())
			//			{
			//				username = SqlRead.GetString(0);
			//				password = SqlRead.GetString(5);

			//				if (txtUsername.Text == username.Trim() && txtPass.Text == password.Trim())
			//				{
			//					check = true;
			//					break;
			//				}
			//			}

			//			if (check )
			//			{
			//				MessageBox.Show("Login successful.","Notification");
			//				temp = txtUsername.Text;
			//				GlobalVar.rootCode = temp;
			//				GlobalVar.position = cmbType.Text.Trim();
			//				txtUsername.Text = null;
			//				txtPass.Text = null;
			//				cmbType.SelectedIndex = -1;
			//				mainMenu_Admin form = new mainMenu_Admin();
			//				SqlCon.Close();
			//				this.Hide();
			//				form.Show();
			//			}
			//			else
			//			{
			//				SqlCon.Close();
			//				txtUsername.Text = null;
			//				txtPass.Text = null;
			//				cmbType.SelectedIndex = -1;
			//				txtUsername.Focus();
			//				MessageBox.Show("Login failed!\nUsername or password is incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//			}
			//		}
			//		else if(cmbType.Text.Trim() =="reader")
			//		{
			//			SqlCom = new SqlCommand("select madocgia,matkhau from tblDocGia", SqlCon);
			//			SqlRead = SqlCom.ExecuteReader();
			//			string username, password;
			//			while (SqlRead.Read())
			//			{
			//				username = SqlRead.GetString(0);
			//				password = SqlRead.GetString(1);

			//				if (txtUsername.Text == username.Trim() && txtPass.Text == password.Trim())
			//				{
			//					check = true;
			//					break;
			//				}
			//			}

			//			if (check)
			//			{
			//				MessageBox.Show("Login successful");
			//				GlobalVar.rootCode = txtUsername.Text.Trim();
			//				GlobalVar.position = cmbType.Text.Trim();
			//				txtUsername.Text = null;
			//				txtPass.Text = null;
			//				cmbType.SelectedIndex = -1;
			//				mainMenu_Admin form = new mainMenu_Admin();
			//				SqlCon.Close();
			//				this.Hide();
			//				form.Show();
			//			}
			//			else
			//			{
			//				SqlCon.Close();
			//				txtUsername.Text = null;
			//				txtPass.Text = null;
			//				cmbType.SelectedIndex = -1;
			//				txtUsername.Focus();
			//				MessageBox.Show("Login failed!\nUsername or password is incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//			}
			//		}
			//	}
			//	else
			//	{
			//		errorProvider1.SetError(cmbType, "Please choose type !");
			//		MessageBox.Show("Please fill the blank!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			//		errorProvider1.Clear();
			//	}

			//}
			//else
			//{
			//	errorProvider1.SetError(txtUsername,"Invalid values!");
			//	errorProvider1.SetError(txtPass, "Invalid values!");
			//	MessageBox.Show("Please fill the blank!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	errorProvider1.Clear();
			//}

			string command = "select * from tbltaikhoan";
			bool check = false;

			if(txtUsername.Text.Length == 0 && txtPass.Text.Length == 0)
			{
				errorProvider1.SetError(txtUsername, "Invalid values!");
				errorProvider1.SetError(txtPass, "Invalid values!");
				MessageBox.Show("Please fill the blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
			}
			else if(txtUsername.Text.Length == 0)
			{
				errorProvider1.SetError(txtUsername, "Invalid values!");
				MessageBox.Show("Please fill the blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
			}
			else if(txtPass.Text.Length == 0)
			{
				errorProvider1.SetError(txtPass, "Invalid values!");
				MessageBox.Show("Please fill the blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
			}
			else
			{
				if(cmbType.SelectedIndex != -1)
				{

					foreach (DataRow row in cldb.execSQLCommand(command).Rows)
					{
						if (row[1].ToString().Trim() == txtUsername.Text && row[2].ToString().Trim() == txtPass.Text && row[3].ToString().Trim() ==cmbType.Text.ToString().Trim() && row[4].ToString().Trim() != "false")
						{
							check = true;
							GlobalVar.rootCode = row[0].ToString().Trim();
							GlobalVar.position = cmbType.Text.ToString().Trim();
							break;
						}
					}

					if (check)
					{
						//if(cmbType.Text.ToString().Trim() == "manager")
						//{
						//	mainMenu_Admin form = new mainMenu_Admin();
						//	this.Close();
						//	form.Show();
						//}
						//else if(cmbType2.Text.ToString().Trim() == "reader")
						//{

						//}
						MessageBox.Show("Login successful.", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
						mainMenu_Admin form = new mainMenu_Admin();
						this.Hide();
						form.Show();
					}
					else
					{
						MessageBox.Show("Login failed!\nUsername or password is incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						cmbType.SelectedIndex = -1;
						txtUsername.Text = "";
						txtPass.Text = "";
						txtUsername.Focus();
					}
				}
				else
				{
					errorProvider1.SetError(cmbType, "Please choose type !");
					MessageBox.Show("Please fill the blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					errorProvider1.Clear();
				}

			}			
		}

		private void btnExit_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			txtPass.UseSystemPasswordChar = true;
			btnHide.Visible = false;
			btnShow.Visible = true;
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			txtPass.UseSystemPasswordChar = false;
			btnShow.Visible = false;
			btnHide.Visible = true;

		}

		private void llblCreateNew_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SqlCon.Close();
			CreateNew form2 = new CreateNew();
			form2.ShowDialog();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			txtPass.UseSystemPasswordChar = true;
			btnHide.Visible = false;
			btnShow.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = false;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			txtPass.UseSystemPasswordChar = false;
			btnShow.Visible = false;
			btnHide.Visible = true;
			pictureBox4.Visible = true;
			pictureBox3.Visible = false;
		}

		private void llblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			errorProvider1.Clear();
			if (cmbType.Text.Trim() == "manager")
			{
				ForgetPass fg = new ForgetPass();
				fg.ShowDialog();
			}
			else if (cmbType.Text.Trim() == "reader")
			{
				ForgetpassReader fr = new ForgetpassReader();
				fr.ShowDialog();
			}
			else
			{
				errorProvider1.SetError(cmbType, "Not allowed blank!");
				MessageBox.Show("Please fill in the blank","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				errorProvider1.Clear();
			}

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
