using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMK_INFORMATION_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void tabel()
        {
            DataTable tabel = new DataTable();
            tabel.Columns.Add("No", typeof(int));
            tabel.Columns.Add("Name",typeof(string));
            tabel.Columns.Add("Umur", typeof(int) );

            tabel.Rows.Add(17, "Pulung");
            tabel.Rows.Add(18, "Wicaksono");
            dataGridView1.DataSource = tabel;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            tabel();
        }
    }
}
