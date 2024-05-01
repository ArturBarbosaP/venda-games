
namespace Vendas_Games
{
    partial class frmJogos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogos));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_plataforma = new System.Windows.Forms.Label();
            this.cbx_plataforma = new System.Windows.Forms.ComboBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.dtg_listarjogos = new System.Windows.Forms.DataGridView();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listarjogos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(212, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(215, 35);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(663, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(30, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(33, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(120, 20);
            this.txt_id.TabIndex = 3;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(30, 75);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(35, 13);
            this.lbl_preco.TabIndex = 4;
            this.lbl_preco.Text = "Preço";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(33, 103);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(120, 20);
            this.txt_preco.TabIndex = 5;
            // 
            // lbl_plataforma
            // 
            this.lbl_plataforma.AutoSize = true;
            this.lbl_plataforma.Location = new System.Drawing.Point(269, 75);
            this.lbl_plataforma.Name = "lbl_plataforma";
            this.lbl_plataforma.Size = new System.Drawing.Size(57, 13);
            this.lbl_plataforma.TabIndex = 6;
            this.lbl_plataforma.Text = "Plataforma";
            // 
            // cbx_plataforma
            // 
            this.cbx_plataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_plataforma.FormattingEnabled = true;
            this.cbx_plataforma.Items.AddRange(new object[] {
            "Playstation",
            "Xbox",
            "Nitendo Switch",
            "PC"});
            this.cbx_plataforma.Location = new System.Drawing.Point(272, 103);
            this.cbx_plataforma.Name = "cbx_plataforma";
            this.cbx_plataforma.Size = new System.Drawing.Size(126, 21);
            this.cbx_plataforma.TabIndex = 7;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(514, 75);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 8;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(517, 103);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(120, 20);
            this.txt_quantidade.TabIndex = 9;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Location = new System.Drawing.Point(753, 75);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_genero.TabIndex = 10;
            this.lbl_genero.Text = "Genêro";
            // 
            // txt_genero
            // 
            this.txt_genero.Location = new System.Drawing.Point(756, 103);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(122, 20);
            this.txt_genero.TabIndex = 11;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(30, 149);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_descricao.TabIndex = 12;
            this.lbl_descricao.Text = "Descricao";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(33, 177);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(845, 20);
            this.txt_descricao.TabIndex = 13;
            // 
            // dtg_listarjogos
            // 
            this.dtg_listarjogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_listarjogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listarjogos.Location = new System.Drawing.Point(33, 215);
            this.dtg_listarjogos.Name = "dtg_listarjogos";
            this.dtg_listarjogos.Size = new System.Drawing.Size(845, 171);
            this.dtg_listarjogos.TabIndex = 14;
            this.dtg_listarjogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listarjogos_CellContentClick);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Image = ((System.Drawing.Image)(resources.GetObject("btn_inserir.Image")));
            this.btn_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inserir.Location = new System.Drawing.Point(33, 399);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(99, 53);
            this.btn_inserir.TabIndex = 15;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(178, 399);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(104, 53);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(328, 399);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(104, 53);
            this.btn_alterar.TabIndex = 17;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(478, 399);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(102, 53);
            this.btn_excluir.TabIndex = 18;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(776, 399);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(102, 53);
            this.btn_voltar.TabIndex = 19;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.Location = new System.Drawing.Point(626, 399);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(102, 53);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 464);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dtg_listarjogos);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.cbx_plataforma);
            this.Controls.Add(this.lbl_plataforma);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Jogos";
            this.Load += new System.EventHandler(this.Jogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listarjogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_plataforma;
        private System.Windows.Forms.ComboBox cbx_plataforma;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.DataGridView dtg_listarjogos;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_limpar;
    }
}

