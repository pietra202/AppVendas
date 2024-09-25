using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo é Obrigatorio")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter, no maximo, 100 caracteres")]
        public string cme { get; set; }
    }
}
