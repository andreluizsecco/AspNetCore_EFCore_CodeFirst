using System;

namespace AspNetCore_EFCore_CodeFirst.Models
{
    public class Livro
    {
        public Livro() =>
            DataEntrada = DateTime.Now;

        public Livro(int id, int categoriaID, string titulo, string autor, int quantidade, decimal preco, DateTime dataEntrada) : this()
        {
            ID = id;
            CategoriaID = categoriaID;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
            DataEntrada = dataEntrada;
        }

        public Livro(int id, int categoriaID, string titulo, string autor, int quantidade, decimal preco) : this()
        {
            ID = id;
            CategoriaID = categoriaID;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
        }

        public int ID { get; set; }
        public int CategoriaID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataEntrada { get; set; }
        public Categoria Categoria { get; set; }
    }
}