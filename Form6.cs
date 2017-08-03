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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("iyi günler...");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection bag = new SqlConnection("Data Source=DESKTOP-K3JSPTM\\KURULUM;Initial Catalog=Proje;Integrated Security=True");
            /* if (bag.State == ConnectionState.Closed)
                 bag.Open();
             //bag =new SqlConnection("Data Source=DESKTOP-K3JSPTM\\SQLEXPRESS;Integrated Security=True");
             SqlCommand com = new SqlCommand("select * from TblEkle", bag);
             SqlDataAdapter adp = new SqlDataAdapter(com);
             DataTable dt = new DataTable();
             adp.Fill(dt);

             dataGridView1.DataSource = dt;
             bag.Close();*/
            bag.Open();
            SqlCommand com = new SqlCommand("Select FirmaAdı , Ücret from TblEkle where FirmaAdı like '%" + textBox1.Text + "%'", bag);
            SqlDataAdapter dt = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bag.Close();
        }
    }
}
