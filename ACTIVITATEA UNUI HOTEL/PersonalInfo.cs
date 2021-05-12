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
    public partial class PersonalInfo : Form
    {
      SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Personal_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PersonalGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Personal_tbl values(" + PersonalIdtbl.Text + ",'" + NumePersonaltbl.Text + "','" + PersonalTelefontbl.Text + "','" + Sexulcb.SelectedItem.ToString() + "','"+parolatb.Text+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personal Successfully Added");
            Con.Close();
            populate();
        }

        private void Sexulcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE Personal_tbl set NumePersonal ='" + NumePersonaltbl.Text + "',NumarTelefon ='" + PersonalTelefontbl.Text + "' ,Sexul ='" + Sexulcb.SelectedItem.ToString() + "',ParolaPersonal ='" + parolatb.Text + "' where PersonalId = " + PersonalIdtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personal Successfully Edited");
            Con.Close();
            populate();
        }

        private void PersonalGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonalIdtbl.Text = PersonalGridView.SelectedRows[0].Cells[0].Value.ToString();
            NumePersonaltbl.Text = PersonalGridView.SelectedRows[0].Cells[1].Value.ToString();
            PersonalTelefontbl.Text = PersonalGridView.SelectedRows[0].Cells[2].Value.ToString();
            parolatb.Text =PersonalGridView.SelectedRows[0].Cells[3].Value.ToString();
    }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Personal_tbl where PersonalId = " + PersonalIdtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personal Successfuly Deleted ");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Personal_tbl where NumePersonal = '" + CautareClienttb.Text + "'";       
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
         PersonalGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaPrincipala fp = new FormaPrincipala();
            fp.Show();
            this.Hide();
        }
    }
       
}
