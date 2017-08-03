using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-K3JSPTM\\KURULUM;database=Proje;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        String tarih, ad, çalışan, ücret, hekim, uzman, adres,etkinlik;

        private void button2_Click_1(object sender, EventArgs e)
        {
            FirmaAdı.Clear();
            textBox1.Clear();
            Çalışan.Clear();
            Ücret.Clear();
            Hekim.Clear();
            Uzman.Clear();
            Adres.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("iyi günler...");
            Application.Exit();
        }

        void verial()
        {
            tarih = date.Value.ToShortTimeString(); ;
            ad = FirmaAdı.Text;
            etkinlik = textBox1.Text;
            çalışan = Çalışan.Text;
            ücret = Ücret.Text;
            hekim = Hekim.Text;
            uzman = Uzman.Text;
            adres = Adres.Text;
           
        }
        void veriyaz()
        {
           
            String Komut = "insert into TblEkle (KayıtTarihi,FirmaAdı,Etkinlik,Çalışan,Ücret,Hekim,Uzman,Adres) values('" + tarih + "','" + ad + "','" + etkinlik+ "','" + çalışan + "','" + ücret + "','" + hekim + "','" + uzman + "','" + adres + "')";
            bag.Open();
           
            SqlCommand komutsatiri = new SqlCommand(Komut, bag);
           
            komutsatiri.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("FİRMA KAYDEDİLDİ!!!!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verial();
            veriyaz();

        }
        


        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
