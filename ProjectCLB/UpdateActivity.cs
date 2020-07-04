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
    public partial class UpdateActivity : Form
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        public UpdateActivity()
        {
            InitializeComponent();
        }

        private void UpdateActivity_Load(object sender, EventArgs e)
        {
            this.AcbxTypeOption.Items.Add("Thêm mới");
            this.AcbxTypeOption.Items.Add("Xóa");
            this.AcbxTypeOption.Items.Add("Sửa");
            this.AcbxTypeOption.SelectedIndex = AcbxTypeOption.FindString("Thêm mới");
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbtnSave_Click(object sender, EventArgs e)
        {
            if (AcbxTypeOption.Text == "Thêm mới")
            {
                AddActivity();
            }
            else if (AcbxTypeOption.Text == "Sửa")
            {
                EditActivity();
            }
            else
            {
                DeleteActivity();
            }
        }
        void AddActivity()
        {
            //check the data
            if (this.AtbxID.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AtbxID.Focus();
            }
            else if (this.AtbxIDCLB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã CLB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AtbxID.Focus();
            }
            else if (this.AtbxName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AtbxName.Focus();
            }
            // perform mission
            else
            {
                string theDateFrom = AdateFrom.Value.ToShortDateString();
                string theDateTo = AdateTo.Value.ToShortDateString();
                //Check if the primary key is the same                
                cn.Open();
                string sql = string.Format("select * from CLB where MaCLB='{0}'", this.AtbxID.Text);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                Boolean t = dr.HasRows;
                cn.Close();
                //Duplicate primary key
                if (t == true)
                {
                    MessageBox.Show("Mã hoạt động bị trùng. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Do not duplicate primary key
                else
                {
                    //Do more data
                    string sql1;
                    sql1 = string.Format("insert into HOATDONG values ('{0}','{1}','{2}','{3}','{4}')", this.AtbxID.Text, this.AtbxIDCLB.Text, this.AtbxName.Text,theDateFrom,theDateTo);
                    Perform(sql1);
                }
            }

        }
        void EditActivity()
        {
            //check the data
            if (this.AtbxID.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AtbxID.Focus();
            }
            else
            {
                string theDateFrom = AdateFrom.Value.ToShortDateString();
                string theDateTo = AdateTo.Value.ToShortDateString();
                //New data
                string sql1 = string.Format("update HOATDONG set MACLB='{0}',TENHOATDONG=N'{1}', TUNGAY='{2}', DENNGAY='{3}' where MAHD='{4}'", this.AtbxIDCLB.Text, this.AtbxName.Text, theDateFrom,theDateTo,this.AtbxID.Text);
                Perform(sql1);
            }
        }
        void DeleteActivity()
        {
            DialogResult = MessageBox.Show("Bạn muốn xóa dữ liệu hoạt động ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //Thực hiện xóa dữ liệu
                string sql = string.Format("Delete from HOATDONG where MAHD='{0}'", this.AtbxID.Text);
                Perform(sql);
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
                MessageBox.Show("Việc cập nhật dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();
        }
    }
}
