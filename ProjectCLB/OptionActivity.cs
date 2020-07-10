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
    public partial class OptionActivity : Form
    {
        public OptionActivity()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptionActivity_Click(object sender, EventArgs e)
        {
            UpdateActivity updateActivity = new UpdateActivity();
            updateActivity.Show();
            this.Close();
        }
    }
}
