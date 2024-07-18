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
	public partial class admin_Reader_account : Form
	{
		public admin_Reader_account()
		{
			InitializeComponent();
		}

		classDataBase cl = new classDataBase();
		private void admin_Reader_account_Load(object sender, EventArgs e)
		{
			btnDelete.Enabled = false;
			cbType.SelectedIndex = 0;
			txtSearch.ReadOnly = true;
			string command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia";
			
			DataTable dt = new DataTable();
			dt = cl.execSQLCommand(command);

			dataGridView1.DataSource = dt;
		}
		classDataBase cldb =new classDataBase();
		private void btnADD_Click(object sender, EventArgs e)
		{
			CreateNew frm = new CreateNew();
			frm.ShowDialog();
			//string[] nv = new string[7];
			//nv[0] = txtReaderID.Text;
			//nv[1] = txtFullname.Text;
			//nv[2] = mtxtDob.Text;
			//nv[3] = txtAddress.Text;
			//nv[4] = txtGmail.Text;
			//nv[5] = txtPhone.Text.Trim();
			//nv[6] = cbSex.Text.Trim();

			//string command = "select * from tbldocgia where madocgia = '" + txtReaderID.Text + "'";
			//string command2 = "select * from tbldocgia where gmail = '" + txtGmail.Text + "'";

			//if (cldb.execSQLCommand(command).Rows.Count > 0) 
			//{
			//	MessageBox.Show("Reader_id has existed or invalid.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	txtReaderID.Text = null;
			//	txtFullname.Text = null;
			//	mtxtDob.Text = null;
			//	txtAddress.Text = null;
			//	txtGmail.Text = null;
			//	txtPhone.Text = null;
			//	cbSex.SelectedIndex = -1;
			//}
			//else
			//{
			//	if(cldb.execSQLCommand(command2).Rows.Count > 0)
			//	{
			//		MessageBox.Show("Gmail has existed or invalid.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//		txtReaderID.Text = null;
			//		txtFullname.Text = null;
			//		mtxtDob.Text = null;
			//		txtAddress.Text = null;
			//		txtGmail.Text = null;
			//		txtPhone.Text = null;
			//		cbSex.SelectedIndex = -1;
			//	}
			//	else
			//	{
			//		cldb.InsertRecords_dg(nv);
			//		MessageBox.Show("Add staff successful.", "Notification");
			//		txtReaderID.Text = null;
			//		txtFullname.Text = null;
			//		mtxtDob.Text = null;
			//		txtAddress.Text = null;
			//		txtGmail.Text = null;
			//		txtPhone.Text = null;
			//		cbSex.SelectedIndex = -1;
			//		dataGridView1.DataSource = cldb.reloadDATA("tbldocgia");
			//	}
			//}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rows = e.RowIndex;
			if(rows >= 0)
			{
				txtReaderID.Text = dataGridView1[0, rows].Value.ToString().Trim();
				txtFullname.Text = dataGridView1[1, rows].Value.ToString().Trim();
				txtAddress.Text = dataGridView1[5, rows].Value.ToString().Trim();
				txtGmail.Text = dataGridView1[6, rows].Value.ToString().Trim();
				txtPhone.Text = dataGridView1[4, rows].Value.ToString().Trim();
				cbSex.Text = dataGridView1[3, rows].Value.ToString().Trim();
				mtxtDob.Text = dataGridView1[2, rows].Value.ToString().Trim();
				txtGhichu.Text = dataGridView1[7,rows].Value.ToString().Trim();
			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This action can not redo. Do you want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				string command = "update tbldocgia set ghichu = 'not available' where madocgia = '" + txtReaderID.Text + "'";
				cldb.execSQLCommand(command);

				string command2 = "update tbltaikhoan set trangthai = 'false' where id = '" + txtReaderID.Text + "'";
				cldb.execSQLCommand(command2);
				MessageBox.Show("Delete reader successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

				pbReload_Click(sender, new EventArgs());
			}
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string[] nv = new string[8];
			nv[0] = txtReaderID.Text.Trim();
			nv[1] = txtFullname.Text.Trim();
			nv[2] = mtxtDob.Text.Trim();
			nv[3] = txtAddress.Text.Trim();
			nv[4] = txtGmail.Text.Trim();
			nv[5] = txtPhone.Text.Trim();
			nv[6] = cbSex.Text.Trim();
			nv[7] = txtGhichu.Text.Trim();

			string update_code = nv[0];
			string command2 = "select * from tbldocgia where gmail = '" + txtGmail.Text + "'";

			if(txtGhichu.Text.ToLower() == "not available")
			{
				MessageBox.Show("Can not update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("You can redo this acction, do you want to keep updating ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					if (txtFullname.Text.Length > 0 && txtAddress.Text.Length > 0 && cbSex.SelectedIndex != -1)
					{
						if (cldb.execSQLCommand(command2).Rows.Count <= 1 && check_Gmail(txtGmail.Text.ToString()) == true)
						{
							if (checkPhone(txtPhone.Text.ToString().Trim()))
							{
								if (check_Datetime(mtxtDob.Text.ToString().Trim()))
								{
									cldb.Update_DG_Recor(update_code, nv);
									MessageBox.Show("Update successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
									txtReaderID.Text = null;
									txtFullname.Text = null;
									mtxtDob.Text = null;
									txtAddress.Text = null;
									txtGmail.Text = null;
									txtPhone.Text = null;
									cbSex.SelectedIndex = -1;
									txtGhichu.Text = null;
									dataGridView1.DataSource = cldb.execSQLCommand("select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia");
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
						else
						{
							MessageBox.Show("Gmail has existed or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						errorProvider1.SetError(btnUpdate, "Please fill all the empty values!");
						MessageBox.Show("Invalid values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						errorProvider1.Clear();
					}

				}
			}
			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}

		private void btnSearch_Click_1(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			string command = "";

			if (cbType.Text.ToLower().Trim() == "id")
			{
				command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia where madocgia = '" + txtSearch.Text.Trim() + "'";
			}
			else if (cbType.Text.ToLower().Trim() == "name")
			{
				command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia where hoten like '%" + txtSearch.Text.Trim() + "%'";
			}
			else if (cbType.Text.ToLower().Trim() == "address")
			{
				command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia where diachi like '%" + txtSearch.Text.Trim() + "%'";
			}
			else
			{
				errorProvider1.SetError(txtSearch, "Please fill the blank !");
				MessageBox.Show("Please enter values for the blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear(); 
				cbType.SelectedIndex = 0;
			}

			DataTable dt = new DataTable();
			dt = cldb.execSQLCommand(command);

			dataGridView1.DataSource = dt;

		}
	

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void panel1_MouseLeave(object sender, EventArgs e)
		{
			pbSearch.Cursor = Cursors.Default;

		}

		private void pbSearch_MouseEnter(object sender, EventArgs e)
		{
			pbSearch.Cursor = Cursors.Hand;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string command = "";
			if (cbType.Text.ToLower().Trim() == "id")
			{
				command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia where madocgia = '" + txtSearch.Text.Trim() + "'";
			}

			else if (cbType.Text.ToLower().Trim() == "name")
			{
				command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia where hoten like '%" + txtSearch.Text.Trim() + "%'";
			}
			else if (cbType.Text.ToLower().Trim() == "address")
			{
				command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia where diachi like '%" + txtSearch.Text.Trim() + "%'";
			}
			else
			{
				errorProvider1.SetError(txtSearch, "Please fill the blank !");
				MessageBox.Show("Please enter value to the blank !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
				cbType.SelectedIndex = 0;
			}

			if (cbType.SelectedIndex != -1 && txtSearch.Text.Length == 0)
			{
				command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia";
			}
			DataTable dt = new DataTable();
			dt = cldb.execSQLCommand(command);

			dataGridView1.DataSource = dt;

		}

		private void txtSearch_Click(object sender, EventArgs e)
		{
			if (cbType.SelectedIndex == -1 || cbType.Text.Length == 0)
			{
				txtSearch.ReadOnly = true;
			}
			else
			{
				txtSearch.ReadOnly = false;
			}
		}

		private void cbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbType.SelectedIndex == -1 || cbType.Text.Length == 0)
			{
				txtSearch.ReadOnly = true;
			}
			else
			{
				txtSearch.ReadOnly = false;
			}
		}

		private void cbType_TextChanged(object sender, EventArgs e)
		{
			txtSearch_Click(sender, e);
		}

		private void pbReload_Click(object sender, EventArgs e)
		{
			string command = "select madocgia[ReaderID],hoten[Fullname],ngaysinh[Dob],gt[Sex],sdt[Phone],diachi[Address],gmail[Gmail],ghichu[Note] from tbldocgia";
			dataGridView1.DataSource = cldb.execSQLCommand(command);
		}

		private void txtReaderID_TextChanged(object sender, EventArgs e)
		{
			if(txtReaderID.Text.Length == 0)
			{
				btnDelete.Enabled = false;
			}
			else
			{
				btnDelete.Enabled = true;
			}
		}

		private void txtGhichu_TextChanged(object sender, EventArgs e)
		{
			if(txtGhichu.Text.Trim().ToLower() =="not available")
			{
				txtGhichu.ReadOnly = true;
			}
			else
			{
				txtGhichu.ReadOnly = false;
			}
		}
	}
}
