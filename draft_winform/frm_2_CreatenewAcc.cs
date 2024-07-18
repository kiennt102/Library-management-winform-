using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Lifetime;

namespace draft_winform
{
	public partial class CreateNew : Form
	{
		public CreateNew()
		{
			InitializeComponent();
		}

		SqlConnection SqlCon;
		SqlCommand SqlCom;
		SqlDataReader SqlRead;
		SqlDataAdapter SqlAdapt;
		DataSet ds;

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(txtName.Text.Length > 0 || txtPhone.Text.Length > 0 || txtGmail.Text.Length > 0 || txtAddress.Text.Length > 0 )
			{
				if (MessageBox.Show("If you are back, this data will lost. Do you want to back?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					this.Close();
				}
			}
			else
			{
				this.Close();
			}

		}
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

		public List<string> list_gmail = new List<string> { };

		private void CreateNew_Load(object sender, EventArgs e)
		{
			dtpDOB.Format = DateTimePickerFormat.Custom;
			dtpDOB.CustomFormat = "dd/MM/yyyy";

			string path = "Data Source=NTDEVICE\\SQLEXPRESS;Initial Catalog=libraryMng;Integrated Security=True";
			SqlCon = new SqlConnection(path);

			ReOpen();
			SqlCom = new SqlCommand("select gmail from tblnhanvien", SqlCon);
			SqlRead = SqlCom.ExecuteReader();
			string gmail;
			while (SqlRead.Read())
			{
				gmail = SqlRead.GetString(0);
				list_gmail.Add(gmail);
			}
			SqlCon.Close();


			ReOpen();
			SqlCom = new SqlCommand("select gmail from tbldocgia", SqlCon);
			SqlRead = SqlCom.ExecuteReader();
			string gmail2;
			while (SqlRead.Read())
			{
				gmail2 = SqlRead.GetString(0);
				list_gmail.Add(gmail2);
			}
		}
		bool checkLength(string a, string b , string c, string d,string e)
		{
			if(a.Length > 0 && b.Length > 0 && c.Length > 0 && d.Length > 0 && e.Length >0)
			{
				return true;
			}
			return false;
		}

		bool checkPhone(string phone)
		{
			bool check = false;
			int sdt;
			for(int i = 0;i < phone.Length; i++)
			{
				if ( int.Parse(phone[0].ToString()) != 0 && int.TryParse(phone[i].ToString(),out sdt) != true)
				{
					break;
				}
				else
				{
					check = true;
				}
			}
			if(check && phone.Length == 10) { return true; }
			return false;
		}

		bool checkID(string id)
		{
			int charr;
			bool check = true;

			for (int i = 0; i < id.Length; i++)
			{
				if (int.TryParse(id[i].ToString(), out charr) == false)
				{
					check =false;
				}
			}

			if (id.Length == 12)
			{
				for (int i = 0; i < id.Length; i++)
				{
					if (int.TryParse(id[0].ToString(), out charr) == true && id[0].ToString().Trim() == "0" && check ==true)
					{
						return true;
					}
				}
			}
			return false;
		}

		bool checkGmail(string gmail,string role)
		{
			bool check = false;

			SqlCon.Close();
			SqlCon.Open();
			string command0 = "select count(*) from tblnhanvien where gmail = '"+gmail+"'";
			SqlCom = new SqlCommand(command0, SqlCon);
			if ( role == "manager" && (int)SqlCom.ExecuteScalar() == 0)
			{
				check = true;
			}


			SqlCon.Close();
			SqlCon.Open();
			string command9 = "select count(*) from tbldocgia where gmail = '"+gmail+"'";
			SqlCom = new SqlCommand(command9, SqlCon);
			if (role == "reader" && (int)SqlCom.ExecuteScalar()==0)
			{
				check = true;
			}

			string[] charac = gmail.Split('@');
			if(charac.Length > 1 && charac[1].Split('.').Count() > 1 && check == true)
			{
				return true;
			}
			return false;
		}


		private void button2_Click(object sender, EventArgs e)
		{
			//GlobalVar.position = cmbType.Text;
			ReOpen();
			errorProvider1.Clear();
			if (checkLength(txtPhone.Text, txtName.Text, txtGmail.Text, txtAddress.Text,txtId.Text))
			{
				if (checkID(txtId.Text))
				{
					errorProvider1.Clear();

					if (checkGmail(txtGmail.Text.Trim(), cmbType.Text.ToString()) )
					{
						errorProvider1.Clear();
						//MessageBox.Show($"{txtGmail.Text},{GlobalVar.position}");


						if (checkPhone(txtPhone.Text))
						{
							errorProvider1.Clear();

							if(cmbSex.Text == "Nam" || cmbSex.Text == "Nữ" || cmbSex.Text == "Khác")
							{
								errorProvider1.Clear();

								if (cmbType.Text == "manager") 
								{
									errorProvider1.Clear();
									SqlCom = new SqlCommand("select count(*) from tbltaikhoan where '" + txtId.Text.Trim() + "'= id", SqlCon);

									SqlCon.Close();
									SqlCon.Open();
									if ( (int)SqlCom.ExecuteScalar() == 0)
									{
										//GlobalVar.position = cmbType.Text.ToString();
										//GlobalVar.rootCode = txtId.Text.Trim();
										string command = "insert into tblnhanvien values('" + txtId.Text.Trim() + "',N'" + txtName.Text.Trim() + "','" + dtpDOB.Text.Trim() + "',N'" + txtAddress.Text.Trim() + "','" + txtGmail.Text.Trim() + "','" + txtId.Text.Trim() + "@123" + "','" + txtPhone.Text.ToString().Trim() + "',N'" +cmbSex.Text.Trim()+"','')";
										SqlCom = new SqlCommand(command, SqlCon);
										SqlCom.ExecuteNonQuery();


										string command2 = "insert into tbltaikhoan values('" + txtId.Text.ToString().Trim() + "','" + txtId.Text.Trim() + "','" + txtId.Text.Trim() + "@123" + "','"+cmbType.Text.ToString().Trim()+"','true')";
										SqlCom = new SqlCommand(command2, SqlCon);
										SqlCom.ExecuteNonQuery();

										MessageBox.Show($"Registration Successful!\nThis is your Username : {txtId.Text.Trim()}\nPassword : {txtId.Text.Trim()}@123\nPlease change the password after login !");
										txtId.Text = null;
										txtName.Text = null;
										txtGmail.Text = null;
										txtPhone.Text = null;
										txtAddress.Text = null;
										cmbType.SelectedIndex = -1;
										cmbSex.SelectedIndex = -1;
									}
									else
									{
										MessageBox.Show("Id has existed!");
									}
								}
								else if (cmbType.Text == "reader")
								{
									SqlCom = new SqlCommand("select count(*) from tbltaikhoan where '" + txtId.Text.Trim() + "' = id", SqlCon);

									SqlCon.Close();
									SqlCon.Open();
									if ((int)SqlCom.ExecuteScalar() == 0)
									{
										//GlobalVar.position = cmbType.Text.ToString();
										//GlobalVar.rootCode = txtId.Text.Trim();
										string command = "insert into tbldocgia values('" + txtId.Text.Trim() + "',N'" + txtName.Text.Trim() + "','" + dtpDOB.Text.Trim() + "',N'" + txtAddress.Text.Trim() + "','" + txtGmail.Text.Trim() + "','" + txtId.Text.Trim() + "@123" + "','"+txtPhone.Text.Trim()+"',N'"+cmbSex.Text.Trim()+"','')";
										SqlCom = new SqlCommand(command, SqlCon);
										SqlCom.ExecuteNonQuery();

										string command3 = "insert into tbltaikhoan values('" + txtId.Text.ToString().Trim() + "','" + txtId.Text.Trim() + "','" + txtId.Text.Trim() + "@123" + "','"+cmbType.Text.ToString().Trim()+"','true')";
										SqlCom = new SqlCommand(command3, SqlCon);
										SqlCom.ExecuteNonQuery();

										MessageBox.Show($"Registration Successful\nThis is your Username : {txtId.Text.Trim()}\nPassword: { txtId.Text.Trim()}@123\nPlease change the password after login !");
										txtId.Text = null;
										txtName.Text = null;
										txtGmail.Text = null;
										txtPhone.Text = null;
										txtAddress.Text = null;
										cmbType.SelectedIndex = -1;
										cmbSex.SelectedIndex = -1;
									}
									else
									{
										MessageBox.Show("Id has existed!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
									}
								}
								else
								{
									errorProvider1.SetError(cmbType, "Invalid value!");
								}
							}
							else
							{
								errorProvider1.SetError(cmbSex, "Invalid value !");
							}

						}
						else
						{
							errorProvider1.SetError(txtPhone, "Phone number is not valid.");
						}
					}
					else
					{
						errorProvider1.SetError(txtGmail, "Gmail contains invalid values.");
					}
				}
				else
				{
					errorProvider1.SetError(txtId, "ID contains invalid values!");
				}	
			}
			else
			{
				MessageBox.Show("Please filling all the missing!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

	
		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}

		private void dtpDOB_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
