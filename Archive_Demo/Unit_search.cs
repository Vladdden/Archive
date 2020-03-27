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
    public partial class Unit_search : Form
    {
        public Unit_search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unit_table main = this.Owner as Unit_table;
            if (main != null)
            {
                for (int i = 0; i < main.Unit_dataGridView.RowCount; i++)
                {
                    main.Unit_dataGridView.Rows[1].Selected = false;
                    for (int j = 0; j < main.Unit_dataGridView.ColumnCount; j++)
                        if (main.Unit_dataGridView.Rows[i].Cells[j].Value != null)
                            if (main.Unit_dataGridView.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.Unit_dataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
