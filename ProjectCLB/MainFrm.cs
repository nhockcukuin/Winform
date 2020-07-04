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
    public partial class MainFrm : Form
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString); 
        public MainFrm()
        {
            InitializeComponent();
            pnColor.Height = btnCLBm.Height;
            pnColor.Top = btnCLBm.Top;
            userControlCLB1.BringToFront();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutUs aboutus = new AboutUs();
            aboutus.Show();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            
            try
            {
                cn.Open();
                string id = "admin";
                string sql = "select HOTEN from TAIKHOAN where TAIKHOAN='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    string dt = (string)data["HOTEN"];
                    this.mainLB2.Text = dt.ToString();
                }
                cn.Close();
            }
            catch(Exception) { }
        }

        private void btnCLBm_Click(object sender, EventArgs e)
        {
            pnColor.Height = btnCLBm.Height;
            pnColor.Top = btnCLBm.Top;
            userControlCLB1.BringToFront();
        }

        private void btnSVm_Click(object sender, EventArgs e)
        {
            pnColor.Height = btnSVm.Height;
            pnColor.Top = btnSVm.Top;
            userControlSV1.BringToFront();
        }

        private void btnActivitym_Click(object sender, EventArgs e)
        {
            pnColor.Height = btnActivitym.Height;
            pnColor.Top = btnActivitym.Top;
            userControlActivity1.BringToFront();
        }

        private void btnUserm_Click(object sender, EventArgs e)
        {
            pnColor.Height = btnUserm.Height;
            pnColor.Top = btnUserm.Top;
            userControlInformation1.BringToFront();
        }

        private void btnStatisticalm_Click(object sender, EventArgs e)
        {
            pnColor.Height = btnStatisticalm.Height;
            pnColor.Top = btnStatisticalm.Top;
            userStatistical1.BringToFront();
        }
    }
}
