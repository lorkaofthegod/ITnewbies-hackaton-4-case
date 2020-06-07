using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Хакатон_4_Кейс
{
    public partial class registration : Form
    {
        authorization authorization1 = new authorization();
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка заполненных полей
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Заполните все поля!");
            }
            else
            {
                MySqlConnection connection;
                string server = "192.99.1.185";
                string database = "bomj1179_3eqhq6";
                string user = "3eqhq6";
                string password = "vFt-MxX-bsQ-ruW";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MySqlCommand checklogin = new MySqlCommand("SELECT login, mail FROM users WHERE ((mail = @mail)||(login = @login))", connection);
                    checklogin.Parameters.AddWithValue("@login", textBox2.Text);
                    checklogin.Parameters.AddWithValue("@mail", textBox3.Text);
                    MySqlDataReader reader = checklogin.ExecuteReader();
                    string dmail = "NULL";
                    string dlogin = "NULL";
                    while (reader.Read())
                    {
                        dlogin = reader[0].ToString();
                        if (dlogin != textBox2.Text)
                        {
                            dlogin = "NULL";
                        }
                        dmail = reader[1].ToString();
                    }
                    reader.Close();
                    // проверка уникальности введеных логина и пароля и отправка их в БД
                    if ((dmail == "NULL") && (dlogin == "NULL"))
                    {
                        MySqlCommand values = new MySqlCommand("insert into users (login,password,mail) values(@Password,@Login,@Email)", connection);
                        values.Parameters.AddWithValue("@Password", textBox1.Text);
                        values.Parameters.AddWithValue("@Login", textBox2.Text);
                        values.Parameters.AddWithValue("@Email", textBox3.Text);
                        values.ExecuteNonQuery();
                        MySqlCommand namesurname = new MySqlCommand("insert into users_information (name,surname) values(@name,@surname)", connection);
                        namesurname.Parameters.AddWithValue("@name", textBox5.Text);
                        namesurname.Parameters.AddWithValue("@surname", textBox6.Text);
                        namesurname.ExecuteNonQuery();

                        Microsoft.VisualBasic.Interaction.MsgBox("Аккаунт успешно зарегистрирован");
                    }
                    if (dmail == textBox3.Text)
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("Введеный email уже используется, пожайлуста,введите другой");
                    }
                    if (dlogin == textBox2.Text)
                    {

                        Microsoft.VisualBasic.Interaction.MsgBox("Введеный логин уже используется, пожайлуста,введите другой");
                    }
                }
                catch (Exception ex)
                {
                }
                connection.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Создаем формы
            authorization authorization1 = new authorization();
            //Закрываем либо открываем формы
            this.Hide();
            this.Close();
            authorization1.ShowDialog();
        }
    }
}
