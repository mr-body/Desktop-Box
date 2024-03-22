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
    public partial class trocos : Form
    {
        public trocos()
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
            cmd.CommandText = "Select * from trocos";
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

            for (A = 0; A < dados.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dados.Rows[A].Cells[3].Value);
                Totall.Text = B.ToString("N2")+"kz";
                total = B.ToString();
                ValorTrocos.Text = B.ToString("d");

            }


            for (C = 0; C < dados.Rows.Count; ++C)
            {
                D += Convert.ToInt32(dados.Rows[C].Cells[3].Value);
                itens.Text = dados.Rows.Count.ToString();
            }
        }

        private void dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
