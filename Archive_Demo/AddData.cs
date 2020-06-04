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
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Archive_Demo
{
    public partial class AddData : Form
    {
        public static TcpClient client;
        const int port = 8888;
        static TcpListener listener;
        public static void ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }
        int ID_User;
        public AddData(int id_User = 2)
        {
            ID_User = Convert.ToInt32(id_User);
            InitializeComponent();
            
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void addFund_btn_Click(object sender, EventArgs e)
        {
            if ((Fund_Num_btn.Text != "")&&(Fund_Name_btn.Text != "") &&(Fund_comboBox_Comp.SelectedValue != null))
            {
                addFund_btn.BackColor = Color.Khaki;
                var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
                string sql = "INSERT INTO Fund VALUES ('" + Fund_Num_btn.Text + "','" + Fund_Lit_btn.Text + "','" + Fund_Name_btn.Text + "','" + Fund_Inv_Count_btn.Text + "','" + Fund_Year_St.Text + "','" + Fund_Year_End.Text + "','" + Fund_Comment_btn.Text + "', 0, '" + Fund_comboBox_Comp.SelectedValue + "')";
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
                this.fundTableAdapter.Fill(this.iPSArchiveDataSet.Fund);

                Fund_Num_btn.Text = "";
                Fund_Lit_btn.Text = "";
                Fund_Name_btn.Text = "";
                Fund_Inv_Count_btn.Text = "";
                Fund_Year_St.Value = DateTime.Today;
                Fund_Year_End.Value = DateTime.Today.AddDays(365);
                Fund_Comment_btn.Text = "";
                Fund_comboBox_Comp.SelectedItem = null;
                Inv_Fund_ID_comboBox.SelectedItem = null;
                Inv_Fund_ID_comboBox.Text = "----Выберите----";
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля для добавления в базу!");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void addInv_btn_Click(object sender, EventArgs e)
        {
            if ((Inv_Fund_ID_comboBox.SelectedItem != null) && (Inv_Num.Text != "") && (Inv_Name.Text != ""))
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
            else MessageBox.Show("Необходимо заполнить все обязательные поля для добавления в базу!");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void addUnit_btn_Click(object sender, EventArgs e)
        {
            if ((Unit_Inv_comboBox.SelectedItem != null) && (Unit_Type.SelectedItem != null) && (Unit_Fund_comboBox.SelectedItem != null) && (Unit_Num.Text != "") && (Unit_Name.Text != ""))
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
            else MessageBox.Show("Необходимо заполнить все обязательные поля для добавления в базу!");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void addUser_btn_Click(object sender, EventArgs e)
        {
            if ((LoginField.Text != "") && (PassField.Text != ""))
            {
                addUser_btn.BackColor = Color.Khaki;
                int flag;
                if (Admin_checkBox.Checked) flag = 1;
                else flag = 0;

                var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
                string sql = "INSERT INTO Users(Name,Surname,Login,Password,Status,Log_Time) VALUES ('" + NameField.Text + "','" + SurField.Text + "','" + LoginField.Text + "','" + PassField.Text + "', '" + flag + "', '" + DateTime.Now + "');";
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


                NameField.Text = "";
                SurField.Text = "";
                LoginField.Text = "";
                PassField.Text = "";
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля для добавления в базу!");
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.Companies". При необходимости она может быть перемещена или удалена.
            this.companiesTableAdapter.Fill(this.iPSArchiveDataSet.Companies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iPSArchiveDataSet.Unit". При необходимости она может быть перемещена или удалена.
            this.unitTableAdapter.Fill(this.iPSArchiveDataSet.Unit);

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
            CompSelect.SelectedItem = null;
            Fund_comboBox_Comp.SelectedItem = null;
            DataTable table = new DataTable();
            Company_dataGridView_Funds.DataSource = table;

            UserInfo usrInfo = new UserInfo("111", "222", "333", "444", "555", "666");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("db.bin", FileMode.Create))
            {
                formatter.Serialize(fs, usrInfo);
                Console.WriteLine("Объект сериализован");
            }
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

        private void Inv_Fund_ID_comboBox_Leave(object sender, EventArgs e)
        {
            if (Inv_Fund_ID_comboBox.Text == "")
                Inv_Fund_ID_comboBox.Text = "----Выберите----";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = "SELECT * FROM Unit WHERE (DateCreate >= @X1) AND (DateCreate <= @X2)";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Подключение: Да");
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@X1", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                command.Parameters.Add("@X2", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[9]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }

                reader.Close();

                connection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = sql_field.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Подключение: Да");
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[9]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                }

                reader.Close();

                connection.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
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
        }

        private void Connect_IPS_btn_Click(object sender, EventArgs e)
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
                listener.Start();
                Console.WriteLine("Ожидание подключений...");

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientObject(client);
                    ConnectionToIPS();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }

        private void ConnectionToIPS()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[1024]; // буфер для получаемых данных
                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                string message = builder.ToString();
                Console.WriteLine(message);
                UserInfo usrInfo = new UserInfo(GenIPS_comboBox.Text, Company_ID_IPS.Text, Admin_Login_IPS.Text, Admin_Pass_IPS.Text, User_Login_IPS.Text, User_Pass_IPS.Text);
                //BinaryFormatter formatter = new BinaryFormatter();
                //XmlSerializer formatter = new XmlSerializer(typeof(UserInfo));
                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("db.xml", FileMode.Create))
                {
                    //formatter.Serialize(fs, usrInfo);
                    DataContractSerializer ser = new DataContractSerializer(typeof(UserInfo));
                    ser.WriteObject(fs, usrInfo);
                    Console.WriteLine("Объект сериализован");
                }

                FileStream file1 = new FileStream("db.xml", FileMode.Open); //создаем файловый поток
                file1.Position = 0;
                StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком
                string result = reader.ReadToEnd(); //считываем все данные с потока и выводим на экран
                reader.Close(); //закрываем поток
                data = Encoding.Unicode.GetBytes(result);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Данные отправлены");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }

        private void Create_IPS_btn_Click(object sender, EventArgs e)
        {
            if ((GenIPS_comboBox.SelectedItem != null) && (Company_ID_IPS.Text != "") && (Admin_Login_IPS.Text != "") && (Admin_Pass_IPS.Text != "") && (User_Login_IPS.Text != "") && (User_Pass_IPS.Text != ""))
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
                string sql = $"INSERT INTO IPS_Clients(CompanyName,Comp_ID,Clients_Name,AdminLogin,AdminPass,UserLogin,UserPass,DateCreate, Author) VALUES ('" + GenIPS_comboBox.Text + "','" + GenIPS_comboBox.SelectedValue + "','" + Company_ID_IPS.Text + "','" + Admin_Login_IPS.Text + "','" + Admin_Pass_IPS.Text + "','" + User_Login_IPS.Text + "','" + User_Pass_IPS.Text + "','" + DateTime.Now + "','" + ID_User + "')";
                Console.WriteLine(GenIPS_comboBox.Text);
                Console.WriteLine(GenIPS_comboBox.SelectedValue);

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

                string path = @"C:\Users\Владислав\source\repos\IPS\IPS\bin\Debug\IPS.exe";
                string newPath = @"C:\диплом\IPS.exe";
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.CopyTo(newPath, true);
                }
                return;
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля для добавления в базу!");
        }

        private void AddData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }

        private void Disconnect()
        {
            DialogResult dr = MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
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

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT Fund_ID,Fund_Name,Comment FROM Fund WHERE Comp_ID='" + CompSelect.SelectedValue + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Company_dataGridView_Funds.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((CompName.Text != ""))
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
                string sql = "INSERT INTO Companies(Comp_Name, Year_St, Comment, IPS_Created) VALUES ('" + CompName.Text + "','" + DateTime.Now.ToString("yyyy") + "','" + CompComment.Text + "', 0)";
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
                this.companiesTableAdapter.Fill(this.iPSArchiveDataSet.Companies);
                this.fundTableAdapter.Fill(this.iPSArchiveDataSet.Fund);
                CompName.Text = "";
                CompComment.Text = "";
                CompSelect.SelectedItem = null;
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля для добавления в базу!");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.companiesTableAdapter.Fill(this.iPSArchiveDataSet.Companies);
            CompSelect.SelectedItem = null;
            DataTable table = new DataTable();
            Company_dataGridView_Funds.DataSource = table;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            Fund_comboBox_Comp.SelectedItem = null;
            GenIPS_comboBox.SelectedItem = null;
        }

    }
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string CompanyName;
        [DataMember]
        public string CompanyID;
        [DataMember]
        public string AdmLogin;
        [DataMember]
        public string AdmPass;
        [DataMember]
        public string UsrLogin;
        [DataMember]
        public string UsrPass;

        public UserInfo(string companyName, string companyID, string admLogin, string admPass, string usrLogin, string usrPass)
        {
            CompanyName = companyName;
            CompanyID = companyID;
            AdmLogin = admLogin;
            AdmPass = admPass;
            UsrLogin = usrLogin;
            UsrPass = usrPass;
        }
    }
}

