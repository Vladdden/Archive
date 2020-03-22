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

        private void checkFunds_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fund_table fund_Table = new Fund_table();
            fund_Table.Show();
        }

        private void checkInv_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inv_table inv_Table = new Inv_table();
            inv_Table.Show();
        }

        private void checkUnits_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Unit_table unit_Table = new Unit_table();
            unit_Table.Show();
        }

        private void checkUsers_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users_table users_Table = new Users_table();
            users_Table.Show();
        }
    }
}
