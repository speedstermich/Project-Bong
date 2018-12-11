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
	public partial class daftar_logistik : Form
	{
		public daftar_logistik()
		{
			InitializeComponent();
		}

		private void batal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tambah_logistik_Click(object sender, EventArgs e)
		{
			input_logistik form = new input_logistik();
			form.ShowDialog();
		}
	}
}
