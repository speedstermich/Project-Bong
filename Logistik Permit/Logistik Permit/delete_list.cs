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
	public partial class delete_list : Form
	{
		public delete_list()
		{
			InitializeComponent();
		}

		private void cancel_btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void delete_btn_Click(object sender, EventArgs e)
		{
			if (id_logistic.Text == "")
			{
				MessageBox.Show("Enter The ID");
			}
			else
			{
				string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand("Delete from [logistik] where Id_logistik = @Id_logistik");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;
					cmd.Parameters.AddWithValue("@Id_logistik", id_logistic.Text);
					connection.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Delete Success");
					connection.Close();

					id_logistic.Text = "";
					name_logistic.Text = "";
				}
			}
		}

		private void search_btn_Click(object sender, EventArgs e)
		{
			if(id_logistic.Text == "")
			{
				MessageBox.Show("Enter The ID");
			}
			else
			{
				string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand("Select Id_logistik from [logistik] where Id_logistik = @Id_logistik");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;
					cmd.Parameters.AddWithValue("@Id_logistik", id_logistic.Text);
					connection.Open();

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while(reader.Read())
						{
							name_logistic.Text = reader["nama"].ToString();
						}
					}

					cmd.ExecuteNonQuery();
					connection.Close();
				}
			}
		}
	}
}
