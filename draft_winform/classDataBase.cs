using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace draft_winform
{
	/// <summary>
	/// Class allows interacting directly with the Database
	/// </summary>
	internal class classDataBase
	{
		SqlDataAdapter sqlAdapter;
		DataTable dt;
		string connection = "Data Source=NTDEVICE\\SQLEXPRESS;Initial Catalog=libraryMng;Integrated Security=True";
		

		/// <summary>
		/// Method return the number of tablename's rows 
		/// </summary>
		/// <param name="tableNAME"></param> table you want to count 
		/// <returns></returns>
		//public int countRecord_nv(string table_name)
		//{
		//	string command = $"select * from tblnhanvien where manv = {table_name}";
		//	sqlAdapter = new SqlDataAdapter(command,connection);

		//	dt = new DataTable();
		//	sqlAdapter.Fill(dt);

		//	int cnt = dt.Rows.Count;

		//	return cnt;
		//}


		/// <summary>
		/// Method running SQL command 
		/// </summary>
		/// <param name="sqlCommand"></param> parameters (select, insert, update,... for example) are passed in 
		public DataTable execSQLCommand(string sqlCommand)
		{
			sqlAdapter = new SqlDataAdapter(sqlCommand,connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);

			return dt;
		}


		/// <summary>
		/// Method doing insert values into database
		/// </summary>
		/// <param name="tableNAME"></param>
		/// <param name="values"></param>
		public void InsertRecords_nv(params object[] values)
		{
			string command = $"insert into tblnhanvien values('{values[0].ToString().Trim()}',N'{values[1].ToString().Trim()}','{values[2].ToString().Trim()}',N'{values[3].ToString().Trim()}','{values[4].ToString().Trim()}','" + values[0].ToString().Trim()+"@123" + "','" + values[5].ToString().Trim() + "',N'" + values[6].ToString().Trim() +"')";
			sqlAdapter = new SqlDataAdapter (command,connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);
		}


		public void InsertRecords_dg(params object[] values)
		{
			string command = $"insert into tbldocgia values('{values[0].ToString().Trim()}',N'{values[1].ToString().Trim()}','{values[2].ToString().Trim()}',N'{values[3].ToString().Trim()}','{values[4].ToString().Trim()}','" + values[0].ToString().Trim() + "@123" + "','" + values[5].ToString().Trim() + "',N'" + values[6].ToString().Trim() + "')";
			sqlAdapter = new SqlDataAdapter(command, connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);
		}



		/// <summary>
		/// Reload data for table after insert, update, add,...
		/// </summary>
		public DataTable reloadDATA(string tablename)
		{
			string command = $"select * from {tablename}";
			return execSQLCommand(command);
		}


		/// <summary>
		/// Method doing delete action
		/// </summary>
		/// <param name="tableNAME"></param>
		/// <param name="Code_or_ID"></param>
		public void Delete_NV_Record(string Code_or_ID)
		{
			string command = $"delete from tblnhanvien nv join tbltaikhoan tk on (tk.id = nv.manv) where manv  = '" + Code_or_ID + "'";
			sqlAdapter = new SqlDataAdapter (command,connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);
		}



		public void Delete_DG_Record(string Code_or_ID)
		{
			string command = $"delete from tbldocgia where madocgia  = '" + Code_or_ID + "'";
			sqlAdapter = new SqlDataAdapter(command, connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);
		}



		/// <summary>
		/// Method doing update action 
		/// </summary>
		/// <param name="tableNAME"></param>
		/// <param name="ID"></param>
		/// <param name="values"></param>
		public void Update_NV_Recor(string ID, params object[] values)
		{
			string command = "update tblnhanvien set  manv ='" + values[0] +"',hoten = N'" + values[1] +"',ngaysinh = '" + values[2] +"', diachi =N'" + values[3] +"',gmail = '" + values[4] +"' , matkhau = '" + values[0]+"@123" +"',phone_number = '" + values[5] +"', gt = N'" + values[6] +"', ghichu = N'" + values[7] +"' where manv = '"+ID+"' ";
			sqlAdapter = new SqlDataAdapter (command,connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);
		}



		public void Update_DG_Recor(string ID, params object[] values)
		{
			string command = "update tbldocgia set  madocgia ='" + values[0] + "',hoten = N'" + values[1] + "',ngaysinh = '" + values[2] + "', diachi =N'" + values[3] + "',gmail = '" + values[4] + "' , matkhau = '" + values[0] + "@123" + "',sdt = '" + values[5] + "', gt = N'" + values[6] + "',ghichu = N'" + values[7] +"' where madocgia = '" + ID + "' ";
			sqlAdapter = new SqlDataAdapter(command, connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);
		}


		public void Update_Acc(string ID, params object[] values)
		{
			string command = "update tbltaikhoan set tentaikhoan ='" + values[0] + "', matkhau = '" + values[1] + "',rolee = '" + values[2] +"' where id = '"+ID+"'";
			sqlAdapter = new SqlDataAdapter(command,connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);
		}


		//For form 8 to take staff_id so as to load information into form
		public DataTable load_privateI4(string code_or_ID)
		{
			string command = "select * from tblnhanvien where manv = '"+code_or_ID+"'";


			sqlAdapter = new SqlDataAdapter (command,connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);

			return dt;
		}
		public DataTable load_privateI4_reader(string code_or_ID)
		{
			string command = "select * from tbldocgia where madocgia = '" + code_or_ID + "'";


			sqlAdapter = new SqlDataAdapter(command, connection);

			dt = new DataTable();
			sqlAdapter.Fill(dt);

			return dt;
		}
	}
	public static class GlobalVar
	{
		public static string rootCode { get; set; }
		public static string position { get; set; }

		public static string book_id { get; set; }
	}
}
