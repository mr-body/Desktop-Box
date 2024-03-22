using Desktop_Box.Classes;
using Desktop_Box.Formularios;
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

namespace Desktop_Box
{
    public partial class escolha : Form
    {
        public escolha()
        {
            InitializeComponent();
            display();
            txtNome.Text = details.id_usuario;
            txtTipo.Text = details.tipo;

            guna2ShadowForm1.SetShadowForm(this);
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide(); 
        }

        void display()
        {
            if (details.tipo != "Gerente")
            {
                guna2Button1.Enabled = false;
                gunaButton8.Enabled=false;
            }
            string[] ficheiro = Directory.GetFiles(@".\db\repositorios", "*sdf*.*");

            foreach (string item in ficheiro)
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(item));
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new create().ShowDialog(); 
            listBox1.Items.Clear();      
            display();
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            details.db_name = listBox1.SelectedItem.ToString();
            if (details.tipo == "Gerente")
            {
                guna2Button1.Enabled = true;
                gunaButton8.Enabled = true;
            }
            else
            {
                guna2Button1.Enabled = true;
            }
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cançelar estas venda", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(@".\db\repositorios\" + details.db_name + ".sdf");
                listBox1.Items.Clear();
                display();
                MessageBox.Show("Deletado som sucesso!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem.ToString() != "")
                {
                    guna2Button1.Enabled = true;
                }
            }
            catch
            {
                guna2Button1.Enabled = false;
            }
        }
    }
}
