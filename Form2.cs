namespace WinFormsAppSW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            textBox2.Font = new Font("Aurebesh", 9);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
