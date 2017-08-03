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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        

       // SqlConnection bag = new SqlConnection("Data Source=DESKTOP-K3JSPTM\\SQLEXPRESS;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

               
        
        int hak = 0;
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            String ad = textBox1.Text;
            String Sifre = textBox2.Text;
            SqlConnection bag = new SqlConnection ("Data Source=DESKTOP-K3JSPTM\\KURULUM;Initial Catalog=Proje;Integrated Security=True");
          bag .Open();

            SqlCommand com = new SqlCommand("Select * from Kayıt where FirmaAdı='" + ad + "' AND Şifre = '" + Sifre + "'",bag);
 
          SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
        {
            Form9 f2 = new Form9();
            f2.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
        }

        bag.Close();


    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            hak++;
            if (textBox3.Text == "admin")
                if (textBox4.Text == "1234")
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("OGSB ANALİSTİ GİRİŞİ!!!");
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    textBox4.Text = "";
                    this.Text = "KULLANİCİ ADİ VEYA SİFRE YANLİS";
                    if (hak == 3)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("programi yetkisiz kisiler kullanamaz:");
                    }
                }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }
    }
}
