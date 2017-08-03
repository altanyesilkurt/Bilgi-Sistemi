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
    public partial class Form11 : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-K3JSPTM\\KURULUM;database=Proje;Integrated Security=True");
        public Form11()
        {
            InitializeComponent();
        }
        String tarih, ad, çalışan, adres;
        void verial()
        {
            tarih = date1.Value.ToShortTimeString();
            ad = FirmaAdı.Text;
            çalışan = Çalışan.Text;
            adres = Adres.Text;
        }

        void veriyaz()
        {

            String Komut = "insert into Randevu (KayıtTarihi,FirmaAdı,Çalışan,Adres) values('" + tarih + "','" + ad + "','" + çalışan + "','" + adres + "')";
            bag.Open();

            SqlCommand komutsatiri = new SqlCommand(Komut, bag);

            komutsatiri.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("RANDEVU ALINDI!!!!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verial();
            veriyaz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("iyi günler...");
            Application.Exit();
        }
    }
}
