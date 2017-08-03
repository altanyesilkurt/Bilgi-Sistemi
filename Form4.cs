using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("iyi günler...");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection("Data Source=DESKTOP-K3JSPTM\\KURULUM;Initial Catalog=Proje;Integrated Security=True");
          
            bag.Open();
            SqlCommand com = new SqlCommand("Delete  from TblEkle where FirmaAdı like '%" + textBox1.Text + "%'", bag);
            com.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("FİRMA SİLİNDİ!!!!!!1")
;
        }
    }
}
