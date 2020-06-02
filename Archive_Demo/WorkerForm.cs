using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archive_Demo
{
    public partial class WorkerForm : Form
    {
        static int ID_User;
        public WorkerForm(int ID_Usr)
        {
            ID_User = ID_Usr;
            InitializeComponent();
        }

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
                MessageBox.Show("Данные успешно добавлены.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

            
            Fund_Num_btn.Text = "";
            Fund_Lit_btn.Text = "";
            Fund_Name_btn.Text = "";
            Fund_Inv_Count_btn.Text = "";
            Fund_Year_St.Value = DateTime.Today;
            Fund_Year_End.Value = DateTime.Today.AddDays(365);
            Fund_Comment_btn.Text = "";

            this.fundTableAdapter.Fill(this.iPSArchiveDataSet.Fund);
            Inv_Fund_ID_comboBox.SelectedItem = null;
            Inv_Fund_ID_comboBox.Text = "----Выберите----";

        }

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
                MessageBox.Show("Данные успешно добавлены.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

            
            Inv_Fund_ID_comboBox.SelectedItem = null;
            Inv_Fund_ID_comboBox.Text = "----Выберите----";
            Inv_Num.Text = "";
            Inv_Lit.Text = "";
            Inv_Vol.Text = "";
            Inv_Name.Text = "";
            Inv_Year_St_dateTimePicker.Value = DateTime.Today;
            Inv_Year_End_dateTimePicker.Value = DateTime.Today.AddDays(365);
            Inv_Dates.Text = "";
            Inv_Unit_Count.Text = "";
            Inv_Comment.Text = "";

            this.inventoryTableAdapter.Fill(this.iPSArchiveDataSet.Inventory);
            Unit_Inv_comboBox.SelectedItem = null;
            Unit_Inv_comboBox.Text = "-----Выберите-----";
        }

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
                MessageBox.Show("Данные успешно добавлены.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

           
            Unit_Num.Text = "";
            Unit_Lit.Text = "";
            Unit_Dates.Text = "";
            Unit_Name.Text = "";
            Unit_P_Count.Text = "";
            Unit_Date_Create_dateTimePicker.Value = DateTime.Now;
            Unit_Comment.Text = "";
            Unit_Inv_comboBox.SelectedItem = null;
            Unit_Inv_comboBox.Text = "-----Выберите-----";
            Unit_Type.SelectedItem = null;
            Unit_Type.Text = "---Выберите---";
            Unit_Year_St_dateTimePicker.Value = DateTime.Today;
            Unit_Year_End_dateTimePicker.Value = DateTime.Today.AddDays(365);

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.iPSArchiveDataSet.Inventory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.UnitTypes". При необходимости она может быть перемещена или удалена.
            this.unitTypesTableAdapter.Fill(this.iPSArchiveDataSet.UnitTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.Fund". При необходимости она может быть перемещена или удалена.
            this.fundTableAdapter.Fill(this.iPSArchiveDataSet.Fund);

            Fund_Year_St.Value = DateTime.Today;
            Fund_Year_End.Value = DateTime.Today.AddDays(365);
            Inv_Year_St_dateTimePicker.Value = DateTime.Today;
            Inv_Year_End_dateTimePicker.Value = DateTime.Today.AddDays(365);
            Unit_Year_St_dateTimePicker.Value = DateTime.Today;
            Unit_Year_End_dateTimePicker.Value = DateTime.Today.AddDays(365);
            Inv_Fund_ID_comboBox.SelectedItem = null;
            Inv_Fund_ID_comboBox.Text = "----Выберите----";
            Unit_Inv_comboBox.SelectedItem = null;
            Unit_Inv_comboBox.Text = "-----Выберите-----";
            Unit_Type.SelectedItem = null;
            Unit_Type.Text = "---Выберите---";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void Inv_Fund_ID_comboBox_Leave(object sender, EventArgs e)
        {
            if (Inv_Fund_ID_comboBox.Text == "")
                Inv_Fund_ID_comboBox.Text = "----Выберите----";
        }

        private void Unit_Inv_comboBox_Leave(object sender, EventArgs e)
        {
            
            if (Unit_Inv_comboBox.Text == "")
                Unit_Inv_comboBox.Text = "-----Выберите-----";
        }

        private void Unit_Type_Leave(object sender, EventArgs e)
        {
            if (Unit_Type.Text == "")
                Unit_Type.Text = "---Выберите---";
        }

        private void Disconnect()
        {
            DialogResult dr = MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.ArchiveConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                string sql = $"UPDATE Users SET Exit_Time = '{DateTime.Now}' WHERE ID = '" + ID_User + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
                connection.Close();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }

        }
    }
}
