using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using ControleEstoque.Data.Models;

namespace ControleEstoque.Data.Repositories
{
    public class ProdutoRepository
    {
        private List<Produto> _produtos = new();

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produtos;
        }
    }
}
