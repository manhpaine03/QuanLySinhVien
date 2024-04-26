﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Classes
{
	internal class ProcessDataBase
	{
		string strConnect = "Data Source=LAPTOP-0ML6ACFF\\SQLEXPRESS04;Initial Catalog=QuanLySinhVien;Integrated Security=True";
		SqlConnection sqlConnect = null;
		//Phương thức mở kết nối
		void OpenConnect()
		{
			sqlConnect = new SqlConnection(strConnect);
			if (sqlConnect.State != ConnectionState.Open)
				sqlConnect.Open();
		}
		//Phương thức đóng kết nối
		void CloseConnect()
		{
			if (sqlConnect.State != ConnectionState.Closed)
			{
				sqlConnect.Close();
				sqlConnect.Dispose();
			}
		}
		//Phương thức thực thi câu lệnh Select trả về một DataTable
		public DataTable DataReader(string sqlSelct)
		{
			DataTable tblData = new DataTable();
			OpenConnect();
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelct, sqlConnect);
			sqlData.Fill(tblData);
			CloseConnect();
			return tblData;
		}
		//Phương thức thực hiện câu lệnh dạng insert,update,delete
		public void DataChange(string sql)
		{
			OpenConnect();
			SqlCommand sqlcomma = new SqlCommand();
			sqlcomma.Connection = sqlConnect;
			sqlcomma.CommandText = sql;
			sqlcomma.ExecuteNonQuery();
			CloseConnect();
		}

	}
}
