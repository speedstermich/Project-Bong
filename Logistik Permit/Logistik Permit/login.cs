﻿using System;
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
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			daftar_logistik form = new daftar_logistik();
			form.Show();	
		}
	}
}
