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
    public partial class UpdateCLB : Form
    {
        SqlConnection cn = new SqlConnection(ConnectString.cnString);
        public UpdateCLB()
        {
            InitializeComponent();

        }

        private void btnAddClb_Click(object sender, EventArgs e)
        {

        }
        // set Minimized
        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            
        }
        //Close tab
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Close tab 
        private void UbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UbtnSave_Click(object sender, EventArgs e)
        {

            if (UcbxTypeOption.Text == "Thêm mới")
            {
                AddCLB();
            }
            else if(UcbxTypeOption.Text == "Sửa")
            {
                EditCLB();
            }
            else
            {
                DeleteCLB();
            }
        }

        private void UpdateCLB_Load(object sender, EventArgs e)
        {
            //Set value for cbx Option and set value default
            this.UcbxTypeOption.Items.Add("Thêm mới");
            this.UcbxTypeOption.Items.Add("Xóa");
            this.UcbxTypeOption.Items.Add("Sửa");
            this.UcbxTypeOption.SelectedIndex = UcbxTypeOption.FindString("Thêm mới");

        }
        void AddCLB()
        {
            //check the data
            if (this.UtbxID.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã CLB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.UtbxID.Focus();
            }
            else if (this.UtbxName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên CLB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.UtbxName.Focus();
            }
            else if (this.UtbxQL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.UtbxQL.Focus();
            }
            // perform mission
            else
            {
                try
                {
                    //Check if the primary key is the same                
                    cn.Open();
                    string sql = string.Format("select * from CLB where MaCLB='{0}'", this.UtbxID.Text);
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    Boolean t = dr.HasRows;
                    cn.Close();
                    //Duplicate primary key
                    if (t == true)
                    {
                        MessageBox.Show("Mã CLB bị trùng. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Do not duplicate primary key
                    else
                    {
                        //Do more data
                        string sql1;
                        sql1 = string.Format("insert into CLB values ('{0}',N'{1}',N'{2}')", this.UtbxID.Text, this.UtbxName.Text, this.UtbxQL.Text);
                        Perform(sql1);
                    }
                }
                catch(Exception)
                {
                    
                }
            }

        }
        void EditCLB()
        {
            try
            {
                //check the data
                if (this.UtbxID.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã CLB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.UtbxID.Focus();
                }
                else
                {
                    //New data
                    string sql1 = string.Format("update CLB set TENCLB=N'{0}',DONVIQUANLY=N'{1}' where MACLB='{2}'", this.UtbxName.Text, this.UtbxQL.Text, this.UtbxID.Text);
                    Perform(sql1);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Mã CLB không hợp lệ");
            }
        }
        void DeleteCLB()
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn muốn xóa dữ liệu câu lạc bộ ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    //Delete data
                    string sql = string.Format("Delete from CLB where MaCLB='{0}'", this.UtbxID.Text);
                    Perform(sql);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Mã CLB không hợp lệ");
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
