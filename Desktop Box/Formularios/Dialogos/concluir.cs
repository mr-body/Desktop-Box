using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_Box.Formularios;
using Desktop_Box.Classes;
using System.Data.SqlServerCe;
using Guna.UI.WinForms;

namespace Desktop_Box.Formularios.Dialogos
{
    public partial class concluir : Form
    {
        public concluir()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            string code = details.code;
            label9.Text = code;
            lblTotal.Text = total.ToString("N2");

        }      

        public  string code;
        public  string maquina;
        public  double total;
        string tipo = "Dinheiro Fisico";

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        private void btn_AddCarinho_Click(object sender, EventArgs e)
        {
            if (txt_Pagamento.Text != "")
            {
                //Verificando Pagamento 
                if (double.Parse(lbltroco.Text) >= 0)
                {
                    printfactura();
                    insert_delete();
                    details.id_clinte = null;
                }
                else
                {
                    MessageBox.Show("O senhor nao pagou o suficiente pelos produtos comprados");
                }
            }
            else
            {
                MessageBox.Show("O senhor Ainda nao efectou o pagamento dos produtos");
            }
        }

        void insert_delete()
        {            
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from vendidos";
                cmd.ExecuteNonQuery();
                double Total = double.Parse(lblTotal.Text);
                double desconto = double.Parse(guna2TextBox1.Text);

                double calculo = Total - desconto;

                cmd.CommandText = "insert into vendas values('"+details.id_clinte + "','" + details.id_usuario + "','" + details.ID_Hora + "','" + details.tikerQuantidade + "','" + lblTotal.Text + "','" + txt_Pagamento.Text + "','" + desconto + "','" + calculo + "','" + lbltroco.Text + "','" + tipo + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                
                conn.Open();
                SqlCeCommand Cmd = conn.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "insert into save_vendas values('" + details.ID_vendas + "','" + details.id_clinte + "','" + details.id_usuario + "','" + details.ID_Hora + "','" + details.tikerQuantidade + "','" + lblTotal.Text + "','" + txt_Pagamento.Text + "','" + desconto + "','" + calculo + "','" + lbltroco.Text + "','" + tipo + "')";
                Cmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
        }
        void printfactura()
        {
            Ticket ticket = new Ticket();
            //ticket.HeaderImage = Image.FromFile(@".\images\logoprint.png");
            ticket.AddHeaderLine("Mata Sede");
            ticket.AddHeaderLine("Desktop Box");
            ticket.AddHeaderLine("Sistema de Venas");
            ticket.AddSubHeaderLine("Walter@gmail.com");
            ticket.AddSubHeaderLine("Code: " + details.id_clinte);
            //===================================================
            ticket.AddItem("DATA: ", DateTime.Now.ToString("d"), "");
            ticket.AddItem("HORA: ", DateTime.Now.ToLongTimeString(), "");
            ticket.AddItem("NIF: ", "", "");
            ticket.AddItem("IVA: ", "", "");
            ticket.AddItem("CLINETE: ", "", details.coderen);
            ticket.AddItem("PAGO POR:", "", tipo);
            ticket.AddItem("BANCO: ", "", "");
            ticket.AddItem("", "", "");
            ticket.AddItem("QTD", "PRODUTO", "PRECO");
            ticket.AddItem("", "", "");
            show_vendas tiker = new show_vendas();
            foreach (DataGridViewRow r in tiker.dados.Rows)
            {
                // QTD                                       //PRODUTO                 //PRECO
                ticket.AddItem(r.Cells[3].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[4].Value.ToString() + "kz"); //imprime una linea de descripcion
            }
            //=====================================================
            ticket.AddTotal("TOTAL", double.Parse(lblTotal.Text).ToString() + "kz");
            ticket.AddTotal("DESC", double.Parse(guna2TextBox1.Text).ToString() + "kz");
            ticket.AddTotal("PAGO", double.Parse(txt_Pagamento.Text).ToString() + "kz");
            ticket.AddTotal("", "");
            ticket.AddTotal("TROCO", double.Parse(lbltroco.Text).ToString() + "kz");

            ticket.AddFooterLine("Obrigado volte sempre....");
            //ticket.PrintTicket("80mm Series Printer");
            ticket.PrintTicket();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {    

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Dinheiro fisico";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "TPA";
        }


        private void txt_Pagamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = double.Parse(lblTotal.Text);
                double pagamento = double.Parse(txt_Pagamento.Text);

                double caluclo = pagamento - total;
                lbltroco.Text = caluclo.ToString();
            }
            catch { }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = double.Parse(lblTotal.Text);
                double pagamento = double.Parse(txt_Pagamento.Text);
                double desconto = double.Parse(guna2TextBox1.Text);

                double caluclo = (pagamento - total) + desconto;
                lbltroco.Text = caluclo.ToString();
            }
            catch { }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into trocos values('" + details.id_clinte + "','" + details.id_usuario + "','" + DateTime.Now.ToShortDateString() + "','" + lbltroco.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Troco Cadastrado na base de dados");
                gunaButton4.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            GunaButton botao = (GunaButton)sender;
            txt_Pagamento.Text = txt_Pagamento.Text + botao;
        }
    }
}
