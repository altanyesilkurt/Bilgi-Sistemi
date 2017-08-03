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
    public partial class Form5 : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-K3JSPTM\\KURULUM;database=Proje;Integrated Security=True");
        String tarih, ad, Sifre;
        public Form5()
        {
            InitializeComponent();
        }

        void verial()
        {
            tarih = date1.Value.ToShortTimeString();
            ad = FirmaAdı.Text;
            Sifre =textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
        void veriyaz()
        {

            String Komut = "insert into Kayıt (KayıtTarihi,FirmaAdı,Şifre) values('" + tarih + "','" + ad + "','" + Sifre + "')";
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
    }
}
