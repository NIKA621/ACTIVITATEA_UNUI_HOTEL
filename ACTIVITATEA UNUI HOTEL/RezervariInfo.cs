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
    public partial class RezervariInfo : Form
    {
        public RezervariInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30");
        DateTime astazi;
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Rezarvari_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RezervariGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void fillCameracombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CameraId from Camera_tbl ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CameraId", typeof(int));
            dt.Load(rdr);
            Cameracb.ValueMember = "CameraId";
            Cameracb.DataSource = dt;
            Con.Close();
        }
        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select NumeClient from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NumeClient", typeof(string));
            dt.Load(rdr);
            Clientcb.ValueMember = "NumeClient";
            Clientcb.DataSource = dt;
            Con.Close();
        }
        private void RezervariInfo_Load(object sender, EventArgs e)
        {
            astazi = Datain.Value;
            fillCameracombo();
            fillClientcombo();
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString()+"-"+ DateTime.Today.Month.ToString()+"-"+ DateTime.Today.Year.ToString();
        }
        public void updatestatutulcamerei()
        {
            Con.Open();
            string newstate = "ocupat";
            string myquery = "UPDATE Camera_tbl set CameraLibera ='" + newstate + "'  where CameraId = " +Convert.ToInt32(Cameracb.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rezervare Successfully Edited");
            Con.Close();
            fillCameracombo();
        }
        public void updatecameraondelete()
        {
            Con.Open();
            string newstate = "liber";
            int cameraid =Convert.ToInt32(RezervariGridView.SelectedRows[0].Cells[2].Value.ToString());
            string myquery = "UPDATE Camera_tbl set CameraLibera ='" + newstate + "'  where CameraId = " +cameraid + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rezervare Successfully Edited");
            Con.Close();
            fillCameracombo();
        }
        private void AddPersonalBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Rezarvari_tbl values(" + Rezidtb.Text + ",'" + Clientcb.SelectedValue.ToString() + "','" + Cameracb.SelectedValue.ToString() + "','" + Datain.Value + "','" + Dataout.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rezervare Successfully Added");
            Con.Close();
            updatestatutulcamerei();
            populate();
        }

        private void Datain_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Datain.Value, astazi);
            if (res < 0)
                MessageBox.Show("Data Gresita Pentru Rezervare");
        }

        private void Dataout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Dataout.Value, Datain.Value);
            if (res < 0)
                MessageBox.Show("Data Gresita ,Incearca Alta");
        }

        private void RezervariGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        Rezidtb.Text = RezervariGridView.SelectedRows[0].Cells[0].Value.ToString();
           
        }

        private void DeletePersonalbtn_Click(object sender, EventArgs e)
        {
            if (Rezidtb.Text == "")
            {
                MessageBox.Show("Introdu rezervarea pentru a fi stearsa");
            }
            else
            {
                Con.Open();
                string query = "delete from Rezarvari_tbl where RezId = " + Rezidtb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervarea Successfuly Deleted ");
                Con.Close();
                updatecameraondelete();
                populate();
            }
        }

        private void PersonalEditBtn_Click(object sender, EventArgs e)
        {
            if (Rezidtb.Text == "")
            {
                MessageBox.Show("Data Libera Pentru Rezervare");
            }
            else
            {
                Con.Open();
                string myquery = "UPDATE Rezarvari_tbl set Client ='" + Clientcb.SelectedValue.ToString() + "',Camera ='" + Cameracb.SelectedValue.ToString() + "' ,DataIntrarii ='" + Datain.Value.ToString() + "',DataIesirii ='" + Dataout.Value.ToString() + "' where RezId = " + Rezidtb.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervare Successfully Edited");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Rezarvari_tbl where RezId = '" + CautareReztb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RezervariGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void Cameracb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaPrincipala fp = new FormaPrincipala();
            fp.Show();
            this.Hide();
        }

        private void Clientcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
