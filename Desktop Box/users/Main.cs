﻿using Desktop_Box.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Box.users
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            try
            {
                Precario f = new Precario();
                ValorStock.Text = double.Parse(f.total).ToString("N2") + "kz";

                Relatorio f2 = new Relatorio();
                ValorVendas.Text = double.Parse(f2.total).ToString("N2") + "kz";

                Despesas f3 = new Despesas();
                ValorDespesas.Text = double.Parse(f3.total).ToString("N2") + "kz";

                trocos f4 = new trocos();
                ValorTrcos.Text = double.Parse(f4.total).ToString("N2") + "kz";

                TOTAL.Text = ((double.Parse(f2.total) + double.Parse(f4.total)) - double.Parse(f3.total)).ToString() + "kz";

            }
            catch { }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
