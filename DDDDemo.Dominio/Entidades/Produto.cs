namespace DDDDemo.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Situacao { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
