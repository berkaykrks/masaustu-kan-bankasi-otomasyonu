namespace Kan_Bankası_Yönetim_Projesi
{
	partial class Login
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
			label1 = new Label();
			label2 = new Label();
			kullanıcıTxt = new TextBox();
			sifreTxt = new TextBox();
			label3 = new Label();
			button1 = new Button();
			label4 = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(28, 93);
			label1.Name = "label1";
			label1.Size = new Size(119, 25);
			label1.TabIndex = 0;
			label1.Text = "Kullanıcı Adı";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(65, 22);
			label2.Name = "label2";
			label2.Size = new Size(296, 30);
			label2.TabIndex = 2;
			label2.Text = "Kan Bankası Yönetim Sistemi";
			// 
			// kullanıcıTxt
			// 
			kullanıcıTxt.Location = new Point(153, 93);
			kullanıcıTxt.Name = "kullanıcıTxt";
			kullanıcıTxt.Size = new Size(193, 23);
			kullanıcıTxt.TabIndex = 3;
			// 
			// sifreTxt
			// 
			sifreTxt.Location = new Point(153, 128);
			sifreTxt.Name = "sifreTxt";
			sifreTxt.PasswordChar = '*';
			sifreTxt.Size = new Size(193, 23);
			sifreTxt.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.Location = new Point(28, 128);
			label3.Name = "label3";
			label3.Size = new Size(51, 25);
			label3.TabIndex = 4;
			label3.Text = "Sifre";
			// 
			// button1
			// 
			button1.Location = new Point(153, 179);
			button1.Name = "button1";
			button1.Size = new Size(87, 29);
			button1.TabIndex = 6;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.Red;
			label4.Location = new Point(91, 223);
			label4.Name = "label4";
			label4.Size = new Size(242, 30);
			label4.TabIndex = 7;
			label4.Text = "Admin olarak devam et";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label5.Location = new Point(377, 9);
			label5.Name = "label5";
			label5.Size = new Size(24, 25);
			label5.TabIndex = 8;
			label5.Text = "X";
			label5.Click += label5_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(413, 263);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(sifreTxt);
			Controls.Add(label3);
			Controls.Add(kullanıcıTxt);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox kullanıcıTxt;
		private TextBox sifreTxt;
		private Label label3;
		private Button button1;
		private Label label4;
		private Label label5;
	}
}