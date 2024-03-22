using Desktop_Box.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Box.users
{
    public partial class Despesas : Form
    {
        public Despesas()
        {
            InitializeComponent();
            display();
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
            cmd.CommandText = "Select * from despesas";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
            dataadp.Fill(dta);
            dados.DataSource = dta;
            conn.Close();
            somar();
        }

        public string total="0";
        private void somar()
        {

            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            try
            {
                for (A = 0; A < dados.Rows.Count; ++A)
                {
                    B += Convert.ToInt32(dados.Rows[A].Cells["Total"].Value);
                    total = B.ToString();
                    ValorDespesas.Text = B.ToString("N2");
                }

            }
            catch { }

            try
            {
                for (C = 0; C < dados.Rows.Count; ++C)
                {
                    D += Convert.ToInt32(dados.Rows[C].Cells["Quantidade"].Value);
                    Qtd.Text = D.ToString();
                }
            }
            catch { }

            itens.Text = dados.Rows.Count.ToString();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into despesas values('" + (dados.Rows.Count + 1).ToString() + "','" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox4.Text + "','" + guna2TextBox5.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                display();
            }
            catch { }

            guna2TextBox1.Text = guna2TextBox2.Text = guna2TextBox3.Text = guna2TextBox4.Text = guna2TextBox5.Text = "";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = DateTime.Now.ToString("d");
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = details.id_usuario;
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deletar registo", "Aapgar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from despesas where id='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    display();
                }
                catch { }
            }
            else
                return;
        }

        private void dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
