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

        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            UpdateActivity uActivity = new UpdateActivity();
            uActivity.Show();
        }
    }
}
