using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Box.users
{
    public partial class contas : Form
    {
        public contas()
        {
            InitializeComponent();
            display();
            qtd.Text = dados.Rows.Count.ToString();
        }

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\db_users.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        void insert()
        {
            try
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO contas Values('" + nome.Text + "','" + sexo.Text + "','" + idade.Text + "','" + numero.Text + "','" + cargo.Text + "','" + inicio.Text + "','Sen registo','" + code.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { MessageBox.Show("Deu Ruim"); }
        }

        //Display da base de dados
        void display()
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from contas";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
            dataadp.Fill(dta);
            dados.DataSource = dta;
            conn.Close();

            dados.Columns["Idade"].Visible = false;
            dados.Columns["Data do contrato"].Visible = false;
            dados.Columns["Fim do contrato"].Visible = false;
            dados.Columns["Code"].Visible = false;
        }

        string caminhoImage;

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Title = "Escolha um perfil para o produto";
            foto.InitialDirectory = @"C:\";
            foto.Filter = "PNG Images (*.png) |*png" + "|" + "GIF Images (*.gif) |*gif" + "|" + "Jpeg Images (*.jpg) |*jpg" + "|" + "BMP files (*.bmp)|*.bmp" + "|" + "PNG images (*.png)|*.png";

            if (foto.ShowDialog() == DialogResult.Cancel) return;

            perfil.Image = Image.FromFile(foto.FileName);
            caminhoImage = foto.FileName;
            foto.Dispose();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            insert();
            try
            {
                File.Copy(caminhoImage, @".\Contas\" + code.Text     + ".png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }    
            display();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            code.Text = DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Increment(10);
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
            }
        }

        private void dados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Deletar Registo de troco", "Registo de troco", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from contas where Nome='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    display();
                }
                catch { }
            }
            else
                return;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deletar Registo de troco", "Registo de troco", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from trocos where Codigo='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    display();
                }
                catch { }
            }
            else
                return;
        }
    }
}
