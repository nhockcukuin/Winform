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
    public partial class UserStatistical : UserControl
    {
        public UserStatistical()
        {
            InitializeComponent();
           // this.dgrStatistical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          //  this.dgrStatistical.DataSource = GetStatistical().Tables[0];
        }

        private void btnRefreshStatistical_Click(object sender, EventArgs e)
        {
           // this.dgrStatistical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // this.dgrStatistical.DataSource = GetStatistical().Tables[0];
        }
        DataSet GetStatistical()
        {
            DataSet dataCLB = new DataSet();
            string query = "select MACLB as [Mã CLB], TENCLB as [Tên CLB], TENDV as [Đơn vị quản lý] from CLB join DVQUANLY on CLB.MADV = DVQUANLY.MADV";
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
