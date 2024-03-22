namespace Desktop_Box.users
{
    partial class contas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contas));
            this.label1 = new System.Windows.Forms.Label();
            this.dados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.numero = new Guna.UI2.WinForms.Guna2TextBox();
            this.code = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.sexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.idade = new Guna.UI.WinForms.GunaNumeric();
            this.label2 = new System.Windows.Forms.Label();
            this.inicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.perfil = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).BeginInit();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova Conta";
            // 
            // dados
            // 
            this.dados.AllowUserToAddRows = false;
            this.dados.AllowUserToDeleteRows = false;
            this.dados.AllowUserToResizeColumns = false;
            this.dados.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dados.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dados.DefaultCellStyle = dataGridViewCellStyle7;
            this.dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dados.EnableHeadersVisualStyles = false;
            this.dados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dados.Location = new System.Drawing.Point(322, 62);
            this.dados.Name = "dados";
            this.dados.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dados.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dados.RowHeadersVisible = false;
            this.dados.RowTemplate.DividerHeight = 5;
            this.dados.RowTemplate.Height = 40;
            this.dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dados.Size = new System.Drawing.Size(765, 538);
            this.dados.TabIndex = 10;
            this.dados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dados.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dados.ThemeStyle.HeaderStyle.Height = 40;
            this.dados.ThemeStyle.ReadOnly = true;
            this.dados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dados.ThemeStyle.RowsStyle.Height = 40;
            this.dados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dados_MouseDoubleClick);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(521, 13);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Pesquisa de pessoas";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(232, 36);
            this.guna2TextBox1.TabIndex = 13;
            // 
            // gunaButton3
            // 
            this.gunaButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.Gray;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaButton3.Location = new System.Drawing.Point(395, 12);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 2;
            this.gunaButton3.Size = new System.Drawing.Size(106, 36);
            this.gunaButton3.TabIndex = 294;
            this.gunaButton3.Text = "Edititar";
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaButton2.Location = new System.Drawing.Point(274, 12);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 2;
            this.gunaButton2.Size = new System.Drawing.Size(106, 36);
            this.gunaButton2.TabIndex = 293;
            this.gunaButton2.Text = "delete";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaButton1.Location = new System.Drawing.Point(9, 415);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 2;
            this.gunaButton1.Size = new System.Drawing.Size(298, 52);
            this.gunaButton1.TabIndex = 295;
            this.gunaButton1.Text = "Cadatrar Funcionario";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // nome
            // 
            this.nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nome.DefaultText = "";
            this.nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nome.DisabledState.Parent = this.nome;
            this.nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nome.FocusedState.Parent = this.nome;
            this.nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nome.HoverState.Parent = this.nome;
            this.nome.Location = new System.Drawing.Point(12, 66);
            this.nome.Name = "nome";
            this.nome.PasswordChar = '\0';
            this.nome.PlaceholderText = "Nome";
            this.nome.SelectedText = "";
            this.nome.ShadowDecoration.Parent = this.nome;
            this.nome.Size = new System.Drawing.Size(295, 36);
            this.nome.TabIndex = 296;
            // 
            // numero
            // 
            this.numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numero.DefaultText = "";
            this.numero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero.DisabledState.Parent = this.numero;
            this.numero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero.FocusedState.Parent = this.numero;
            this.numero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero.HoverState.Parent = this.numero;
            this.numero.Location = new System.Drawing.Point(12, 107);
            this.numero.Name = "numero";
            this.numero.PasswordChar = '\0';
            this.numero.PlaceholderText = "Numero";
            this.numero.SelectedText = "";
            this.numero.ShadowDecoration.Parent = this.numero;
            this.numero.Size = new System.Drawing.Size(295, 36);
            this.numero.TabIndex = 297;
            // 
            // code
            // 
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.DefaultText = "";
            this.code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.code.DisabledState.Parent = this.code;
            this.code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.code.FocusedState.Parent = this.code;
            this.code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.code.HoverState.Parent = this.code;
            this.code.Location = new System.Drawing.Point(12, 189);
            this.code.Name = "code";
            this.code.PasswordChar = '\0';
            this.code.PlaceholderText = "Codigo";
            this.code.SelectedText = "";
            this.code.ShadowDecoration.Parent = this.code;
            this.code.Size = new System.Drawing.Size(267, 36);
            this.code.TabIndex = 298;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.Honeydew;
            this.gunaButton4.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaButton4.BorderSize = 1;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaButton4.Location = new System.Drawing.Point(275, 189);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(32, 36);
            this.gunaButton4.TabIndex = 299;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // sexo
            // 
            this.sexo.BackColor = System.Drawing.Color.Transparent;
            this.sexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo.FocusedColor = System.Drawing.Color.Empty;
            this.sexo.FocusedState.Parent = this.sexo;
            this.sexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.sexo.FormattingEnabled = true;
            this.sexo.HoverState.Parent = this.sexo;
            this.sexo.ItemHeight = 30;
            this.sexo.Items.AddRange(new object[] {
            "Selecionar sexo",
            "Maculino",
            "Femenino",
            "Personalizaso"});
            this.sexo.ItemsAppearance.Parent = this.sexo;
            this.sexo.Location = new System.Drawing.Point(12, 147);
            this.sexo.Name = "sexo";
            this.sexo.ShadowDecoration.Parent = this.sexo;
            this.sexo.Size = new System.Drawing.Size(295, 36);
            this.sexo.StartIndex = 0;
            this.sexo.TabIndex = 300;
            // 
            // cargo
            // 
            this.cargo.BackColor = System.Drawing.Color.Transparent;
            this.cargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargo.FocusedColor = System.Drawing.Color.Empty;
            this.cargo.FocusedState.Parent = this.cargo;
            this.cargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cargo.FormattingEnabled = true;
            this.cargo.HoverState.Parent = this.cargo;
            this.cargo.ItemHeight = 30;
            this.cargo.Items.AddRange(new object[] {
            "Selecionar Cargo",
            "Gerente",
            "Vendedor",
            "Guarda",
            "Fachineira"});
            this.cargo.ItemsAppearance.Parent = this.cargo;
            this.cargo.Location = new System.Drawing.Point(11, 232);
            this.cargo.Name = "cargo";
            this.cargo.ShadowDecoration.Parent = this.cargo;
            this.cargo.Size = new System.Drawing.Size(296, 36);
            this.cargo.StartIndex = 0;
            this.cargo.TabIndex = 301;
            // 
            // idade
            // 
            this.idade.BaseColor = System.Drawing.Color.White;
            this.idade.BorderColor = System.Drawing.Color.Silver;
            this.idade.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.idade.ButtonForeColor = System.Drawing.Color.White;
            this.idade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idade.ForeColor = System.Drawing.Color.Black;
            this.idade.Location = new System.Drawing.Point(226, 295);
            this.idade.Maximum = ((long)(9999999));
            this.idade.Minimum = ((long)(0));
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(81, 30);
            this.idade.TabIndex = 302;
            this.idade.Text = "gunaNumeric1";
            this.idade.Value = ((long)(0));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(223, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 303;
            this.label2.Text = "Idade";
            // 
            // inicio
            // 
            this.inicio.BorderColor = System.Drawing.Color.Gainsboro;
            this.inicio.CheckedState.Parent = this.inicio;
            this.inicio.FillColor = System.Drawing.Color.White;
            this.inicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inicio.HoverState.Parent = this.inicio;
            this.inicio.Location = new System.Drawing.Point(9, 295);
            this.inicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.inicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.inicio.Name = "inicio";
            this.inicio.ShadowDecoration.Parent = this.inicio;
            this.inicio.Size = new System.Drawing.Size(211, 30);
            this.inicio.TabIndex = 304;
            this.inicio.Value = new System.DateTime(2022, 4, 3, 14, 7, 10, 958);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(10, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 305;
            this.label3.Text = "Inicio do contrato";
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.Moccasin;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageSize = new System.Drawing.Size(22, 22);
            this.gunaButton5.Location = new System.Drawing.Point(13, 347);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 2;
            this.gunaButton5.Size = new System.Drawing.Size(104, 39);
            this.gunaButton5.TabIndex = 308;
            this.gunaButton5.Text = "Perfil";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // perfil
            // 
            this.perfil.BackColor = System.Drawing.Color.Transparent;
            this.perfil.BaseColor = System.Drawing.Color.White;
            this.perfil.Image = ((System.Drawing.Image)(resources.GetObject("perfil.Image")));
            this.perfil.Location = new System.Drawing.Point(122, 347);
            this.perfil.Name = "perfil";
            this.perfil.Radius = 6;
            this.perfil.Size = new System.Drawing.Size(54, 39);
            this.perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.perfil.TabIndex = 309;
            this.perfil.TabStop = false;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.label7);
            this.gunaLinePanel1.Controls.Add(this.label6);
            this.gunaLinePanel1.Controls.Add(this.qtd);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.LightGray;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 600);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1087, 51);
            this.gunaLinePanel1.TabIndex = 317;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(319, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quantidade de cadastros";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Contas de funcionarios";
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.qtd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.qtd.Location = new System.Drawing.Point(473, 17);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(28, 22);
            this.qtd.TabIndex = 4;
            this.qtd.Text = "---";
            this.qtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(13, 50);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.Gray;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.Gray;
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(248, 3);
            this.guna2ProgressBar1.TabIndex = 318;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.numero);
            this.gunaLinePanel2.Controls.Add(this.guna2ProgressBar1);
            this.gunaLinePanel2.Controls.Add(this.perfil);
            this.gunaLinePanel2.Controls.Add(this.gunaButton4);
            this.gunaLinePanel2.Controls.Add(this.label1);
            this.gunaLinePanel2.Controls.Add(this.gunaButton1);
            this.gunaLinePanel2.Controls.Add(this.gunaButton5);
            this.gunaLinePanel2.Controls.Add(this.nome);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Controls.Add(this.code);
            this.gunaLinePanel2.Controls.Add(this.inicio);
            this.gunaLinePanel2.Controls.Add(this.sexo);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.cargo);
            this.gunaLinePanel2.Controls.Add(this.idade);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.LightGray;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(322, 600);
            this.gunaLinePanel2.TabIndex = 319;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Controls.Add(this.guna2TextBox1);
            this.gunaLinePanel3.Controls.Add(this.gunaButton2);
            this.gunaLinePanel3.Controls.Add(this.gunaButton3);
            this.gunaLinePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel3.LineBottom = 1;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.LightGray;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.Location = new System.Drawing.Point(322, 0);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(765, 62);
            this.gunaLinePanel3.TabIndex = 320;
            // 
            // contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 651);
            this.Controls.Add(this.dados);
            this.Controls.Add(this.gunaLinePanel3);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "contas";
            this.Text = "contas";
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfil)).EndInit();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaLinePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dados;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI2.WinForms.Guna2TextBox nome;
        private Guna.UI2.WinForms.Guna2TextBox numero;
        private Guna.UI2.WinForms.Guna2TextBox code;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI2.WinForms.Guna2ComboBox sexo;
        private Guna.UI2.WinForms.Guna2ComboBox cargo;
        private Guna.UI.WinForms.GunaNumeric idade;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker inicio;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaPictureBox perfil;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private System.Windows.Forms.Label qtd;
    }
}