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

namespace Desktop_Box.Formularios.Dialogos.rem
{
    public partial class show_show_ren : Form
    {
        public show_show_ren()
        {
            InitializeComponent();
            string code = details.code;
            label19.Text = details.coderen;
            label12.Text = code;
            display();
            txt_Quant.Text = "1";
            txt_Quant.Enabled = false;
        }

        public string query;

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        string categoria;
        string quantidade;

        //Display da base de dados
        void display()
        {
            try
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = details.query;
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlCeDataAdapter dataadp = new SqlCeDataAdapter(cmd);
                dataadp.Fill(dta);
                dados.DataSource = dta;
                conn.Close();
                somar();

            }
            catch { }
        }

        private void somar()
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            for (A = 0; A < dados.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dados.Rows[A].Cells[5].Value);
                Total.Text = B.ToString();
                label13.Text = "Itens: " + dados.Rows.Count;
            }


            for (C = 0; C < dados.Rows.Count; ++C)
            {
                D += Convert.ToInt32(dados.Rows[C].Cells[3].Value);
                details.tikerQuantidade = D.ToString();
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
        int Reqtd;
        private void Deletar()
        {
            try
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
                cmd.CommandText = "delete from save_vendidos where barcode='" + dados.SelectedRows[0].Cells[0].Value.ToString() + "' and ID='"+details.coderen+"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE stock set Qtd = '" + (Reqtd + int.Parse(dados.SelectedRows[0].Cells[3].Value.ToString())) + "' where barcode = '" + dados.SelectedRows[0].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                display();
            }
            catch { MessageBox.Show("Nenhum objecto selecionado"); }
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
                    string query = "Select * from [save_vendidos] where barcode='" + txt_Codigo.Text + "' and ID='" + details.coderen + "'";
                    SqlCeCommand comand = conn.CreateCommand();
                    comand.CommandType = CommandType.Text;
                    comand.CommandText = query;
                    comand.ExecuteNonQuery();
                    SqlCeDataReader da = comand.ExecuteReader();
                    if (da.Read() == false)
                    {
                        SqlCeCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into [save_vendidos] values('" + details.ID_vendas + "','" + details.coderen + "','" + details.id_usuario + "','" + details.ID_Hora + "','" + txt_Codigo.Text + "','" + txt_Producto.Text + "','" + categoria + "','" + txt_Quant.Text + "','" + txt_Preço.Text + "','" + (double.Parse(txt_Preço.Text) * double.Parse(txt_Quant.Text)).ToString() + "')";
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
                Select();
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (dados.Rows.Count > 0)
            {
                Desktop_Box.Formularios.Dialogos.rem.concluir conn = new concluir();
                conn.lblTotal.Text = Total.Text;
                conn.ShowDialog();
                gunaLinePanel1.Visible = false;
                gunaLinePanel2.Visible = false;
                dados.Visible = false;
                openChildForm(new Vendas());
            }
            else
                if (MessageBox.Show("Deletar tudo", "O senhor ten serveza disto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                else
                {
                    conn.Open();
                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from vendas where ID='" + details.coderen + "'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from save_vendas where ID='" + details.coderen + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    gunaLinePanel1.Visible = false;
                    gunaLinePanel2.Visible = false;
                    dados.Visible = false;
                    openChildForm(new Vendas());
                }

        }

        private void btn_AddCarinho_Click(object sender, EventArgs e)
        {
            try
            {
                insert();
            }
            catch { MessageBox.Show("Nenhum objecto seleconado"); }
        }

        private void dados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Desktop_Box.Formularios.Dialogos.rem.rem.edit f = new rem.edit(int.Parse(dados.SelectedRows[0].Cells[4].Value.ToString()), dados.SelectedRows[0].Cells[0].Value.ToString(), int.Parse(dados.SelectedRows[0].Cells[3].Value.ToString()));
                f.ShowDialog();
                display();
            }
            catch { MessageBox.Show("Nenhum objecto selecionado"); }
        }

        private void dados_MouseClick(object sender, MouseEventArgs e)
        {
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
            catch (Exception ex)
            {
                MessageBox.Show("Nemhun objecto selecionado");
            }
        }

        private void AutoPriechimento(string campo, string indice)
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
                        txt_Codigo.Text = code.Text = da.GetValue(0).ToString();

                        //Nome
                        txt_Producto.Text = nome.Text = da.GetValue(1).ToString();

                        //Categoria
                        categoria = categoria = da.GetValue(2).ToString();

                        //Preco
                        txt_Preço.Text = valor.Text = da.GetValue(5).ToString();

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

        private void txt_Producto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    AutoPriechimento(txt_Producto.Text, "Nome");
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
            Deletar();
            display();
            somar();
        }

        private void txt_Quant_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insert();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Desktop_Box.Formularios.Dialogos.rem.rem.edit f = new rem.edit(int.Parse(dados.SelectedRows[0].Cells[4].Value.ToString()), dados.SelectedRows[0].Cells[0].Value.ToString(), int.Parse(dados.SelectedRows[0].Cells[3].Value.ToString()));
                f.ShowDialog();
                display();
            }
            catch { MessageBox.Show("Nenhum objecto selecionado"); }
        }

        void combox()
        {
            switch (opscaner.Text)
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

    }
}
