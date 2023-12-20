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

namespace Meja_03
{
    public partial class SuperAdminNavigation : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        public SuperAdminNavigation()
        {
            InitializeComponent();
        }

        private void SuperAdminNavigation_Load(object sender, EventArgs e)
        {
            TampilUser();
        }

        private void TampilUser()
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            cmd = new SqlCommand("select * from employee where employee_id='" + Login.Username + "';", conn);
            {
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    labelStatus.Text = "Welcome " + rd[1].ToString();
                }
                rd.Close();
            }
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangePassword A = new ChangePassword();
            A.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUnit A = new ManageUnit()
            {TopLevel = false, TopMost = true
            };
            A.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(A);
            A.Show();
        }
    }
}
