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
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Создаем формы
            registration registration1 = new registration();
            //Закрываем либо открываем формы
            this.Close();
            this.Hide();
            registration1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            string userid = "NULL";
            //Проверка заполненных полей
            if (password.Text == "" || login.Text == "")
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Заполните все поля!");
            }
            else
            {
                MySqlConnection connection;
                
                string server = "192.99.1.185";
                string database = "bomj1179_3eqhq6";
                string user = "3eqhq6";
                string pass = "vFt-MxX-bsQ-ruW";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
                connection = new MySqlConnection(connectionString);
                try
                {
                   
                    string[] users = new string[3];
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MySqlCommand checkuser =new MySqlCommand( "SELECT * FROM users WHERE (login=@login) && (@password=password)" , connection);
                    checkuser.Parameters.AddWithValue("@login", login.Text);
                    checkuser.Parameters.AddWithValue("@password", password.Text);
                    MySqlDataReader reader = checkuser.ExecuteReader();
                    while (reader.Read())
                    {
                        userid = reader[0].ToString();
                    }
                    reader.Close();
                    Idhandler.Value = userid;

                    if (userid == "NULL")
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("Такой учетной записи не существует");
                    }
                    else
                    {
                        Form1 main = new Form1();
                        main.Show();
                        this.Close();
                    }
                    connection.Close();
                    
                }
                catch (Exception ex)
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("Неверный логин или пароль");
                }
            }
        }
    }
}
