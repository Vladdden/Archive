using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Archive_Demo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;
            PassField.UseSystemPasswordChar = false;

            /*
            string connectionString = @"Data Source=ВЛАДИСЛАВ-ПК\SQLEXPRESS;Initial Catalog=IPSArchive;Integrated Security=True";
           
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", connection.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", connection.Database);
                Console.WriteLine("\tСервер: {0}", connection.DataSource);
                Console.WriteLine("\tВерсия сервера: {0}", connection.ServerVersion);
                Console.WriteLine("\tСостояние: {0}", connection.State);
                Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);
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
            */
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.Text = "";
                PassField.UseSystemPasswordChar = true;
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.UseSystemPasswordChar = false;
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {

            string UserLogin = LoginField.Text;
            string UserPass = PassField.Text;

            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.ArchiveConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", connection.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", connection.Database);
                Console.WriteLine("\tСервер: {0}", connection.DataSource);
                Console.WriteLine("\tВерсия сервера: {0}", connection.ServerVersion);
                Console.WriteLine("\tСостояние: {0}", connection.State);
                Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);

                //string sqlExpression ="SELECT * FROM users WHERE 'Login' = @uL AND 'Password'= @uP";


                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT ID FROM Users WHERE Login='" + LoginField.Text + "' AND Password='" + PassField.Text + "'", connection);
                //SqlCommand command = new SqlCommand($"SELECT * FROM users WHERE 'Login'='"+ LoginField.Text +"' AND 'Password'='" + PassField.Text + "'", connection);
                //command.Parameters.Add("@uL", SqlDbType.VarChar).Value = UserLogin;
                //command.Parameters.Add("@uP", SqlDbType.VarChar).Value = UserPass;
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    int s = table.Rows[0].Field<int>(0);
                    string sql = $"UPDATE Users SET Log_Time = '{DateTime.Now}' WHERE Login = '" + LoginField.Text + "' AND Password = '" + PassField.Text + "'";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int number = command.ExecuteNonQuery();
                    Console.WriteLine("Добавлено объектов: {0}", number);
                    Console.WriteLine("Сеанс записан в базу: {0}", s);

                    sql = "SELECT Status FROM users WHERE Login='" + LoginField.Text + "' AND Password='" + PassField.Text + "'";
                    command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetValue(0).ToString() == "0")
                        {
                            this.Hide();
                            WorkerForm workerForm = new WorkerForm(s);
                            workerForm.Show();
                        }
                        if (reader.GetValue(0).ToString() == "1")
                        {
                            this.Hide();
                            AddData addData = new AddData(s);
                            addData.Show();
                        }
                    }
                }
                else
                    MessageBox.Show("Данный пользователь не обнаружен!");
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                   /* string sqlExpression = "SELECT * FROM users";
                    SqlCommand command2 = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command2.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4), reader.GetName(5));

                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object name = reader.GetValue(1);
                            object surname = reader.GetValue(2);
                            object login = reader.GetValue(3);
                            object pass = reader.GetValue(4);
                            object status = reader.GetValue(5);

                        Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4} \t{5}", id, name, surname, login, pass, status);
                        }
                    }

                    reader.Close();*/
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////            
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
