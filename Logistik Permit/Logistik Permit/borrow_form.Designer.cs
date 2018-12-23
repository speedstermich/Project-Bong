namespace Logistik_Permit
{
	partial class borrow_form
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.list_textbox = new System.Windows.Forms.RichTextBox();
			this.form_id = new System.Windows.Forms.TextBox();
			this.borrow_btn = new System.Windows.Forms.Button();
			this.cancel_btn = new System.Windows.Forms.Button();
			this.name_combobox = new System.Windows.Forms.ComboBox();
			this.peminjamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this._logistik_permitDataSet = new Logistik_Permit._logistik_permitDataSet();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.id_borrower = new System.Windows.Forms.TextBox();
			this.logistik_Peminjam_Nama = new Logistik_Permit.logistik_Peminjam_Nama();
			this.peminjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.peminjamTableAdapter = new Logistik_Permit.logistik_Peminjam_NamaTableAdapters.peminjamTableAdapter();
			this.peminjamTableAdapter1 = new Logistik_Permit._logistik_permitDataSetTableAdapters.peminjamTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._logistik_permitDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logistik_Peminjam_Nama)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Form ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(58, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Borrower ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(58, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(58, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Logistic List";
			// 
			// list_textbox
			// 
			this.list_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.list_textbox.Location = new System.Drawing.Point(174, 211);
			this.list_textbox.Name = "list_textbox";
			this.list_textbox.Size = new System.Drawing.Size(508, 181);
			this.list_textbox.TabIndex = 5;
			this.list_textbox.Text = "";
			// 
			// form_id
			// 
			this.form_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.form_id.Location = new System.Drawing.Point(174, 16);
			this.form_id.Name = "form_id";
			this.form_id.Size = new System.Drawing.Size(508, 29);
			this.form_id.TabIndex = 9;
			// 
			// borrow_btn
			// 
			this.borrow_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borrow_btn.Location = new System.Drawing.Point(174, 398);
			this.borrow_btn.Name = "borrow_btn";
			this.borrow_btn.Size = new System.Drawing.Size(104, 42);
			this.borrow_btn.TabIndex = 10;
			this.borrow_btn.Text = "Borrow";
			this.borrow_btn.UseVisualStyleBackColor = true;
			this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
			// 
			// cancel_btn
			// 
			this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel_btn.Location = new System.Drawing.Point(578, 398);
			this.cancel_btn.Name = "cancel_btn";
			this.cancel_btn.Size = new System.Drawing.Size(104, 42);
			this.cancel_btn.TabIndex = 11;
			this.cancel_btn.Text = "Cancel";
			this.cancel_btn.UseVisualStyleBackColor = true;
			this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
			// 
			// name_combobox
			// 
			this.name_combobox.DataSource = this.peminjamBindingSource1;
			this.name_combobox.DisplayMember = "Nama";
			this.name_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_combobox.FormattingEnabled = true;
			this.name_combobox.Location = new System.Drawing.Point(174, 162);
			this.name_combobox.Name = "name_combobox";
			this.name_combobox.Size = new System.Drawing.Size(508, 32);
			this.name_combobox.TabIndex = 17;
			// 
			// peminjamBindingSource1
			// 
			this.peminjamBindingSource1.DataMember = "peminjam";
			this.peminjamBindingSource1.DataSource = this._logistik_permitDataSet;
			// 
			// _logistik_permitDataSet
			// 
			this._logistik_permitDataSet.DataSetName = "_logistik_permitDataSet";
			this._logistik_permitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(58, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 24);
			this.label5.TabIndex = 18;
			this.label5.Text = "Date";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(174, 69);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker1.TabIndex = 19;
			// 
			// id_borrower
			// 
			this.id_borrower.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peminjamBindingSource1, "Id_peminjam", true));
			this.id_borrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id_borrower.Location = new System.Drawing.Point(173, 118);
			this.id_borrower.Name = "id_borrower";
			this.id_borrower.Size = new System.Drawing.Size(508, 29);
			this.id_borrower.TabIndex = 20;
			// 
			// logistik_Peminjam_Nama
			// 
			this.logistik_Peminjam_Nama.DataSetName = "logistik_Peminjam_Nama";
			this.logistik_Peminjam_Nama.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// peminjamBindingSource
			// 
			this.peminjamBindingSource.DataMember = "peminjam";
			this.peminjamBindingSource.DataSource = this.logistik_Peminjam_Nama;
			// 
			// peminjamTableAdapter
			// 
			this.peminjamTableAdapter.ClearBeforeFill = true;
			// 
			// peminjamTableAdapter1
			// 
			this.peminjamTableAdapter1.ClearBeforeFill = true;
			// 
			// borrow_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.id_borrower);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.name_combobox);
			this.Controls.Add(this.cancel_btn);
			this.Controls.Add(this.borrow_btn);
			this.Controls.Add(this.form_id);
			this.Controls.Add(this.list_textbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "borrow_form";
			this.Text = "borrow_form";
			this.Load += new System.EventHandler(this.borrow_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._logistik_permitDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logistik_Peminjam_Nama)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.peminjamBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox list_textbox;
		private System.Windows.Forms.TextBox form_id;
		private System.Windows.Forms.Button borrow_btn;
		private System.Windows.Forms.Button cancel_btn;
		private System.Windows.Forms.ComboBox name_combobox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox id_borrower;
		private logistik_Peminjam_Nama logistik_Peminjam_Nama;
		private System.Windows.Forms.BindingSource peminjamBindingSource;
		private logistik_Peminjam_NamaTableAdapters.peminjamTableAdapter peminjamTableAdapter;
		private _logistik_permitDataSet _logistik_permitDataSet;
		private System.Windows.Forms.BindingSource peminjamBindingSource1;
		private _logistik_permitDataSetTableAdapters.peminjamTableAdapter peminjamTableAdapter1;
	}
}