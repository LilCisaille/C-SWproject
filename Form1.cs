using System.Media;
using System.Net;
using WinFormsApp1;

namespace WinFormsAppSW
{

    public partial class Form1 : Form
    {
        private SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button2.MouseEnter += new EventHandler(button2_MouseEnter);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fLtA = new Form2();
            fLtA.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fAtL = new Form3();
            fAtL.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://dl.dafont.com/dl/?f=aurebesh"; //  URL
            string fileName = "Aurebesh.zip"; // file name
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName); //DL path

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(url, downloadPath);
            }

            MessageBox.Show($"Font downloaded successfully to {downloadPath}", "Download Complete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fLtA = new Form4();
            fLtA.Show();
            this.Hide();
        }
    }
}