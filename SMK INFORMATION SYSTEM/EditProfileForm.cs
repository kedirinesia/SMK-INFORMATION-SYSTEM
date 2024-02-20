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
    public partial class EditProfileForm : Form
    {
        Connection Konn = new Connection();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public EditProfileForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {

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
                        string query = "INSERT INTO Student (StudentID, StudentName, Address, DateofBirth, NoHp) " +
                                       "VALUES (@StudentID, @StudentName, @Address, @DateofBirth, @NoHp)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Gunakan parameter yang benar
                            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                            cmd.Parameters.AddWithValue("@DateofBirth", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@NoHp", textBox4.Text); // tambahkan .Text

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("DATA BERHASIL DIINPUT");
                    }
                }
                catch (SqlException ex)
                {
                    // Tangani kesalahan SQL dengan lebih spesifik
                    MessageBox.Show("Terjadi kesalahan SQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Tangani kesalahan lainnya
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

    }
}

