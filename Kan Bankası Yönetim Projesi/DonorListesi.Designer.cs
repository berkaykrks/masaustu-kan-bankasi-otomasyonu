namespace Kan_Bankası_Yönetim_Projesi
{
	partial class DonorListesi
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
			label10 = new Label();
			panel2 = new Panel();
			label2 = new Label();
			panel1 = new Panel();
			label12 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			panel3 = new Panel();
			label3 = new Label();
			label1 = new Label();
			donorView = new DataGridView();
			adSoyadTxt = new TextBox();
			label11 = new Label();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)donorView).BeginInit();
			SuspendLayout();
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.WhiteSmoke;
			label10.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label10.ForeColor = Color.Red;
			label10.Location = new Point(376, 71);
			label10.Name = "label10";
			label10.Size = new Size(155, 28);
			label10.TabIndex = 21;
			label10.Text = "Donor Listesi";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(0, 0, 192);
			panel2.Controls.Add(label2);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(144, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(656, 56);
			panel2.TabIndex = 20;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.WhiteSmoke;
			label2.Location = new Point(169, 13);
			label2.Name = "label2";
			label2.Size = new Size(296, 30);
			label2.TabIndex = 3;
			label2.Text = "Kan Bankası Yönetim Sistemi";
			// 
			// panel1
			// 
			panel1.BackColor = Color.Red;
			panel1.Controls.Add(label12);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(144, 450);
			panel1.TabIndex = 19;
			panel1.Paint += panel1_Paint;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.Red;
			label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label12.ForeColor = Color.WhiteSmoke;
			label12.Location = new Point(29, 124);
			label12.Name = "label12";
			label12.Size = new Size(87, 21);
			label12.TabIndex = 10;
			label12.Text = "Kan Bağışı";
			label12.Click += label12_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Red;
			label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label9.ForeColor = Color.WhiteSmoke;
			label9.Location = new Point(41, 420);
			label9.Name = "label9";
			label9.Size = new Size(43, 21);
			label9.TabIndex = 9;
			label9.Text = "Çıkış";
			label9.Click += label9_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.Red;
			label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label8.ForeColor = Color.WhiteSmoke;
			label8.Location = new Point(27, 299);
			label8.Name = "label8";
			label8.Size = new Size(114, 21);
			label8.TabIndex = 8;
			label8.Text = "Kontrol Paneli";
			label8.Click += label8_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Red;
			label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label7.ForeColor = Color.WhiteSmoke;
			label7.Location = new Point(27, 264);
			label7.Name = "label7";
			label7.Size = new Size(107, 21);
			label7.TabIndex = 8;
			label7.Text = "Kan Transferi";
			label7.Click += label7_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Red;
			label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label6.ForeColor = Color.WhiteSmoke;
			label6.Location = new Point(29, 225);
			label6.Name = "label6";
			label6.Size = new Size(90, 21);
			label6.TabIndex = 8;
			label6.Text = "Kan Stoğu";
			label6.Click += label6_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Red;
			label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label5.ForeColor = Color.WhiteSmoke;
			label5.Location = new Point(28, 190);
			label5.Name = "label5";
			label5.Size = new Size(102, 21);
			label5.TabIndex = 8;
			label5.Text = "Hasta Listesi";
			label5.Click += label5_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Red;
			label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.WhiteSmoke;
			label4.Location = new Point(28, 155);
			label4.Name = "label4";
			label4.Size = new Size(56, 21);
			label4.TabIndex = 6;
			label4.Text = "Hasta";
			label4.Click += label4_Click;
			// 
			// panel3
			// 
			panel3.BackColor = Color.WhiteSmoke;
			panel3.Location = new Point(12, 93);
			panel3.Name = "panel3";
			panel3.Size = new Size(10, 20);
			panel3.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Red;
			label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label3.ForeColor = Color.WhiteSmoke;
			label3.Location = new Point(28, 92);
			label3.Name = "label3";
			label3.Size = new Size(103, 21);
			label3.TabIndex = 6;
			label3.Text = "Donor Listesi";
			label3.Click += label3_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Red;
			label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label1.ForeColor = Color.WhiteSmoke;
			label1.Location = new Point(28, 53);
			label1.Name = "label1";
			label1.Size = new Size(57, 21);
			label1.TabIndex = 4;
			label1.Text = "Donor";
			label1.Click += label1_Click;
			// 
			// donorView
			// 
			donorView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			donorView.Location = new Point(150, 175);
			donorView.Name = "donorView";
			donorView.Size = new Size(638, 263);
			donorView.TabIndex = 22;
			// 
			// adSoyadTxt
			// 
			adSoyadTxt.Location = new Point(303, 146);
			adSoyadTxt.Name = "adSoyadTxt";
			adSoyadTxt.Size = new Size(124, 23);
			adSoyadTxt.TabIndex = 24;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = SystemColors.Control;
			label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label11.ForeColor = Color.IndianRed;
			label11.Location = new Point(180, 144);
			label11.Name = "label11";
			label11.Size = new Size(92, 21);
			label11.TabIndex = 23;
			label11.Text = "Adı Soyadı";
			// 
			// DonorListesi
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(adSoyadTxt);
			Controls.Add(label11);
			Controls.Add(donorView);
			Controls.Add(label10);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "DonorListesi";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DonorListesi";
			Load += DonorListesi_Load;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)donorView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label10;
		private Panel panel2;
		private Label label2;
		private Panel panel1;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Panel panel3;
		private Label label3;
		private Label label1;
		private DataGridView donorView;
		private TextBox adSoyadTxt;
		private Label label11;
		private Label label12;
	}
}