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
	public partial class admin_manage_acc : Form
	{
		public admin_manage_acc()
		{
			InitializeComponent();
		}

		classDataBase cldb = new classDataBase();

		bool checkPhone(string phone)
		{
			bool check = false;
			int sdt;
			for (int i = 0; i < phone.Length; i++)
			{
				if (int.Parse(phone[0].ToString()) != 0 && int.TryParse(phone[i].ToString(), out sdt) != true)
				{
					break;
				}
				else
				{
					check = true;
				}
			}
			if (check && phone.Length == 10) { return true; }
			return false;
		}

		bool check_Gmail(string gmail)
		{
			string[] charac = gmail.Split('@');
			if (charac.Length > 1 && charac[1].Split('.').Count() > 1)
			{
				return true;
			}
			return false;
		}


		bool check_Datetime(string date)
		{
			string[] date_char = date.Split('/');
			if (int.Parse(date_char[1]) >= 1 && int.Parse(date_char[1]) <= 31 && int.Parse(date_char[0]) >= 1 && int.Parse(date_char[0]) <= 12 && int.Parse(date_char[2]) >= 1000)
			{
				return true;
			}
			return false;

		}



		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string[] person = new string[8];
			if (txtName.Text.Length == 0 || txtAddress.Text.Length == 0 || cbSex.Text.Length == 0)
			{
				//errorProvider1.SetError()
				MessageBox.Show("Please fill all the blanks !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("This action can not redo. Do you want to update?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
				{
					if (checkPhone(txtPhone.Text.ToString()))
					{
						if (check_Datetime(mtxtDob.Text.ToString()))
						{
							if (GlobalVar.position == "manager")
							{
								string command = "select * from tblnhanvien where gmail = '" + txtGmail.Text.ToString().Trim() + "'";
								//MessageBox.Show(cldb.execSQLCommand(command).Rows.Count.ToString());
								//MessageBox.Show(GlobalVar.rootCode);
								if (cldb.execSQLCommand(command).Rows.Count <= 1 && check_Gmail(txtGmail.Text.ToString()))
								{
									//MessageBox.Show("aaaaaaaaaaa");
									person[0] = GlobalVar.rootCode;
									person[1] = txtName.Text.ToString().Trim();
									person[2] = mtxtDob.Text.ToString().Trim();
									person[3] = txtAddress.Text.ToString().Trim();
									person[4] = txtGmail.Text.ToString().Trim();
									person[5] = txtPhone.Text.ToString().Trim();
									person[6] = cbSex.Text.ToString().Trim();


									string note = "";
									string command1 = "select * from tblnhanvien where manv = '" + person[0] + "'";
									foreach (DataRow row in cldb.execSQLCommand(command1).Rows)
									{
										note += row[8];
									}
									person[7] = note;


									cldb.Update_NV_Recor(person[0], person);
									MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
									txtName.Text = null;
									mtxtDob.Text = null;
									txtAddress.Text = null;
									txtGmail.Text = null;
									txtPhone.Text = null;
									cbSex.SelectedIndex = -1;
								}
								else
								{
									MessageBox.Show("Gmail has existed or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}

							}
							else
							{
								string command = "select * from tbldocgia where gmail = '" + txtGmail.Text.ToString().Trim() + "'";
								//MessageBox.Show(cldb.execSQLCommand(command).Rows.Count.ToString());
								//MessageBox.Show(GlobalVar.rootCode);
								if (cldb.execSQLCommand(command).Rows.Count <= 1 && check_Gmail(txtGmail.Text.ToString()))
								{
									person[0] = GlobalVar.rootCode;
									person[1] = txtName.Text.ToString().Trim();
									person[2] = mtxtDob.Text.ToString().Trim();
									person[3] = txtAddress.Text.ToString().Trim();
									person[4] = txtGmail.Text.ToString().Trim();
									person[5] = txtPhone.Text.ToString().Trim();
									person[6] = cbSex.Text.ToString().Trim();

																		string note = "";
									string command1 = "select * from tbldocgia where madocgia = '" + person[0] + "'";
									foreach (DataRow row in cldb.execSQLCommand(command1).Rows)
									{
										note += row[8];
									}
									person[7] = note;

									cldb.Update_DG_Recor(person[0], person);
									MessageBox.Show("Update successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
									txtName.Text = null;
									mtxtDob.Text = null;
									txtAddress.Text = null;
									txtGmail.Text = null;
									txtPhone.Text = null;
									cbSex.SelectedIndex = -1;
								}
								else
								{
									MessageBox.Show("Gmail has existed or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
						}
						else
						{
							MessageBox.Show("Date time values are invalid format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Phone number contains invalid values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			
		}

		private void manageAccount_Paint(object sender, PaintEventArgs e)
		{

		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void admin_manage_acc_Load(object sender, EventArgs e)
		{
			txtUsername.Text = GlobalVar.rootCode.ToString().Trim();
		}

		private void btnChangepass_Click(object sender, EventArgs e)
		{
			frm_49_change_Acc form = new frm_49_change_Acc();
			form.ShowDialog();
		}
	}
}
