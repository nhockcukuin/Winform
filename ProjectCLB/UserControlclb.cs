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
            UpdateCLB uCLB = new UpdateCLB();
            uCLB.Show();
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
    }
}
