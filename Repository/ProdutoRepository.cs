using ProjetoAPI.Model;

namespace ProjetoAPI.Repository
{
    public class ProdutoRepository
    {
        //criar lista - List para armazenar o produto
        //criando uma lista
        List<Produto> listaProdutos = new()
        { 
            //Inserindo informacoes na lista
            new Produto()
            {
                Nome = "Produto_1",
                Categoria = "Categoria_1"
            },
            //Inserindo informacoes na lista
            new Produto()
            {
                Nome = "Produto_2",
                Categoria = "Categoria_2"
            }
        };

        //metodo pra listar os produtos da lista
        public List<Produto> ListarProdutos()
        {
            return listaProdutos;
        }


    }
}
