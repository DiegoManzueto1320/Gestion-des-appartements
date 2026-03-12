using GESTAPP.Views;

namespace GESTAPP
{
    public partial class LancementMenu : Form
    {
        public LancementMenu()
        {
            InitializeComponent();
            MiseEnForme.AppliquerForm(this);
            panel1.BackColor = Color.FromArgb(102, 154, 204);
            progressBar1.BackColor = Color.FromArgb(199, 221, 245);
            // Configurer la ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            // Configurer le Timer
            timer1.Interval = 50; // vitesse (ms)
            timer1.Tick += timer1_Tick;
            timer1.Start();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                // Ouvrir une autre fenêtre
                FrmConnexion f2 = new FrmConnexion ();
                this.Hide();
                f2.ShowDialog();

            }
        }
    }
}
