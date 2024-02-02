using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppSW
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button41_Click(object sender, EventArgs e) // bouton espace
        {
            textBox1.Text = textBox1.Text + " ";
        }

        private void keyboard_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            textBox1.Text = textBox1.Text + clickedButton.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // majusucle
            if (!string.IsNullOrEmpty(textBox.Text)) 
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1);
            }
            textBox2.Text = textBox1.Text;
            textBox2.Font = new Font("Segoe", 9);
        }

        private void button42_Click(object sender, EventArgs e) // bouton supp
        {
            // Create a SoundPlayer instance
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            // Get the sound file from resources
            System.IO.Stream stream = WinFormsApp1.Properties.Resources.mysong;
            player.Stream = stream;

            // Play the sound file
            player.Play();
            TextBox textBox = textBox1;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
    }
}
