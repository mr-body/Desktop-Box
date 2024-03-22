using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using Desktop_Box.Classes;
using Desktop_Box.Formularios.Dialogos;
using System.Data.SqlServerCe;
using System.Drawing.Text; 

namespace Desktop_Box.Formularios
{
    public partial class Precario : Form
    {
        public Precario()
        {
            InitializeComponent();
            display();
            lblcode.Text = details.code;
            label22.Text = dados.Rows.Count.ToString();

            if (details.tipo != "Gerente")
            {
                gunaButton4.Enabled = false;
                gunaButton3.Enabled = false;
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
            cmd.CommandText = "Select * from stock";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
            dataadp.Fill(dta);
            dados.DataSource = dta;
            conn.Close();
            somar();
        }

        public string total;

        private void somar()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            for (A = 0; A < dados.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dados.Rows[A].Cells[6].Value);
                total = B.ToString();
                Totall.Text = B.ToString("N2")+"kz";
                ValorVendas.Text = B.ToString("N2")+"kz";
            }


            for (C = 0; C < dados.Rows.Count; ++C)
            {
                D += Convert.ToInt32(dados.Rows[C].Cells[3].Value);
                label14.Text = D.ToString();
                label22.Text = dados.Rows.Count.ToString();
                ValorStock.Text = D.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void dados_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile("./font/LibreBarcode128Text-Regular.ttf");
                barcode.Font = new Font(pfc.Families[0], 25, FontStyle.Regular);
            }
            catch { }
            select();
        }

        private void Deletar()
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from stock where barcode='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            display();

            try
            {
                File.Delete(@".\images\" + dados.SelectedRows[0].Cells[0].Value.ToString() + ".png");
            }
            catch { }
            
        }


        void select()
        {
            barcode.Text = dados.SelectedRows[0].Cells[0].Value.ToString();
            nome.Text = dados.SelectedRows[0].Cells[1].Value.ToString();
            preco.Text = dados.SelectedRows[0].Cells[5].Value.ToString();
            exp.Text = dados.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            Deletar();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            addStock f = new addStock();
            f.ShowDialog();
            display();
        }

        moduleExcel excelImp = new moduleExcel();

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string title = " Excel Export by Camellabs";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "DesktopBox.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                excelImp.ToCsV(dados, "Walter Santana","16", "Golf 2", "Teste do meu aplicativo", sfd.FileName);
                MessageBox.Show("Concluido");
            }
        }

        private void dados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
