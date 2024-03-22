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

namespace Desktop_Box.Formularios
{
    public partial class re_Rela : Form
    {
        public re_Rela(string id)
        {
            InitializeComponent();
            label4.Text = id;
        }           
                      
        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        string ID;

        //Display da base de dados
        void display()
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from save_vendas where ID_vendas=" + label4.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
            dataadp.Fill(dta);
            dados.DataSource = dta;
            conn.Close();
            somar();
        }

        private void somar()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            for (A = 0; A < dados.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dados.Rows[A].Cells[4].Value);    
                ValorVendas.Text = B.ToString("N2") + "kz";
                label1.Text = B.ToString("N2") + "kz";
            }


            for (C = 0; C < dados.Rows.Count; ++C)
            {
                //D += Convert.ToInt32(dados.Rows[C].Cells[3].Value);

                ValorStock.Text = dados.Rows.Count.ToString(); ;
            }
        }

        private void re_Rela_Load(object sender, EventArgs e)
        {
            try
            {
                display();
                dados.Columns["ID_vendas"].Visible = false;
                dados.Columns["ID"].Visible = false;
                dados.Columns["Data"].Visible = false;
            }
            catch(Exception ex)
                MessageBox.Show("ERRO:" ex);
        }
    }
}
