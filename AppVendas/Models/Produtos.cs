namespace AppVendas.Models
{
    public class Produtos
    {
        public Guid ProdutosId { get; set; }
        public string ProdutoNome { get; set; }
        public double Valor { get; set; }
        public double QtadeEstoque { get; set; }
        public bool CadastroAtivo { get; set; }

        /* chava estrangeira*/
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}