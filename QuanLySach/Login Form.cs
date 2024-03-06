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

namespace QuanLySach
{
    public partial class Login_Form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=QuanLyThuVien;IntergratedSecurity=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            conn.Open()

        }
    }
}
