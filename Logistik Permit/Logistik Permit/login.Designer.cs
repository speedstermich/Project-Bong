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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(198, 206);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(92, 24);
			this.password.TabIndex = 1;
			this.password.Text = "Password";
			this.password.UseMnemonic = false;
			// 
			// username_txt
			// 
			this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_txt.Location = new System.Drawing.Point(330, 143);
			this.username_txt.Name = "username_txt";
			this.username_txt.Size = new System.Drawing.Size(193, 29);
			this.username_txt.TabIndex = 2;
			// 
			// password_txt
			// 
			this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_txt.Location = new System.Drawing.Point(330, 201);
			this.password_txt.Name = "password_txt";
			this.password_txt.PasswordChar = '*';
			this.password_txt.Size = new System.Drawing.Size(193, 29);
			this.password_txt.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(401, 286);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 44);
			this.button1.TabIndex = 4;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(202, 286);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 44);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(198, 143);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(97, 24);
			this.username.TabIndex = 6;
			this.username.Text = "Username";
			this.username.UseMnemonic = false;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.username);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.password_txt);
			this.Controls.Add(this.username_txt);
			this.Controls.Add(this.password);
			this.Name = "login";
			this.Text = "Permit Logistik";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.TextBox username_txt;
		private System.Windows.Forms.TextBox password_txt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label username;
	}
}

