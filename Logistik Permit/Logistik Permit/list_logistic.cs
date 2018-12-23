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
	public partial class list_logistic : Form
	{
		public list_logistic()
		{
			InitializeComponent();
		}

		private void tambah_logistik_Click(object sender, EventArgs e)
		{
			input_logistic input = new input_logistic();
			input.ShowDialog();
		}

		private void hapus_data_Click(object sender, EventArgs e)
		{
			delete_list delete = new delete_list();
			delete.ShowDialog();
		}

		private void batal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void list_logistic_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'logistik_permitDataSet.logistik' table. You can move, or remove it, as needed.
			this.logistikTableAdapter.Fill(this.logistik_permitDataSet.logistik);

		}

		private void list_logistic_Load_1(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'logistik_permitDataSet.logistik' table. You can move, or remove it, as needed.
			this.logistikTableAdapter.Fill(this.logistik_permitDataSet.logistik);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = "logistikBindingSource";
			dataGridView1.Refresh();
		}
	}
}
