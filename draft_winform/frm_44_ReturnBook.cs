using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draft_winform
{
	public partial class frm_44_ReturnBook : Form
	{
		public frm_44_ReturnBook()
		{
			InitializeComponent();
		}

		classDataBase cl = new classDataBase();
		private void frm_44_ReturnBook_Load(object sender, EventArgs e)
		{
			string command = "select madocgia from tbldocgia";
			cbMadocgia.DataSource = cl.execSQLCommand(command);
			cbMadocgia.DisplayMember = "madocgia";
			cbMadocgia.SelectedIndex = -1;

			txtTenDG.Text = null;
			btnTra.Enabled = false;
			txtKhac.Enabled = false;
			txtManv.Text = GlobalVar.rootCode;

			dataGridView1.DataSource = null; 
		}

		private void cbMadocgia_TextChanged(object sender, EventArgs e)
		{
			if(cbMadocgia.SelectedIndex != -1 )
			{
				string command = "select s.id[Id],s.tensach[Book],ms.ngaymuon[Borrow date],ms.mamuon from tblsach s inner join tblctmuon ctm on(s.id = ctm.masach) inner join tblmuonsach ms on(ms.mamuon = ctm.mamuon) where ms.madocgia = '" + cbMadocgia.Text.ToString() + "' and s.trangthai like 'taken' and ctm.trangthai = 'true'";
				dataGridView1.DataSource = cl.execSQLCommand(command);

				string com = "select * from tbldocgia where madocgia = '" + cbMadocgia.Text.ToString() + "'";
				string name = "";
				foreach(DataRow row in cl.execSQLCommand(com).Rows)
				{
					name += row[1].ToString().Trim(); 
				}
				txtTenDG.Text = name;
			}

			if (txtMatra.Text.Length > 0 && cbMadocgia.Text.Length > 0 && txtMasach.Text.Length > 0)
			{
				btnTra.Enabled = true;
			}
			else
			{
				btnTra.Enabled = false;
			}

		}

		private void radKhac_CheckedChanged(object sender, EventArgs e)
		{
			if (radKhac.Checked)
			{
				txtKhac.Enabled = true;
			}
			else
			{
				txtKhac.Enabled= false;
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if(index >= 0)
			{
				DateTime dateTime = Convert.ToDateTime(dataGridView1[2, index].Value.ToString());
				string date = dateTime.ToString("MM/dd/yyyy") ;
				txtMasach.Text = dataGridView1[0, index].Value.ToString().Trim();
				txtTensach.Text = dataGridView1[1, index].Value.ToString().Trim();
				txtNgaymuon.Text = date.ToString();
				txtMamuon.Text = dataGridView1[3, index].Value.ToString().Trim();
			}
		}

		private void txtMatra_TextChanged(object sender, EventArgs e)
		{
			if (txtMatra.Text.Length > 0 && cbMadocgia.Text.Length > 0 && txtMasach.Text.Length > 0)
			{
				btnTra.Enabled = true;
			}
			else
			{
				btnTra.Enabled = false;
			}
		}

		private void btnTra_Click(object sender, EventArgs e)
		{
			string command = "select s.id[Id],s.tensach[Book],ms.ngaymuon[Borrow date],ms.mamuon from tblsach s inner join tblctmuon ctm on(s.id = ctm.masach) inner join tblmuonsach ms on(ms.mamuon = ctm.mamuon) where ms.madocgia = '" + cbMadocgia.Text.ToString() + "' and s.trangthai like 'taken' and ctm.trangthai = 'true'";

			if ((radKhac.Checked == false && radMuon.Checked == false) || txtMatra.Text.Length == 0 || cbMadocgia.SelectedIndex == -1 )
			{			
				errorProvider1.SetError(btnTra, "Invalid values!");
				MessageBox.Show("Make sure all information are valid or correct format!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProvider1.Clear();
				
			}
			else
			{
				string comman1 = "select * from tbltrasach where matra ='" + txtMatra.Text + "'";
				string comman2 = "select * from tbltrasach ts inner join tblmuonsach ms on(ts.mamuon = ms.mamuon) where ts.matra ='" + txtMatra.Text + "' and ts.manv = '" + txtManv.Text + "' and ms.madocgia = '"+cbMadocgia.Text+"' and ts.ngaytra = '"+dtpNgaytra.Text.ToString()+"'";

				if(cl.execSQLCommand(comman1).Rows.Count == 0 )
				{
					string command_insert = "insert into tbltrasach values('" + txtMatra.Text.Trim() + "','" + txtManv.Text.Trim() + "','" + txtMamuon.Text.Trim() + "','" + dtpNgaytra.Text + "')";
					cl.execSQLCommand(command_insert);			
					
					if(radKhac.Checked)
					{
						string inser = "insert into tblcttra values('" + txtMatra.Text.Trim() + "','" + txtMasach.Text.Trim() + "',N'" + txtKhac.Text.Trim() + "')";
						cl.execSQLCommand(inser);
						string update1 = "update tblsach set trangthai = 'available' where id = '" + txtMasach.Text.Trim() + "'";
						cl.execSQLCommand(update1);
						string set_borrow = "update tblctmuon set trangthai = 'false' where masach = '" + txtMasach.Text.Trim() + "' ";
						cl.execSQLCommand(set_borrow);

						MessageBox.Show("Register successful!","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
						txtMasach.Text = null;
						txtTensach.Text = null;
						txtNgaymuon.Text = null;
						txtMamuon.Text = null;
						radKhac.Checked = false;
						radMuon.Checked = false;
						txtKhac.ReadOnly = true;
						txtKhac.Text = null;

						dataGridView1.DataSource = cl.execSQLCommand(command);
					}

					if (radMuon.Checked)
					{
						string inser = "insert into tblcttra values('" + txtMatra.Text + "','" + txtMasach.Text + "',N'Quá hạn')";
						cl.execSQLCommand(inser);
						string update2 = "update tblsach set trangthai = 'available' where id = '" + txtMasach.Text + "'";
						cl.execSQLCommand(update2);
						string set_borrow2 = "update tblctmuon set trangthai = 'false' where masach = '" + txtMasach.Text.Trim() + "' ";
						cl.execSQLCommand(set_borrow2);

						MessageBox.Show("Register successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtMasach.Text = null;
						txtTensach.Text = null;
						txtNgaymuon.Text = null;
						txtMamuon.Text = null;
						radKhac.Checked = false;
						radMuon.Checked = false;
						txtKhac.ReadOnly = true;
						txtKhac.Text = null;

						dataGridView1.DataSource = cl.execSQLCommand(command);
					}

				}
				else if (cl.execSQLCommand(comman2).Rows.Count >= 1 )
				{
					if(radKhac.Checked)
					{
						string inser = "insert into tblcttra values('" + txtMatra.Text.Trim() + "','" + txtMasach.Text.Trim() + "',N'" + txtKhac.Text.Trim() + "')";
						cl.execSQLCommand(inser);
						string update1 = "update tblsach set trangthai = 'available' where id = '" + txtMasach.Text.Trim() + "'";
						cl.execSQLCommand(update1);
						string set_borrow3 = "update tblctmuon set trangthai = 'false' where masach = '" + txtMasach.Text.Trim() + "' ";
						cl.execSQLCommand(set_borrow3);

						MessageBox.Show("Register successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtMasach.Text = null;
						txtTensach.Text = null;
						txtNgaymuon.Text = null;
						txtMamuon.Text = null;
						radKhac.Checked = false;
						radMuon.Checked = false;
						txtKhac.ReadOnly = true;
						txtKhac.Text = null;

						dataGridView1.DataSource = cl.execSQLCommand(command);
					}

					if (radMuon.Checked)
					{
						string inser = "insert into tblcttra values('" + txtMatra.Text + "','" + txtMasach.Text + "',N'Quá hạn')";
						cl.execSQLCommand(inser);
						string update2 = "update tblsach set trangthai = 'available' where id = '" + txtMasach.Text + "'";
						cl.execSQLCommand(update2);
						string set_borrow = "update tblctmuon set trangthai = 'false' where masach = '" + txtMasach.Text.Trim() + "' ";
						cl.execSQLCommand(set_borrow);

						MessageBox.Show("Register successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtMasach.Text = null;
						txtTensach.Text = null;
						txtNgaymuon.Text = null;
						txtMamuon.Text = null;
						radKhac.Checked = false;
						radMuon.Checked = false;
						txtKhac.ReadOnly = true;
						txtKhac.Text = null;

						dataGridView1.DataSource = cl.execSQLCommand(command);
					}
				}
				else
				{
					MessageBox.Show("ReturnID has existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void dtpNgaytra_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtMatra.Text = null;
			cbMadocgia.SelectedIndex = -1;
			radKhac.Checked = false;
			radMuon.Checked = false;
			txtManv.Text = null;
			txtMasach.Text = null;
			txtTenDG.Text = null;
			txtTensach.Text = null;
			txtNgaymuon.Text = null;
			txtMamuon.Text = null;
			dataGridView1.DataSource = null;
		}

		private void txtMasach_TextChanged(object sender, EventArgs e)
		{
			if (txtMatra.Text.Length > 0 && cbMadocgia.Text.Length > 0 && txtMasach.Text.Length > 0)
			{
				btnTra.Enabled = true;
			}
			else
			{
				btnTra.Enabled = false;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void cbMadocgia_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txtTensach_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void txtNgaymuon_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void txtMamuon_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void txtManv_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void txtTenDG_TextChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void radMuon_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void txtKhac_TextChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}
	}
}
