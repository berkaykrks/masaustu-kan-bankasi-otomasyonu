namespace Kan_Bankası_Yönetim_Projesi
{
	partial class AdminLogin
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
			label4 = new Label();
			button1 = new Button();
			sifreTxt = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.Red;
			label4.Location = new Point(86, 183);
			label4.Name = "label4";
			label4.Size = new Size(209, 30);
			label4.TabIndex = 14;
			label4.Text = "Login sayfasına dön";
			label4.Click += label4_Click;
			// 
			// button1
			// 
			button1.Location = new Point(141, 130);
			button1.Name = "button1";
			button1.Size = new Size(87, 29);
			button1.TabIndex = 13;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// sifreTxt
			// 
			sifreTxt.Location = new Point(102, 89);
			sifreTxt.Name = "sifreTxt";
			sifreTxt.PasswordChar = '*';
			sifreTxt.Size = new Size(193, 23);
			sifreTxt.TabIndex = 12;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.Location = new Point(37, 89);
			label3.Name = "label3";
			label3.Size = new Size(51, 25);
			label3.TabIndex = 11;
			label3.Text = "Sifre";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(37, 21);
			label2.Name = "label2";
			label2.Size = new Size(296, 30);
			label2.TabIndex = 9;
			label2.Text = "Kan Bankası Yönetim Sistemi";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label5.Location = new Point(344, 9);
			label5.Name = "label5";
			label5.Size = new Size(24, 25);
			label5.TabIndex = 15;
			label5.Text = "X";
			label5.Click += label5_Click;
			// 
			// AdminLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(378, 236);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(sifreTxt);
			Controls.Add(label3);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AdminLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AdminLogin";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private Button button1;
		private TextBox sifreTxt;
		private Label label3;
		private Label label2;
		private Label label5;
	}
}