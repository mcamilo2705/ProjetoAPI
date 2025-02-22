using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Model;

namespace ProjetoAPI.Context
{
    //hendando funcoes da classe DbContext
    public class ProdutoDbContext : DbContext
    {
        //criando um metodo construtor da classe, recebendo um valor do banco como parametro
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base (options)
        {
            

        }
        //Criando uma tabela para o banco de dados
        public DbSet<Produto> Produtos => Set<Produto>();
    }
}
