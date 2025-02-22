using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Context;
using ProjetoAPI.Model;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Definindo o nome do arquivo do banco de dados
var stringConexao = "Data Source=produtos.db";
//Informando para usar sqlite.
builder.Services.AddSqlite<ProdutoDbContext>(stringConexao);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//async significa metodo assincrono, ou seja, o sistema continua rodando enquanto esta processando no banco de dados, o async atua em 
//conjunto com o await
app.MapGet("/produtos", async (ProdutoDbContext db) =>
{
    //await vai acessanar a tabela Produtos dentro do db
    return await db.Produtos.ToListAsync();
});

//Criando um metodo post
app.MapPost("/produtos", async (Produto prod, ProdutoDbContext db) =>
{
    //add e o metodo para cadastrar no banco de dados
  
    db.Produtos.Add(prod);
    //EF - SaveChange, ou seja, ele so efetiva quando nao dar erro
    //essa linha salva
    await db.SaveChangesAsync();

    //retonar o status
    return Results.Created();
});

//GET - Listagem de produtos - "/listarProdutos"
app.MapGet("/listarProdutos", async (ProdutoDbContext db2) =>
{ 
    return await db2.Produtos.ToListAsync();
});

//POST - Cadastro de produtos - "/cadastrarProdutos"
app.MapPost("/cadastrarProdutos", async (Produto prd2, ProdutoDbContext db2) =>
{
    db2.Produtos.Add(prd2);
    await db2.SaveChangesAsync();

    return Results.Created();
});

//app.MapPut("/atualizaProduto", async )

app.Run();
