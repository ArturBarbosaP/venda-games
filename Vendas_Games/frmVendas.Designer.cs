
namespace Vendas_Games
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.dtg_listarvendas = new System.Windows.Forms.DataGridView();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_jogoid = new System.Windows.Forms.TextBox();
            this.lbl_jogoid = new System.Windows.Forms.Label();
            this.dtg_jogos = new System.Windows.Forms.DataGridView();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listarvendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_jogos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(30, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(33, 34);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(119, 20);
            this.txt_id.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(208, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(211, 34);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(666, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(30, 69);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(33, 95);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(844, 20);
            this.txt_email.TabIndex = 5;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(755, 130);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 6;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(573, 130);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 8;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(211, 130);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 10;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(214, 155);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(119, 20);
            this.txt_quantidade.TabIndex = 11;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            // 
            // dtg_listarvendas
            // 
            this.dtg_listarvendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_listarvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listarvendas.Location = new System.Drawing.Point(33, 212);
            this.dtg_listarvendas.Name = "dtg_listarvendas";
            this.dtg_listarvendas.Size = new System.Drawing.Size(844, 166);
            this.dtg_listarvendas.TabIndex = 12;
            this.dtg_listarvendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listarvendas_CellContentClick);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Image = ((System.Drawing.Image)(resources.GetObject("btn_inserir.Image")));
            this.btn_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inserir.Location = new System.Drawing.Point(33, 397);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(105, 53);
            this.btn_inserir.TabIndex = 16;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(180, 397);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(105, 53);
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(328, 397);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(105, 53);
            this.btn_alterar.TabIndex = 18;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(476, 397);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(105, 53);
            this.btn_excluir.TabIndex = 19;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(772, 397);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(105, 53);
            this.btn_voltar.TabIndex = 20;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(392, 130);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 21;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(395, 155);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(119, 20);
            this.txt_valor.TabIndex = 22;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(624, 397);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(105, 53);
            this.btn_limpar.TabIndex = 23;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_jogoid
            // 
            this.txt_jogoid.Location = new System.Drawing.Point(33, 155);
            this.txt_jogoid.Name = "txt_jogoid";
            this.txt_jogoid.Size = new System.Drawing.Size(119, 20);
            this.txt_jogoid.TabIndex = 24;
            this.txt_jogoid.TextChanged += new System.EventHandler(this.txt_jogoid_TextChanged);
            // 
            // lbl_jogoid
            // 
            this.lbl_jogoid.AutoSize = true;
            this.lbl_jogoid.Location = new System.Drawing.Point(29, 130);
            this.lbl_jogoid.Name = "lbl_jogoid";
            this.lbl_jogoid.Size = new System.Drawing.Size(47, 13);
            this.lbl_jogoid.TabIndex = 25;
            this.lbl_jogoid.Text = "Jogo_ID";
            // 
            // dtg_jogos
            // 
            this.dtg_jogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_jogos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg_jogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_jogos.Location = new System.Drawing.Point(904, 9);
            this.dtg_jogos.Name = "dtg_jogos";
            this.dtg_jogos.Size = new System.Drawing.Size(348, 441);
            this.dtg_jogos.TabIndex = 26;
            this.dtg_jogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_jogos_CellContentClick);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(576, 155);
            this.txt_telefone.Mask = "(99) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(88, 20);
            this.txt_telefone.TabIndex = 27;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(757, 155);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(86, 20);
            this.txt_cpf.TabIndex = 28;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 464);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.dtg_jogos);
            this.Controls.Add(this.lbl_jogoid);
            this.Controls.Add(this.txt_jogoid);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dtg_listarvendas);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listarvendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_jogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.DataGridView dtg_listarvendas;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_jogoid;
        private System.Windows.Forms.Label lbl_jogoid;
        private System.Windows.Forms.DataGridView dtg_jogos;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
    }
}