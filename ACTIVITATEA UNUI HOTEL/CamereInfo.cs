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
    public partial class CamereInfo : Form
    {
        public CamereInfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Camera_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CameraGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddCameraBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Daradio.Checked == true)
                isfree = "libera";
            else
                isfree = "ocupat";
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Camera_tbl values(" + Numarcameratb.Text + ",'" + Telefoncameratb.Text + "','" + isfree + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Camera Successfully Added");
            Con.Close();
            populate();
        }

        private void CamereInfo_Load(object sender, EventArgs e)
        {
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void CameraGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            Numarcameratb.Text = CameraGridView.SelectedRows[0].Cells[0].Value.ToString();
           Telefoncameratb.Text = CameraGridView.SelectedRows[0].Cells[1].Value.ToString();
          
        }

        private void DeleteCamerabtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Camera_tbl where CameraId = " + Numarcameratb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Camera Successfuly Deleted ");
            Con.Close();
            populate();
        }

        private void EditCameraBtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (Daradio.Checked == true)
                isfree = "libera";
            else
                isfree = "ocupat";
            Con.Open();
            string myquery = "UPDATE Camera_tbl set TelefonulCamerei ='" + Telefoncameratb.Text + "',CameraLibera ='" + isfree + "'where CameraId = " + Numarcameratb.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Camera Successfully Edited");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Camera_tbl where CameraId = '" + CautareCameratb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CameraGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void CautareCameratb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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
