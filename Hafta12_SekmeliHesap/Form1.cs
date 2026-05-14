using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta12_SekmeliHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double sayi1) && double.TryParse(textBox2.Text, out double sayi2)) {
                double sonuc = sayi1 + sayi2;
                label3.Text = "Sonuç = " + sonuc;
            }
            else {
                MessageBox.Show("Lütfen sadece sayı giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // bu toplama butonudur burada tryparse ile kontrol yapıyoruz sonucu da label yerine ekrana yazdırıyoruz
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double sayi1) && double.TryParse(textBox3.Text, out double sayi2))
            {
                double sonuc = sayi1 - sayi2;
                label4.Text = "Sonuç = " + sonuc;
            }
            else
            {
                MessageBox.Show("Lütfen sadece sayı giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // bu kısımda da aynı şekilde işlem yapıyoruz . bu kısım çıkarma işlemine aittir

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox5.Text, out double sayi1) && double.TryParse(textBox6.Text, out double sayi2))
            {
                double sonuc = sayi1 * sayi2;
                label7.Text = "Sonuç = " + sonuc;
            }
            else
            {
                MessageBox.Show("Lütfen sadece sayı giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // aynı şeklide çarpma ilemini de yaptık 
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab != null)
            {
                this.Text = "Hesap Makinesi — " + tabControl1.SelectedTab.Text;
            }
        } // burada da tabcontol ile başlık ile ilgili maddeyi yerine getirmiş olduk 

    }
}
