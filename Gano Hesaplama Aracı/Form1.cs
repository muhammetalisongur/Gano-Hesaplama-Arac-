using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gano_Hesaplama_Aracı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();


            form.label6.Text = textBox1.Text;
            form.label7.Text = textBox2.Text;
            form.label8.Text = textBox3.Text;
            form.label9.Text = textBox4.Text;
            form.label10.Text = textBox5.Text + ".Sınıf";

            form.ShowDialog();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text!="")
            {
                try
                {
                    int sinif = Convert.ToInt32(textBox5.Text);
                    if (sinif<1)
                    {
                        MessageBox.Show("1 veya 4 aralığında rakam giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);

                    }
                    else if (sinif > 4)
                    {
                        MessageBox.Show("1 veya 4 aralığında rakam giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^A-z ]"))
            {
                MessageBox.Show("Sadece Harf Giriniz... ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);

            }
        }
    }
}
