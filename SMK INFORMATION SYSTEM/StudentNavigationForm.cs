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

namespace SMK_INFORMATION_SYSTEM
{
    public partial class StudentNavigationForm : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private readonly SqlDataAdapter da;
        private readonly SqlDataReader rd;
        public string userid;
        Connection Konn = new Connection();
        public string username;

        public static StudentEditProfileForm seform;
        public static ViewScheduleForm tform;
        public static EditProfileForm eform;

        public static

        EditProfileForm editform;
        TeachingScheduleForm teachingschform;


        ViewScheduleForm classSchedule;
        public StudentNavigationForm()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmlog = new FrmLogin();
            this.Hide();
            frmlog.Show();
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            if (editform == null)
            {
                editform = new EditProfileForm();

                SqlDataReader reader = null;
                SqlConnection conn = Konn.GetConn();

                editform.ShowDialog();
            }
        }
    


        private void StudentNavigationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTeachingSchedule_Click(object sender, EventArgs e)
        {
            if (classSchedule == null)
            {
                classSchedule = new ViewScheduleForm();
            
                classSchedule.ShowDialog();
                 
            }
        }
    }
}
