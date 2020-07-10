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
    public partial class UserControlCLB : UserControl
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        // Fill Gridview
        public UserControlCLB()
        {
            InitializeComponent();
            this.dgrCLB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrCLB.DataSource = GetCLB().Tables[0];
        }

        private void btnRefreshClb_Click(object sender, EventArgs e)
        {
            this.dgrCLB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrCLB.DataSource = GetCLB().Tables[0];
        }
        //get data 
        DataSet GetCLB()
        {
            DataSet dataCLB = new DataSet();
            string query = "select MACLB as [Mã CLB], TENCLB as [Tên CLB], DONVIQUANLY as [Đơn vị quản lý] from CLB";
            using (SqlConnection cn = new SqlConnection(ConnectString.cnString))
            {
                cn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
                adapter.Fill(dataCLB);
                cn.Close();
            }

            return dataCLB;
        }

        private void dgrCLB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //show tab update
        private void btnAddClb_Click(object sender, EventArgs e)
        {
            OptionCLB optionCLB = new OptionCLB();
            optionCLB.Show();
        }
        //find data
        private void btnFindClb_Click(object sender, EventArgs e)
        {
            this.dgrCLB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrCLB.DataSource = FindData().Tables[0];
        }
        DataSet FindData()
        {
            DataSet dataCLB = new DataSet();
            string valueCLB = this.tbxFindClb.Text;
            string query= string.Format("select MACLB as [Mã CLB], TENCLB as [Tên CLB], DONVIQUANLY as [Đơn vị quản lý] from CLB where MACLB like '%{0}%' or TENCLB like N'%{0}%' or DONVIQUANLY like '%{0}%'",valueCLB);
            using (SqlConnection cn = new SqlConnection(ConnectString.cnString))
            {
                cn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
                adapter.Fill(dataCLB);
                cn.Close();
            }

            return dataCLB;
        }
        // Member of CLB
        private void btnListJoinCLB_Click(object sender, EventArgs e)
        {
            this.dgrCLB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrCLB.DataSource = GetJoinCLB().Tables[0];
        }
        DataSet GetJoinCLB()
        {
            DataSet dataCLB = new DataSet();
            string query = "select SINHVIEN.MASV as [Mã sinh viên], HOTEN as [Thành viên], TENCLB as [Tên CLB], NGAYTHAMGIA as [Ngày tham gia], NGAYROI as [Ngày rời] from SINHVIEN join THAMGIACLB on SINHVIEN.MASV = THAMGIACLB.MASV join CLB on CLB.MACLB = THAMGIACLB.MACLB";
            using (SqlConnection cn = new SqlConnection(ConnectString.cnString))
            {
                cn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
                adapter.Fill(dataCLB);
                cn.Close();
            }

            return dataCLB;
        }
    }
}
