﻿using System;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            NameField.Text = "Введите имя";
            NameField.ForeColor = Color.Gray;
            SurField.Text = "Введите фамилию";
            SurField.ForeColor = Color.Gray;
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;
            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;
            PassField.UseSystemPasswordChar = false;
        }

        private void addUser_MouseMove(object sender, MouseEventArgs e)
        {
            addUser.ForeColor = Color.Black;
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите имя";
                NameField.ForeColor = Color.Gray;
            }
        }

        private void SurField_Enter(object sender, EventArgs e)
        {
            if (SurField.Text == "Введите фамилию")
            {
                SurField.Text = "";
                SurField.ForeColor = Color.Black;
            }
        }

        private void SurField_Leave(object sender, EventArgs e)
        {
            if (SurField.Text == "")
            {
                SurField.Text = "Введите фамилию";
                SurField.ForeColor = Color.Gray;
            }
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

        private void Registration_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Archive_Demo.Properties.Settings.IPSArchiveConnectionString"].ConnectionString;
            string sql = "INSERT INTO Users(Name,Surname,Login,Password,Status,Log_Time) VALUES ('" + NameField.Text + "','" + SurField.Text + "','" + LoginField.Text + "','" + PassField.Text + "', 0, '" + DateTime.Now  + "');";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Подключение: Да");
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
                DialogResult dr = MessageBox.Show("Пользователь успешно зарегистрирован. Перейти к авторизации?", "Регистрация", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
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
    }
}
