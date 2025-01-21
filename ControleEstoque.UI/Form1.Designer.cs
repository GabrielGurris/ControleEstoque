namespace ControleEstoque.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpa os recursos usados.
        /// </summary>
        /// <param name="disposing">True se os recursos gerenciados devem ser descartados; caso contrário, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Formulários Windows

        /// <summary>
        /// Método necessário para suporte ao Designer.
        /// Não modifique o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtPrecoCusto = new TextBox();
            txtQuantidade = new TextBox();
            txtCategoria = new TextBox();
            txtEstoqueMinimo = new TextBox();
            txtPrecoVenda = new TextBox();
            btnAdicionarProduto = new Button();
            lblnome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstProdutos = new ListBox();
            btnListarProdutos = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(197, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Location = new Point(197, 164);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(100, 23);
            txtPrecoCusto.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(197, 122);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 2;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(197, 77);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 3;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(197, 246);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(100, 23);
            txtEstoqueMinimo.TabIndex = 4;
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Location = new Point(197, 204);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(100, 23);
            txtPrecoVenda.TabIndex = 5;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(324, 122);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(86, 65);
            btnAdicionarProduto.TabIndex = 6;
            btnAdicionarProduto.Text = "Adicionar Produto";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(134, 38);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 7;
            lblnome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 207);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 8;
            label1.Text = "Preço Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 167);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 9;
            label2.Text = "Preço Custo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 125);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 10;
            label3.Text = "Quantidade Estoque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 80);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 249);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 12;
            label5.Text = "Estoque Minimo";
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 15;
            lstProdutos.Location = new Point(551, 108);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(237, 94);
            lstProdutos.TabIndex = 13;
            // 
            // btnListarProdutos
            // 
            btnListarProdutos.Location = new Point(439, 122);
            btnListarProdutos.Name = "btnListarProdutos";
            btnListarProdutos.Size = new Size(88, 65);
            btnListarProdutos.TabIndex = 14;
            btnListarProdutos.Text = "Listar Produtos";
            btnListarProdutos.UseVisualStyleBackColor = true;
            btnListarProdutos.Click += btnListarProdutos_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarProdutos);
            Controls.Add(lstProdutos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblnome);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(txtPrecoVenda);
            Controls.Add(txtEstoqueMinimo);
            Controls.Add(txtCategoria);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPrecoCusto);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Controle de Estoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPrecoCusto;
        private TextBox txtQuantidade;
        private TextBox txtCategoria;
        private TextBox txtEstoqueMinimo;
        private TextBox txtPrecoVenda;
        private Button btnAdicionarProduto;
        private Label lblnome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstProdutos;
        private Button btnListarProdutos;
    }
}
