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
	public partial class frm_40_mybooks : Form
	{
		public frm_40_mybooks()
		{
			InitializeComponent();
		}

		classDataBase cl = new classDataBase();
		private void frm_40_mybooks_Load(object sender, EventArgs e)
		{
			string command = "select ms.mamuon[Borrow ID], s.tensach[Book],s.id[Id], tg.tentacgia[Author], tl.tenloai [Type], ms.ngaymuon[Borrow date] from tblsach s inner join tbltacgia tg on(tg.matacgia = s.matacgia) inner join tbltheloai tl on(tl.maloai=s.maloai) inner join tblctmuon ctm on (ctm.masach = s.id) inner join tblmuonsach ms on (ms.mamuon = ctm.mamuon) where ms.madocgia = '" + GlobalVar.rootCode + "' group by ms.mamuon, s.tensach,s.id, tg.tentacgia, tl.tenloai, ms.ngaymuon";
			dataGridView1.DataSource = cl.execSQLCommand(command);

			
			string commandd = "select ts.matra[Return ID],ms.mamuon[Borrow ID], s.tensach[Book], s.id[Id], tg.tentacgia[Author], tl.tenloai[Type], ts.ngaytra[Return date] from tblsach s inner join tbltacgia tg on(tg.matacgia = s.matacgia) inner join tbltheloai tl on (tl.maloai = s.maloai) inner join tblcttra ctt on(ctt.masach = s.id) inner join tbltrasach ts on(ts.matra = ctt.matra) inner join tblmuonsach ms on (ms.mamuon = ts.mamuon) where ms.madocgia = '" + GlobalVar.rootCode + "' group by ts.matra,ms.mamuon, s.tensach, s.id, tg.tentacgia, tl.tenloai, ts.ngaytra";
			dataGridView2.DataSource = cl.execSQLCommand(commandd);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
