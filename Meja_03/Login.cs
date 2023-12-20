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
using System.Windows.Forms.VisualStyles;

namespace Meja_03
{
    public partial class Login : Form
    {
        private SqlCommand cmd;
        private SqlDataReader rd;
        Koneksi konn = new Koneksi();
        private string Role;
        public static string Username;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            cmd = new SqlCommand("select * from employee where employee_id='" + textBox1.Text + "' and password='" + textBox2.Text + "'",conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                Username = textBox1.Text;
                rd.Close();
                cmd = new SqlCommand("select * from employee where employee_id='" + textBox1.Text + "';", conn);
                {
                    SqlDataReader rd1 = cmd.ExecuteReader();
                    while(rd1.Read())
                    {
                        Role = rd1[5].ToString();

                        if(Role == "1")
                        {
                            SuperAdminNavigation K = new SuperAdminNavigation();
                            K.Show();
                            this.Hide();
                            MessageBox.Show("Selamat Datang");
                        }
                        else if(Role == "2")
                        {
                            LogisticsAdminNavigation K = new LogisticsAdminNavigation();
                            K.Show();
                            this.Hide();
                            MessageBox.Show("Selamat Datang");
                        }
                        else
                        {
                            CentralAdminNavigation K = new CentralAdminNavigation();
                            K.Show();
                            this.Hide();
                            MessageBox.Show("Selamat Datang");
                        }
                    }
                    rd1.Close();
                }
            }
            else
            {
                MessageBox.Show("Password/Username Salah");
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
