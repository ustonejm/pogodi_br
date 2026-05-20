using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int trazeniBroj;
        int brojPokusaja = 0;

        public Form1()
        {
            InitializeComponent();

            trazeniBroj = rnd.Next(1, 101);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int unos;

                if (int.TryParse(textBox1.Text, out unos))
                {
                    brojPokusaja++;

                    BrPokusaja.Text = brojPokusaja.ToString();

                    if (unos < trazeniBroj)
                    {
                        Komentar.Text = "Traženi broj je VEĆI";
                    }
                    else if (unos > trazeniBroj)
                    {
                        Komentar.Text = "Traženi broj je MANJI";
                    }
                    else
                    {
                        Komentar.Text = "pogodio si doktore!";
                        MessageBox.Show("bravo legendo, pogodio si br");
                    }
                }
                else
                {
                    MessageBox.Show("Unesi validan broj!");
                }

                textBox1.Clear();
            }
        }
    }
}
