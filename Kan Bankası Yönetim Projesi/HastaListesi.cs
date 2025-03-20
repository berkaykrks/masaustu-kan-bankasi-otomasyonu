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
	public partial class HastaListesi : Form
	{
		public HastaListesi()
		{
			InitializeComponent();
			uyeler();
		}
		SqlConnection baglanti = new SqlConnection("Server=DESKTOP-5UN8A75\\SQLEXPRESS;Database=KanBankasiDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

		private void Reset()
		{
			adSoyadTxt.Text = "";
			yasTxt.Text = "";
			cinsiyetCmb.SelectedIndex = -1;
			telefonTxt.Text = "";
			kanGrubuCmb.SelectedIndex = -1;
			adresTxt.Text = "";
			key = 0;
		}


		private void uyeler()
		{
			baglanti.Open();
			string query = "select * from HastaTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			sda.Fill(ds);
			hastaView.DataSource = ds.Tables[0];
			baglanti.Close();
		}
		private void HastaListesi_Load(object sender, EventArgs e)
		{

		}
		int key = 0;
		private void hastaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (hastaView.SelectedRows.Count > 0) // En az bir satır seçili mi?
			{
				adSoyadTxt.Text = hastaView.SelectedRows[0].Cells[1].Value?.ToString() ?? string.Empty;
				yasTxt.Text = hastaView.SelectedRows[0].Cells[2].Value?.ToString() ?? string.Empty;
				telefonTxt.Text = hastaView.SelectedRows[0].Cells[3].Value?.ToString() ?? string.Empty;
				cinsiyetCmb.Text = hastaView.SelectedRows[0].Cells[4].Value?.ToString() ?? string.Empty;
				kanGrubuCmb.Text = hastaView.SelectedRows[0].Cells[5].Value?.ToString() ?? string.Empty;
				adresTxt.Text = hastaView.SelectedRows[0].Cells[6].Value?.ToString() ?? string.Empty;


			}
			if (adSoyadTxt.Text == "")
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(hastaView.SelectedRows[0].Cells[0].Value.ToString());
			}

		}

		private void silBtn_Click(object sender, EventArgs e)
		{
			if (key == 0)
			{
				MessageBox.Show("silinecek hastayı seçiniz");
			}
			else
			{
				try
				{
					string query = "delete from HastaTbl where HNum=" + key + ";";
					baglanti.Open();
					SqlCommand komut = new SqlCommand(query, baglanti);
					komut.ExecuteNonQuery();
					MessageBox.Show("Hasta Başarıyla silindi");
					baglanti.Close();
					Reset();
					uyeler();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);

				}
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			HastaListesi hl = new HastaListesi();
			hl.Show();
			this.Hide();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Hasta hasta = new Hasta();
			hasta.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			DonorListesi dl = new DonorListesi();
			dl.Show();
			this.Hide();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Donor donor = new Donor();
			donor.Show();
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
			KontrolPaneli kp = new KontrolPaneli();
			kp.Show();
			this.Hide();
		}

		private void düzenleBtn_Click(object sender, EventArgs e)
		{
			if (adSoyadTxt.Text == "" || yasTxt.Text == "" || cinsiyetCmb.SelectedIndex == -1 || telefonTxt.Text == "" || kanGrubuCmb.SelectedIndex == -1 || adresTxt.Text == "")
			{
				MessageBox.Show("eksik bilgi");
			}
			else
			{
				try
				{
					string query = "update HastaTbl set  HAdSoyad='" + adSoyadTxt.Text + "',HYas=" + yasTxt.Text + ",HTelefon='" + telefonTxt.Text + "',HCinsiyet='" + cinsiyetCmb.SelectedItem.ToString() + "',HKGrup='" + kanGrubuCmb.SelectedItem.ToString() + "',HAdres='" + adresTxt.Text + "' where HNum=" + key + ";";
					baglanti.Open();
					SqlCommand komut = new SqlCommand(query, baglanti);
					komut.ExecuteNonQuery();
					MessageBox.Show("Hasta Başarıyla güncellendi");
					baglanti.Close();
					Reset();
					uyeler();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);

				}
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{
			KanBagısı kb = new KanBagısı();
			kb.Show();
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
