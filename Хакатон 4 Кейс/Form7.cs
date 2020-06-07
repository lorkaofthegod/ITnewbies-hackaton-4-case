using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хакатон_4_Кейс
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        
        private void Form7_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#707070");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Subscribers.IsSubsribed == false)
            {
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
                Subscribers.Count = label3.Text;
                Subscribers.IsSubsribed = true;
                button1.Text = "Отписаться";
            }
            else
            {
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) - 1);
                Subscribers.Count = label3.Text;
                Subscribers.IsSubsribed = false;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
