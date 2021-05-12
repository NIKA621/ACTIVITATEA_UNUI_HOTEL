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

namespace ACTIVITATEA_UNUI_HOTEL
{
    public partial class Clientinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30");
       public void populate()
        {
            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
           Con.Close();
        }
        public Clientinfo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clientidtbl.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            numeclienttbl.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
            telefontbl.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Clientinfo_Load(object sender, EventArgs e)
        { 
            //Datelbl.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values("+Clientidtbl.Text+",'"+numeclienttbl.Text+"','"+telefontbl.Text+"','"+taraclientcb.SelectedItem.ToString()+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Added");
            Con.Close();
            populate();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Client_tbl where Clientid = " + Clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted");
            Con.Close();
            populate();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Client_tbl set NumeClient ='" + numeclienttbl.Text + "',NumarTelefon ='" + telefontbl.Text + "',TaraClientului='" + taraclientcb.SelectedItem.ToString() + "'where ClientId = " + Clientidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Edited");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Client_tbl where NumeClient = '"+CautareClienttb.Text+"'" ;
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormaPrincipala fp = new FormaPrincipala();
            fp.Show();
            this.Hide();
        }
    }
}
