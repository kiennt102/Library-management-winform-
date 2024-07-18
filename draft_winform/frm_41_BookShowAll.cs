using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draft_winform
{
	public partial class frm_41_BookShowAll : Form
	{
		public frm_41_BookShowAll()
		{
			InitializeComponent();
		}

		classDataBase cl = new classDataBase();
		private void frm_41_BookShowAll_Load(object sender, EventArgs e)
		{
			cbSearch.SelectedIndex = 0;
			txtSearch.ReadOnly = true;
			string command = "select  s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.trangthai[Status] from tblsach s inner join tbltacgia tg on(s.matacgia = tg.matacgia) inner join tbltheloai tl on (tl.maloai = s.maloai) ";// left join tblctmuon ctm on(ctm.masach = s.id)";
			string command1 = " group by s.tensach,tg.tentacgia,tl.tenloai,s.trangthai";//s.id[Id], s.id,
			dataGridView1.DataSource = cl.execSQLCommand(command+command1);
		}

		private void pbSearch_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			string select = "";

			if (cbSearch.Text.ToLower().Trim() == "id")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where s.id = '" + txtSearch.Text.Trim() + "'";
			}
			else if (cbSearch.Text.ToLower().Trim() == "book name")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where s.tensach like N'%" + txtSearch.Text.Trim() + "%'";
			}
			else if (cbSearch.Text.ToLower().Trim() == "author name")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where tg.tentacgia like N'%" + txtSearch.Text.Trim() + "%'";
			}
			else if (cbSearch.Text.ToLower().Trim() == "type")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where tl.tenloai like N'%" + txtSearch.Text.ToString().Trim() + "%'";
			}
			else
			{
				errorProvider1.SetError(txtSearch, "Please fill the blank!");
				MessageBox.Show("Invalid values or not enough needed information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
			}

			if (txtSearch.Text.Length == 0 && cbSearch.SelectedIndex != -1)
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai)";
			}

			dataGridView1.DataSource = cl.execSQLCommand(select);

		}

		private void pbSearch_MouseEnter(object sender, EventArgs e)
		{
			pbSearch.Cursor = Cursors.Hand;
		}

		private void pbSearch_MouseLeave(object sender, EventArgs e)
		{
			pbSearch.Cursor = Cursors.Default;
		}

		private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbSearch.SelectedIndex == -1 || cbSearch.Text.Length == 0)
			{
				txtSearch.ReadOnly = true;
			}
			else
			{
				txtSearch.ReadOnly = false;
			}
		}

		private void cbSearch_TextChanged(object sender, EventArgs e)
		{
			txtSearch_Click(sender, e);
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			string select = "";

			if (cbSearch.Text.ToLower().Trim() == "id")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where s.id = '" + txtSearch.Text.Trim() + "'";
			}
			else if (cbSearch.Text.ToLower().Trim() == "book name")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where s.tensach like N'%" + txtSearch.Text.Trim() + "%'";
			}
			else if (cbSearch.Text.ToLower().Trim() == "author name")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where tg.tentacgia like N'%" + txtSearch.Text.Trim() + "%'";
			}
			else if (cbSearch.Text.ToLower().Trim() == "type")
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai) where tl.tenloai like N'%" + txtSearch.Text.ToString().Trim() + "%'";
			}
			else
			{
				errorProvider1.SetError(txtSearch, "Please fill the blank!");
				MessageBox.Show("Invalid values or not enough needed information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
			}

			if (txtSearch.Text.Length == 0 && cbSearch.SelectedIndex != -1)
			{
				select = "select s.id[Id],s.tensach[Book],tg.tentacgia[Author],tl.tenloai[Type],s.gia[Price],s.trangthai[Status] from tblsach s inner join tbltacgia tg on (tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai = s.maloai)";
			}

			dataGridView1.DataSource = cl.execSQLCommand(select);


		}

		private void txtSearch_Click(object sender, EventArgs e)
		{
			if (cbSearch.SelectedIndex == -1 || cbSearch.Text.Length == 0)
			{
				txtSearch.ReadOnly = true;
			}
			else
			{
				txtSearch.ReadOnly = false;
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//int row_in = e.RowIndex;
			//if (row_in > 0)
			//{
			//	txtBname.Text = dataGridView1[0, row_in].Value.ToString().Trim();
			//	txtAname.Text = dataGridView1[1, row_in].Value.ToString().Trim();
			//	txtType.Text = dataGridView1[2, row_in].Value.ToString().Trim();
			//	txtStatus.Text = dataGridView1[3, row_in].Value.ToString().Trim();
			//	txtPrice.Text = dataGridView1[4, row_in].Value.ToString().Trim();
			//}

		}

		private void txtStatus_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void txtPrice_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txtType_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtAname_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtBname_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
