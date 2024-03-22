using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_Box.Formularios.Dialogos;
using System.Data.SqlServerCe;
using Desktop_Box.Classes;
using Desktop_Box.Formularios.Dialogos.rem;
using System.Drawing.Text;
using System.Drawing.Printing;
using Desktop_Box.Report;

namespace Desktop_Box.Formularios
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();

            if (details.ID_vendas == null)
            {
              details.ID_vendas = DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();
              details.ID_Hora = DateTime.Now.ToString("d");
            } 
            string code = details.code;
            cargo.Text = details.tipo;
            nome.Text = details.id_usuario;
            perfil.Image = Image.FromFile(@".\contas\" + details.code + ".png");
            label20.Text = details.code;
            label25.Text = DateTime.Now.ToLongDateString();
            display();

            if (details.tipo != "Gerente")
            {
                guna2Button2.Enabled = false;
                label24.Text = "SEM PERMISSAO";
                label24.ForeColor = Color.Red;
                //gunaShadowPanel1.Enabled = false;
                label26.Visible = true;
            }
        }

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand(); 
        //Display comboBox
        private void getDataComboBox()
        {
            conn.Open();
            SqlCeCommand cmd = new SqlCeCommand("select distinct Produto from save_vendidos", conn);
            SqlCeDataReader da;
            da = cmd.ExecuteReader();
            if (da.Read() == true)
            {
                do
                {
                    guna2ComboBox1.Items.Add(da["Produto"].ToString());
                }
                while (da.Read());

            }
            conn.Close();

            //Categoria
            conn.Open();
            SqlCeCommand Cmd = new SqlCeCommand("select distinct Categoria from save_vendidos", conn);
            SqlCeDataReader Da;
           Da = Cmd.ExecuteReader();
            if (Da.Read() == true)
            {
                do
                {
                    guna2ComboBox2.Items.Add(Da["Categoria"].ToString());
                }
                while (Da.Read());

            }
            conn.Close();
        }

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
                    label1.Text = B.ToString("N2");
                    ValorVendas.Text = B.ToString("N2")+ "kz";
                    ftotal.Text = B.ToString("kz")+"kz";
                    itens.Text = "Itens: " + dados.Rows.Count;
                }

                int C = 0;
                int D = 0;
                for (C = 0; C < dados.Rows.Count; ++C)
                {
                    D += Convert.ToInt32(dados.Rows[C].Cells["Qtd"].Value);
                    qtdTotal.Text = D.ToString();
                    ValorStock.Text = D.ToString();
                }
            }
            catch { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gunaLinePanel1.Visible = false;
            panel1.Visible = false;
            dados.Visible = false;
            //gunaShadowPanel1.Visible = false;

            if (details.id_clinte == null)
            {
                details.id_clinte = DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString();
                openChildForm(new show_vendas());   
            }
            else
            {
                openChildForm(new show_vendas());   
            }         
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

        private void dados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //gunaTransition1.ShowSync(gunaShadowPanel1);
                if (sellect == true)
                {
                    details.coderen = dados.SelectedRows[0].Cells[0].Value.ToString();
                    details.query = "SELECT [barcode],[Produto],[Categoria],[Qtd],[Preco.Unit],[Total] FROM [save_vendidos] WHERE ID='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    gunaLinePanel1.Visible = false;
                    panel1.Visible = false;
                    dados.Visible = false;
                    openChildForm(new show_show_ren());
                }
                else
                    MessageBox.Show("Selecione detalis para poder fazer reenbolsos");
            }
            catch
            { MessageBox.Show("Este campo esta vazio"); }
        }

        private void gunaCircleButton7_Click(object sender, EventArgs e)
        {
            //gunaTransition1.HideSync(gunaShadowPanel1);
        }

        void select()
        {

            if (sellect == true)
            {
                try
                {
                    PrivateFontCollection pfc = new PrivateFontCollection();
                    pfc.AddFontFile("./font/LibreBarcode128Text-Regular.ttf");
                    id.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                }
                catch { }
                try
                {
                    id.Text = dados.SelectedRows[0].Cells[0].Value.ToString();
                    funcionario.Text = dados.SelectedRows[0].Cells[1].Value.ToString();
                    data.Text = dados.SelectedRows[0].Cells[2].Value.ToString();
                    qtd.Text = dados.SelectedRows[0].Cells[3].Value.ToString();
                    total.Text = dados.SelectedRows[0].Cells[6].Value.ToString();
                    desconto.Text = dados.SelectedRows[0].Cells[5].Value.ToString();
                    pagamento.Text = dados.SelectedRows[0].Cells[7].Value.ToString();
                }
                catch { };
            }
                
        }
        private void dados_MouseClick(object sender, MouseEventArgs e)
        {
            select();
            Dta.Visible = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (Dta.Visible == false)
            {
                Dta.Visible = true;
                FormMain f = new FormMain();
                perfil.Image = f.perfil.Image;
            }
            else
                Dta.Visible = false;
        }

        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //===========================================
            gunaLinePanel1.Visible = false;
            panel1.Visible = false;
            dados.Visible = false;
            //gunaShadowPanel1.Visible = false; 
            //==========================================   
            if (dados.Rows.Count > 0)
            {
                insert();
            }
            return;
           
        }

        void insert()
        {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into relatorio values('" + details.ID_vendas + "','" + DateTime.Now.ToString("d") + "','" + details.id_usuario + "','" + qtdTotal.Text + "','" + stotal + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from vendas";
                cmd.ExecuteNonQuery();
                conn.Close();
                openChildForm(new Relatorio());

        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            details.query = "SELECT [barcode],[Produto],[Categoria],[Qtd],[Preco.Unit],[Total] FROM [save_vendidos] WHERE ID='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
            show_show_ren f = new show_show_ren();
            details.id_clinte= dados.SelectedRows[0].Cells[0].Value.ToString();
            gunaLinePanel1.Visible = false;
            panel1.Visible = false;
            dados.Visible = false;
            //gunaShadowPanel1.Visible = false; 
            openChildForm(new show_show_ren());
            
        }

        bool sellect = true;
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dta.Visible = false;
            sellect = true;
            if (sellect == true)
            {
                if (guna2ComboBox2.SelectedItem.ToString() == "Dados detalhados")
                {
                    display();
                    sellect = true;
                }
                else if (guna2ComboBox2.SelectedItem.ToString() == "Todos dados")
                {
                    sellect = false;
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from save_vendidos";
                    cmd.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
                    dataadp.Fill(dta);
                    dados.DataSource = dta;
                    conn.Close();
                    somar();

                    dados.Columns["Usuario"].Visible = false;
                    dados.Columns["Data"].Visible = false;
                }
                else
                {
                    try
                    {
                        sellect = false;
                        conn.Open();
                        SqlCeCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Select * from save_vendidos where Categoria='" + guna2ComboBox2.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dta = new DataTable();
                        SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
                        dataadp.Fill(dta);
                        dados.DataSource = dta;
                        conn.Close();
                    }
                    catch { MessageBox.Show("Ocorreu um Erro!"); }
                    somar();

                    dados.Columns["Usuario"].Visible = false;
                    dados.Columns["Data"].Visible = false;
                    dados.Columns["ID"].Visible = false;
                }
            }
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dta.Visible = false;
            sellect = true;
           if (sellect == true)
           {
               if (guna2ComboBox3.SelectedItem.ToString() == "Todos tipos de pagamento")
               {
                   display();
                   sellect = true;
               }
               else
               {
                   sellect = false;
                   conn.Open();
                   SqlCeCommand cmd = conn.CreateCommand();
                   cmd.CommandType = CommandType.Text;
                   cmd.CommandText = "Select * from vendas where MTC='" + guna2ComboBox3.SelectedItem.ToString() + "'";
                   cmd.ExecuteNonQuery();
                   DataTable dta = new DataTable();
                   SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
                   dataadp.Fill(dta);
                   dados.DataSource = dta;
                   conn.Close();
                   somar();

                   dados.Columns["Usuario"].Visible = false;
                   dados.Columns["Data"].Visible = false;
               }
           }
        }

        private void Vendas_Load(object sender, EventArgs e)
        {

            getDataComboBox();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dta.Visible = false;
            sellect = true;
            if (sellect == true)
            {
                if (guna2ComboBox3.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Nao existe nenum produto nesta lista");
                }
                else
                {
                    try
                    {
                        sellect = false;
                        conn.Open();
                        SqlCeCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Select * from save_vendidos where Produto='" + guna2ComboBox1.SelectedItem.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dta = new DataTable();
                        SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
                        dataadp.Fill(dta);
                        dados.DataSource = dta;
                        conn.Close();
                    }
                    catch { MessageBox.Show("Erro na Operacao"); }
                    somar();

                    dados.Columns["Usuario"].Visible = false;
                    dados.Columns["Data"].Visible = false;
                    dados.Columns["ID"].Visible = false;
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        void busca()
        {
            try
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from save_vendidos where ID='" + search.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
                dataadp.Fill(dta);
                dados.DataSource = dta;
                conn.Close();
            }
            catch
            { return; }
        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (search.Text != "")
                    busca();
                else
                    display();
            }
        }

        private void gunaCircleButton13_Click(object sender, EventArgs e)
        {
            if (search.Text != "")
                busca();
            else
                display();
        }       


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new vendas().Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           
        }
    }
}
