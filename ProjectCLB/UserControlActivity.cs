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
    public partial class UserControlActivity : UserControl
    {
        //show date in data grid
        public UserControlActivity()
        {
            InitializeComponent();
            this.dgrActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrActivity.DataSource = GetActivity().Tables[0];
        }

        private void btnRefreshActivity_Click(object sender, EventArgs e)
        {
            this.dgrActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrActivity.DataSource = GetActivity().Tables[0];
        }
        DataSet GetActivity()
        {
            DataSet dataCLB = new DataSet();
            string query = "select MAHD as [Mã hoạt động], TENCLB as [Tên CLB], TENHOATDONG as [Tên hoạt động], TUNGAY as [Từ ngày] , DENNGAY as [Đến ngày]from HOATDONG join CLB on HOATDONG.MACLB = CLB.MACLB";
            using (SqlConnection cn = new SqlConnection(ConnectString.cnString))
            {
                cn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
                adapter.Fill(dataCLB);
                cn.Close();
            }

            return dataCLB;
        }
        // show tab update
        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            OptionActivity optionActivity = new OptionActivity();
            optionActivity.Show();
        }
        //Find and show data
        private void btnFindActivity_Click(object sender, EventArgs e)
        {
            this.dgrActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrActivity.DataSource = FindData().Tables[0];
        }
        DataSet FindData()
        {
            DataSet dataCLB = new DataSet();
            string valueActivity = this.tbxFindActivity.Text;
            string query = string.Format("select MAHD as [Mã hoạt động], TENCLB as [Tên CLB], TENHOATDONG as [Tên hoạt động], TUNGAY as [Từ ngày] , DENNGAY as [Đến ngày]from HOATDONG join CLB on HOATDONG.MACLB = CLB.MACLB where MAHD like '%{0}%' or TENCLB like '%{0}%' or TENHOATDONG like N'%{0}%' ", valueActivity);
            using (SqlConnection cn = new SqlConnection(ConnectString.cnString))
            {
                cn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
                adapter.Fill(dataCLB);
                cn.Close();
            }

            return dataCLB;
        }
        // join Activity
        private void btnListJoinActivity_Click(object sender, EventArgs e)
        {
            this.dgrActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrActivity.DataSource = GetMemberJoinActivity().Tables[0];
        }
        DataSet GetMemberJoinActivity()
        {
            DataSet dataCLB = new DataSet();
            string query = "select SINHVIEN.MASV as [Mã sinh viên], HOTEN as [Họ tên], TENHOATDONG as [Tên hoạt động], NGAYTHAMGIAHD as [Ngày tham gia] from SINHVIEN join THAMGIAHD on SINHVIEN.MASV = THAMGIAHD.MASV join HOATDONG on HOATDONG.MAHD = THAMGIAHD.MAHD";
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
