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
   
    public partial class Form8 : Form
    {
        int k = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

      
        }
        public void openChildFrom(Form childForm)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Subscribers.IsSubsribed == false)
            {

                if (k == 0)
                {
                    label7.Text = Convert.ToString(Convert.ToInt32(label7.Text) + 1);
                    k += 1;
                }
                else
                {
                    label7.Text = Convert.ToString(Convert.ToInt32(label7.Text) - 1);
                    k -= 1;
                }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {   if (Idhandler.Value != "1")
            {
                openChildFrom(new Form7());
            }
            else
            {
                openChildFrom(new profileForm());
            }
        }

        private void Form8_Shown(object sender, EventArgs e)
        {
            if (Idhandler.Value == "1")
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
            if (Subscribers.IsSubsribed == true)
            {
                button2.Enabled = false;
                label7.Text = Subscribers.Count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (Idhandler.Value != "1")
            {
                richTextBox3.ReadOnly = true;
                MySqlCommand getNameSurname = new MySqlCommand("SELECT name,surname FROM users_information WHERE userid=@userid", connection);
                getNameSurname.Parameters.AddWithValue("@userid", Idhandler.Value);
                MySqlDataReader reader = getNameSurname.ExecuteReader();
                while (reader.Read())
                {
                    label4.Text = reader[0].ToString() + "   " + reader[1].ToString();
                }
                reader.Close();
                MySqlCommand getimg = new MySqlCommand("SELECT pic FROM users_information WHERE userid=@userid", connection);
                getimg.Parameters.AddWithValue("@userid", Idhandler.Value);
                img64 = getimg.ExecuteScalar().ToString();
                button1.Enabled = false;
                try
                {
                    if (img64 != null)
                    {
                        pictureBox3.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(img64))); ;
                    }
                }
                catch (Exception ex)
                {
                   
                }
                connection.Close();
            }
          
        }
    }
}
