# Controle de Estoque

## Descrição do Projeto
O **Controle de Estoque** é uma aplicação desktop desenvolvida em C#, destinada a gerenciar o estoque de uma empresa. A solução oferece funcionalidades para cadastro, consulta, atualização (em construção) e remoção de produtos (em construção), garantindo um controle eficiente e organizado do estoque.

---

## Funcionalidades

- **Adicionar Produto**: Insere um novo produto no estoque com detalhes como nome, categoria, quantidade, preço de custo, preço de venda e estoque mínimo.
- **Listar Produtos**: Exibe todos os produtos cadastrados no estoque.
- **Atualizar Produto (em construção)**: Permite editar informações de produtos existentes.
- **Remover Produto (em construção)**: Exclui produtos do estoque.
- **Alertas de Estoque (em construção)**: Indica produtos com quantidade abaixo do estoque mínimo.

---

## Estrutura do Projeto

### Diretórios e Componentes
1. **Business**:
   - Contém a lógica de negócio da aplicação.
   - Exemplo: `EstoqueService.cs` – Gerencia operações como adicionar e listar produtos.

2. **Data**:
   - Responsável pelo acesso a dados.
   - Exemplo: `ProdutoRepository.cs` 

3. **Models**:
   - Contém as classes que representam as entidades do sistema.
   - Exemplo: `Produto.cs` – Define as propriedades dos produtos.

4. **UI**:
   - Gerencia a interface gráfica do usuário.
   - Exemplo: `Form1.cs` – Janela principal onde o usuário interage com o sistema.

---

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework de Interface**: Windows Forms
- **IDE**: Visual Studio

---

## Como Executar o Projeto

1. **Clone o Repositório**:
   ```bash
   git clone https://github.com/GabrielGurris/controle-estoque
   ```

2. **Abra no Visual Studio**:
   - Abra o arquivo da solução `.sln` no Visual Studio.

3. **Compile o Projeto**:
   - No menu superior, clique em `Build > Build Solution`.

4. **Execute o Projeto**:
   - Pressione `F5` ou clique em `Start` para executar.

---

## Exemplos de Uso

### Adicionar Produto
1. Preencha os campos com os detalhes do produto.
2. Clique no botão **Adicionar**.

### Listar Produtos
- Clique no botão **Listar** para visualizar todos os produtos cadastrados.

---

## Melhorias Futuras

- Implementação de relatórios gerenciais.
- Suporte a múltiplos usuários com permissões.
- Integração com banco de dados para persistência de dados.
- Adição de testes unitários para validação do código.
