namespace Logistik_Permit
{
	partial class main_page
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
			this.logistic = new System.Windows.Forms.Button();
			this.peminjam = new System.Windows.Forms.Button();
			this.pinjam_barang = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.add_user = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.check_btn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// logistic
			// 
			this.logistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logistic.Location = new System.Drawing.Point(132, 304);
			this.logistic.Name = "logistic";
			this.logistic.Size = new System.Drawing.Size(160, 60);
			this.logistic.TabIndex = 1;
			this.logistic.Text = "Logistic";
			this.logistic.UseVisualStyleBackColor = true;
			this.logistic.Click += new System.EventHandler(this.logistic_Click);
			// 
			// peminjam
			// 
			this.peminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.peminjam.Location = new System.Drawing.Point(312, 304);
			this.peminjam.Name = "peminjam";
			this.peminjam.Size = new System.Drawing.Size(160, 60);
			this.peminjam.TabIndex = 2;
			this.peminjam.Text = "Borrowers";
			this.peminjam.UseVisualStyleBackColor = true;
			this.peminjam.Click += new System.EventHandler(this.peminjam_Click);
			// 
			// pinjam_barang
			// 
			this.pinjam_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pinjam_barang.Location = new System.Drawing.Point(490, 304);
			this.pinjam_barang.Name = "pinjam_barang";
			this.pinjam_barang.Size = new System.Drawing.Size(160, 60);
			this.pinjam_barang.TabIndex = 3;
			this.pinjam_barang.Text = "Borrow";
			this.pinjam_barang.UseVisualStyleBackColor = true;
			this.pinjam_barang.Click += new System.EventHandler(this.pinjam_barang_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(122, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(528, 57);
			this.label1.TabIndex = 10;
			this.label1.Text = "Permit Logistic APP";
			// 
			// add_user
			// 
			this.add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_user.Location = new System.Drawing.Point(132, 378);
			this.add_user.Name = "add_user";
			this.add_user.Size = new System.Drawing.Size(160, 60);
			this.add_user.TabIndex = 11;
			this.add_user.Text = "Add User";
			this.add_user.UseVisualStyleBackColor = true;
			this.add_user.Click += new System.EventHandler(this.add_user_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Logistik_Permit.Properties.Resources.Logo_PERMIT;
			this.pictureBox1.Location = new System.Drawing.Point(206, 102);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(360, 187);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// check_btn
			// 
			this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.check_btn.Location = new System.Drawing.Point(490, 378);
			this.check_btn.Name = "check_btn";
			this.check_btn.Size = new System.Drawing.Size(160, 60);
			this.check_btn.TabIndex = 12;
			this.check_btn.Text = "Check";
			this.check_btn.UseVisualStyleBackColor = true;
			this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "label2";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(312, 378);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 60);
			this.button1.TabIndex = 14;
			this.button1.Text = "Log Out";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// main_page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.check_btn);
			this.Controls.Add(this.add_user);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pinjam_barang);
			this.Controls.Add(this.peminjam);
			this.Controls.Add(this.logistic);
			this.Name = "main_page";
			this.Text = "Permit Logistik Home";
			this.Load += new System.EventHandler(this.main_page_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button logistic;
		private System.Windows.Forms.Button peminjam;
		private System.Windows.Forms.Button pinjam_barang;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button add_user;
		private System.Windows.Forms.Button check_btn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}