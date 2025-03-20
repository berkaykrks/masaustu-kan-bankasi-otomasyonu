namespace Kan_Bankası_Yönetim_Projesi
{
	partial class Calisan
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
			düzenleBtn = new Button();
			calisanView = new DataGridView();
			label10 = new Label();
			panel2 = new Panel();
			label2 = new Label();
			panel1 = new Panel();
			label9 = new Label();
			panel3 = new Panel();
			label1 = new Label();
			silBtn = new Button();
			kaydetBtn = new Button();
			sifreTxt = new TextBox();
			label12 = new Label();
			adSoyadTxt = new TextBox();
			label11 = new Label();
			((System.ComponentModel.ISupportInitialize)calisanView).BeginInit();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// düzenleBtn
			// 
			düzenleBtn.Location = new Point(407, 429);
			düzenleBtn.Name = "düzenleBtn";
			düzenleBtn.Size = new Size(114, 36);
			düzenleBtn.TabIndex = 77;
			düzenleBtn.Text = "Düzenle";
			düzenleBtn.UseVisualStyleBackColor = true;
			düzenleBtn.Click += düzenleBtn_Click;
			// 
			// calisanView
			// 
			calisanView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			calisanView.Location = new Point(274, 114);
			calisanView.Name = "calisanView";
			calisanView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			calisanView.Size = new Size(391, 238);
			calisanView.TabIndex = 69;
			calisanView.CellContentClick += calisanView_CellContentClick;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.WhiteSmoke;
			label10.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label10.ForeColor = Color.Red;
			label10.Location = new Point(411, 71);
			label10.Name = "label10";
			label10.Size = new Size(100, 28);
			label10.TabIndex = 68;
			label10.Text = "Calisan";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(0, 0, 192);
			panel2.Controls.Add(label2);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(144, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(689, 56);
			panel2.TabIndex = 67;
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
			panel1.Controls.Add(label9);
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(144, 470);
			panel1.TabIndex = 66;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Red;
			label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label9.ForeColor = Color.WhiteSmoke;
			label9.Location = new Point(28, 411);
			label9.Name = "label9";
			label9.Size = new Size(43, 21);
			label9.TabIndex = 9;
			label9.Text = "Çıkış";
			label9.Click += label9_Click;
			// 
			// panel3
			// 
			panel3.BackColor = Color.WhiteSmoke;
			panel3.Location = new Point(12, 79);
			panel3.Name = "panel3";
			panel3.Size = new Size(10, 20);
			panel3.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Red;
			label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label1.ForeColor = Color.WhiteSmoke;
			label1.Location = new Point(28, 77);
			label1.Name = "label1";
			label1.Size = new Size(67, 21);
			label1.TabIndex = 4;
			label1.Text = "Çalışan";
			// 
			// silBtn
			// 
			silBtn.Location = new Point(530, 429);
			silBtn.Name = "silBtn";
			silBtn.Size = new Size(114, 36);
			silBtn.TabIndex = 78;
			silBtn.Text = "Sil";
			silBtn.UseVisualStyleBackColor = true;
			silBtn.Click += silBtn_Click;
			// 
			// kaydetBtn
			// 
			kaydetBtn.Location = new Point(287, 429);
			kaydetBtn.Name = "kaydetBtn";
			kaydetBtn.Size = new Size(114, 36);
			kaydetBtn.TabIndex = 79;
			kaydetBtn.Text = "Kaydet";
			kaydetBtn.UseVisualStyleBackColor = true;
			kaydetBtn.Click += kaydetBtn_Click;
			// 
			// sifreTxt
			// 
			sifreTxt.Location = new Point(485, 379);
			sifreTxt.Name = "sifreTxt";
			sifreTxt.Size = new Size(124, 23);
			sifreTxt.TabIndex = 83;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = SystemColors.Control;
			label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label12.ForeColor = Color.IndianRed;
			label12.Location = new Point(485, 355);
			label12.Name = "label12";
			label12.Size = new Size(41, 21);
			label12.TabIndex = 82;
			label12.Text = "Sifre";
			// 
			// adSoyadTxt
			// 
			adSoyadTxt.Location = new Point(309, 379);
			adSoyadTxt.Name = "adSoyadTxt";
			adSoyadTxt.Size = new Size(124, 23);
			adSoyadTxt.TabIndex = 81;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = SystemColors.Control;
			label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label11.ForeColor = Color.IndianRed;
			label11.Location = new Point(309, 355);
			label11.Name = "label11";
			label11.Size = new Size(92, 21);
			label11.TabIndex = 80;
			label11.Text = "Adı Soyadı";
			// 
			// Calisan
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(833, 470);
			Controls.Add(sifreTxt);
			Controls.Add(label12);
			Controls.Add(adSoyadTxt);
			Controls.Add(label11);
			Controls.Add(kaydetBtn);
			Controls.Add(silBtn);
			Controls.Add(düzenleBtn);
			Controls.Add(calisanView);
			Controls.Add(label10);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Calisan";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Calisan";
			((System.ComponentModel.ISupportInitialize)calisanView).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button düzenleBtn;
		private DataGridView calisanView;
		private Label label10;
		private Panel panel2;
		private Label label2;
		private Panel panel1;
		private Label label9;
		private Panel panel3;
		private Label label1;
		private Button silBtn;
		private Button kaydetBtn;
		private TextBox sifreTxt;
		private Label label12;
		private TextBox adSoyadTxt;
		private Label label11;
	}
}