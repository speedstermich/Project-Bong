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
	public partial class delete_borrower : Form
	{
		public delete_borrower()
		{
			InitializeComponent();
		}

		private void search_btn_Click(object sender, EventArgs e)
		{
			if(borrower_id.Text == "")
			{
				MessageBox.Show("Please Input Borrower ID");
			}
			else
			{
				string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand("Select Id_peminjam from [peminjam] where Id_peminjam = @Id_peminjam");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;
					cmd.Parameters.AddWithValue("@Id_peminjam", borrower_id.Text);
					connection.Open();

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							borrower_name.Text = reader["Nama"].ToString();
						}
					}

					cmd.ExecuteNonQuery();
					connection.Close();
				}
			}
		}

		private void cancel_btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void delete_btn_Click(object sender, EventArgs e)
		{
			if (borrower_id.Text == "")
			{
				MessageBox.Show("Please Input Borrower ID");
			}
			else
			{
				string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand("Delete from [peminjam] where Id_Peminjam = @Id_Peminjam");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;
					cmd.Parameters.AddWithValue("@Id_Peminjam", borrower_id.Text);
					connection.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Delete Success");
					connection.Close();

					borrower_id.Text = "";
					borrower_name.Text = "";
				}
			}
		}
	}
}
