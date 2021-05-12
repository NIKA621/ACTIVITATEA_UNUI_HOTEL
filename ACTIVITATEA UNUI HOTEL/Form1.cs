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
    public partial class Form1 : Form
    {
 SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Personal_tbl where NumePersonal='"+numeutilizatortb.Text+"'and ParolaPersonal='"+parolatb.Text+"' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                FormaPrincipala fp = new FormaPrincipala();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong NumeUtilizator or Parola");
            }
            Con.Close();
        }

        private void numeutilizatortb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
