using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_Box.Classes;
using System.Data.SqlServerCe;
using System.Drawing.Text;

namespace Desktop_Box.Formularios
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            string code = details.code; 
            codigo.Text = code;
            nome.Text = details.id_usuario;
            perfil.Image = Image.FromFile(@".\contas\" + code + ".png");
            display();
            select();

            if (details.tipo != "Gerente")
            {
                gunaShadowPanel1.Enabled = false;
            }
        }

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        //Display da base de dados
        void display()
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from relatorio";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
            dataadp.Fill(dta);
            dados.DataSource = dta;
            conn.Close();
            somar();
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
            contentor.Controls.Add(childForm);
            contentor.Tag = childForm;
            contentor.BringToFront();
            childForm.Show();
        }

        public string total="0";
        private void somar()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            for (A = 0; A < dados.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dados.Rows[A].Cells[4].Value);
                total = B.ToString();
                Total.Text = B.ToString("N2")+"kz";
                ValorVendas.Text = B.ToString("N2")+"kz";
            }


            for (C = 0; C < dados.Rows.Count; ++C)
            {
                //D += Convert.ToInt32(dados.Rows[C].Cells[3].Value);

                Quantidades.Text = dados.Rows.Count.ToString(); ;
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
          
        }

        void select()
        {
            try
            {
                label13.Text = dados.SelectedRows[0].Cells[0].Value.ToString();
                label14.Text = dados.SelectedRows[0].Cells[2].Value.ToString();
                label15.Text = dados.SelectedRows[0].Cells[1].Value.ToString();
                double valor=double.Parse(dados.SelectedRows[0].Cells[3].Value.ToString());
                label16.Text = valor.ToString("N2")+"kz";
            }
            catch { }
        }

        private void guna2DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
                gunaTransition1.ShowSync(gunaShadowPanel1);
                select();
        }

        private void gunaCircleButton17_Click(object sender, EventArgs e)
        {
          
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton7_Click(object sender, EventArgs e)
        {
            gunaTransition1.Hide(gunaShadowPanel1);
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            Deletar(); 
        }

        private void Deletar()
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from relatorio where Data='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            display();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void dados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dados.Visible = false;
            gunaLinePanel1.Visible = false;
            gunaLinePanel3.Visible = false;
            openChildForm(new re_Rela(dados.SelectedRows[0].Cells[0].Value.ToString()));
        }
    }
}
