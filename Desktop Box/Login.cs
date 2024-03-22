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

namespace Desktop_Box
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlCeConnection conn = new SqlCeConnection(@"Data Source=.\db\db_users.sdf");
        SqlCeCommand cmd = new SqlCeCommand();
        SqlCeDataAdapter da = new SqlCeDataAdapter();

        void verif()
        {
            conn.Open();
            string query = "Select * from contas where Nome='" + nome.Text + "' and code='" + code.Text + "'";
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlCeDataReader da = cmd.ExecuteReader();
            if (da.Read() == true)
            {
                SqlCeCommand CMD = new SqlCeCommand("select * from [contas] where Nome =@ID ", conn);
                CMD.Parameters.AddWithValue("@ID", nome.Text);
                SqlCeDataReader DA = cmd.ExecuteReader();
                if (DA.Read() == true)
                {
                    details.id_usuario = nome.Text;
                    details.numero = DA.GetValue(3).ToString();
                    details.tipo = DA.GetValue(4).ToString();
                    details.code = code.Text;
                    new escolha().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username ou codigo incorretos! tente novamente");
            }
            conn.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            verif();
        }

        private void code_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                verif();
            }
        }

        private void nome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                code.Focus();
        }
    }
}
