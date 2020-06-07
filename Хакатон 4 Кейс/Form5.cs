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
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml;

namespace Хакатон_4_Кейс
{
    public partial class posts : Form
    {
        public posts()
        {
            InitializeComponent();
        }

        private void posts_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            openChildFrom(new Form8());
        }
    }
}
