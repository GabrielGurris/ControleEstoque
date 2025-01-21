using System.Collections.Generic; // Importa o namespace para trabalhar com coleções genéricas, como listas.
using ControleEstoque.Data.Models; // Importa a classe Produto do projeto Data.
using ControleEstoque.Data.Repositories; // Importa a classe ProdutoRepository do projeto Data.

namespace ControleEstoque.Business.Services // Define o namespace para organizar a classe EstoqueService.
{
    // Define a classe EstoqueService que será responsável pela lógica de negócios do estoque.
    public class EstoqueService
    {
        // Declara uma variável privada para armazenar a instância de ProdutoRepository.
        private readonly ProdutoRepository _produtoRepository;

        // Construtor da classe EstoqueService que recebe uma instância de ProdutoRepository como dependência.
        public EstoqueService(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository; // Atribui a instância recebida ao campo privado.
        }

        // Método responsável por adicionar um produto ao estoque.
        public void AdicionarProduto(string nome, string categoria, int quantidade, decimal precoCusto, decimal precoVenda, int estoqueMinimo)
        {
            // Validação para garantir que a quantidade não seja negativa.
            if (quantidade < 0) throw new ArgumentException("Quantidade não pode ser negativa.");

            // Validação para garantir que o preço de venda seja maior que o preço de custo.
            if (precoVenda < precoCusto) throw new ArgumentException("Preço de venda deve ser maior que o preço de custo.");

            // Cria uma nova instância da classe Produto com os dados fornecidos.
            var produto = new Produto
            {
                Nome = nome, // Define o nome do produto.
                Categoria = categoria, // Define a categoria do produto.
                QuantidadeEstoque = quantidade, // Define a quantidade em estoque.
                PrecoCusto = precoCusto, // Define o preço de custo do produto.
                PrecoVenda = precoVenda, // Define o preço de venda do produto.
                EstoqueMinimo = estoqueMinimo // Define a quantidade mínima em estoque.
            };

            // Chama o método Adicionar do ProdutoRepository para salvar o produto.
            _produtoRepository.Adicionar(produto);
        }

        // Método responsável por listar todos os produtos do estoque.
        public IEnumerable<Produto> ListarProdutos()
        {
            // Retorna a lista de produtos armazenados no repositório.
            return _produtoRepository.ObterTodos();
        }
    }
}
