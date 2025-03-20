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
	public partial class KanBagısı : Form
	{
		public KanBagısı()
		{
			InitializeComponent();
			uyeler();
			kanStok();
		}
		SqlConnection baglanti = new SqlConnection("Server=DESKTOP-5UN8A75\\SQLEXPRESS;Database=KanBankasiDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

		private void uyeler()
		{
			baglanti.Open();
			string query = "select * from DonorTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			sda.Fill(ds);
			donorView.DataSource = ds.Tables[0];
			baglanti.Close();
		}
		private void kanStok()
		{
			baglanti.Open();
			string query = "select * from KanTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			sda.Fill(ds);
			kanStokView.DataSource = ds.Tables[0];
			baglanti.Close();
		}

		private void KanBagısı_Load(object sender, EventArgs e)
		{

		}
		int eskiStok;
		private void Stok(string Kgrup)
		{
			baglanti.Open();
			string query = "select * from KanTbl where KGrup='" + Kgrup + "'";
			SqlCommand komut = new SqlCommand(query, baglanti);
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(komut);
			sda.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				eskiStok = Convert.ToInt32(dr["KStok"].ToString());
			}
			baglanti.Close();
		}
		private void donorView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			adSoyadTxt.Text = donorView.SelectedRows[0].Cells[1].Value.ToString();
			kanGrubuTxt.Text = donorView.SelectedRows[0].Cells[6].Value.ToString();
			Stok(kanGrubuTxt.Text);
		}

		private void Reset()
		{
			adSoyadTxt.Text = "";
			kanGrubuTxt.Text = "";
		}
		private void kaydetBtn_Click(object sender, EventArgs e)
		{
			if (adSoyadTxt.Text == "")
			{
				MessageBox.Show("Bir Donor Seçiniz");
			}
			else
			{
				try
				{
					int stok = eskiStok + 1;
					string query = "update KanTbl set KStok='" + stok + "'where KGrup ='" + kanGrubuTxt.Text + "';";
					baglanti.Open();
					SqlCommand komut = new SqlCommand(query, baglanti);
					komut.ExecuteNonQuery();
					MessageBox.Show("Bağış başarıyla yapıldı");
					baglanti.Close();
					Reset();
					uyeler();
					kanStok();
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

		private void label13_Click(object sender, EventArgs e)
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
