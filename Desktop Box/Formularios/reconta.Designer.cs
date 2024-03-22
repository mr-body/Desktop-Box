namespace Desktop_Box.Formularios
{
    partial class reconta
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.code = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(114, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(114, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(114, 249);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(265, 45);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "ENTRAR NO SISTEMA";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // nome
            // 
            this.nome.BorderRadius = 6;
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
            this.nome.Location = new System.Drawing.Point(114, 85);
            this.nome.Name = "nome";
            this.nome.PasswordChar = '\0';
            this.nome.PlaceholderText = "Nome do usuario";
            this.nome.SelectedText = "";
            this.nome.ShadowDecoration.Parent = this.nome;
            this.nome.Size = new System.Drawing.Size(265, 45);
            this.nome.TabIndex = 10;
            this.nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nome_KeyUp);
            // 
            // code
            // 
            this.code.BorderRadius = 6;
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
            this.code.Location = new System.Drawing.Point(114, 167);
            this.code.Name = "code";
            this.code.PasswordChar = '\0';
            this.code.PlaceholderText = "ID do Usuario";
            this.code.SelectedText = "";
            this.code.ShadowDecoration.Parent = this.code;
            this.code.Size = new System.Drawing.Size(265, 45);
            this.code.TabIndex = 11;
            this.code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.code_KeyUp);
            this.code.MouseUp += new System.Windows.Forms.MouseEventHandler(this.code_MouseUp);
            // 
            // reconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.code);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reconta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudar de conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox nome;
        private Guna.UI2.WinForms.Guna2TextBox code;
    }
}