namespace Logistik_Permit
{
	partial class add_user
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pass = new System.Windows.Forms.TextBox();
			this.keterangan = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.nama_barang = new System.Windows.Forms.Label();
			this.id_logistik = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.TextBox();
			this.user_id = new System.Windows.Forms.TextBox();
			this.role = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(519, 366);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 46);
			this.button2.TabIndex = 35;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(337, 366);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 46);
			this.button1.TabIndex = 34;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pass
			// 
			this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pass.Location = new System.Drawing.Point(337, 184);
			this.pass.Name = "pass";
			this.pass.PasswordChar = '*';
			this.pass.Size = new System.Drawing.Size(289, 26);
			this.pass.TabIndex = 29;
			// 
			// keterangan
			// 
			this.keterangan.AutoSize = true;
			this.keterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keterangan.Location = new System.Drawing.Point(175, 245);
			this.keterangan.Name = "keterangan";
			this.keterangan.Size = new System.Drawing.Size(49, 24);
			this.keterangan.TabIndex = 24;
			this.keterangan.Text = "Role";
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(175, 184);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(92, 24);
			this.password.TabIndex = 23;
			this.password.Text = "Password";
			// 
			// nama_barang
			// 
			this.nama_barang.AutoSize = true;
			this.nama_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nama_barang.Location = new System.Drawing.Point(175, 130);
			this.nama_barang.Name = "nama_barang";
			this.nama_barang.Size = new System.Drawing.Size(97, 24);
			this.nama_barang.TabIndex = 21;
			this.nama_barang.Text = "Username";
			// 
			// id_logistik
			// 
			this.id_logistik.AutoSize = true;
			this.id_logistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id_logistik.Location = new System.Drawing.Point(175, 77);
			this.id_logistik.Name = "id_logistik";
			this.id_logistik.Size = new System.Drawing.Size(71, 24);
			this.id_logistik.TabIndex = 20;
			this.id_logistik.Text = "User ID";
			// 
			// username
			// 
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(338, 127);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(288, 29);
			this.username.TabIndex = 19;
			// 
			// user_id
			// 
			this.user_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user_id.Location = new System.Drawing.Point(337, 74);
			this.user_id.Name = "user_id";
			this.user_id.Size = new System.Drawing.Size(289, 29);
			this.user_id.TabIndex = 18;
			// 
			// role
			// 
			this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.role.FormattingEnabled = true;
			this.role.Items.AddRange(new object[] {
            "Admin",
            "Client"});
			this.role.Location = new System.Drawing.Point(337, 242);
			this.role.Name = "role";
			this.role.Size = new System.Drawing.Size(121, 32);
			this.role.TabIndex = 36;
			// 
			// add_user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.role);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.keterangan);
			this.Controls.Add(this.password);
			this.Controls.Add(this.nama_barang);
			this.Controls.Add(this.id_logistik);
			this.Controls.Add(this.username);
			this.Controls.Add(this.user_id);
			this.Name = "add_user";
			this.Text = "Add User";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox pass;
		private System.Windows.Forms.Label keterangan;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Label nama_barang;
		private System.Windows.Forms.Label id_logistik;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox user_id;
		private System.Windows.Forms.ComboBox role;
	}
}