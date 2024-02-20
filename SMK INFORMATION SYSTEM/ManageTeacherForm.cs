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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMK_INFORMATION_SYSTEM
{
    public partial class ManageTeacherForm : Form
    {
        Connection Konn = new Connection();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public ManageTeacherForm()
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
            cmd = new SqlCommand("select * from Teacher", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Teacher");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Teacher";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void ManageTeacherForm_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void LoadData()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                string query = "SELECT * FROM Teacher";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["TeacherID"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
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


        private void button1_Click(object sender, EventArgs e)
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
                        string query = "INSERT INTO Teacher (TeacherID, Name, Address, Gender, DateofBirth, NoHp) " +
                                       "VALUES (@TeacherID, @Name, @Address, @Gender, @DateofBirth, @NoHp)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@TeacherID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
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



        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data Diperbarui");
            button6.Click += new EventHandler(button6_Click);
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
                        string query = "UPDATE Teacher SET Name = @Name, Address = @Address, Gender = @Gender, DateofBirth = @DateofBirth, NoHp = @NoHp WHERE TeacherID = @TeacherID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@TeacherID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
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

                        string query = "DELETE FROM Teacher WHERE TeacherID = @TeacherID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@TeacherID", textBox1.Text);

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

        private void textBoxIDName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Panggil fungsi button5_Click saat tombol Enter ditekan
                button5_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Data Tidak Disimpan");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("DATA  DISIMPAN");
                }
                

                        AdminNavigationForm adgv = new AdminNavigationForm();
                        this.Close();





                    }
        }
            }
        }
    

