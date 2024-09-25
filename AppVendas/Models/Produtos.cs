using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produtos
    {
        public Guid ProdutosId { get; set; }
        [Display(Name = "Desrição")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [MaxLength(100, ErrorMessage = "O campo dve ter, no máximo, 100 caracteres")]
        [MinLength(3, ErrorMessage = "O campo deve ter, no mínimo, 3 caracteres")]
        public string ProdutoNome { get; set; }
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo!")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "A Quantidade em estoque deve ser um número positivo!")]
        public double QtadeEstoque { get; set; }
        public bool CadastroAtivo { get; set; } = true;

        /* chava estrangeira*/
        [Required(ErrorMessage = "Por favor, selecione um cliente!")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}