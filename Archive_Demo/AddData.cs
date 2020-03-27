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
            Inv_Fund_ID_comboBox.SelectedItem = null;
            Inv_Fund_ID_comboBox.SelectedText = "--Выберите--";
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void addFund_btn_Click(object sender, EventArgs e)
        {
            addFund_btn.BackColor = Color.Khaki;
            
            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = "INSERT INTO Fund VALUES ('" + Fund_Num_btn.Text + "','" + Fund_Lit_btn.Text + "','" + Fund_Name_btn.Text + "','" + Fund_Inv_Count_btn.Text + "','" + Fund_Year_St.Text + "','" + Fund_Year_End.Text + "','" + Fund_Comment_btn.Text + "', 0)";
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
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void addInv_btn_Click(object sender, EventArgs e)
        {
            addInv_btn.BackColor = Color.Khaki;

            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = "INSERT INTO Inventory (Fund_ID, Inv_Num, Inv_Lit, Inv_Vol, Inv_Name, Year_St, Year_End, Dates, Unit_Count, Comment, Deleted) VALUES ('" + Inv_Fund_ID_comboBox.SelectedValue + "','" + Inv_Num.Text + "','" + Inv_Lit.Text + "','" + Inv_Vol.Text + "','" + Inv_Name.Text + "','" + Inv_Year_St_dateTimePicker.Text + "','" + Inv_Year_End_dateTimePicker.Text + "','" + Inv_Dates.Text + "','" + Inv_Unit_Count.Text + "','" + Inv_Comment.Text + "', 0)";
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

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void addUnit_btn_Click(object sender, EventArgs e)
        {
            addUnit_btn.BackColor = Color.Khaki;

            
            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = "INSERT INTO Unit (Unit_Num, Unit_Lit, Dates, Unit_Name, P_Count, DateCreate, Comment, Inv_ID, Deleted, Unit_Type, Year_St, Year_End) VALUES ('" + Unit_Num.Text + "','" + Unit_Lit.Text + "','" + Unit_Dates.Text + "','" + Unit_Name.Text + "','" + Unit_P_Count.Text + "', @Unit_Date_Create_dateTimePicker,'" + Unit_Comment.Text + "','" + Unit_Inv_comboBox.SelectedValue + "',0,'" + Unit_Type.SelectedValue + "','" + Unit_Year_St_dateTimePicker.Text + "','" + Unit_Year_End_dateTimePicker.Text + "')";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Подключение: Да");
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@Unit_Date_Create_dateTimePicker", SqlDbType.Date).Value = Unit_Date_Create_dateTimePicker.Value.Date;
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
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void addUser_btn_Click(object sender, EventArgs e)
        {
            addUser_btn.BackColor = Color.Khaki;

            int flag;
            if (Admin_checkBox.Checked) flag = 1;
            else flag = 0;
           
            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = "INSERT INTO users VALUES ('" + NameField.Text + "','" + SurField.Text + "','" + LoginField.Text + "','" + PassField.Text + "', '" + flag + "');";
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
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

        private void AddData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.iPSArchiveDataSet.Inventory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.UnitTypes". При необходимости она может быть перемещена или удалена.
            this.unitTypesTableAdapter.Fill(this.iPSArchiveDataSet.UnitTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.Fund". При необходимости она может быть перемещена или удалена.
            this.fundTableAdapter.Fill(this.iPSArchiveDataSet.Fund);

        }
    }
}
