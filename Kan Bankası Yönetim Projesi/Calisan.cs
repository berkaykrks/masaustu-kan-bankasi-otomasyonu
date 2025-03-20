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
	public partial class Calisan : Form
	{
		public Calisan()
		{
			InitializeComponent();
			uyeler();
		}
		SqlConnection baglanti = new SqlConnection("Server=DESKTOP-5UN8A75\\SQLEXPRESS;Database=KanBankasiDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

		private void label9_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}
		private void Reset()
		{
			adSoyadTxt.Text = "";
			sifreTxt.Text = "";
			key = 0;
		}
		private void uyeler()
		{
			baglanti.Open();
			string query = "select * from CalisanTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			sda.Fill(ds);
			calisanView.DataSource = ds.Tables[0];
			baglanti.Close();
		}
		private void kaydetBtn_Click(object sender, EventArgs e)
		{
			if (adSoyadTxt.Text == "" || sifreTxt.Text == "")
			{
				MessageBox.Show("Eksik Bilgi Girişi");
			}
			else
			{
				try
				{
					string query = "insert into CalisanTbl values ('" + adSoyadTxt.Text + "','" + sifreTxt.Text + "')";
					baglanti.Open();
					SqlCommand komut = new SqlCommand(query, baglanti);
					komut.ExecuteNonQuery();
					MessageBox.Show("Calışan Başarıyla eklendi");
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
		int key = 0;
		private void calisanView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{


			adSoyadTxt.Text = calisanView.SelectedRows[0].Cells[1].Value.ToString();
			sifreTxt.Text = calisanView.SelectedRows[0].Cells[2].Value.ToString();


			if (adSoyadTxt.Text == "")
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(calisanView.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void silBtn_Click(object sender, EventArgs e)
		{
			if (key == 0)
			{
				MessageBox.Show("silinecek calisanı seçiniz");
			}
			else
			{
				try
				{
					string query = "delete from CalisanTbl where CalNum=" + key + ";";
					baglanti.Open();
					SqlCommand komut = new SqlCommand(query, baglanti);
					komut.ExecuteNonQuery();
					MessageBox.Show("Calışan Başarıyla silindi");
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

		private void düzenleBtn_Click(object sender, EventArgs e)
		{
			if (adSoyadTxt.Text == "" || sifreTxt.Text == "")
			{
				MessageBox.Show("eksik bilgi");
			}
			else
			{
				try
				{
					string query = "update CalisanTbl set  CalId='" + adSoyadTxt.Text + "',CalSif='" + sifreTxt.Text + "' where CalNum="+key+ ";";
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
	}
}
