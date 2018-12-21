using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistik_Permit
{
	public partial class borrower : Form
	{
		public borrower()
		{
			InitializeComponent();
		}

		private void tambah_logistik_Click(object sender, EventArgs e)
		{
			input_borrower borrower_input = new input_borrower();
			borrower_input.ShowDialog();
		}

		private void hapus_data_Click(object sender, EventArgs e)
		{
			delete_borrower borrower_delete = new delete_borrower();
			borrower_delete.ShowDialog();
		}

		private void batal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void borrower_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the '_logistik_permitDataSet1.peminjam' table. You can move, or remove it, as needed.
			this.peminjamTableAdapter.Fill(this._logistik_permitDataSet1.peminjam);

		}
	}
}
