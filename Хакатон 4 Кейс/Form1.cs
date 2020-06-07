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
using FontAwesome.Sharp;

namespace Хакатон_4_Кейс
{
    
    public partial class Form1 : Form
    {
        string userid;
        authorization authorization = new authorization();
        public Form1()
        {
            InitializeComponent();
        }

        public void openChildFrom(Form childForm)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorization.ShowDialog();
        }


        public void profileBtn_Click(object sender, EventArgs e)
        {
            openChildFrom(new profileForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildFrom(new posts());
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            userid = Idhandler.Value;
            if (userid == null) 
            {
                panel1.Visible = false;
            }
            else { 
                panel1.Visible = true;
                emblem.Visible = false;
                welcome.Visible = false;
                button1.Visible = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildFrom(new Form6());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new Form9());
        }
    }
}
