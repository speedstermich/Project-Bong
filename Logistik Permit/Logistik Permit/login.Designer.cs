namespace Logistik_Permit
{
	partial class login
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
			this.password = new System.Windows.Forms.Label();
			this.username_txt = new System.Windows.Forms.TextBox();
			this.password_txt = new System.Windows.Forms.TextBox();
			this.login_btn = new System.Windows.Forms.Button();
			this.cancel_btn = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(42, 88);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(92, 24);
			this.password.TabIndex = 1;
			this.password.Text = "Password";
			this.password.UseMnemonic = false;
			// 
			// username_txt
			// 
			this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_txt.Location = new System.Drawing.Point(174, 25);
			this.username_txt.Name = "username_txt";
			this.username_txt.Size = new System.Drawing.Size(193, 29);
			this.username_txt.TabIndex = 2;
			// 
			// password_txt
			// 
			this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_txt.Location = new System.Drawing.Point(174, 83);
			this.password_txt.Name = "password_txt";
			this.password_txt.PasswordChar = '*';
			this.password_txt.Size = new System.Drawing.Size(193, 29);
			this.password_txt.TabIndex = 3;
			// 
			// login_btn
			// 
			this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_btn.Location = new System.Drawing.Point(46, 168);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(122, 44);
			this.login_btn.TabIndex = 4;
			this.login_btn.Text = "Login";
			this.login_btn.UseVisualStyleBackColor = true;
			this.login_btn.Click += new System.EventHandler(this.button1_Click);
			// 
			// cancel_btn
			// 
			this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel_btn.Location = new System.Drawing.Point(245, 168);
			this.cancel_btn.Name = "cancel_btn";
			this.cancel_btn.Size = new System.Drawing.Size(122, 44);
			this.cancel_btn.TabIndex = 5;
			this.cancel_btn.Text = "Cancel";
			this.cancel_btn.UseVisualStyleBackColor = true;
			this.cancel_btn.Click += new System.EventHandler(this.button2_Click);
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(42, 25);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(97, 24);
			this.username.TabIndex = 6;
			this.username.Text = "Username";
			this.username.UseMnemonic = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.username);
			this.groupBox1.Controls.Add(this.password);
			this.groupBox1.Controls.Add(this.cancel_btn);
			this.groupBox1.Controls.Add(this.username_txt);
			this.groupBox1.Controls.Add(this.login_btn);
			this.groupBox1.Controls.Add(this.password_txt);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(378, 138);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(410, 224);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Logistik_Permit.Properties.Resources.Logo_PERMIT;
			this.pictureBox1.Location = new System.Drawing.Point(12, 163);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(360, 187);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(113, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(528, 57);
			this.label1.TabIndex = 9;
			this.label1.Text = "Permit Logistic APP";
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "login";
			this.Text = "Permit Logistik";
			this.Load += new System.EventHandler(this.login_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.TextBox username_txt;
		private System.Windows.Forms.TextBox password_txt;
		private System.Windows.Forms.Button login_btn;
		private System.Windows.Forms.Button cancel_btn;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}

