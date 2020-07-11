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
    public partial class MemberofCLB : Form
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        public MemberofCLB()
        {
            InitializeComponent();
        }
        //close tab
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // minimized tab
        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UbtnSave_Click(object sender, EventArgs e)
        {
            if (cbxMemberOption.Text == "Thêm mới")
            {
                AddMember();
            }
            else if (cbxMemberOption.Text == "Sửa")
            {
                EditMember();
            }
            else
            {
                DeleteMember();
            }
        }

        private void MemberofCLB_Load(object sender, EventArgs e)
        {
            //Set value for cbx Option and set value default
            this.cbxMemberOption.Items.Add("Thêm mới");
            this.cbxMemberOption.Items.Add("Xóa");
            this.cbxMemberOption.Items.Add("Sửa");
            this.cbxMemberOption.SelectedIndex = cbxMemberOption.FindString("Thêm mới");
            
        }
        void AddMember()
        {
            try
            {
                //Check if the primary key is the same    
                String theDateFrom = dateFrom.Value.ToShortDateString();
                String theDateTo = dateTo.Value.ToShortDateString();
                cn.Open();
                string sql = string.Format("select * from THAMGIACLB where MaCLB='{0}' and MASV = '{1}'",this.tbxMemberCLB.Text,this.tbxMemberJoin.Text);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                Boolean t = dr.HasRows;
                cn.Close();
                //Duplicate primary key
                if (t == true)
                {
                    MessageBox.Show("Sinh viên đã tham gia CLB này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Do not duplicate primary key
                else
                {
                    //Do more data
                    string sql1;
                    sql1 = string.Format("insert into THAMGIACLB values ('{0}','{1}','{2}','{3}')",this.tbxMemberCLB.Text,this.tbxMemberJoin.Text,theDateFrom,theDateTo);
                    Perform(sql1);
                }
            }
            catch (Exception)
            {

            }
        }
        void EditMember()
        {
            try
            {
                String theDateFrom = dateFrom.Value.ToShortDateString();
                String theDateTo = dateTo.Value.ToShortDateString();
                //New data
                string sql1 = string.Format("update THAMGIACLB set MACLB='{0}',MASV='{1}',NGAYTHAMGIA='{2}',NGAYROI='{3}' where MACLB = '{4}' and MASV='{5}'", this.tbxMemberCLB.Text, this.tbxMemberJoin.Text, theDateFrom, theDateTo, this.tbxOldIDCLB.Text, this.tbxOldIDStudent.Text);
                Perform(sql1);
            }
            catch (Exception)
            {
                
            }
        }
        void DeleteMember()
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn muốn xóa dữ liệu", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    //Delete data
                    string sql = string.Format("Delete from THAMGIACLB where MACLB='{0}' and MASV='{1}'", this.tbxMemberCLB.Text, this.tbxMemberJoin.Text);
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

        private void UbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMemberOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMemberOption.Text == "Thêm mới")
            {
                this.grOldData.Hide();
            }
            else if (cbxMemberOption.Text == "Sửa")
            {
                this.grOldData.Show();
            }
            else
            {
                this.grOldData.Hide();
            }
        }
    }
}
