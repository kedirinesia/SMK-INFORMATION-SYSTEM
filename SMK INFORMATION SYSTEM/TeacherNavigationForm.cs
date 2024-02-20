using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMK_INFORMATION_SYSTEM
{
    public partial class TeacherNavigationForm : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private readonly SqlDataAdapter da;
        private readonly SqlDataReader rd;
        public string userid;
        Connection Konn = new Connection();
        public string username;

        public static EditProfileForm eform;
        public static TeachingScheduleForm tform;
        public static 

        EditProfileForm editform;
        TeachingScheduleForm teachingschform;
        private void EditProfileForm_fromClosed(object sender, FormClosedEventArgs e)
        {
            editform = null;
        }
        public TeacherNavigationForm()
        {
            InitializeComponent();
        }

        private void TeacherNavigationForm_Load(object sender, EventArgs e)
        {
            teachingschform = null;
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            if (editform == null)
            {
                editform = new EditProfileForm();
                editform.FormClosed += new FormClosedEventHandler(EditProfileForm_fromClosed);
                SqlDataReader reader = null;
                SqlConnection conn = Konn.GetConn();
                {
                    conn.Open();


                    cmd = new SqlCommand("SELECT * FROM [teacher] WHERE userid=@userid", conn);
                    cmd.Parameters.AddWithValue("@userid", userid);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        editform.textBox1.Text = reader["teacherid"].ToString();
                        editform.textBox1.Text = reader["teacherid"].ToString();
                    }
                        editform.ShowDialog();
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmlog = new FrmLogin();
            this.Hide();
            frmlog.Show();

        }

        private void btnTeachingSchedule_Click(object sender, EventArgs e)
        {
            if (teachingschform == null)
            {
                teachingschform = new TeachingScheduleForm();
                teachingschform.FormClosed += new FormClosedEventHandler(EditProfileForm_fromClosed);
                teachingschform.ShowDialog();
            }
        }
    }
}
