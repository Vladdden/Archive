using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
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
            int Fund_ID = 8;
            string Fund_Num = Fund_Num_btn.Text;
            string Fund_Lit = Fund_Lit_btn.Text;
            string Fund_Name = Fund_Name_btn.Text;
            string Inv_Count = Fund_Inv_Count_btn.Text;
            string Year_St = Fund_Year_St.Text;
            string Year_End = Fund_Year_End.Text;
            string comment = Fund_Comment_btn.Text;

            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            { 
                connection.Open();
                Console.WriteLine("Connection: yes");
                string sql = "INSERT INTO Fund (Fund_Num, Fund_Lit ,Fund_Name, Inv_Count, Year_St, Year_End, Comment) VALUES ('" + Fund_Num_btn.Text + "','" + Fund_Lit_btn.Text + "','" + Fund_Name_btn.Text + "','" + Fund_Inv_Count_btn.Text + "','" + Fund_Year_St.Text + "','" + Fund_Year_End.Text + "','" + Fund_Comment_btn.Text + "', 0)";
                SqlCommand command = new SqlCommand(sql, connection);
                
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
    }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }
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

            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = "INSERT INTO users VALUES ('6','" + NameField.Text + "','" + SurField.Text + "','" + LoginField.Text + "','" + PassField.Text + "', '0');";
            SqlConnection connection = new SqlConnection(connectionString);
             try
             {
                 connection.Open();
                 Console.WriteLine("Подключение: Да");
                 SqlCommand command = new SqlCommand(sql, connection);
                 int number = command.ExecuteNonQuery();
                 Console.WriteLine("Добавлено объектов: {0}", number);
            }
             catch (SqlException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 connection.Close();
                 Console.WriteLine("Подключение закрыто...");
             }
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
