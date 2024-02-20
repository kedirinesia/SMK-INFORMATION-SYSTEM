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
    public partial class AdminNavigationForm : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private readonly SqlDataAdapter da;
        private readonly SqlDataReader rd;
        Connection Konn = new Connection();

        public static ManageStudentForm mngstudentfrm;
        public static ManageTeacherForm mngTeacherfrm;
        public static ManageClassForm mngclassfrm;
        public static ManageScheduleForm mngschedulefrm;

        public AdminNavigationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin frmlog = new FrmLogin();
            this.Hide();
            frmlog.Show();

        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            if (mngstudentfrm == null)
            {
                mngstudentfrm = new ManageStudentForm();
             
                mngstudentfrm.ShowDialog();
            }
        }

            private void AdminNavigationForm_Load(object sender, EventArgs e)
            {

            }

        private void btnTeachingSchedule_Click(object sender, EventArgs e)
        {
            if (mngTeacherfrm == null)
            {
                mngTeacherfrm = new ManageTeacherForm();

                mngTeacherfrm.ShowDialog();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (mngclassfrm == null)
            {
                mngclassfrm = new ManageClassForm();

                mngclassfrm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mngschedulefrm == null)
            {
                mngschedulefrm = new ManageScheduleForm();

                mngschedulefrm.ShowDialog();
            }
        }
    }
    }

