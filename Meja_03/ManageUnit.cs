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
    public partial class ManageUnit : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private DataSet ds;
        public ManageUnit()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageUnit_Load(object sender, EventArgs e)
        {
            SVINSERT.Hide();
            INSERT.Show();
            UPDATE.Enabled = false;
            DELETE.Enabled = false;
            CANCEL.Enabled = false;
            Tutup();
            Kosong();
        }

        private void Tampil()
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            da = new SqlDataAdapter("select * from unit", conn);
            ds = new DataSet();
            da.Fill(ds, "employee");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "employee";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void Kosong()
        {
            UNID.Clear();
            UNIT.Clear();
        }

        private void Buka()
        {
            UNIT.Enabled = true;
        }

        private void Tutup()
        {
            UNID.Enabled = false;
            UNIT.Enabled = false;
        }

        private void Kode()
        {
            int Hitung;
            string Urutan;
            SqlConnection conn = konn.GetCon();
            conn.Open();
            cmd = new SqlCommand("select * from unit where unit_id in(select max(unit_id) from unit) order by unit_id desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if(rd.HasRows)
            {
                Hitung = Convert.ToInt32(rd[0].ToString().Substring(rd["unit_id"].ToString().Length - 3, 3)) + 1;
                String Urutannya = "000" + Hitung;
                Urutan = "UNT-" + Urutannya.Substring(Urutannya.Length - 3, 3);
            }
            else
            {
                Urutan = "UNT-001";
            }
            rd.Close();
            UNID.Text = Urutan;
            conn.Close();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            Kosong();
            SVINSERT.Show();
            INSERT.Hide();
            INSERT.Enabled = false;
            UPDATE.Enabled = false;
            DELETE.Enabled = false;
            CANCEL.Enabled = true;
            Kode();
            Buka();
            MessageBox.Show("Silahkan Isi Data");
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            Tutup();
            Kosong();
            SVINSERT.Hide();
            INSERT.Show();
            INSERT.Enabled = true;
            UPDATE.Enabled = false;
            DELETE.Enabled = false;
            CANCEL.Enabled = false;
        }

        private void SVINSERT_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            if(UNIT.Text.Trim() == "" || UNID.Text.Trim() == "")
            {
                MessageBox.Show("Isi Data Dengan Benar");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("insert into unit values ('" + UNID.Text + "','" + UNIT.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    Tampil();
                    Kosong();
                    Tutup();
                    SVINSERT.Hide();
                    INSERT.Show();
                    UPDATE.Enabled = false;
                    DELETE.Enabled = false;
                    CANCEL.Enabled = false;
                    INSERT.Enabled = true;
                    MessageBox.Show("Data Berhasil Dimasukkan");
                }
                catch(Exception f)
                {
                    MessageBox.Show("Data Gagal Dimasukkan");
                    MessageBox.Show(f.ToString());
                }
            }
            conn.Close();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            if (UNIT.Text.Trim() == "" || UNID.Text.Trim() == "")
            {
                MessageBox.Show("Pilih Data Dengan Benar");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("update unit set unit_item='" + UNIT.Text + "' where unit_id='" + UNID.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    Tampil();
                    Kosong();
                    Tutup();
                    SVINSERT.Hide();
                    INSERT.Show();
                    UPDATE.Enabled = false;
                    DELETE.Enabled = false;
                    CANCEL.Enabled = false;
                    INSERT.Enabled = true;
                    MessageBox.Show("Data Berhasil Diubah");
                }
                catch (Exception f)
                {
                    MessageBox.Show("Data Gagal Diubah");
                    MessageBox.Show(f.ToString());
                }
            }
            conn.Close();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            if (UNIT.Text.Trim() == "" || UNID.Text.Trim() == "")
            {
                MessageBox.Show("Pilih Data Dengan Benar");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("delete unit where unit_id='" + UNID.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    Tampil();
                    Kosong();
                    Tutup();
                    SVINSERT.Hide();
                    INSERT.Show();
                    UPDATE.Enabled = false;
                    DELETE.Enabled = false;
                    CANCEL.Enabled = false;
                    INSERT.Enabled = true;
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                catch (Exception f)
                {
                    MessageBox.Show("Data Gagal Dihapus");
                    MessageBox.Show(f.ToString());
                }
            }
            conn.Close();
        }

        private void CARI_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetCon();
            conn.Open();
            da = new SqlDataAdapter("select * from unit where unit_item like '%" + CARI.Text + "%'", conn);
            ds = new DataSet();
            da.Fill(ds, "unit");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "unit";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }
    }
}
