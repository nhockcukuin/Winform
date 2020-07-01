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
    public partial class UpdateSV : Form
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        //string theDate = SVdate.Value.ToShortDateString();
        public UpdateSV()
        {
            InitializeComponent();
        }

        private void UpdateSV_Load(object sender, EventArgs e)
        {
            //Set value for cbx Option and set value default
            this.SVcbxTypeOption.Items.Add("Thêm mới");
            this.SVcbxTypeOption.Items.Add("Xóa");
            this.SVcbxTypeOption.Items.Add("Sửa");
            this.SVcbxTypeOption.SelectedIndex = SVcbxTypeOption.FindString("Thêm mới");

            //Set value for Sex student and set value default
            this.SVcbxSex.Items.Add("Nam");
            this.SVcbxSex.Items.Add("Nữ");
            this.SVcbxSex.SelectedIndex = SVcbxSex.FindString("Nam");
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UbtnSave_Click(object sender, EventArgs e)
        {
            if (SVcbxTypeOption.Text == "Thêm mới")
            {
                AddSV();
            }
            else if (SVcbxTypeOption.Text == "Sửa")
            {
                EditSV();
            }
            else
            {
                DeleteSV();
            }
        }
        void AddSV()
        {
            //check the data
            if (this.SVtbxID.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SVtbxID.Focus();
            }
            else if (this.SVtbxName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SVtbxName.Focus();
            }
            else if (this.SVtbxDepartment.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SVtbxDepartment.Focus();
            }
            // perform mission
            else
            {
                string theDate = SVdate.Value.ToShortDateString();
                int sex;
                if(SVcbxSex.Text =="Nam")
                {
                    sex = 1;
                }
                else { sex = 0; }
                //Check if the primary key is the same                
                cn.Open();
                string sql = string.Format("select * from SINHVIEN where MASV='{0}'", this.SVtbxID.Text);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                Boolean t = dr.HasRows;
                cn.Close();
                //Duplicate primary key
                if (t == true)
                {
                    MessageBox.Show("Mã sinh viên bị trùng. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Do not duplicate primary key
                else
                {
                    //Do more data
                    string sql1;
                    sql1 = string.Format("insert into SINHVIEN values ('{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}')", this.SVtbxID.Text, this.SVtbxName.Text, theDate, this.SVtbxNPhone.Text, this.SVtbxAdress.Text, sex,this.SVtbxDepartment.Text);
                    Perform(sql1);
                }
            }

        }
        void EditSV()
        {
            //check the data
            string theDate = SVdate.Value.ToShortDateString();
            int sex;
            if (SVcbxSex.Text == "Nam")
            {
                sex = 1;
            }
            else { sex = 0; }
            if (this.SVtbxID.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SVtbxID.Focus();
            }
            else
            {
                //New data
                string sql1 = string.Format("update SINHVIEN set HOTEN=N'{0}',NGAYSINH='{1}',SDT={2},DIACHI='{3}',GIOITINH='{4}',KHOA=N'{5}' where MASV='{6}'", this.SVtbxName.Text, theDate, this.SVtbxNPhone.Text, this.SVtbxAdress.Text, sex, this.SVtbxDepartment.Text, this.SVtbxID.Text);
                Perform(sql1);
            }
        }
        void DeleteSV()
        {
            DialogResult = MessageBox.Show("Bạn muốn xóa dữ liệu sinh viên ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //Thực hiện xóa dữ liệu
                string sql = string.Format("Delete from SINHVIEN where MASV='{0}'", this.SVtbxID.Text);
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
