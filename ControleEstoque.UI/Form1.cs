using System;
using System.Windows.Forms;
using ControleEstoque.Business.Services;
using ControleEstoque.Data.Repositories;

namespace ControleEstoque.UI
{
    public partial class Form1 : Form
    {
        private EstoqueService _estoqueService;

        public Form1()
        {
            InitializeComponent();
            var produtoRepository = new ProdutoRepository();
            _estoqueService = new EstoqueService(produtoRepository);
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                _estoqueService.AdicionarProduto(
                    txtNome.Text,
                    txtCategoria.Text,
                    int.Parse(txtQuantidade.Text),
                    decimal.Parse(txtPrecoCusto.Text),
                    decimal.Parse(txtPrecoVenda.Text),
                    int.Parse(txtEstoqueMinimo.Text)
                );

                MessageBox.Show("Produto adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            var produtos = _estoqueService.ListarProdutos();
            lstProdutos.Items.Clear();

            foreach (var produto in produtos)
            {
                lstProdutos.Items.Add($"{produto.Nome} - {produto.Categoria} - {produto.QuantidadeEstoque} em estoque");
            }
        }
    }
}
