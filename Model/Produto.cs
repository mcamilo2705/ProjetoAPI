namespace ProjetoAPI.Model
{
    public class Produto
    {
        //na model informa quais campos sao ou nao obrigatorios

        //Contrutor --> define o que a classe tem que fazer quando for instanciada
        //sempre que criar um construtor, deixar entre os paranteses em branco
        public Produto()
        {
            //toda vez que criar um produdo, sera gerado um id unico
            Id = Guid.NewGuid();
        }

        //get e set modificador de acesso
        //o Guid e uma classe do c# que gera numeros aleatorios
        public Guid Id { get; set; }
        //interrogacao informa que o nome pode ser nulo
        public string? Nome { get; set; }
        //interrogacao informa que a categoria pode ser nula
        public string? Categoria { get; set; }
    }
}
