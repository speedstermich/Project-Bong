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
			this.label1 = new System.Windows.Forms.Label();
			this.logistik = new System.Windows.Forms.Button();
			this.peminjam = new System.Windows.Forms.Button();
			this.pinjam_barang = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(260, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(297, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Permit Logistik Application";
			// 
			// logistik
			// 
			this.logistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logistik.Location = new System.Drawing.Point(94, 256);
			this.logistik.Name = "logistik";
			this.logistik.Size = new System.Drawing.Size(160, 60);
			this.logistik.TabIndex = 1;
			this.logistik.Text = "Logistik";
			this.logistik.UseVisualStyleBackColor = true;
			// 
			// peminjam
			// 
			this.peminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.peminjam.Location = new System.Drawing.Point(326, 256);
			this.peminjam.Name = "peminjam";
			this.peminjam.Size = new System.Drawing.Size(160, 60);
			this.peminjam.TabIndex = 2;
			this.peminjam.Text = "Peminjam";
			this.peminjam.UseVisualStyleBackColor = true;
			// 
			// pinjam_barang
			// 
			this.pinjam_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pinjam_barang.Location = new System.Drawing.Point(556, 256);
			this.pinjam_barang.Name = "pinjam_barang";
			this.pinjam_barang.Size = new System.Drawing.Size(160, 60);
			this.pinjam_barang.TabIndex = 3;
			this.pinjam_barang.Text = "Pinjam Barang";
			this.pinjam_barang.UseVisualStyleBackColor = true;
			// 
			// main_page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pinjam_barang);
			this.Controls.Add(this.peminjam);
			this.Controls.Add(this.logistik);
			this.Controls.Add(this.label1);
			this.Name = "main_page";
			this.Text = "Permit Logistik Home";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button logistik;
		private System.Windows.Forms.Button peminjam;
		private System.Windows.Forms.Button pinjam_barang;
	}
}