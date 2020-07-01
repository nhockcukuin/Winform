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

namespace ProjectCLB
{
    public partial class LoginFrm : Form
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void lgUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void lgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lgIntro_Click(object sender, EventArgs e)
        {

        }

        private void lgBtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            string id = this.lgtbxUser.Text;
            string pw = this.lgtbxPass.Text;
            string sql = "select * from TAIKHOAN where TAIKHOAN='" + id + "' and MATKHAU='" + pw + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == true)
            {
                this.Hide();
                MainFrm m = new MainFrm();
                m.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
            cn.Close();
        }
    

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
