using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCLB
{
    public partial class OptionCLB : Form
    {
        public OptionCLB()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptionCLB_Click(object sender, EventArgs e)
        {
            UpdateCLB upCLB = new UpdateCLB();
            upCLB.Show();
            this.Close();
        }

        private void btnOptionJoin_Click(object sender, EventArgs e)
        {
            MemberofCLB memberofCLB = new MemberofCLB();
            memberofCLB.Show();
            this.Close();
        }
    }
}
