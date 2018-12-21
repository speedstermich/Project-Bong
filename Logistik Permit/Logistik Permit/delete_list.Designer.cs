namespace Logistik_Permit
{
	partial class delete_list
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
			this.id_logistic = new System.Windows.Forms.TextBox();
			this.name_logistic = new System.Windows.Forms.TextBox();
			this.search_btn = new System.Windows.Forms.Button();
			this.delete_btn = new System.Windows.Forms.Button();
			this.cancel_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(112, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Logistic ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(113, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// id_logistic
			// 
			this.id_logistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id_logistic.Location = new System.Drawing.Point(244, 87);
			this.id_logistic.Name = "id_logistic";
			this.id_logistic.Size = new System.Drawing.Size(317, 31);
			this.id_logistic.TabIndex = 2;
			// 
			// name_logistic
			// 
			this.name_logistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_logistic.Location = new System.Drawing.Point(244, 200);
			this.name_logistic.Name = "name_logistic";
			this.name_logistic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.name_logistic.Size = new System.Drawing.Size(435, 31);
			this.name_logistic.TabIndex = 3;
			// 
			// search_btn
			// 
			this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_btn.Location = new System.Drawing.Point(567, 79);
			this.search_btn.Name = "search_btn";
			this.search_btn.Size = new System.Drawing.Size(112, 48);
			this.search_btn.TabIndex = 4;
			this.search_btn.Text = "Search";
			this.search_btn.UseVisualStyleBackColor = true;
			this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
			// 
			// delete_btn
			// 
			this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete_btn.Location = new System.Drawing.Point(118, 302);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(112, 48);
			this.delete_btn.TabIndex = 5;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = true;
			this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
			// 
			// cancel_btn
			// 
			this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancel_btn.Location = new System.Drawing.Point(449, 302);
			this.cancel_btn.Name = "cancel_btn";
			this.cancel_btn.Size = new System.Drawing.Size(112, 48);
			this.cancel_btn.TabIndex = 6;
			this.cancel_btn.Text = "Cancel";
			this.cancel_btn.UseVisualStyleBackColor = true;
			this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
			// 
			// delete_list
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cancel_btn);
			this.Controls.Add(this.delete_btn);
			this.Controls.Add(this.search_btn);
			this.Controls.Add(this.name_logistic);
			this.Controls.Add(this.id_logistic);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "delete_list";
			this.Text = "Delete";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox id_logistic;
		private System.Windows.Forms.TextBox name_logistic;
		private System.Windows.Forms.Button search_btn;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.Button cancel_btn;
	}
}