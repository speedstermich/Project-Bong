namespace Logistik_Permit
{
	partial class daftar_logistik
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tambah_logistik = new System.Windows.Forms.Button();
			this.hapus_data = new System.Windows.Forms.Button();
			this.batal = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data Logistik Permit";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(772, 286);
			this.dataGridView1.TabIndex = 1;
			// 
			// tambah_logistik
			// 
			this.tambah_logistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tambah_logistik.Location = new System.Drawing.Point(16, 357);
			this.tambah_logistik.Name = "tambah_logistik";
			this.tambah_logistik.Size = new System.Drawing.Size(117, 49);
			this.tambah_logistik.TabIndex = 2;
			this.tambah_logistik.Text = "Add";
			this.tambah_logistik.UseVisualStyleBackColor = true;
			this.tambah_logistik.Click += new System.EventHandler(this.tambah_logistik_Click);
			// 
			// hapus_data
			// 
			this.hapus_data.Location = new System.Drawing.Point(176, 357);
			this.hapus_data.Name = "hapus_data";
			this.hapus_data.Size = new System.Drawing.Size(117, 49);
			this.hapus_data.TabIndex = 3;
			this.hapus_data.Text = "Delete";
			this.hapus_data.UseVisualStyleBackColor = true;
			// 
			// batal
			// 
			this.batal.Location = new System.Drawing.Point(671, 357);
			this.batal.Name = "batal";
			this.batal.Size = new System.Drawing.Size(117, 49);
			this.batal.TabIndex = 4;
			this.batal.Text = "Cancel";
			this.batal.UseVisualStyleBackColor = true;
			this.batal.Click += new System.EventHandler(this.batal_Click);
			// 
			// daftar_logistik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.batal);
			this.Controls.Add(this.hapus_data);
			this.Controls.Add(this.tambah_logistik);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "daftar_logistik";
			this.Text = "Daftar Logistik";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button tambah_logistik;
		private System.Windows.Forms.Button hapus_data;
		private System.Windows.Forms.Button batal;
	}
}