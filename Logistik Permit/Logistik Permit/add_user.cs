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
	public partial class add_user : Form
	{
		public add_user()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (user_id.Text == "" || username.Text == "" || pass.Text == "" || role.GetItemText(role.SelectedItem) == "")
			{
				MessageBox.Show("Data Incomplete");
			}
			else
			{
				string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\Documents\\GitHub\\Project-Bong\\Logistik Permit\\Logistik Permit\\logistik-permit.mdf;Integrated Security=True";
				//string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\GitHub\\Project-Bong\\Logistik Permit\\Logistik Permit\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand("INSERT INTO usertbl (id_user, username, password, role) VALUES (@id_user, @username, @password, @role)");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;

					cmd.Parameters.AddWithValue("@id_user", user_id.Text);
					cmd.Parameters.AddWithValue("@username", username.Text);
					cmd.Parameters.AddWithValue("@password", pass.Text);
					cmd.Parameters.AddWithValue("@role", role.GetItemText(role.SelectedItem));

					/*Id_peminjam = Borrower ID, nama = 名字, Divisi = 部门， Contact = 联系方式*/
					connection.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Success");
					connection.Close();

					user_id.Text = "";
					username.Text = "";
					pass.Text = "";
					

				}
			}
		}
	}
}
