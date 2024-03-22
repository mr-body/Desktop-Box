using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Box.Formularios.Dialogos
{
    public partial class addStock : Form
    {
        public addStock()
        {
            InitializeComponent();
        }

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\database.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        //Display da base de dados
        void insert()
        {
            try
            {
                conn.Open();
                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO stock Values('" + txt_Codigo.Text + "','" + txt_Producto.Text + "','" + guna2ComboBox1.Text + "','" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + txt_Preço.Text + "','" + double.Parse(guna2TextBox1.Text) * double.Parse(guna2TextBox2.Text) + "','" + guna2DateTimePicker1.Text +"')";
                cmd.ExecuteNonQuery();
            }
            catch
            { 
            }
        }

        string caminhoImage;

        private void txt_Preço_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddCarinho_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Title = "Escolha um perfil para o produto";
            foto.InitialDirectory = @"C:\";
            foto.Filter = "PNG Images (*.png) |*png" + "|" + "GIF Images (*.gif) |*gif" + "|" + "Jpeg Images (*.jpg) |*jpg" + "|" + "BMP files (*.bmp)|*.bmp" + "|" + "PNG images (*.png)|*.png";

            if (foto.ShowDialog() == DialogResult.Cancel) return;

            perfil.Image = Image.FromFile(foto.FileName);
            caminhoImage = foto.FileName;
            foto.Dispose();
        }

        private void addStock_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            insert();
            try
            {
                File.Copy(caminhoImage, @".\images\" + txt_Codigo.Text + ".png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            this.Close();

        }
    }
}
