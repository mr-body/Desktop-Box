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

namespace Desktop_Box.Formularios.Dialogos.rem.rem
{
    public partial class edit : Form
    {
        public edit(int preco, string code, int qtd)
        {
            InitializeComponent();
            Preco = preco;
            Barcode = code;
            Quantidade = qtd;
            verif();
        }

        int Preco;
        string Barcode;
        int Quantidade;
        int Reqtd;

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();


        void verif()
        {
            conn.Open();
            SqlCeCommand cmd = new SqlCeCommand("select * from stock where barcode = " + Barcode + "", conn);
            SqlCeDataReader da = cmd.ExecuteReader();
            if (da.Read() == true)
            {
                //Codigo
                Reqtd = int.Parse(da.GetValue(4).ToString());
            }
            conn.Close();
        }

        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddCarinho_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Quant.Text != "")
                {
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE save_vendidos set Qtd = '" + txt_Quant.Text + "' where barcode = '" + Barcode + "' and ID='" + Desktop_Box.Classes.details.coderen + "'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE save_vendidos set Total = '" + (int.Parse(txt_Quant.Text) * Preco) + "' where barcode = '" + Barcode + "' and ID='" + Desktop_Box.Classes.details.coderen + "'";
                    cmd.ExecuteNonQuery();

                    if (Quantidade > int.Parse(txt_Quant.Text))
                    {
                        int calculo1 = Quantidade - int.Parse(txt_Quant.Text);
                        int calculo2 = calculo1 + Reqtd;
                        cmd.CommandText = "UPDATE stock set Qtd = '" + calculo2 + "' where barcode = '" + Barcode + "'";
                        cmd.ExecuteNonQuery();
                    }
                    if (int.Parse(txt_Quant.Text) > Quantidade)
                    {
                        int calculo1 = int.Parse(txt_Quant.Text) - Quantidade;
                        int calculo2 = Reqtd - calculo1;
                        cmd.CommandText = "UPDATE stock set Qtd = '" + calculo2 + "' where barcode = '" + Barcode + "'";
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Preencha o campo de texto");
                }
            }
            catch { }
            this.Close();
        }
    }
}
