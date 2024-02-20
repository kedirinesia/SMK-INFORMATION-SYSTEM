using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMK_INFORMATION_SYSTEM
{
    public partial class ManageClassForm : Form
    {
        Connection Konn = new Connection();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public string nilai4, nilai5 ,nilai6;
       

        public ManageClassForm()
        {
            InitializeComponent();
        }

        void ClassName()
        {
            comboBox1.Items.Add("MATEMATIKA");
            comboBox1.Items.Add("ASJ & KJI");
            comboBox1.Items.Add("AIJ");
            comboBox1.Items.Add("Bahasa Jawa");
            comboBox1.Items.Add("Bahasa Inggris");
            comboBox1.Items.Add("Bahasa Jepang");

        }

        void KondisiAwal()
        {
            ClassName();
            MunculData2();
            MunculData();

        }

        void MunculData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select StudentID, Name from Student", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Student";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }
        void MunculData2()
        {
            Console.WriteLine("MunculData2 Start");

            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select Class.StudentID ,Class.StudentName from Class", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Class");
            dataGridView2.DataSource = ds.Tables["Class"];
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Refresh();
        }
        void carisiswa1()
        {

        }
        void CariSiswa()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID, StudentName FROM Class WHERE 10 = 10", conn);
                if (!string.IsNullOrEmpty(nilai4))
                {
                    cmd.CommandText += " AND StudentName LIKE @StudentName";
                    cmd.Parameters.AddWithValue("@StudentName", "%" + nilai4 + "%");
                }
                if (!string.IsNullOrEmpty(comboBox1.Text))
                {
                    cmd.CommandText += " AND Kelas LIKE @Kelas";
                    cmd.Parameters.AddWithValue("@Kelas", "%" + comboBox1.Text + "%");
                }
               

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Class");

                dataGridView2.DataSource = ds.Tables["Class"];
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.Refresh();
            }
        }


        void CariSiswa2()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Student WHERE Kelas LIKE @Kelas", conn);
            cmd.Parameters.AddWithValue("@Kelas", "%" + comboBox1.Text + "%");
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Student";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }





        private void ManageClassForm_Load(object sender, EventArgs e)
        {
            KondisiAwal();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                nilai5 = row.Cells[1].Value.ToString();

                //MessageBox.Show( nilai5 );



            }
        }
        public void RefreshPage1()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                string query = "select StudentID, Name from Student";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
            }
        }
        public void RefreshPage2()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                string query = "select Class.StudentID, Class.StudentName from Class";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;

                }
            }
        }
        void participant()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Class (StudentID, StudentName, Kelas) VALUES (@StudentID, @StudentName, @Kelas)", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", nilai6);
                    cmd.Parameters.AddWithValue("@StudentName", nilai4);
                    cmd.Parameters.AddWithValue("@Kelas", comboBox1.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                      //  Refresh();
                        MessageBox.Show("Data berhasil disimpan!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                         
                    }
                }
            }
        }


        void participant1()
        {
            SqlConnection conn = Konn.GetConn();

            SqlCommand cmd = new SqlCommand("INSERT INTO Class (StudentName)VALUES ('" + nilai4 + "')", conn);

            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh();
            MessageBox.Show("Data berhasil disimpan!");
            participant2();
        }
        void participant2()
        {
            string selectedClass = comboBox1.Text;

            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();

                string query = "INSERT INTO Class (Kelas) VALUES (@Kelas)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kelas", selectedClass);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }


            Refresh();
            MessageBox.Show("Data berhasil disimpan!");
        }


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nilai4 = row.Cells[1].Value.ToString();
                nilai6 = row.Cells[0].Value.ToString();
                
                //MessageBox.Show( nilai4 );
                
             

            }
            
         
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CariSiswa();
            //CariSiswa2();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();

            SqlCommand cmd = new SqlCommand("INSERT INTO Student (Name) VALUES ('" + nilai5 + "')", conn);
            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh();
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshPage1();
            RefreshPage2();
            MessageBox.Show("Berhasil Refresh");
            button6.Click += new EventHandler(button6_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            participant();
            CariSiswa();

            
        }
    }
}
