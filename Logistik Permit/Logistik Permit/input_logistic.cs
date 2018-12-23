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
	public partial class input_logistic : Form
	{
		public input_logistic()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (logisticId_text.Text == "" || name_text.Text == "" || type_text.Text == "" || total_text.Text == "" || owner_text.Text == "" || detail_text.Text == "" || member_text.Text == "")
			{
				MessageBox.Show("Please Complete Your Data");
			}
			else
			{
				string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\Documents\\GitHub\\Project-Bong\\Logistik Permit\\Logistik Permit\\logistik-permit.mdf;Integrated Security=True";
				//string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\GitHub\\Project-Bong\\Logistik Permit\\Logistik Permit\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionstring))
				{
					SqlCommand cmd = new SqlCommand("INSERT INTO logistik (Id_logistik, nama, jenis_barang, jumlah, kepemilikan, keterangan, update_by) VALUES (@Id_logistik, @nama, @jenis_barang, @jumlah, @kepemilikan, @keterangan, @update_by)");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;

					cmd.Parameters.AddWithValue("@Id_logistik", logisticId_text.Text);
					cmd.Parameters.AddWithValue("@nama", name_text.Text);
					cmd.Parameters.AddWithValue("@jenis_barang", type_text.Text);
					cmd.Parameters.AddWithValue("@jumlah", total_text.Text);
					cmd.Parameters.AddWithValue("@kepemilikan", owner_text.Text);
					cmd.Parameters.AddWithValue("@keterangan", detail_text.Text);
					cmd.Parameters.AddWithValue("@update_by", member_text.Text);
					/*Id_logistik = Logistic ID, nama = 名字, jenis_barang = 类型， jumlah = total, 
					 * kepemilikan = owner, keterangan = detail, update_by = 更新*/
					connection.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Success");
					connection.Close();

					logisticId_text.Text = "";
					name_text.Text = "";
					type_text.Text = "";
					total_text.Text = "";
					owner_text.Text = "";
					detail_text.Text = "";
					member_text.Text = "";
				}
			}	
		}

		private void input_logistic_Load(object sender, EventArgs e)
		{
			//connection.GetConnection();
		}
	}
}
