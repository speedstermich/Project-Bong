using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logistik_Permit
{
	class connection
	{
		public static SqlConnection GetConnection()
		{
			string str = null;
			SqlConnection con;
			str = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = H:\\GitHub\\Project-Bong\\Logistik Permit\\Logistik Permit\\logistik-permit.mdf; Integrated Security = True";
			con = new SqlConnection(str);

			try{
				con.Open();
				//MessageBox.Show("Connection Success");
			}
			catch(Exception ex)
			{
				//MessageBox.Show("Connection Fail");
			}

			return con;
		} 
	}
}
