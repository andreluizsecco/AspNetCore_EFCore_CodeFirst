using System.Collections.Generic;

namespace AspNetCore_EFCore_CodeFirst.Models
{
    public class Categoria
    {
        protected Categoria() =>
            Livros = new List<Livro>();

        public Categoria(int id, string nome) : this()
        {
            ID = id;
            Nome = nome;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}