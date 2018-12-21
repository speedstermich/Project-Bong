namespace Logistik_Permit
{
	partial class delete_borrower
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
			this.label2 = new System.Windows.Forms.Label();
			this.search_btn = new System.Windows.Forms.Button();
			this.borrower_id = new System.Windows.Forms.TextBox();
			this.delete_btn = new System.Windows.Forms.Button();
			this.borrower_name = new System.Windows.Forms.TextBox();
			this.cancel_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(91, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Borrower ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(91, 215);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// search_btn
			// 
			this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_btn.Location = new System.Drawing.Point(576, 100);
			this.search_btn.Name = "search_btn";
			this.search_btn.Size = new System.Drawing.Size(109, 31);
			this.search_btn.TabIndex = 2;
			this.search_btn.Text = "Search";
			this.search_btn.UseVisualStyleBackColor = true;
			this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
			// 
			// borrower_id
			// 
			this.borrower_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borrower_id.Location = new System.Drawing.Point(221, 100);
			this.borrower_id.Name = "borrower_id";
			this.borrower_id.Size = new System.Drawing.Size(349, 31);
			this.borrower_id.TabIndex = 3;
			// 
			// delete_btn
			// 
			this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete_btn.Location = new System.Drawing.Point(96, 332);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(109, 31);
			this.delete_btn.TabIndex = 4;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = true;
			this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
			// 
			// borrower_name
			// 
			this.borrower_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borrower_name.Location = new System.Drawing.Point(221, 212);
			this.borrower_name.Name = "borrower_name";
			this.borrower_name.Size = new System.Drawing.Size(464, 31);
			this.borrower_name.TabIndex = 5;
			// 
			// cancel_btn
			// 
			this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel_btn.Location = new System.Drawing.Point(461, 332);
			this.cancel_btn.Name = "cancel_btn";
			this.cancel_btn.Size = new System.Drawing.Size(109, 31);
			this.cancel_btn.TabIndex = 6;
			this.cancel_btn.Text = "Cancel";
			this.cancel_btn.UseVisualStyleBackColor = true;
			this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
			// 
			// delete_borrower
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cancel_btn);
			this.Controls.Add(this.borrower_name);
			this.Controls.Add(this.delete_btn);
			this.Controls.Add(this.borrower_id);
			this.Controls.Add(this.search_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "delete_borrower";
			this.Text = "Delete Borrower";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button search_btn;
		private System.Windows.Forms.TextBox borrower_id;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.TextBox borrower_name;
		private System.Windows.Forms.Button cancel_btn;
	}
}