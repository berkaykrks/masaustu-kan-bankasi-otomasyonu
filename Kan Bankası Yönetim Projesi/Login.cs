using Microsoft.Data.SqlClient;
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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Server=DESKTOP-5UN8A75\\SQLEXPRESS;Database=KanBankasiDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
		private void label4_Click(object sender, EventArgs e)
		{
			AdminLogin al = new AdminLogin();
			al.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CalisanTbl where CalId='" + kullanıcıTxt.Text + "' and CalSif='" + sifreTxt.Text + "'", baglanti);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows[0][0].ToString() == "1")
			{
				AnaSayfa ana = new AnaSayfa();
				ana.Show();
				this.Hide();
				baglanti.Close();
			}
			else
			{
				MessageBox.Show("Yanlıs kullanıcı adı yada sifre");

			}
			baglanti.Close();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
