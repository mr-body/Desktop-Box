namespace Desktop_Box.Controls
{
    partial class produto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produto));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.admin = new System.Windows.Forms.Label();
            this.nome = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaLinePanel1.Controls.Add(this.admin);
            this.gunaLinePanel1.Controls.Add(this.nome);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.LightGray;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(252, 60);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "00,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(7, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 5;
            this.gunaPictureBox1.Size = new System.Drawing.Size(52, 54);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 16;
            this.gunaPictureBox1.TabStop = false;
            // 
            // admin
            // 
            this.admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Calibri", 10F);
            this.admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin.Location = new System.Drawing.Point(65, 35);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(30, 17);
            this.admin.TabIndex = 14;
            this.admin.Text = "AKZ";
            this.admin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nome
            // 
            this.nome.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.nome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.nome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.nome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nome.Location = new System.Drawing.Point(62, 10);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(150, 23);
            this.nome.TabIndex = 15;
            this.nome.TabStop = true;
            this.nome.Text = "Nome do Produto";
            this.nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "produto";
            this.Size = new System.Drawing.Size(252, 60);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label admin;
        private Guna.UI.WinForms.GunaLinkLabel nome;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}
