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
	public partial class main_page : Form
	{
		public main_page(string role)
		{
			InitializeComponent();
			label2.Text = role;
		}

		private void logistic_Click(object sender, EventArgs e)
		{
			//this.Hide();
			list_logistic list = new list_logistic();
			list.Show();
		}

		private void peminjam_Click(object sender, EventArgs e)
		{
			borrower list_borrower = new borrower();
			list_borrower.Show();
		}

		private void pinjam_barang_Click(object sender, EventArgs e)
		{
			borrow_form form_borrow = new borrow_form();
			form_borrow.Show();
		}

		private void main_page_Load(object sender, EventArgs e)
		{
			if (label2.Text == "Client")
			{
				add_user.Visible = false;
			}

			if (label2.Text == "Admin")
			{
				add_user.Visible = true;
			}
		}

		private void add_user_Click(object sender, EventArgs e)
		{
			add_user user = new add_user();
			user.Show();
		}

		private void check_btn_Click(object sender, EventArgs e)
		{
			check form = new check();
			form.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			login form_login = new login();
			form_login.Show();
		}
	}
}
