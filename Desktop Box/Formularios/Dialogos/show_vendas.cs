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

namespace Desktop_Box.Formularios.Dialogos
{
    public partial class show_vendas : Form
    {
        public show_vendas()
        {
            InitializeComponent();
            string code = details.code;
            txtcode.Text = code;
            label19.Text = details.id_clinte;
            txtnome.Text = details.id_usuario;
            display();
            txt_Quant.Text = "1";
            txt_Quant.Enabled = false;
        }

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        string categoria;
        string quantidade;

        //Display da base de dados
        void display()
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select barcode,Produto,Categoria,Qtd,[Preco.Unit],Total from vendidos";
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
                B += Convert.ToInt32(dados.Rows[A].Cells["Total"].Value);
                Total.Text = B.ToString();
                label13.Text ="Itens: "+ dados.Rows.Count;
            }


            for (C = 0; C < dados.Rows.Count; ++C)
            {
                D+= Convert.ToInt32(dados.Rows[C].Cells[3].Value);
                details.tikerQuantidade = D.ToString();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (dados.Rows.Count > 0)
            {
                concluir conn = new concluir();
                conn.lblTotal.Text = Total.Text;
                conn.ShowDialog();
                gunaLinePanel1.Visible = false;
                gunaLinePanel2.Visible = false;
                dados.Visible = false;
                openChildForm(new Vendas());
            }
            else
                MessageBox.Show("O senhor ainda nao comprou nada");
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

        int Reqtd;

        private void Deletar()
        {
                conn.Open();
                SqlCeCommand Cmd = new SqlCeCommand("select * from stock where barcode = " + dados.SelectedRows[0].Cells[0].Value.ToString() + "", conn);
                SqlCeDataReader da = Cmd.ExecuteReader();
                if (da.Read() == true)
                {
                    //Codigo
                    Reqtd = int.Parse(da.GetValue(4).ToString());
                }
                conn.Close();

                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from vendidos where barcode='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "' and ID = '" + details.id_clinte + "'";
                cmd.ExecuteNonQuery();   
                cmd.CommandText = "delete from save_vendidos where barcode='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "' and ID = '" + details.id_clinte + "'";
                cmd.ExecuteNonQuery(); 
                cmd.CommandText = "UPDATE stock set Qtd = '" + (Reqtd + int.Parse(dados.SelectedRows[0].Cells[3].Value.ToString())) + "' where barcode = '" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                display();
        }

        void select_auto()
        {
            if (txt_Quant.Text == "")
                txt_Quant.Focus();
            else
                insert();
        }

        void insert()
        {
            try
            {       
                if (txt_Codigo.Text != "" && txt_Producto.Text != "" && txt_Preço.Text != "" && txt_Quant.Text != "")
                {

                    conn.Open();
                    string query = "Select * from vendidos where barcode='" + txt_Codigo.Text + "'";
                    SqlCeCommand comand = conn.CreateCommand();
                    comand.CommandType = CommandType.Text;
                    comand.CommandText = query;
                    comand.ExecuteNonQuery();
                    SqlCeDataReader da = comand.ExecuteReader();
                    if (da.Read() == false)
                    {
                        SqlCeCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into vendidos values('" + details.id_clinte + "','" + details.id_usuario + "','" + details.ID_Hora + "','" + txt_Codigo.Text + "','" + txt_Producto.Text + "','" + categoria + "','" + txt_Quant.Text + "','" + txt_Preço.Text + "','" + (double.Parse(txt_Preço.Text) * double.Parse(txt_Quant.Text)).ToString() + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "insert into [save_vendidos] values('" + details.ID_vendas + "','" + details.id_clinte + "','" + details.id_usuario + "','" + details.ID_Hora + "','" + txt_Codigo.Text + "','" + txt_Producto.Text + "','" + categoria + "','" + txt_Quant.Text + "','" + txt_Preço.Text + "','" + (double.Parse(txt_Preço.Text) * double.Parse(txt_Quant.Text)).ToString() + "')";
                        cmd.ExecuteNonQuery();
                        //==========================================
                        //Update da base d atbela stock
                        //==========================================   
                        int QtdUp = (int.Parse(quantidade) - int.Parse(txt_Quant.Text));
                        cmd.CommandText = "UPDATE stock set Qtd = '" + QtdUp + "' where barcode = '" + txt_Codigo.Text + "'";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE stock set Total = '" + (QtdUp * int.Parse(txt_Preço.Text)) + "' where barcode = '" + txt_Codigo.Text + "'";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        if(MessageBox.Show("Este Produto ja esta cadastrado no carrinho")==DialogResult.OK);
                        conn.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos, Para adicionar um novo produto ao carrinho");
                    txt_Codigo.Focus();
                }
                conn.Close();
                txt_Codigo.Text = txt_Producto.Text = txt_Preço.Text = txt_Quant.Text = "";
                display();
                combox();
                Select();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btn_AddCarinho_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void txt_Quant_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (guna2ShadowPanel1.Visible == false)
                bunifuTransition1.ShowSync(guna2ShadowPanel1);
            else
                bunifuTransition1.HideSync(guna2ShadowPanel1);
        }
           
        private void dados_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile("./font/LibreBarcode128Text-Regular.ttf");
                code.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
            catch { }
            try
            {
                code.Text = dados.SelectedRows[0].Cells[0].Value.ToString();
                nome.Text = dados.SelectedRows[0].Cells[1].Value.ToString();
                valor.Text = dados.SelectedRows[0].Cells[4].Value.ToString();
                qtd.Text = dados.SelectedRows[0].Cells[3].Value.ToString();
                try
                {
                    perfil.Image = Image.FromFile(@".\images\" + code.Text + ".png");
                }
                catch
                {
                    perfil.Image = Image.FromFile(@".\images\padrao.png");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nenhum objecto selecionado");
            }
        }

        private void AutoPriechimento(string campo,string indice)
        {
            try
            {
                if (campo != "")
                {
                    conn.Open();
                    SqlCeCommand cmd = new SqlCeCommand("select * from stock where " + indice + " =@ID ", conn);
                    cmd.Parameters.AddWithValue("@ID", campo);
                    SqlCeDataReader da = cmd.ExecuteReader();
                    if (da.Read() == true)
                    {
                        //Codigo
                        txt_Codigo.Text=code.Text = da.GetValue(0).ToString();

                        //Nome
                        txt_Producto.Text=nome.Text = da.GetValue(1).ToString();

                        //Categoria
                        categoria=categoria = da.GetValue(2).ToString();

                        //Preco
                        txt_Preço.Text=valor.Text = da.GetValue(5).ToString();

                        //qtd
                        qtd.Text = quantidade = da.GetValue(4).ToString();

                        try
                        {
                            perfil.Image = Image.FromFile(@".\images\" + da.GetValue(0).ToString() + ".png");
                        }
                        catch
                        {
                            perfil.Image = Image.FromFile(@".\images\padrao.png");
                        }
                    }
                    conn.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }    
        }

        private void txt_Codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    AutoPriechimento(txt_Codigo.Text, "barcode");
                    select_auto();
                }
                catch
                {
                    return;
                }
            }
        }
        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt_Producto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    AutoPriechimento(txt_Producto.Text,"Nome");
                    select_auto();
                }
                catch
                {
                    return;
                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            Deletar();
            somar(); 
        }

        private void txt_Quant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insert();
                txt_Codigo.Focus();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                edit_qtd f = new edit_qtd(int.Parse(dados.SelectedRows[0].Cells[4].Value.ToString()), dados.SelectedRows[0].Cells[0].Value.ToString(), int.Parse(dados.SelectedRows[0].Cells[3].Value.ToString()));
                f.ShowDialog();
                display();
            }
            catch { MessageBox.Show("Nenhum objecto selecionado"); }
        }
        void combox()
        {
            switch (actomatic.Text)
            {
                case "1 de cada":
                    txt_Quant.Text = "1";
                    txt_Quant.Enabled = false;
                    break;
                case "2 de cada":
                    txt_Quant.Text = "2";
                    txt_Quant.Enabled = false;
                    break;
                case "3 de cada":
                    txt_Quant.Text = "3";
                    txt_Quant.Enabled = false;
                    break;
                case "4 de cada":
                    txt_Quant.Text = "4";
                    txt_Quant.Enabled = false;
                    break;
                case "5 de cada":
                    txt_Quant.Text = "5";
                    txt_Quant.Enabled = false;
                    break;
                case "Manual":
                    txt_Quant.Text = "";
                    txt_Quant.Enabled = true;
                    break;
            }


            txt_Codigo.Focus();
        }
        private void opscaner_SelectedIndexChanged(object sender, EventArgs e)
        {
            combox();
        }

        private void dados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edit_qtd f = new edit_qtd(int.Parse(dados.SelectedRows[0].Cells[4].Value.ToString()), dados.SelectedRows[0].Cells[0].Value.ToString(), int.Parse(dados.SelectedRows[0].Cells[3].Value.ToString()));
            f.ShowDialog();
            display();
        }
    }
}
