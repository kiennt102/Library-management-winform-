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
	public partial class frm_5_Statistics : Form
	{
		public frm_5_Statistics()
		{
			InitializeComponent();
		}

		private void pbReloadType_MouseEnter(object sender, EventArgs e)
		{
			pbReloadType.Cursor = Cursors.Hand;
		}

		private void pbReloadType_MouseLeave(object sender, EventArgs e)
		{
			pbReloadType.Cursor= Cursors.Default;
		}

		classDataBase cl = new classDataBase();

		private void frm_5_Statistics_Load(object sender, EventArgs e)
		{
			string command_take_TYPE = "select * from tbltheloai";
			cbType.DataSource = cl.execSQLCommand(command_take_TYPE);
			cbType.DisplayMember = "tenloai"; 
			cbType.SelectedIndex = -1;

			cbMonth.DataSource = cl.execSQLCommand("select distinct month(ngaymuon)[thang_muon] from tblmuonsach");
			cbMonth.DisplayMember = "thang_muon";
			cbMonth.SelectedIndex = -1;

			cbYear.DataSource = cl.execSQLCommand("select distinct year(ngaymuon)[nam_muon] from tblmuonsach");
			cbYear.DisplayMember = "nam_muon";
			cbYear.SelectedIndex = -1;

		}

		private void pbReloadType_Click(object sender, EventArgs e)
		{
			string command = "select s.tensach[Book],tl.tenloai[Type],count(s.tensach)[Quantity],sum(s.gia)[Price] from tblctthem ctt inner join tblsach s on(s.id = ctt.masach) inner join tblthemsach ts on(ts.mathem = ctt.mathem) inner join tbltheloai tl on(s.maloai = tl.maloai) where tl.tenloai like N'" + cbType.Text.ToString().Trim() + "' group by s.tensach,tl.tenloai order by count(s.tensach) desc";
			dataGridView1.DataSource = cl.execSQLCommand(command);
		}

		private void cbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			pbReloadType_Click(sender, e);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			string command = "select dg.madocgia[ReaderId],dg.hoten[Fullname], count(s.id)[Times borrow] from tblsach s inner join tblctmuon ctm on (ctm.masach = s. id) inner join tblmuonsach ms on(ms.mamuon = ctm.mamuon) inner join tbldocgia dg on(dg.madocgia = ms.madocgia) where CONVERT(char,month(ms.ngaymuon))  = '" + cbMonth.Text.ToString()+ "' and convert(char,year(ms.ngaymuon)) = '" + cbYear.Text.ToString()+"' group by dg.madocgia,dg.hoten having count(s.id ) > 3 order by count(s.id) desc";
			dataGridView2.DataSource = cl.execSQLCommand(command);
		}

		private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			pictureBox2_Click(sender, e);
		}

		private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			pictureBox2_Click(sender,e);
		}

		private void pbStaPerson_MouseEnter(object sender, EventArgs e)
		{
			pbStaPerson.Cursor = Cursors.Hand;
		}

		private void pbStaPerson_MouseLeave(object sender, EventArgs e)
		{
			pbStaPerson.Cursor= Cursors.Default;
		}
	}
}
