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
    public partial class Users_table : Form
    {
        public Users_table()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddData addData = new AddData();
            addData.Show();
        }

        private void Registration_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddData addData = new AddData();
            addData.Show();
        }

        private void Users_table_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.iPSArchiveDataSet.users);

        }
    }
}
