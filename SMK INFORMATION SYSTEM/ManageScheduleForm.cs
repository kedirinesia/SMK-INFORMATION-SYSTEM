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
    public partial class ManageScheduleForm : Form
    {
        Connection Konn = new Connection();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public ManageScheduleForm()
        {
            InitializeComponent();
        }
        void ComboBox()
        {
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("6");
            comboBox2.Items.Add("7");
            comboBox2.Items.Add("8");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("11");
            comboBox2.Items.Add("12");
            comboBox2.Items.Add("13");
            comboBox1.Items.Add("Senin");
            comboBox1.Items.Add("Selasa");
            comboBox1.Items.Add("Rabu");
            comboBox1.Items.Add("Kamis");
            comboBox1.Items.Add("Jumat");

        }

        void KondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

            ComboBox();
            MunculData();


        }

        void MunculData()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT HeaderSchedule.*, Teacher.Name FROM HeaderSchedule INNER JOIN Teacher ON Teacher.TeacherID = HeaderSchedule.TeacherID", conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        //ds = new DataSet();
                        //DataAdapter daa = new SqlDataAdapter(cmd);
                        //daa = Connection.getQuery("select HeaderSchedule.*, Teacher.Name from HeaderSchedule, Teacher where Teacher.TeacherID = HeaderSchedule.TeacherID");
                        //daa.Fill(ds, "HeaderSchedule");
                        //dataGridView1.DataSource = ds;
                        //dataGridView1.DataMember = "HeaderSchedule";
                    }
                }
            }
        }


        private void RefreshData()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                string query = "SELECT HeaderSchedule.*, Teacher.Name FROM HeaderSchedule INNER JOIN Teacher ON Teacher.TeacherID = HeaderSchedule.TeacherID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }


        private void ManageScheduleForm_Load(object sender, EventArgs e)
        {
            KondisiAwal();
            MunculData();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshData();
            MessageBox.Show("Berhasil Refresh");
            button6.Click += new EventHandler(button6_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Pastikan semua form diisi.");
            }
            else
            {
                if (int.TryParse(textBox1.Text, out int subjectID) &&
                    int.TryParse(textBox2.Text, out int teacherID) &&
                    int.TryParse(textBox3.Text, out int classID))
                {
                    using (SqlConnection conn = Konn.GetConn())
                    {
                        conn.Open();
                        MessageBox.Show("Koneksi berhasil dibuka.");
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // First, insert data into the Teacher table
                                string teacherQuery = "INSERT INTO Teacher (TeacherID, Name) " +
                                    "VALUES (@TeacherID, @Name)";

                                using (SqlCommand teacherCmd = new SqlCommand(teacherQuery, conn, transaction))
                                {
                                    teacherCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                                    teacherCmd.Parameters.AddWithValue("@Name", "");


                                    teacherCmd.ExecuteNonQuery();
                                }

                                // Next, insert data into the HeaderSchedule table
                                string scheduleQuery = "INSERT INTO HeaderSchedule (SubjectID, TeacherID, ClassID, Day, Time) " +
                                    "VALUES (@SubjectID, @TeacherID, @ClassID, @Day, @Time)";

                                using (SqlCommand scheduleCmd = new SqlCommand(scheduleQuery, conn, transaction))
                                {
                                    scheduleCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                                    scheduleCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                                    scheduleCmd.Parameters.AddWithValue("@ClassID", classID);
                                    scheduleCmd.Parameters.AddWithValue("@Day", comboBox1.Text);
                                    scheduleCmd.Parameters.AddWithValue("@Time", comboBox2.Text);

                                    scheduleCmd.ExecuteNonQuery();
                                }

                                // If both INSERTs succeed, commit the transaction
                                transaction.Commit();
                                MessageBox.Show("Data berhasil diinput.");
                            }
                            catch (SqlException ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Terjadi kesalahan SQL: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Input Subject ID, Teacher ID, dan Class ID harus berupa angka.");
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["SubjectID"].Value.ToString();
                textBox2.Text = row.Cells["TeacherID"].Value.ToString();
                textBox3.Text = row.Cells["ClassID"].Value.ToString();
                comboBox1.Text = row.Cells["Day"].Value.ToString();
                comboBox2.Text = row.Cells["Time"].Value.ToString();


               

             
            }
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
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Pastikan semua form diisi.");
            }
            else
            {
                if (int.TryParse(textBox1.Text, out int subjectID) &&
                    int.TryParse(textBox2.Text, out int teacherID) &&
                    int.TryParse(textBox3.Text, out int classID))
                {
                    using (SqlConnection conn = Konn.GetConn())
                    {
                        conn.Open();
                        MessageBox.Show("Koneksi berhasil dibuka.");
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Update Teacher table
                                string teacherQuery = "UPDATE Teacher SET Name = @Name WHERE TeacherID = @TeacherID";

                                using (SqlCommand teacherCmd = new SqlCommand(teacherQuery, conn, transaction))
                                {
                                    teacherCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                                    teacherCmd.Parameters.AddWithValue("@Name", "");  

                                    teacherCmd.ExecuteNonQuery();
                                }

                                // Update HeaderSchedule table
                                string scheduleQuery = "UPDATE HeaderSchedule SET SubjectID = @SubjectID, TeacherID = @TeacherID, ClassID = @ClassID, Day = @Day, Time = @Time WHERE TeacherID = @TeacherID";

                                using (SqlCommand scheduleCmd = new SqlCommand(scheduleQuery, conn, transaction))
                                {
                                    scheduleCmd.Parameters.AddWithValue("@SubjectID", subjectID);
                                    scheduleCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                                    scheduleCmd.Parameters.AddWithValue("@ClassID", classID);
                                    scheduleCmd.Parameters.AddWithValue("@Day", comboBox1.Text);
                                    scheduleCmd.Parameters.AddWithValue("@Time", comboBox2.Text);

                                    scheduleCmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Data berhasil diupdate.");
                            }
                            catch (SqlException ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Terjadi kesalahan SQL: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Input Subject ID, Teacher ID, dan Class ID harus berupa angka.");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)
                )
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

                        string query = "DELETE FROM HeaderSchedule WHERE SubjectID = @SubjectID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SubjectID", textBox1.Text);

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
    }
}


