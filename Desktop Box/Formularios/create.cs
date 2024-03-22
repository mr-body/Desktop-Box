using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Box.Formularios
{
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            File.Copy(@".\db\database.sdf", @".\db\repositorios\" + guna2TextBox2.Text + ".sdf");
            this.Close();
        }
    }
}
