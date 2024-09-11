namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }
        /* relacinamento com a tabela vendas*/
        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        /*relacionado com produtos*/

        public Guid ProdutoId { get; set; }
        public Produtos? Produto { get; set; }
        public double QtadeEstoque { get; set; }
        public double ValorTotal { get; set; }

    }
}

