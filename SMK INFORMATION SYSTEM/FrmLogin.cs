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
    public partial class FrmLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private readonly SqlDataAdapter da;
        private readonly SqlDataReader rd;

        Connection Konn = new Connection();
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                cmd = new SqlCommand("SELECT * FROM [User] WHERE username=@username AND password=@password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string userRole = reader["Role"].ToString();
                    if (userRole == "teacher")
                    {
                        TeacherNavigationForm teachernavfrm = new TeacherNavigationForm();
                        this.Hide();
                        teachernavfrm.lblWelcome.Text = "Welcome, [" + reader["Username"].ToString() + "]";
                        teachernavfrm.userid = reader["userid"].ToString();
                        teachernavfrm.username = reader["username"].ToString();
                        teachernavfrm.Show();
                    }
                    else if (userRole == "admin")
                    {
                        AdminNavigationForm adminnavfrm = new AdminNavigationForm();
                        this.Hide();
                        adminnavfrm.lblWelcome.Text = "Welcome, [" + reader["Username"].ToString() + "]";
                        adminnavfrm.Show();
                    }
                    else if (userRole == "student")
                    {
                        StudentNavigationForm studentnavfrm = new StudentNavigationForm();
                        this.Hide();
                        studentnavfrm.lblWelcome.Text = "Welcome, [" + reader["Username"].ToString() + "]";
                        studentnavfrm.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Password salah");
                }

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
