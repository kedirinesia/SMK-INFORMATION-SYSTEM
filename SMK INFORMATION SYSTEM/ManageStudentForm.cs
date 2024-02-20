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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMK_INFORMATION_SYSTEM
{

    public partial class ManageStudentForm : Form
    {
        Connection Konn = new Connection();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;


        public ManageStudentForm()
        {
            InitializeComponent();

        }
        void KondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            RadioMale.Text = "Male";
            RadioFemale.Text = "Female";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
            MunculDataBarang();
        }
        void MunculDataBarang()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from Student", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Student";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }
        private void LoadData()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                string query = "SELECT * FROM Student";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["StudentID"].Value.ToString();
                textBox2.Text = row.Cells["StudentName"].Value.ToString();
                textBox3.Text = row.Cells["Address"].Value.ToString();



                if (row.Cells["Gender"].Value.ToString() == "Male")
                {
                    RadioMale.Checked = true;
                    RadioFemale.Checked = false;
                }

                else if (row.Cells["Gender"].Value.ToString() == "Female")
                {
                    RadioMale.Checked = false;
                    RadioFemale.Checked = true;
                }

                dateTimePicker1.Text = row.Cells["DateofBirth"].Value.ToString();
                textBox4.Text = row.Cells["NoHp"].Value.ToString();
            }
        
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Periksa apakah semua form telah diisi dan tanggal lahir valid
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("PASTIKAN SEMUA FORM DIISI");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = Konn.GetConn())
                    {
                        conn.Open();
                        string query = "INSERT INTO Student (StudentID, StudentName, Address, Gender, DateofBirth, NoHp) " +
                                       "VALUES (@StudentID, @StudentName, @Address, @Gender, @DateofBirth, @NoHp)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                            cmd.Parameters.AddWithValue("@Address", textBox3.Text);

                            if (RadioMale.Checked)
                            {
                                cmd.Parameters.AddWithValue("@Gender", "Male");
                            }
                            else if (RadioFemale.Checked)
                            {
                                cmd.Parameters.AddWithValue("@Gender", "Female");
                            }

                            cmd.Parameters.AddWithValue("@DateofBirth", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@NoHp", textBox4.Text);

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("DATA BERHASIL DIINPUT");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan SQL: " + ex.Message);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            LoadData();
            MessageBox.Show("Data Diperbarui");
            btnRefresh.Click += new EventHandler(btnRefresh_Click);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data Diperbarui");
            btnRefresh.Click += new EventHandler(btnRefresh_Click);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1 != null)
            {
                AdminNavigationForm adgv = new AdminNavigationForm();
                this.Close();

                MessageBox.Show("Data Tidak Disimpan");

            }
            else
            {
                MessageBox.Show("Data Berhasil Disimpan");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
               string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
               dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("PASTIKAN SEMUA FORM DIISI");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = Konn.GetConn())
                    {
                        conn.Open();
                        string query = "UPDATE Student SET StudentName = @StudentName, Address = @Address, Gender = @Gender, DateofBirth = @DateofBirth, NoHp = @NoHp WHERE StudentID = @StudentID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                            cmd.Parameters.AddWithValue("@Address", textBox3.Text);

                            if (RadioMale.Checked)
                            {
                                cmd.Parameters.AddWithValue("@Gender", "Male");
                            }
                            else if (RadioFemale.Checked)
                            {
                                cmd.Parameters.AddWithValue("@Gender", "Female");
                            }

                            cmd.Parameters.AddWithValue("@DateofBirth", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@NoHp", textBox4.Text);

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("DATA BERHASIL DIUPDATE");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan SQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
              dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("PASTIKAN SEMUA FORM DIISI");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = Konn.GetConn())
                    {
                        conn.Open();

                        string query = "DELETE FROM Student WHERE StudentID = @StudentID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("DATA BERHASIL DIHAPUS");
                                KondisiAwal();
                            }
                            else
                            {
                                MessageBox.Show("Tidak ada data yang dihapus.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }

            }
        }

        private void f5(object sender, KeyPressEventArgs e)
        {
            LoadData();
            MessageBox.Show("Data Diperbarui");
        }

        private void btnRefresh_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void RadioMale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
