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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //eger sayi degilse ve kontrol et harf degilse diger tuslari calistir silme tusu gibi
            {
                var result = MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                var result = MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                var result = MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                var result = MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                var result = MessageBox.Show("Sayisal Değer Giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            listView1.Columns.Add("Ders Adı", 200);
            listView1.Columns.Add("Kredi", 50);
            listView1.Columns.Add("Vize", 50);
            listView1.Columns.Add("Vize 2", 50);
            listView1.Columns.Add("Final", 50);
            listView1.Columns.Add("Büt", 50);
            listView1.Columns.Add("Ort", 50);
            listView1.Columns.Add("Harf", 50);
            listView1.Columns.Add("Sonuç", 100);
            listView1.Columns.Add("Dersin Ganoya Etkisi", 200);

            kayitSayisi();

            timer1.Start();

        }
        private void kayitSayisi()
        {
            int kayitSayisi = listView1.Items.Count;
            label21.Text = Convert.ToString(kayitSayisi);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dersAdi = "", kredi = "", vize = "", vize2 = "", final = "", but = "";
            dersAdi = textBox1.Text;
            kredi = textBox2.Text;
            vize = textBox3.Text;
            vize2 = textBox4.Text;
            final = textBox5.Text;
            but = textBox6.Text;
            string[] bilgiler = { dersAdi, kredi, vize, vize2, final, but };
            bool kayitKontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    kayitKontrolu = true;
                    MessageBox.Show(textBox1.Text + " Dersi Zaten Mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            if (kayitKontrolu == false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (dersAdi != "" && kredi != "" && vize != "" && final != "")
                {
                    listView1.Items.Add(lst);
                }
                else
                    MessageBox.Show("Verilerde Eksiklik Var...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            kayitSayisi();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                try
                {
                    int sayi = Convert.ToInt32(textBox2.Text);
                    if (sayi < 2)
                    {
                        MessageBox.Show("2 ve 4 arasında sayı giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Clear();
                    }
                    else if (sayi > 6)
                    {
                        MessageBox.Show("2 ve 4 arasında sayı giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Clear();
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }

            /*if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^2-6]"))
            //eger double deger ise 6 dan sonra . koy 6. gibi
            //eger harf girmek istersek ascii koduna gore A-z yazmaliyiz onde geldigi icin
            //^ den 6 a kadar demek ust ismatch eslesiyorsa regularexpression kalip
            {
                MessageBox.Show("2 veya 6 arasında rakam giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);// girilen ifadenin uzunlugunu bulup uzunluktan bir siliyor
            }*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


            if (textBox3.Text != "")
            {
                try
                {
                    int sayi = Convert.ToInt32(textBox3.Text);
                    if (sayi > 100)
                    {
                        MessageBox.Show("0 ve 100 arasında sayı giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }




        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text != "")
            {
                try
                {
                    int sayi = Convert.ToInt32(textBox4.Text);
                    if (sayi > 100)
                    {
                        MessageBox.Show("0 ve 100 arasında sayı giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text != "")
            {
                try
                {
                    int sayi = Convert.ToInt32(textBox5.Text);
                    if (sayi > 100)
                    {
                        MessageBox.Show("0 ve 100 arasında sayı giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (textBox6.Text != "")
            {
                try
                {
                    int sayi = Convert.ToInt32(textBox6.Text);
                    if (sayi > 100)
                    {
                        MessageBox.Show("0 ve 100 arasında sayı giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilen = listView1.CheckedItems.Count + listView1.SelectedItems.Count;

            foreach (ListViewItem seciliKayit in listView1.SelectedItems)
            {
                seciliKayit.Remove();
            }
            foreach (ListViewItem seciliKayit in listView1.CheckedItems)
            {
                seciliKayit.Remove();
            }
            MessageBox.Show(secilen.ToString() + " Adet Kayit Silindi.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);

            kayitSayisi();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label23.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool kayitKontrol = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text) // listviewdeki i nesle gercekteki 1 nesne subitems yani ilk sutunu aliyoruz
                {
                    kayitKontrol = true;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    textBox4.Text = listView1.Items[i].SubItems[3].Text;
                    textBox5.Text = listView1.Items[i].SubItems[4].Text;
                    textBox6.Text = listView1.Items[i].SubItems[5].Text;

                }
            }
            if (kayitKontrol == false)
                MessageBox.Show("Aramis Oldugunuz '" + textBox1.Text + "' Dersi Bulunamadi.", "Bulunamadi", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void guncelle()
        {
            listView1.SelectedItems[0].SubItems[1].Text=textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text=textBox3.Text;
            listView1.SelectedItems[0].SubItems[3].Text=textBox4.Text;
            listView1.SelectedItems[0].SubItems[4].Text=textBox5.Text;
            listView1.SelectedItems[0].SubItems[5].Text=textBox6.Text;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            guncelle();

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text= listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text= listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;


        }

       
    }
}
