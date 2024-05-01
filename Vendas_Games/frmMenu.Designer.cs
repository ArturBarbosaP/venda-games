
namespace Vendas_Games
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.picJogos = new System.Windows.Forms.PictureBox();
            this.picVendas = new System.Windows.Forms.PictureBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.toolStripButtonCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.picJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendas)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picJogos
            // 
            this.picJogos.Image = ((System.Drawing.Image)(resources.GetObject("picJogos.Image")));
            this.picJogos.Location = new System.Drawing.Point(70, 73);
            this.picJogos.Name = "picJogos";
            this.picJogos.Size = new System.Drawing.Size(342, 342);
            this.picJogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogos.TabIndex = 0;
            this.picJogos.TabStop = false;
            this.picJogos.Click += new System.EventHandler(this.picJogos_Click);
            // 
            // picVendas
            // 
            this.picVendas.Image = ((System.Drawing.Image)(resources.GetObject("picVendas.Image")));
            this.picVendas.Location = new System.Drawing.Point(499, 73);
            this.picVendas.Name = "picVendas";
            this.picVendas.Size = new System.Drawing.Size(342, 342);
            this.picVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVendas.TabIndex = 1;
            this.picVendas.TabStop = false;
            this.picVendas.Click += new System.EventHandler(this.picVendas_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCadastro,
            this.toolStripButtonSair});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(910, 23);
            this.toolStripMenu.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(2, 29);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(117, 21);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Seja bem vindo";
            // 
            // toolStripButtonCadastro
            // 
            this.toolStripButtonCadastro.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCadastro.Image")));
            this.toolStripButtonCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCadastro.Name = "toolStripButtonCadastro";
            this.toolStripButtonCadastro.Size = new System.Drawing.Size(120, 20);
            this.toolStripButtonCadastro.Text = "Cadastrar Usuario";
            this.toolStripButtonCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonCadastro.Click += new System.EventHandler(this.toolStripButtonCadastro_Click);
            // 
            // toolStripButtonSair
            // 
            this.toolStripButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSair.Image")));
            this.toolStripButtonSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSair.Name = "toolStripButtonSair";
            this.toolStripButtonSair.Size = new System.Drawing.Size(46, 20);
            this.toolStripButtonSair.Text = "Sair";
            this.toolStripButtonSair.Click += new System.EventHandler(this.toolStripButtonSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 464);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.picVendas);
            this.Controls.Add(this.picJogos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVendas)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJogos;
        private System.Windows.Forms.PictureBox picVendas;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.ToolStripButton toolStripButtonCadastro;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
    }
}