using System.Collections.Generic;

namespace DDDDemo.Dominio.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }
}
}
