using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCLB
{
    public partial class UserControlInformation : UserControl
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        public UserControlInformation()
        {
            InitializeComponent();
            string query = "select * from TAIKHOAN";
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == true)
            {
                string dt = (string)data["TAIKHOAN"];
                this.tbxUserI.Text = dt.ToString();
                string dt2 = (string)data["MATKHAU"];
                this.tbxPassI.Text = dt2.ToString();
                string dt3 = (string)data["EMAIL"];
                this.tbxEmailI.Text = dt3.ToString();
                string dt4 = (string)data["SDT"];
                this.tbxNbPhoneI.Text = dt4.ToString();
                string dt5 = (string)data["HOTEN"];
                this.tbxNameI.Text = dt5.ToString();
            }
            cn.Close();
        }

        private void infoUser_Click(object sender, EventArgs e)
        {

        }

        private void UserControlInformation_Load(object sender, EventArgs e)
        {

        }

        private void btnLockout_Click(object sender, EventArgs e)
        {
            MainFrm main = new MainFrm();
            LoginFrm lg = new LoginFrm();
            ((Form)this.TopLevelControl).Close();
            lg.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pw = this.tbxPassI.Text;
            string email = this.tbxEmailI.Text;
            string sdt = this.tbxNbPhoneI.Text;
            string name = this.tbxNameI.Text;
            string query2 = "update TAIKHOAN set MATKHAU='"+pw+"', EMAIL='"+email+"',SDT='"+sdt+"',HOTEN=N'"+name+"'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(query2, cn);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == true)
            {
                string dt = (string)data["TAIKHOAN"];
                this.tbxUserI.Text = dt.ToString();
                string dt2 = (string)data["MATKHAU"];
                this.tbxPassI.Text = dt2.ToString();
                string dt3 = (string)data["EMAIL"];
                this.tbxEmailI.Text = dt3.ToString();
                string dt4 = (string)data["SDT"];
                this.tbxNbPhoneI.Text = dt4.ToString();
                string dt5 = (string)data["HOTEN"];
                this.tbxNameI.Text = dt5.ToString();
            }
            cn.Close();
            MessageBox.Show("Thay đổi thông tin thành công");
        }
    }
}
