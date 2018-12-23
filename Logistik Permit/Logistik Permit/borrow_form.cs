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
	public partial class borrow_form : Form
	{
		public borrow_form()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void cancel_btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void borrow_btn_Click(object sender, EventArgs e)
		{
			if (form_id.Text == "" || list_textbox.Text == "" || id_borrower.Text == "" || name_combobox.GetItemText(name_combobox.SelectedItem) == "")
			{
				MessageBox.Show("Data Incomplete");
			}
			else
			{
				string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\Documents\\GitHub\\Project-Bong\\Logistik Permit\\Logistik Permit\\logistik-permit.mdf;Integrated Security=True";
				//string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand("INSERT INTO form_pinjam (id_form, date, id_borrower, name, list) VALUES (@id_form, @date, @id_borrower, @name, @list)");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;

					cmd.Parameters.AddWithValue("@id_form", form_id.Text);
					cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
					cmd.Parameters.AddWithValue("@id_borrower", id_borrower.Text);
					cmd.Parameters.AddWithValue("@name", name_combobox.GetItemText(name_combobox.SelectedItem));
					cmd.Parameters.AddWithValue("@list", list_textbox.Text);

					/*Id_peminjam = Borrower ID, nama = 名字, Divisi = 部门， Contact = 联系方式*/
					connection.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Success");
					connection.Close();

					form_id.Text = "";
					list_textbox.Text = "";

				}
			}
		}

		private void borrow_form_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the '_logistik_permitDataSet.peminjam' table. You can move, or remove it, as needed.
			this.peminjamTableAdapter1.Fill(this._logistik_permitDataSet.peminjam);
			// TODO: This line of code loads data into the 'logistik_Peminjam_Nama.peminjam' table. You can move, or remove it, as needed.
			this.peminjamTableAdapter.Fill(this.logistik_Peminjam_Nama.peminjam);

		}
	}
}
