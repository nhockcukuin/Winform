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
    public partial class UpdateJoinActivity : Form
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        public UpdateJoinActivity()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseJoin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSaveJoin_Click(object sender, EventArgs e)
        {
            if (cbxOptionJoinActivity.Text == "Thêm mới")
            {
                AddMemberJoin();
            }
            else if (cbxOptionJoinActivity.Text == "Sửa")
            {
                EditMemberJoin();
            }
            else
            {
                DeleteMemberJoin();
            }
        }

        private void UpdateJoinActivity_Load(object sender, EventArgs e)
        {
            //Set value for cbx Option and set value default
            this.cbxOptionJoinActivity.Items.Add("Thêm mới");
            this.cbxOptionJoinActivity.Items.Add("Xóa");
            this.cbxOptionJoinActivity.Items.Add("Sửa");
            this.cbxOptionJoinActivity.SelectedIndex = cbxOptionJoinActivity.FindString("Thêm mới");
        }
        void AddMemberJoin()
        {
            try
            {
                //Check if the primary key is the same    
                String theDateJoin = dateJoin.Value.ToShortDateString();
                cn.Open();
                string sql = string.Format("select * from THAMGIAHD where MaHD='{0}' and MASV = '{1}'", this.tbxIDActivity.Text, this.tbxIDActivityJoin.Text);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                Boolean t = dr.HasRows;
                cn.Close();
                //Duplicate primary key
                if (t == true)
                {
                    MessageBox.Show("Sinh viên đã tham gia hoạt động này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Do not duplicate primary key
                else
                {
                    //Do more data
                    string sql1;
                    sql1 = string.Format("insert into THAMGIAHD values ('{0}','{1}','{2}')", this.tbxIDActivityJoin.Text, this.tbxIDActivity.Text, theDateJoin);
                    Perform(sql1);
                }
            }
            catch (Exception)
            {

            }
        }
        void EditMemberJoin()
        {
            try
            {
                String theDateJoin = dateJoin.Value.ToShortDateString();
                //New data
                string sql1 = string.Format("update THAMGIAHD set MAHD='{0}',MASV='{1}',NGAYTHAMGIAHD='{2}'", this.tbxIDActivity.Text, this.tbxIDActivityJoin.Text, theDateJoin);
                Perform(sql1);
            }
            catch (Exception)
            {

            }
        }
        void DeleteMemberJoin()
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn muốn xóa dữ liệu", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    //Delete data
                    string sql = string.Format("Delete from THAMGIAHD where MAHD='{0}' and MASV='{1}'", this.tbxIDActivity.Text, this.tbxIDActivityJoin.Text);
                    Perform(sql);
                }
            }
            catch (Exception)
            {

            }
        }
        void Perform(string sql)
        {
            //Execute sql statement
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            //Notification if not successful
            if (i == 0)
            {
                MessageBox.Show("Việc cập nhật dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            cn.Close();
        }
    }
}
