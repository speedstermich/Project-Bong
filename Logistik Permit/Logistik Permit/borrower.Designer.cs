namespace Logistik_Permit
{
	partial class borrower
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
			this.components = new System.ComponentModel.Container();
			this.batal = new System.Windows.Forms.Button();
			this.hapus_data = new System.Windows.Forms.Button();
			this.tambah_logistik = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this._logistik_permitDataSet1 = new Logistik_Permit._logistik_permitDataSet1();
			this.peminjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.peminjamTableAdapter = new Logistik_Permit._logistik_permitDataSet1TableAdapters.peminjamTableAdapter();
			this.idpeminjamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.divisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._logistik_permitDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// batal
			// 
			this.batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.batal.Location = new System.Drawing.Point(671, 375);
			this.batal.Name = "batal";
			this.batal.Size = new System.Drawing.Size(117, 49);
			this.batal.TabIndex = 14;
			this.batal.Text = "Cancel";
			this.batal.UseVisualStyleBackColor = true;
			this.batal.Click += new System.EventHandler(this.batal_Click);
			// 
			// hapus_data
			// 
			this.hapus_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hapus_data.Location = new System.Drawing.Point(172, 375);
			this.hapus_data.Name = "hapus_data";
			this.hapus_data.Size = new System.Drawing.Size(117, 49);
			this.hapus_data.TabIndex = 13;
			this.hapus_data.Text = "Delete";
			this.hapus_data.UseVisualStyleBackColor = true;
			this.hapus_data.Click += new System.EventHandler(this.hapus_data_Click);
			// 
			// tambah_logistik
			// 
			this.tambah_logistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tambah_logistik.Location = new System.Drawing.Point(16, 375);
			this.tambah_logistik.Name = "tambah_logistik";
			this.tambah_logistik.Size = new System.Drawing.Size(117, 49);
			this.tambah_logistik.TabIndex = 12;
			this.tambah_logistik.Text = "Add";
			this.tambah_logistik.UseVisualStyleBackColor = true;
			this.tambah_logistik.Click += new System.EventHandler(this.tambah_logistik_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "Borrower Data";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeminjamDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.divisiDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.peminjamBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(16, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(772, 315);
			this.dataGridView1.TabIndex = 16;
			// 
			// _logistik_permitDataSet1
			// 
			this._logistik_permitDataSet1.DataSetName = "_logistik_permitDataSet1";
			this._logistik_permitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// peminjamBindingSource
			// 
			this.peminjamBindingSource.DataMember = "peminjam";
			this.peminjamBindingSource.DataSource = this._logistik_permitDataSet1;
			// 
			// peminjamTableAdapter
			// 
			this.peminjamTableAdapter.ClearBeforeFill = true;
			// 
			// idpeminjamDataGridViewTextBoxColumn
			// 
			this.idpeminjamDataGridViewTextBoxColumn.DataPropertyName = "Id_peminjam";
			this.idpeminjamDataGridViewTextBoxColumn.HeaderText = "Id_peminjam";
			this.idpeminjamDataGridViewTextBoxColumn.Name = "idpeminjamDataGridViewTextBoxColumn";
			// 
			// namaDataGridViewTextBoxColumn
			// 
			this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
			this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
			this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
			// 
			// divisiDataGridViewTextBoxColumn
			// 
			this.divisiDataGridViewTextBoxColumn.DataPropertyName = "Divisi";
			this.divisiDataGridViewTextBoxColumn.HeaderText = "Divisi";
			this.divisiDataGridViewTextBoxColumn.Name = "divisiDataGridViewTextBoxColumn";
			// 
			// contactDataGridViewTextBoxColumn
			// 
			this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
			this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
			this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
			// 
			// borrower
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.batal);
			this.Controls.Add(this.hapus_data);
			this.Controls.Add(this.tambah_logistik);
			this.Controls.Add(this.label1);
			this.Name = "borrower";
			this.Text = "borrower";
			this.Load += new System.EventHandler(this.borrower_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._logistik_permitDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button batal;
		private System.Windows.Forms.Button hapus_data;
		private System.Windows.Forms.Button tambah_logistik;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private _logistik_permitDataSet1 _logistik_permitDataSet1;
		private System.Windows.Forms.BindingSource peminjamBindingSource;
		private _logistik_permitDataSet1TableAdapters.peminjamTableAdapter peminjamTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjamDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn divisiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
	}
}