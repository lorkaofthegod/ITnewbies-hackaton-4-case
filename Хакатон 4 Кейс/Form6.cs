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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#707070");
        }

        private void userEdit_Click(object sender, EventArgs e)
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
            connection.Open();
            try
            {
                if (textpost.Text.Length <= 50 || theme.Text.Length < 15)
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("Минимальное количество символов в названии темы: 15. Минимальное количество символов в посте: 50");
                }
                else
                {
                    MySqlCommand sendpotsinfo = new MySqlCommand("INSERT INTO posts (userid,header,textmessage) values(@userid,@header,@textmessage)", connection);
                    sendpotsinfo.Parameters.AddWithValue("@userid", Idhandler.Value);
                    sendpotsinfo.Parameters.AddWithValue("@header", theme.Text);
                    sendpotsinfo.Parameters.AddWithValue("@textmessage", textpost.Text);
                    sendpotsinfo.ExecuteNonQuery();
                    Microsoft.VisualBasic.Interaction.MsgBox("Пост создан!");
                }
            }
            catch (Exception ex)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(ex.ToString());
            }

            connection.Close();
        }

        private void textpost_Click(object sender, EventArgs e)
        {
            textpost.Text = "";
        }

        private void theme_Click(object sender, EventArgs e)
        {
            theme.Text = "";
        }
    }
}
