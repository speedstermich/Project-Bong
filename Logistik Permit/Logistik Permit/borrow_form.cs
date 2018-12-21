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
			/*if (form_id.Text == "" || borrower_name.Text == "" || borrower_division.Text == "")
			{
				MessageBox.Show("Data Incomplete");
			}
			else
			{
				string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\logistik-permit.mdf;Integrated Security=True";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					SqlCommand cmd = new SqlCommand("INSERT INTO peminjam (Id_peminjam, Nama, Divisi, Contact) VALUES (@Id_peminjam, @Nama, @Divisi, @Contact)");
					cmd.CommandType = CommandType.Text;
					cmd.Connection = connection;

					cmd.Parameters.AddWithValue("@Id_peminjam", borrower_id.Text);
					cmd.Parameters.AddWithValue("@Nama", borrower_name.Text);
					cmd.Parameters.AddWithValue("@Divisi", borrower_division.Text);
					cmd.Parameters.AddWithValue("@Contact", borrower_contact.Text);

					/*Id_peminjam = Borrower ID, nama = 名字, Divisi = 部门， Contact = 联系方式*/
				/*connection.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Success");
				connection.Close();

				borrower_id.Text = "";
				borrower_name.Text = "";
				borrower_division.Text = "";
				borrower_contact.Text = "";

			}*/
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
