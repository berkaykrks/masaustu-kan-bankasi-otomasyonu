namespace Kan_Bankası_Yönetim_Projesi
{
	public partial class Gecis : Form
	{
		public Gecis()
		{
			InitializeComponent();
		}
		int startpos = 0;

		private void timer1_Tick(object sender, EventArgs e)
		{
			startpos += 1;
			gecisProgBar.ProgressValue= startpos;
			if (gecisProgBar.ProgressValue==100)
			{

				gecisProgBar.ProgressValue = 0;
				timer1.Stop();
				Login log = new Login();
				log.Show();
				this.Hide();
			}
		}

		private void Gecis_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
