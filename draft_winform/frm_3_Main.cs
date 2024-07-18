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
	public partial class mainMenu_Admin : Form
	{ 
		public mainMenu_Admin()
		{
			InitializeComponent();
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			ForgetpassReader frm = new ForgetpassReader();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			management_book form = new management_book();
			AddFormToPanel(form);
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you want to Log out?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
			{
				Login frm = new Login();
				this.Close();
				frm.Show();
			}

		}

		private void pbAccount_Click(object sender, EventArgs e)
		{
			admin_Account form = new admin_Account();
			AddFormToPanel(form);
		}

		private void pbAccount_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void pbAccount_MouseEnter(object sender, EventArgs e)
		{
			pbAccount.Cursor = Cursors.Hand;
		}

		private void pbAccount_MouseLeave(object sender, EventArgs e)
		{
			pbAccount.Cursor = Cursors.Default;

		}

		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.Cursor = Cursors.Hand;
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.Cursor = Cursors.Default;
		}

		private void pbSetting_MouseEnter(object sender, EventArgs e)
		{
			pbSetting.Cursor = Cursors.Hand;
		}

		private void pbSetting_MouseLeave(object sender, EventArgs e)
		{
			pbSetting.Cursor = Cursors.Default;
		}

		private void panel2_MouseLeave(object sender, EventArgs e)
		{

		}

		private void pbLogout_MouseEnter(object sender, EventArgs e)
		{
			pbLogout.Cursor = Cursors.Hand;
		}

		private void pbLogout_MouseLeave(object sender, EventArgs e)
		{
			pbLogout.Cursor= Cursors.Default;
		}

		private void AddFormToPanel(Form form)
		{
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			plDisplay.Controls.Clear();
			plDisplay.Controls.Add(form);
			form.Show();
		}
		private void mainMenu_Admin_Load(object sender, EventArgs e)
		{
		
		}

		private void pbSetting_Click(object sender, EventArgs e)
		{
			frm_5_Statistics frm = new frm_5_Statistics();
			AddFormToPanel(frm);
		}
	}
}
