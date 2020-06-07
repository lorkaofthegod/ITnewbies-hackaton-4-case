using Microsoft.VisualBasic.ApplicationServices;
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
using System.IO;

namespace Хакатон_4_Кейс
{
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
        }

        private void userEdit_Click(object sender, EventArgs e)
        {
            string isindata = "NULL";
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

                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand checkoldpassword = new MySqlCommand("SELECT COUNT(*) FROM users WHERE (userid=@userid) && (password=@password)", connection);
                checkoldpassword.Parameters.AddWithValue("@userid", Idhandler.Value);
                checkoldpassword.Parameters.AddWithValue("@password", Oldpassword.Text);
                isindata = checkoldpassword.ExecuteScalar().ToString();
                //обновление краткого описания закончилось
                if (isindata != "0")
                {
                    MySqlCommand newpass = new MySqlCommand("UPDATE users SET password=@password WHERE userid=@userid", connection);
                    newpass.Parameters.AddWithValue("@password", Newpassword.Text);
                    newpass.Parameters.AddWithValue("@userid", Idhandler.Value);
                    newpass.ExecuteNonQuery();
                    Microsoft.VisualBasic.Interaction.MsgBox("Пароль изменен");
                }
                else
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("Пароли не совпадают!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(ex.ToString());
            }
        }

        private void profileForm_Load_1(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#707070");
            panel1.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            panel2.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            textBox1.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            profilePic.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            richTextBox1.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            panel3.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            panel4.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            Oldpassword.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            Newpassword.BackColor = ColorTranslator.FromHtml("#7A7A7A");
            string img64;
            MySqlConnection connection;
            string server = "192.99.1.185";
            string database = "bomj1179_3eqhq6";
            string user = "3eqhq6";
            string pass = "vFt-MxX-bsQ-ruW";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand getDesription = new MySqlCommand("SELECT briefDescription FROM users_information WHERE userid=@userid", connection);
            getDesription.Parameters.AddWithValue("@userid", Idhandler.Value);
            richTextBox1.Text = getDesription.ExecuteScalar().ToString();
            MySqlCommand getNameSurname = new MySqlCommand("SELECT name,surname FROM users_information WHERE userid=@userid", connection);
            getNameSurname.Parameters.AddWithValue("@userid", Idhandler.Value);
            MySqlDataReader reader = getNameSurname.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString() + "   " + reader[1].ToString();
            }
            reader.Close();
            MySqlCommand getimg = new MySqlCommand("SELECT pic FROM users_information WHERE userid=@userid", connection);
            getimg.Parameters.AddWithValue("@userid", Idhandler.Value);
            img64 = getimg.ExecuteScalar().ToString();
            try
            {
                if (img64 != null)
                {
                    profilePic.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(img64))); ;
                }
            }
            catch (Exception ex)
            {
            }
            connection.Close();
        }

        private void loadPic_Click(object sender, EventArgs e)
        {
            string img64;
            MySqlConnection connection;
            string server = "192.99.1.185";
            string database = "bomj1179_3eqhq6";
            string user = "3eqhq6";
            string pass = "vFt-MxX-bsQ-ruW";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {
                //Вызываем окно проводника
                OpenFileDialog opfd = new OpenFileDialog();
                //Растягиваем во весь пикчур бокс изображение
                profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
                //Если выбрали то
                if (opfd.ShowDialog(this) == DialogResult.OK)
                {
                    //Открываем в пикчур бокс
                    profilePic.Image = Image.FromFile(opfd.FileName);

                    img64 = Convert.ToBase64String(File.ReadAllBytes(opfd.FileName));
                    MySqlCommand sendimage = new MySqlCommand("UPDATE users_information SET pic=@pic WHERE userid=@userid ", connection);
                    sendimage.Parameters.AddWithValue("@pic", img64);
                    sendimage.Parameters.AddWithValue("@userid", Idhandler.Value);
                    sendimage.ExecuteNonQuery();

                }
                else
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("Вы ничего не выбрали");
                }
            }
            catch (Exception ex)
            {
            }
            connection.Close();
        }

        private void profileForm_Shown(object sender, EventArgs e)
        {
            string img64;
            MySqlConnection connection;
            string server = "192.99.1.185";
            string database = "bomj1179_3eqhq6";
            string user = "3eqhq6";
            string pass = "vFt-MxX-bsQ-ruW";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand getimg = new MySqlCommand("SELECT pic FROM users_information WHERE userid=@userid", connection);
            getimg.Parameters.AddWithValue("@userid", Idhandler.Value);
            img64 = getimg.ExecuteScalar().ToString();
            try
            {
                if (img64 != null)
                {

                    profilePic.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(img64))); ;
                }
            }
            catch (Exception ex)
            {
            }


            connection.Close();

        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            //Обновление краткого описания 
            MySqlConnection connection;
            string server = "192.99.1.185";
            string database = "bomj1179_3eqhq6";
            string user = "3eqhq6";
            string pass = "vFt-MxX-bsQ-ruW";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {
                MySqlCommand updateBriefDescription = new MySqlCommand("UPDATE users_information SET briefDescription=@briefDescription WHERE userid=@userid", connection);
                updateBriefDescription.Parameters.AddWithValue("@userid", Idhandler.Value);
                updateBriefDescription.Parameters.AddWithValue("@briefDescription", richTextBox1.Text);
                updateBriefDescription.ExecuteNonQuery();
            }
            catch { }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
