using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draft_winform
{
	public partial class frm_42_AddBook : Form
	{
		public frm_42_AddBook()
		{
			InitializeComponent();
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			pbAdd.Cursor = Cursors.Hand;
		}

		private void pbAdd_MouseLeave(object sender, EventArgs e)
		{
			pbAdd.Cursor = Cursors.Default;
		}

		private void pbAdd_Click(object sender, EventArgs e)
		{
			frm_421_AddAuthor form = new frm_421_AddAuthor();
			form.ShowDialog();
		}

		private void comboBox2_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void frm_42_AddBook_Load(object sender, EventArgs e)
		{
			string command = "select tentacgia from tbltacgia";
			cbTacgia.DataSource = cl.execSQLCommand(command);
			cbTacgia.DisplayMember = "tentacgia";
			cbTacgia.SelectedIndex = -1;

			string command1 = "select tenloai from tbltheloai";
			cbTheloai.DataSource = cl.execSQLCommand(command1);
			cbTheloai.DisplayMember = "tenloai";
			cbTheloai.SelectedIndex = -1;

			txtManv.Text = GlobalVar.rootCode;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtMathem.Text = null;
			txtBookname.Text = null;
			cbTacgia.SelectedIndex = -1;
			cbTheloai.SelectedIndex = -1;
			txtSoluong.Text = null;
			txtGia.Text = null;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you want to back ?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.Hide();
			}
		}


		classDataBase cl = new classDataBase();


		private void btnAdd_Click(object sender, EventArgs e)
		{
			int price;

			if(txtMathem.Text.ToString().Length <= 0 || txtBookname.Text.ToString().Length == 0|| cbTacgia.SelectedIndex == -1|| cbTheloai.SelectedIndex ==-1 || int.TryParse(txtGia.Text.ToString().Trim(),out price) == false || int.TryParse(txtSoluong.Text.ToString(),out price) == false)
			{
				errorProvider1.SetError(btnAdd, "Invalid values!");
				MessageBox.Show("Your data entered are invalid, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
			}
			else
			{
				string matg = "", matheloai = "";

				//take id of the loai in tbltacgia
				string take_tg_id = "select * from tbltacgia where tentacgia like N'" + cbTacgia.Text.ToString() + "'";
				foreach (DataRow row in cl.execSQLCommand(take_tg_id).Rows)
				{
					matg += row[0].ToString().Trim();
				}

				//take id of the loai in tbltheloai
				string take_tl_id = "select * from tbltheloai where tenloai like N'" + cbTheloai.Text.ToString() + "'";
				foreach (DataRow row in cl.execSQLCommand(take_tl_id).Rows)
				{
					matheloai += row[0].ToString().Trim();
				}

				//auto random book id 
				Random rd = new Random();
				string masach;
				string masach_duplicate;


				//check existence
				string command = "select * from tblthemsach where mathem = '" + txtMathem.Text.ToString() + "'";
				string command_check = "select * from tblthemsach where mathem = '" + txtMathem.Text.Trim() + "' and manhanvien ='" + txtManv.Text + "' and ngaythem = '" + dtpDate.Text.Trim() + "'";

				if (cl.execSQLCommand(command).Rows.Count == 0)
				{
					//if additional code has not existed -> insert into tblthemsach
					string command1 = "insert into tblthemsach values('" + txtMathem.Text.ToString() + "','" + txtManv.Text.ToString() + "','" + dtpDate.Text.Trim() + "','"+txtMota.Text.Trim()+"')";
					cl.execSQLCommand(command1);		

					if (MessageBox.Show("Make sure additional information are correct!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
					{
						for (int i = 0; i < int.Parse(txtSoluong.Text); i++)
						{
							int masach1 = rd.Next(1000);
							masach = masach1.ToString() + i.ToString();

							//if book id and added code appear two times not allowed to insert into tblctthem  
							string command2 = "select * from tblthemsach ts inner join tblctthem ctt on(ctt.mathem = ts.mathem) where ts.mathem = '" + txtMathem.Text + "' and ctt.masach ='" + masach.ToString() + "' ";

							if (cl.execSQLCommand(command2).Rows.Count == 0)
							{
								//check duplicated bookd_id

								string command4 = "insert into tblctthem values('" + txtMathem.Text.ToString() + "','" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "',N'" + cbTacgia.Text.ToString() + "',N'" + cbTheloai.Text.ToString() + "','" + txtGia.Text.ToString().Trim() + "')";
								cl.execSQLCommand(command4);
								string command5 = "insert into tblsach values('" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "','" + matg.ToString().Trim() + "','" + matheloai.ToString().Trim() + "','available','" + txtGia.Text.ToString() + "','')";
								cl.execSQLCommand(command5);

								//string check_id = "select * from tblsach where id = '" + masach + "'";
								//if (cl.execSQLCommand(check_id).Rows.Count == 0)
								//{
								//	string command4 = "insert into tblctthem values('" + txtMathem.Text.ToString() + "','" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "',N'" + cbTacgia.Text.ToString() + "',N'" + cbTheloai.Text.ToString() + "','" + txtGia.Text.ToString().Trim() + "')";
								//	cl.execSQLCommand(command4);
								//	string command5 = "insert into tblsach values('" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "','" + matg.ToString().Trim() + "','" + matheloai.ToString().Trim() + "','available','" + txtGia.Text.ToString() + "','')";
								//	cl.execSQLCommand(command5);
								//}
								//else
								//{
								//	masach_duplicate = masach.ToString() + "AS";
								//	string command4 = "insert into tblctthem values('" + txtMathem.Text.ToString() + "','" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "',N'" + cbTacgia.Text.ToString() + "',N'" + cbTheloai.Text.ToString() + "','" + txtGia.Text.ToString().Trim() + "')";
								//	cl.execSQLCommand(command4);
								//	string command5 = "insert into tblsach values('" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "','" + matg.ToString().Trim() + "','" + matheloai.ToString().Trim() + "','available','" + txtGia.Text.ToString() + "','')";
								//	cl.execSQLCommand(command5);
								//}
							}
							else
							{
								MessageBox.Show("AddedID and bookID have existed or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}

						MessageBox.Show("Books were added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						//txtMathem.Text = null;
						txtBookname.Text = null;
						cbTacgia.SelectedIndex = -1;
						cbTheloai.SelectedIndex = -1;
						txtGia.Text = null;
						txtSoluong.Text = null;
					}

				}
				else if (cl.execSQLCommand(command_check).Rows.Count >= 1)
				{
					if (MessageBox.Show("Make sure additional information are correct!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
					{
						for (int i = 0; i < int.Parse(txtSoluong.Text); i++)
						{
							int masach1 = rd.Next(1000);
							masach = masach1.ToString() + i.ToString();

							//if book id and added code appear two times not allowed to insert into tblctthem  
							string command2 = "select * from tblthemsach ts inner join tblctthem ctt on(ctt.mathem = ts.mathem) where ts.mathem = '" + txtMathem.Text + "' and ctt.masach ='" + masach.ToString() + "' ";

							if (cl.execSQLCommand(command2).Rows.Count == 0)
							{
								//check duplicated bookd_id

								string command4 = "insert into tblctthem values('" + txtMathem.Text.ToString() + "','" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "',N'" + cbTacgia.Text.ToString() + "',N'" + cbTheloai.Text.ToString() + "','" + txtGia.Text.ToString().Trim() + "')";
								cl.execSQLCommand(command4);
								string command5 = "insert into tblsach values('" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "','" + matg.ToString().Trim() + "','" + matheloai.ToString().Trim() + "','available','" + txtGia.Text.ToString() + "','')";
								cl.execSQLCommand(command5);

								//string check_id = "select * from tblsach where id = '" + masach + "'";
								//if (cl.execSQLCommand(check_id).Rows.Count == 0)
								//{
								//	string command4 = "insert into tblctthem values('" + txtMathem.Text.ToString() + "','" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "',N'" + cbTacgia.Text.ToString() + "',N'" + cbTheloai.Text.ToString() + "','" + txtGia.Text.ToString().Trim() + "')";
								//	cl.execSQLCommand(command4);
								//	string command5 = "insert into tblsach values('" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "','" + matg.ToString().Trim() + "','" + matheloai.ToString().Trim() + "','available','" + txtGia.Text.ToString() + "','')";
								//	cl.execSQLCommand(command5);
								//}
								//else
								//{
								//	masach_duplicate = masach.ToString() + "AS";
								//	string command4 = "insert into tblctthem values('" + txtMathem.Text.ToString() + "','" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "',N'" + cbTacgia.Text.ToString() + "',N'" + cbTheloai.Text.ToString() + "','" + txtGia.Text.ToString().Trim() + "')";
								//	cl.execSQLCommand(command4);
								//	string command5 = "insert into tblsach values('" + masach.ToString() + "',N'" + txtBookname.Text.ToString() + "','" + matg.ToString().Trim() + "','" + matheloai.ToString().Trim() + "','available','" + txtGia.Text.ToString() + "','')";
								//	cl.execSQLCommand(command5);
								//}
							}
							else
							{
								MessageBox.Show("AddedID and bookID have existed or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}

						MessageBox.Show("Books were added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						//txtMathem.Text = null;
						txtBookname.Text = null;
						cbTacgia.SelectedIndex = -1;
						cbTheloai.SelectedIndex = -1;
						txtGia.Text = null;
						txtSoluong.Text = null;
					}
				}
				else
				{
					MessageBox.Show("Id has existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			frm_422_AddType frm = new frm_422_AddType();
			frm.ShowDialog();
		}

		private void cbTacgia_Click(object sender, EventArgs e)
		{
			string command = "select tentacgia from tbltacgia";
			cbTacgia.DataSource = cl.execSQLCommand(command);
			cbTacgia.DisplayMember = "tentacgia";
			cbTacgia.SelectedIndex = -1;
		}

		private void cbTheloai_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbTheloai_Click(object sender, EventArgs e)
		{
			string command1 = "select tenloai from tbltheloai";
			cbTheloai.DataSource = cl.execSQLCommand(command1);
			cbTheloai.DisplayMember = "tenloai";
			cbTheloai.SelectedIndex = -1;
		}
	}
}
