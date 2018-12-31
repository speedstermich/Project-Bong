namespace Logistik_Permit
{
	partial class check
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
			this.label5 = new System.Windows.Forms.Label();
			this.cancel_btn = new System.Windows.Forms.Button();
			this.update_btn = new System.Windows.Forms.Button();
			this.list_textbox = new System.Windows.Forms.RichTextBox();
			this.formpinjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.logistik_formpinjam = new Logistik_Permit.logistik_formpinjam();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.formid_combobox = new System.Windows.Forms.ComboBox();
			this.borrowerid_textbox = new System.Windows.Forms.TextBox();
			this.name_textbox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.form_pinjamTableAdapter = new Logistik_Permit.logistik_formpinjamTableAdapters.form_pinjamTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.formpinjamBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logistik_formpinjam)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(88, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 24);
			this.label5.TabIndex = 34;
			this.label5.Text = "Date";
			// 
			// cancel_btn
			// 
			this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel_btn.Location = new System.Drawing.Point(608, 396);
			this.cancel_btn.Name = "cancel_btn";
			this.cancel_btn.Size = new System.Drawing.Size(104, 42);
			this.cancel_btn.TabIndex = 31;
			this.cancel_btn.Text = "Cancel";
			this.cancel_btn.UseVisualStyleBackColor = true;
			this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
			// 
			// update_btn
			// 
			this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update_btn.Location = new System.Drawing.Point(203, 395);
			this.update_btn.Name = "update_btn";
			this.update_btn.Size = new System.Drawing.Size(104, 42);
			this.update_btn.TabIndex = 30;
			this.update_btn.Text = "Update";
			this.update_btn.UseVisualStyleBackColor = true;
			this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
			// 
			// list_textbox
			// 
			this.list_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formpinjamBindingSource, "list", true));
			this.list_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.list_textbox.Location = new System.Drawing.Point(204, 208);
			this.list_textbox.Name = "list_textbox";
			this.list_textbox.Size = new System.Drawing.Size(508, 181);
			this.list_textbox.TabIndex = 28;
			this.list_textbox.Text = "";
			// 
			// formpinjamBindingSource
			// 
			this.formpinjamBindingSource.DataMember = "form_pinjam";
			this.formpinjamBindingSource.DataSource = this.logistik_formpinjam;
			// 
			// logistik_formpinjam
			// 
			this.logistik_formpinjam.DataSetName = "logistik_formpinjam";
			this.logistik_formpinjam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(88, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 24);
			this.label4.TabIndex = 27;
			this.label4.Text = "Logistic List";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(88, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 24);
			this.label3.TabIndex = 26;
			this.label3.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(88, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 24);
			this.label2.TabIndex = 25;
			this.label2.Text = "Borrower ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 24);
			this.label1.TabIndex = 24;
			this.label1.Text = "Form ID";
			// 
			// formid_combobox
			// 
			this.formid_combobox.DataSource = this.formpinjamBindingSource;
			this.formid_combobox.DisplayMember = "id_form";
			this.formid_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.formid_combobox.FormattingEnabled = true;
			this.formid_combobox.Location = new System.Drawing.Point(204, 10);
			this.formid_combobox.Name = "formid_combobox";
			this.formid_combobox.Size = new System.Drawing.Size(508, 32);
			this.formid_combobox.TabIndex = 40;
			// 
			// borrowerid_textbox
			// 
			this.borrowerid_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formpinjamBindingSource, "id_borrower", true));
			this.borrowerid_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borrowerid_textbox.Location = new System.Drawing.Point(204, 115);
			this.borrowerid_textbox.Name = "borrowerid_textbox";
			this.borrowerid_textbox.Size = new System.Drawing.Size(509, 29);
			this.borrowerid_textbox.TabIndex = 41;
			// 
			// name_textbox
			// 
			this.name_textbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formpinjamBindingSource, "name", true));
			this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_textbox.Location = new System.Drawing.Point(204, 159);
			this.name_textbox.Name = "name_textbox";
			this.name_textbox.Size = new System.Drawing.Size(509, 29);
			this.name_textbox.TabIndex = 42;
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formpinjamBindingSource, "date", true));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(203, 60);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(509, 29);
			this.textBox1.TabIndex = 43;
			// 
			// form_pinjamTableAdapter
			// 
			this.form_pinjamTableAdapter.ClearBeforeFill = true;
			// 
			// check
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.name_textbox);
			this.Controls.Add(this.borrowerid_textbox);
			this.Controls.Add(this.formid_combobox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancel_btn);
			this.Controls.Add(this.update_btn);
			this.Controls.Add(this.list_textbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "check";
			this.Text = "check";
			this.Load += new System.EventHandler(this.check_Load);
			((System.ComponentModel.ISupportInitialize)(this.formpinjamBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logistik_formpinjam)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cancel_btn;
		private System.Windows.Forms.Button update_btn;
		private System.Windows.Forms.RichTextBox list_textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox formid_combobox;
		private System.Windows.Forms.TextBox borrowerid_textbox;
		private System.Windows.Forms.TextBox name_textbox;
		private System.Windows.Forms.TextBox textBox1;
		private logistik_formpinjam logistik_formpinjam;
		private System.Windows.Forms.BindingSource formpinjamBindingSource;
		private logistik_formpinjamTableAdapters.form_pinjamTableAdapter form_pinjamTableAdapter;
	}
}