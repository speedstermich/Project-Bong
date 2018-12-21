namespace Logistik_Permit
{
	partial class list_logistic
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
			this.logistik_permitDataSet = new Logistik_Permit.logistik_permitDataSet();
			this.logistikpermitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.logistikBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.logistikTableAdapter = new Logistik_Permit.logistik_permitDataSetTableAdapters.logistikTableAdapter();
			this.idlogistikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jenisbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kepemilikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updatebyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logistik_permitDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logistikpermitDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logistikBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// batal
			// 
			this.batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.batal.Location = new System.Drawing.Point(671, 375);
			this.batal.Name = "batal";
			this.batal.Size = new System.Drawing.Size(117, 49);
			this.batal.TabIndex = 9;
			this.batal.Text = "Cancel";
			this.batal.UseVisualStyleBackColor = true;
			this.batal.Click += new System.EventHandler(this.batal_Click);
			// 
			// hapus_data
			// 
			this.hapus_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hapus_data.Location = new System.Drawing.Point(176, 375);
			this.hapus_data.Name = "hapus_data";
			this.hapus_data.Size = new System.Drawing.Size(117, 49);
			this.hapus_data.TabIndex = 8;
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
			this.tambah_logistik.TabIndex = 7;
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
			this.label1.Size = new System.Drawing.Size(115, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Logistic Data";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlogistikDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jenisbarangDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.kepemilikanDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.updatebyDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.logistikBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(16, 55);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(772, 314);
			this.dataGridView1.TabIndex = 11;
			// 
			// logistik_permitDataSet
			// 
			this.logistik_permitDataSet.DataSetName = "logistik_permitDataSet";
			this.logistik_permitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// logistikpermitDataSetBindingSource
			// 
			this.logistikpermitDataSetBindingSource.DataSource = this.logistik_permitDataSet;
			this.logistikpermitDataSetBindingSource.Position = 0;
			// 
			// logistikBindingSource
			// 
			this.logistikBindingSource.DataMember = "logistik";
			this.logistikBindingSource.DataSource = this.logistikpermitDataSetBindingSource;
			// 
			// logistikTableAdapter
			// 
			this.logistikTableAdapter.ClearBeforeFill = true;
			// 
			// idlogistikDataGridViewTextBoxColumn
			// 
			this.idlogistikDataGridViewTextBoxColumn.DataPropertyName = "Id_logistik";
			this.idlogistikDataGridViewTextBoxColumn.HeaderText = "Id_logistik";
			this.idlogistikDataGridViewTextBoxColumn.Name = "idlogistikDataGridViewTextBoxColumn";
			// 
			// namaDataGridViewTextBoxColumn
			// 
			this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama ";
			this.namaDataGridViewTextBoxColumn.HeaderText = "nama ";
			this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
			// 
			// jenisbarangDataGridViewTextBoxColumn
			// 
			this.jenisbarangDataGridViewTextBoxColumn.DataPropertyName = "jenis_barang";
			this.jenisbarangDataGridViewTextBoxColumn.HeaderText = "jenis_barang";
			this.jenisbarangDataGridViewTextBoxColumn.Name = "jenisbarangDataGridViewTextBoxColumn";
			// 
			// jumlahDataGridViewTextBoxColumn
			// 
			this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah";
			this.jumlahDataGridViewTextBoxColumn.HeaderText = "jumlah";
			this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
			// 
			// kepemilikanDataGridViewTextBoxColumn
			// 
			this.kepemilikanDataGridViewTextBoxColumn.DataPropertyName = "kepemilikan";
			this.kepemilikanDataGridViewTextBoxColumn.HeaderText = "kepemilikan";
			this.kepemilikanDataGridViewTextBoxColumn.Name = "kepemilikanDataGridViewTextBoxColumn";
			// 
			// keteranganDataGridViewTextBoxColumn
			// 
			this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
			this.keteranganDataGridViewTextBoxColumn.HeaderText = "keterangan";
			this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
			// 
			// updatebyDataGridViewTextBoxColumn
			// 
			this.updatebyDataGridViewTextBoxColumn.DataPropertyName = "update_by";
			this.updatebyDataGridViewTextBoxColumn.HeaderText = "update_by";
			this.updatebyDataGridViewTextBoxColumn.Name = "updatebyDataGridViewTextBoxColumn";
			// 
			// list_logistic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.batal);
			this.Controls.Add(this.hapus_data);
			this.Controls.Add(this.tambah_logistik);
			this.Controls.Add(this.label1);
			this.Name = "list_logistic";
			this.Text = "list_logistic";
			this.Load += new System.EventHandler(this.list_logistic_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logistik_permitDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logistikpermitDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logistikBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button batal;
		private System.Windows.Forms.Button hapus_data;
		private System.Windows.Forms.Button tambah_logistik;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource logistikpermitDataSetBindingSource;
		private logistik_permitDataSet logistik_permitDataSet;
		private System.Windows.Forms.BindingSource logistikBindingSource;
		private logistik_permitDataSetTableAdapters.logistikTableAdapter logistikTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idlogistikDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jenisbarangDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kepemilikanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn updatebyDataGridViewTextBoxColumn;
	}
}