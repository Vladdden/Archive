using Archive_Demo.IPSArchiveDataSetTableAdapters;
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
    public partial class Fund_table : Form
    {
        public Fund_table()
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

        private void Fund_table_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.Fund". При необходимости она может быть перемещена или удалена.
            this.fundTableAdapter.Fill(this.iPSArchiveDataSet.Fund);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.fundTableAdapter.Update(this.iPSArchiveDataSet.Fund);
        }
    }
}
