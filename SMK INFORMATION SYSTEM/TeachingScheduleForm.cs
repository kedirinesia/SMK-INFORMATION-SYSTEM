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

    public partial class TeachingScheduleForm : Form
    {
        public static SubjectForm subjectfrm;

        Connection Konn = new Connection();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public TeachingScheduleForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
       
        void KondisiAwal()
        {
            MunculData();
            MunculData2();
        }

        void MunculData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select SubjectID, Subject, ClassName, Day, Time from HeaderSchedule", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "HeaderSchedule");
            DGTeachingSchedule.DataSource = ds;
            DGTeachingSchedule.DataMember = "HeaderSchedule";
            DGTeachingSchedule.AllowUserToAddRows = false;
            DGTeachingSchedule.Refresh();
        }
        void MunculData2()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select StudentID, StudentName, Gender from Student", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Student");
            DGStudentList.DataSource = ds;
            DGStudentList.DataMember = "Student";
            DGStudentList.AllowUserToAddRows = false;
            DGStudentList.Refresh();
        }

        private void DGTeachingSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    DGTeachingSchedule.DataSource = dataTable;
                }
            }
        }

                private void TeachingScheduleForm_Load(object sender, EventArgs e)
        {
            DGTeachingSchedule.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            KondisiAwal();
        }

        private void buttonSubjectInfo_Click(object sender, EventArgs e)
        {
            if (subjectfrm == null)
            {
                subjectfrm = new SubjectForm();
                subjectfrm.ShowDialog();
            }
        }

        private void DGStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data Diperbarui");
            button6.Click += new EventHandler(button6_Click);
        }
    }
}
