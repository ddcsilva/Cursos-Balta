using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;

public class EdicaoCategoriaViewModel
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [StringLength(40, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 3)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Slug { get; set; }
}
