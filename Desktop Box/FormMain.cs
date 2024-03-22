using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;                
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Desktop_Box.messages;
using Desktop_Box.Formularios;
using Desktop_Box.Classes;
using Desktop_Box.Formularios.Dialogos;
using System.Data.SqlServerCe;
using Desktop_Box.users;

namespace Desktop_Box
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            atribuirr();

            bool connection = NetworkInterface.GetIsNetworkAvailable();
            if (connection == true)
            {
                try
                {
                    openChildForm(new Relatorio());
                }
                catch
                {
                    openChildForm(new tadabase_erro());
                }
            }
            else
            {
                openChildForm(new internet_erro());
            }
        }

        //atribuir
        public void atribuirr()
        {
            guna2ShadowForm1.SetShadowForm(this);
            label6.Text = details.db_name+" (Sistema de vendas - Desktop Box)";
            nome.Text = details.id_usuario;
            admin.Text = details.tipo;
            string code = details.code;
            perfil.Image = Image.FromFile(@".\contas\" + code + ".png");
        }

        //Move slid Panel
        public void MoveSidePanel(Control c)
        {
            Slid.Width = c.Width;
            Slid.Left = c.Left;
        }

        //zoom
       
        // Abrir paines containers
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            body.Controls.Add(childForm);
            body.Tag = childForm;
            body.BringToFront();
            childForm.Show();
        }

        private void gunaLinePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (nav.Visible == true)
                gunaTransition1.HideSync(nav);
            else
                gunaTransition1.ShowSync(nav);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Relatorio());
            MoveSidePanel(gunaAdvenceButton1);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Precario());
            MoveSidePanel(gunaAdvenceButton2);
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new Vendas());
            MoveSidePanel(gunaAdvenceButton3);
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (details.tipo == "Gerente")
            {
                openChildForm(new Desktop_Box.users.home(new Main()));
            }
            else
                MessageBox.Show("Desculpe, Mas o senhor nao tem permissoa para usar esta ferramenta", "ERRO! DE PERMISSAO");
            MoveSidePanel(gunaAdvenceButton4);
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
           
        }

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand(); 

        void insert()
        {
            Vendas f = new Vendas();
            try
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into relatorio values('" + details.ID_vendas + "','" + DateTime.Now.ToString("d") + "','" + details.id_usuario + "','" + f.ValorStock.Text + "','" + f.stotal + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from vendas";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from vendidos";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from save_vendidos";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return;
            }

        }


        private void nome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (details.tipo == "Gerente")
            {
                openChildForm(new Desktop_Box.users.home(new  contas()));
            }
            else
                MessageBox.Show("Desculpe, Mas o senhor nao tem permissoa para usar esta ferramenta", "ERRO! DE PERMISSAO");
            MoveSidePanel(gunaAdvenceButton4);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Vendas f = new Vendas();
            if (f.dados.Rows.Count > 0)
            {
                if (details.tipo == "Gerente")
                {
                    if (MessageBox.Show("Fazer o feicho de hoje?", "Feicho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        insert();
                        Application.Exit();
                    }
                    else
                        return;
                }
                else
                {
                    MessageBox.Show("Como ja foram feitas vendas de produtos o senhor(a) nao pode feichar o aplicativo sem fazer o feicho, mais como o senhor nao esta cadastrado no sistema como gerente o senhor nao porde feichar o aplicativo, sendo assim o senhor(a) tem que consultar o gerente pra fazer uma leitura das vendas e ele mesmo fazer o fecho!");
                }
            }
            else
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "delete from vendidos";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from save_vendidos";
                cmd.ExecuteNonQuery();
                conn.Close();
                Application.Exit();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (details.tipo == "Gerente")
            {
                openChildForm(new Desktop_Box.users.home(new Main()));
            }
            else
                MessageBox.Show("Desculpe, Mas o senhor nao tem permissoa para usar esta ferramenta", "ERRO! DE PERMISSAO");
            MoveSidePanel(gunaAdvenceButton4);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (details.tipo == "Gerente")
            {
                openChildForm(new Desktop_Box.users.home(new Despesas()));
            }
            else
                MessageBox.Show("Desculpe, Mas o senhor nao tem permissoa para usar esta ferramenta", "ERRO! DE PERMISSAO");
            MoveSidePanel(gunaAdvenceButton4);
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (details.tipo == "Gerente")
            {
                openChildForm(new Desktop_Box.users.home(new trocos()));
            }
            else
                MessageBox.Show("Desculpe, Mas o senhor nao tem permissoa para usar esta ferramenta", "ERRO! DE PERMISSAO");
            MoveSidePanel(gunaAdvenceButton4);
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            if (details.tipo == "Gerente")
            {
                openChildForm(new Desktop_Box.users.home(new contas()));
            }
            else
                MessageBox.Show("Desculpe, Mas o senhor nao tem permissoa para usar esta ferramenta", "ERRO! DE PERMISSAO");
            MoveSidePanel(gunaAdvenceButton4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.Year.ToString();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            new reconta().ShowDialog();

        }
    }
}
