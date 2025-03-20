using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kan_Bankası_Yönetim_Projesi
{
	public partial class AdminLogin : Form
	{
		public AdminLogin()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Login log = new Login();
			log.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (sifreTxt.Text == "")
			{
				MessageBox.Show("Admin Şifrenizi giriniz");
			}
			else if (sifreTxt.Text == "0678")
			{
				Calisan calisan = new Calisan();
				calisan.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("yanlıs sifre");
				sifreTxt.Text = "";
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
