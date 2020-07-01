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
    public partial class UserControlSV : UserControl
    {
        public UserControlSV()
        {
            InitializeComponent();
            this.dgrSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrSV.DataSource = GetSV().Tables[0];
        }

        private void btnRefreshSV_Click(object sender, EventArgs e)
        {
            this.dgrSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrSV.DataSource = GetSV().Tables[0];
        }
        DataSet GetSV()
        {
            DataSet dataCLB = new DataSet();
            string query = "select * from SINHVIEN";
            using (SqlConnection cn = new SqlConnection(ConnectString.cnString))
            {
                cn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
                adapter.Fill(dataCLB);
                cn.Close();
            }

            return dataCLB;
        }

        private void UserControlSV_Load(object sender, EventArgs e)
        {

        }

        private void usLBSV_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateSV_Click(object sender, EventArgs e)
        {
            UpdateSV uSV = new UpdateSV();
            uSV.Show();
        }
    }
}
