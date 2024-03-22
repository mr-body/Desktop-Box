    using Desktop_Box.Classes;
using Desktop_Box.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Box.Report
{
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
            data.Text = data2.Text = DateTime.Now.ToString("d");            

            code.Text = details.ID_vendas;
            user.Text = details.id_usuario;
            tipo.Text = details.tipo;
            numero.Text = details.numero;
            perfil.Image = Image.FromFile(@".\contas\" + details.code + ".png");

        //    Vendas f = new Vendas();
        //    ValorVendas.Text = f.stotal;

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
            cmd.CommandText = "Select ID,Usuario,Data,Qtd,[Valor.unit],Desconto,Total,Pagamento,Troco,MTC from vendas";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
            dataadp.Fill(dta);
            dados.DataSource = dta;
            conn.Close();
            somar();

            dados.Columns["ID"].Visible = false;
            dados.Columns["Usuario"].Visible = false;
            dados.Columns["Data"].Visible = false;
        }

        public string stotal;

        private void somar()
        {
            try
            {
                int A = 0;
                int B = 0;
                for (A = 0; A < dados.Rows.Count; ++A)
                {
                    B += Convert.ToInt32(dados.Rows[A].Cells["Total"].Value);
                    stotal = B.ToString();
                    ValorVendas.Text = B.ToString("N2") + "kz";
                    label4.Text = "Itens: " + dados.Rows.Count;
                }

                int C = 0;
                int D = 0;
                for (C = 0; C < dados.Rows.Count; ++C)
                {
                    D += Convert.ToInt32(dados.Rows[C].Cells["Qtd"].Value);
                    label6.Text = D.ToString();
                }
            }
            catch { }
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            PanelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        void recolheraddos()
        {
            Vendas v = new Vendas();

            //Produtos
            conn.Open();
            SqlCeCommand cmd = new SqlCeCommand("select distinct Produto from save_vendidos", conn);
            SqlCeDataReader da;
            da = cmd.ExecuteReader();
            if (da.Read() == true)
            {
                do
                {
                    listBox1.Items.Add(da["Produto"].ToString().ToUpper());
                }
                while (da.Read());

            }  
            //Categorias
            SqlCeCommand Cmd = new SqlCeCommand("select distinct Categoria from save_vendidos", conn);
            SqlCeDataReader Da;
            Da = Cmd.ExecuteReader();
            if (Da.Read() == true)
            {
                do
                {
                    listBox2.Items.Add(Da["Categoria"].ToString().ToUpper());
                }
                while (Da.Read());

            }
            conn.Close();
        }

        private void vendas_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("./font/LibreBarcode128Text-Regular.ttf");
            code.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            recolheraddos();
            Print(PanelPrint);
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pegearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pegearea.Width / 2) - (this.PanelPrint.Width / 2), this.PanelPrint.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
