using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into sell values(@property,@width,@height,@price,@phone)", conn);
            cmd.Parameters.AddWithValue("@property",textBox1.Text);
            cmd.Parameters.AddWithValue("@width",textBox2.Text);
            cmd.Parameters.AddWithValue("@height", textBox3.Text);
            cmd.Parameters.AddWithValue("@price",textBox4.Text);
            cmd.Parameters.AddWithValue("@phone",textBox5.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("THANKYOU....");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.ShowDialog();
            this.Hide();
        }
    }
}
