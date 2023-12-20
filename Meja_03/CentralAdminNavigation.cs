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
    public partial class CentralAdminNavigation : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public CentralAdminNavigation()
        {
            InitializeComponent();
        }

        private void CentralAdminNavigation_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePassword A = new ChangePassword();
            A.Show();
            this.Hide();
        }
    }
}
