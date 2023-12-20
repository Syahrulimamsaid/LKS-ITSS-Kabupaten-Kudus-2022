using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Meja_03
{
    public partial class ChangePassword : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private string Role;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
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
                    labelStatus.Text = rd[1].ToString();
                    OLDPASS.Text = rd[4].ToString();
                }
                rd.Close();
            }
            conn.Close();
        }

        private void CONFIRMPASS_TextChanged(object sender, EventArgs e)
        {
            if(CONFIRMPASS.Text != NEWPASS.Text)
            {
                CONFIRMPASS.ForeColor = Color.Red;
            }
            else
            {
                CONFIRMPASS.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            if(NEWPASS.Text.Trim() == "")
            {
                MessageBox.Show("Password Baru Masih Kosong");
            }
            else if(CONFIRMPASS.ForeColor == Color.Red)
            {
                MessageBox.Show("Confirm Password Masih Salah");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("update employee set password='" + CONFIRMPASS.Text + "' where employee_id='" + Login.Username + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Berhasil Diubah");
                    cmd = new SqlCommand("select * from employee where employee_id='" + Login.Username + "';", conn);
                    {
                        SqlDataReader rd1 = cmd.ExecuteReader();
                        while (rd1.Read())
                        {
                            Role = rd1[5].ToString();

                            if (Role == "1")
                            {
                                SuperAdminNavigation K = new SuperAdminNavigation();
                                K.Show();
                                this.Hide();
                            }
                            else if (Role == "2")
                            {
                                LogisticsAdminNavigation K = new LogisticsAdminNavigation();
                                K.Show();
                                this.Hide();
                            }
                            else
                            {
                                CentralAdminNavigation K = new CentralAdminNavigation();
                                K.Show();
                                this.Hide();
                            }
                        }
                        rd1.Close();
                    }
                }
                catch (Exception D)
                {
                    MessageBox.Show("Password Gagal Diubah");
                    MessageBox.Show(D.ToString());
                }
            }
        }
    }
}
