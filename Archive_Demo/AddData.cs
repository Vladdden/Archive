using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archive_Demo
{
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void addFund_btn_Click(object sender, EventArgs e)
        {
            addFund_btn.BackColor = Color.Khaki;
        }

        private void addInv_btn_Click(object sender, EventArgs e)
        {
            addInv_btn.BackColor = Color.Khaki;
        }

        private void addUnit_btn_Click(object sender, EventArgs e)
        {
            addUnit_btn.BackColor = Color.Khaki;
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            addUser_btn.BackColor = Color.Khaki;
        }
    }
}
