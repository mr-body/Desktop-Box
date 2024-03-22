using Desktop_Box.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Box.users
{
    public partial class home : Form
    {
        public home(Form childForm)
        {
            InitializeComponent();
            nome.Text = details.id_usuario;
            admin.Text = details.tipo;
            perfil.Image = Image.FromFile(@".\contas\" + details.code + ".png");
            openChildForm(childForm);
        }

        // Abrir paines containers
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Contentor.Controls.Add(childForm);
            Contentor.Tag = childForm;
            Contentor.BringToFront();
            childForm.Show();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new contas());
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new trocos());
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Despesas());
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new Main());
        }
    }
}
