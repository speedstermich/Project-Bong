using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Logistik_Permit
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(username_txt.Text=="" || password_txt.Text=="")
			{
				MessageBox.Show("Incomplete !!");
			}
			else{
				string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\Documents\\GitHub\\Project-Bong\\Logistik Permit\\Logistik Permit\\logistik-permit.mdf;Integrated Security=True";
				//string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\logistik-permit.mdf;Integrated Security=True";
				SqlConnection connect = new SqlConnection(connectionstring);
				//SqlCommand cmd = new SqlCommand("select * From user where username = @username and password = @password", connect);
				//cmd.Parameters.AddWithValue("@username", username_txt.Text);
				//cmd.Parameters.AddWithValue("@password", password_txt.Text);
				SqlDataAdapter sda = new SqlDataAdapter("select * from usertbl where username ='" + username_txt.Text + "' and password='" + password_txt.Text + "'", connect);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					this.Hide();
					SqlDataAdapter sda1 = new SqlDataAdapter("select role from usertbl where username ='" + username_txt.Text + "' and password='" + password_txt.Text + "'", connect);
					DataTable dts = new DataTable();
					sda1.Fill(dts);
					main_page main = new main_page(dts.Rows[0][0].ToString());
					main.Show();
				}
				else
				{
					MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void login_Load(object sender, EventArgs e)
		{
			connection.GetConnection();
		}
	}
}
