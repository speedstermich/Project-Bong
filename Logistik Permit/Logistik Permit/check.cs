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
	public partial class check : Form
	{
		public check()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void check_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'logistik_formpinjam.form_pinjam' table. You can move, or remove it, as needed.
			this.form_pinjamTableAdapter.Fill(this.logistik_formpinjam.form_pinjam);

		}

		private void cancel_btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void update_btn_Click(object sender, EventArgs e)
		{

		}
	}
}
