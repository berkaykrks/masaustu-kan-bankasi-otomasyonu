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
	public partial class KontrolPaneli : Form
	{
		public KontrolPaneli()
		{
			InitializeComponent();
			VeriCek();
		}
		SqlConnection baglanti = new SqlConnection("Server=DESKTOP-5UN8A75\\SQLEXPRESS;Database=KanBankasiDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

		private void VeriCek()
		{
			baglanti.Open();
			SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DonorTbl", baglanti);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			donorLbl.Text = dt.Rows[0][0].ToString();

			SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from TransferTbl", baglanti);
			DataTable dt1 = new DataTable();
			sda1.Fill(dt1);
			transferLbl.Text = dt1.Rows[0][0].ToString();

			SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from CalisanTbl", baglanti);
			DataTable dt2 = new DataTable();
			sda2.Fill(dt2);
			kullaniciLbl.Text = dt2.Rows[0][0].ToString();

			SqlDataAdapter sda3 = new SqlDataAdapter("Select count(*) from KanTbl", baglanti);
			DataTable dt3 = new DataTable();
			sda3.Fill(dt3);
			int KStok = Convert.ToInt32(dt3.Rows[0][0].ToString());
			totalLbl.Text = "" + KStok;

			SqlDataAdapter sda4 = new SqlDataAdapter("Select KStok from KanTbl where KGrup='" + "0+" + "'", baglanti);
			DataTable dt4 = new DataTable();
			sda4.Fill(dt4);
			opLbl.Text = dt4.Rows[0][0].ToString();
			double OplusPercantage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / KStok) * 100;
			OplusBar.ProgressValue = Convert.ToInt32(OplusPercantage);

			SqlDataAdapter sda5 = new SqlDataAdapter("Select KStok from KanTbl where KGrup='" + "AB+" + "'", baglanti);
			DataTable dt5 = new DataTable();
			sda5.Fill(dt5);
			abpLbl.Text = dt5.Rows[0][0].ToString();
			double abPlusPercantage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / KStok) * 100;
			AbPlusBar.ProgressValue = Convert.ToInt32(abPlusPercantage);

			SqlDataAdapter sda6 = new SqlDataAdapter("Select KStok from KanTbl where KGrup='" + "0-" + "'", baglanti);
			DataTable dt6 = new DataTable();
			sda6.Fill(dt6);
			oNegativeLbl.Text = dt6.Rows[0][0].ToString();
			double oNegPercantage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / KStok) * 100;
			ONegBar.ProgressValue = Convert.ToInt32(oNegPercantage);


			SqlDataAdapter sda7 = new SqlDataAdapter("Select KStok from KanTbl where KGrup='" + "AB-" + "'", baglanti);
			DataTable dt7 = new DataTable();
			sda7.Fill(dt7);
			abNegativeLbl.Text = dt7.Rows[0][0].ToString();
			double abNegPercantage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / KStok) * 100;
			AbNegBar.ProgressValue = Convert.ToInt32(abNegPercantage);

			baglanti.Close();
		}
		private void KontrolPaneli_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
			Donor donor = new Donor();
			donor.Show();
			this.Hide();
		}

		private void label11_Click(object sender, EventArgs e)
		{
			KanBagısı kb = new KanBagısı();
			kb.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			DonorListesi dl = new DonorListesi();
			dl.Show();
			this.Hide();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Hasta hasta = new Hasta();
			hasta.Show();
			this.Hide();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			HastaListesi hl = new HastaListesi();
			hl.Show();
			this.Hide();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			KanStogu ks = new KanStogu();
			ks.Show();
			this.Hide();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			KanTransferi kt = new KanTransferi();
			kt.Show();
			this.Hide();
		}

		private void label8_Click(object sender, EventArgs e)
		{
			KontrolPaneli kt = new KontrolPaneli();
			kt.Show();
			this.Hide();
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Login log = new Login();
			log.Show();
			this.Hide();
		}
	}
}
