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
	public partial class KanTransferi : Form
	{
		public KanTransferi()
		{
			InitializeComponent();
			fillHastaCb();
			VeriAl();
		}
		SqlConnection baglanti = new SqlConnection("Server=DESKTOP-5UN8A75\\SQLEXPRESS;Database=KanBankasiDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

		private void fillHastaCb()
		{
			baglanti.Open();
			SqlCommand cmd = new SqlCommand("select HNum From HastaTbl", baglanti);
			SqlDataReader rdr;
			rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("HNum", typeof(int));
			dt.Load(rdr);
			hastaIdCmb.ValueMember = "HNum";
			hastaIdCmb.DataSource = dt;
			baglanti.Close();
		}
		private void VeriAl()
		{
			baglanti.Open();
			string query = "select * from HastaTbl where HNum='" + hastaIdCmb.SelectedValue.ToString() + "'";
			SqlCommand komut = new SqlCommand(query, baglanti);
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(komut);
			sda.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				adSoyadTxt.Text = dr["HAdSoyad"].ToString();
				kanGrubTxt.Text = dr["HKGrup"].ToString();
			}
			baglanti.Close();
		}
		int stokk = 0;
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
				stokk = Convert.ToInt32(dr["KStok"].ToString());
			}
			baglanti.Close();


		}
		private void KanTransferi_Load(object sender, EventArgs e)
		{

		}

		private void hastaIdCmb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			VeriAl();
			Stok(kanGrubTxt.Text);
			if (stokk > 0)
			{
				transferBtn.Visible = true;
				uygunLbl.Text = "Stok Var";
				uygunLbl.Visible = true;
			}
			else
			{
				uygunLbl.Text = "Stok Yok";
				uygunLbl.Visible = false;
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Hasta hasta = new Hasta();
			hasta.Show();
			this.Hide();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			KanTransferi kt = new KanTransferi();
			kt.Show();
			this.Hide();
		}
		private void Reset()
		{

			adSoyadTxt.Text = "";
			kanGrubTxt.Text = "";
			uygunLbl.Visible = false;
			transferBtn.Visible = false;
		}

		private void KanGüncelle()
		{
			int yeniStok = stokk - 1;
			try
			{
				string query = "update KanTbl set KStok=" + yeniStok + " where KGrup='" + kanGrubTxt.Text + "';";
				baglanti.Open();
				SqlCommand komut = new SqlCommand(query, baglanti);
				komut.ExecuteNonQuery();
				//MessageBox.Show("Hasta Başarıyla güncellendi");
				baglanti.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}

		private void transferBtn_Click(object sender, EventArgs e)
		{
			if (adSoyadTxt.Text == "")
			{
				MessageBox.Show("Eksik Bilgi Girişi");
			}
			else
			{
				try
				{
					string query = "insert into TransferTbl values ('" + adSoyadTxt.Text + "','" + kanGrubTxt.Text + "')";
					baglanti.Open();
					SqlCommand komut = new SqlCommand(query, baglanti);
					komut.ExecuteNonQuery();
					MessageBox.Show("Transfer Başarıyla Gerçekleşti");
					baglanti.Close();
					Stok(kanGrubTxt.Text);
					Reset();
					KanGüncelle();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);

				}
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{
			KanStogu ks = new KanStogu();
			ks.Show();
			this.Hide();
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

		private void label14_Click(object sender, EventArgs e)
		{
			KanBagısı kb = new KanBagısı();
			kb.Show();
			this.Hide();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			HastaListesi hl = new HastaListesi();
			hl.Show();
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
