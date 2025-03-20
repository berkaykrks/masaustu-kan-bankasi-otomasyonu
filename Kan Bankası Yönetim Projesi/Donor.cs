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
	public partial class Donor : Form
	{

		public Donor()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Server=DESKTOP-5UN8A75\\SQLEXPRESS;Database=KanBankasiDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
		private void Donor_Load(object sender, EventArgs e)
		{

		}
		private void Reset()
		{
			adSoyadTxt.Text = "";
			yasTxt.Text = "";
			cinsiyetCmb.SelectedIndex = -1;
			telefonTxt.Text = "";
			kanGrubuCmb.SelectedIndex = -1;
			adresTxt.Text = "";
		}

		private void kaydetBtn_Click(object sender, EventArgs e)
		{
			if (adSoyadTxt.Text == "" || yasTxt.Text == "" || cinsiyetCmb.SelectedIndex == -1 || telefonTxt.Text == "" || kanGrubuCmb.SelectedIndex == -1 || adresTxt.Text == "")
			{
				MessageBox.Show("Eksik Bilgi Girişi");
			}
			else
			{
				try
				{
					string query = "insert into DonorTbl values ('" + adSoyadTxt.Text + "'," + yasTxt.Text + ",'" + cinsiyetCmb.SelectedItem.ToString() + "','" + telefonTxt.Text + "','" + adresTxt.Text + "','" + kanGrubuCmb.SelectedItem.ToString() + "')";
					baglanti.Open();
					SqlCommand komut = new SqlCommand(query, baglanti);
					komut.ExecuteNonQuery();
					MessageBox.Show("Donor Başarıyla eklendi");
					baglanti.Close();
					Reset();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);

				}
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Donor donor = new Donor();
			donor.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			DonorListesi dl = new DonorListesi();
			dl.Show();
			this.Hide();
		}

		private void label17_Click(object sender, EventArgs e)
		{
			KanBagısı kb = new KanBagısı();
			kb.Show();
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
