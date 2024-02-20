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

namespace SMK_INFORMATION_SYSTEM
{
    public partial class ViewScheduleForm : Form
    {
        Connection Konn = new Connection();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        public static SubjectForm subjectForm;
        public ViewScheduleForm()
        {
            InitializeComponent();
        }

        void MunculData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from HeaderSchedule", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "HeaderSchedule");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "HeaderSchedule";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void ViewScheduleForm_Load(object sender, EventArgs e)
        {
            MunculData();
        }

        private void btnviw_Click(object sender, EventArgs e)
        {
            if (subjectForm == null)
            {
                subjectForm = new SubjectForm();

                subjectForm.ShowDialog();
            }
            }

        private void LoadData()
        {
            using (SqlConnection conn = Konn.GetConn())
            {
                conn.Open();
                string query = "SELECT * FROM HeaderSchedule";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data Diperbarui");
          
        }
    }
}
