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
	public partial class frm_43_BorowBook : Form
	{
		public frm_43_BorowBook()
		{
			InitializeComponent();
		}

		classDataBase cl = new classDataBase();
		private void frm_43_BorowBook_Load(object sender, EventArgs e)
		{			
			cbManv.Text = GlobalVar.rootCode;

			string command1 = "select madocgia from tbldocgia";
			cbMadocgia.DataSource = cl.execSQLCommand(command1);
			cbMadocgia.DisplayMember = "madocgia";
			cbMadocgia.SelectedIndex = -1;


			string command3 = "select tenloai from tbltheloai";
			cbTheloai.DataSource = cl.execSQLCommand(command3);
			cbTheloai.DisplayMember = "tenloai";
			cbTheloai.SelectedIndex = -1;

			string tennv = "";
			string command = "select * from tblnhanvien where manv ='" + cbManv.Text.ToString() + "'";
			foreach (DataRow row in cl.execSQLCommand(command).Rows)
			{
				tennv += row[1].ToString().Trim();
			}
			txtTennv.Text = tennv;

			btnDangky.Enabled = false;
		}

		private void cbManv_TextChanged(object sender, EventArgs e)
		{

		}

		private void cbMadocgia_TextChanged(object sender, EventArgs e)
		{
			string tendg = "";
			string command = "select * from tbldocgia where madocgia ='" + cbMadocgia.Text.ToString() + "'";
			foreach (DataRow row in cl.execSQLCommand(command).Rows)
			{
				tendg += row[1].ToString().Trim();
			}
			txtTendocgia.Text = tendg;
		}

		private void cbMasach_TextChanged(object sender, EventArgs e)
		{
			
			string price = "";
			string matag = "";
			string tensach = "";


			string command = "select * from tblsach where id ='" + cbMasach.Text.ToString() + "'";
			foreach (DataRow row in cl.execSQLCommand(command).Rows)
			{
				tensach += row[1].ToString().Trim();
				matag += row[2].ToString().Trim();
				price += row[5].ToString().Trim();
			}
			txtTensach.Text = tensach;
			txtGia.Text = price;


			string tentg = "";
			string command1 = "select * from tbltacgia where matacgia ='" +matag+ "'";
			foreach (DataRow row in cl.execSQLCommand(command1).Rows)
			{
				tentg += row[1].ToString().Trim();
			}
			txtTacgia.Text = tentg;

			string comm = "select * from tblsach where trangthai like 'taken' and id ='" + cbMasach.Text.ToString() + "'";

			if (cl.execSQLCommand(comm).Rows.Count == 0)
			{
				btnDangky.Enabled = true;
			}
			else
			{
				btnDangky.Enabled = false;
			}

		}

		private void cbTheloai_TextChanged(object sender, EventArgs e)
		{
			string command2 = "select id,tensach from tblsach s inner join tbltheloai tl on(s.maloai = tl.maloai) where tl.tenloai like N'" + cbTheloai.Text.ToString() + "'";
			cbMasach.DataSource = cl.execSQLCommand(command2);
			cbMasach.DisplayMember = "id";
			cbMasach.SelectedIndex = -1;

			cbMasach_TextChanged(sender, e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			

		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtMamuon.Text = null;
			cbMadocgia.SelectedIndex = -1;
			cbTheloai.SelectedIndex = -1;
			cbMasach.SelectedIndex = -1;
			txtTensach.Text = null;
			txtTacgia.Text = null;
			txtGia.Text = null;
			txtGhichu.Text = null;
		}

		private void cbTheloai_SelectedIndexChanged(object sender, EventArgs e)
		{
			//cbMasach_TextChanged(sender, e);
		}

		private void txtMamuon_TextChanged(object sender, EventArgs e)
		{
			if(txtMamuon.Text.Length > 0 && cbMadocgia.Text.Length > 0 &&  cbTheloai.Text.Length > 0 && cbMasach.Text.Length > 0)//mtxtMuon.Text.Length > 0 &&
			{
				btnDangky.Enabled = true;
			}
			else
			{
				 btnDangky.Enabled = false;
			}
		}

		private void btnDangky_Click(object sender, EventArgs e)
		{
			string command_check_book_valid = "select * from tblctmuon where masach ='" + cbMasach.Text.ToString() + "' and mamuon = '" + txtMamuon.Text.ToString() + "'";

			string check_borrw_id_existence = "select * from tblmuonsach where mamuon = '" + txtMamuon.Text.Trim() + "'";

			string check_borrw_id2 = "select * from tblmuonsach where mamuon = '" + txtMamuon.Text.Trim() + "' and manv = '" + cbManv.Text.ToString().Trim() + "' and madocgia = '" + cbMadocgia.Text.ToString().Trim() + "' and ngaymuon = '"+dtpNgayMuon.Text.Trim()+"'";


			if (cl.execSQLCommand(check_borrw_id_existence).Rows.Count == 0)
			{
				string command1 = "insert into tblmuonsach values ('" + txtMamuon.Text.ToString().Trim() + "','" + cbManv.Text.ToString() + "','" + cbMadocgia.Text.ToString() + "','" + dtpNgayMuon.Text + "')";
				cl.execSQLCommand(command1);


				string command11 = "insert into tblctmuon values('" + txtMamuon.Text.ToString() + "','" + cbMasach.Text.ToString() + "','true')";
				cl.execSQLCommand(command11);

				string commadn2 = "update tblsach set trangthai = 'taken' where id = '" + cbMasach.Text.ToString() + "'";
				cl.execSQLCommand(commadn2);

				MessageBox.Show("Register successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cbTheloai.SelectedIndex = -1;
				txtTensach.Text = null;
				cbMasach.SelectedIndex = -1;
				txtTacgia.Text = null;
				txtGhichu.Text = null;
				txtGia.Text = null;
			}
			else if (cl.execSQLCommand(check_borrw_id2).Rows.Count >= 1)
			{
				if (cl.execSQLCommand(command_check_book_valid).Rows.Count == 0)
				{
					string command1 = "insert into tblctmuon values('" + txtMamuon.Text.ToString() + "','" + cbMasach.Text.ToString() + "','true')";
					cl.execSQLCommand(command1);

					string commadn2 = "update tblsach set trangthai = 'taken' where id = '" + cbMasach.Text.ToString() + "'";
					cl.execSQLCommand(commadn2);

					MessageBox.Show("Register successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
					cbTheloai.SelectedIndex = -1;
					txtTensach.Text = null;
					cbMasach.SelectedIndex = -1;
					txtTacgia.Text = null;
					txtGhichu.Text = null;
					txtGia.Text = null;
				}
				else
				{
					MessageBox.Show("Book id has already taken or invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("BorrowID has existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
