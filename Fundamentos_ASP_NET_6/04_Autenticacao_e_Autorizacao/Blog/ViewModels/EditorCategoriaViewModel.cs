using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class EditorCategoriaViewModel
    {
        [Required(ErrorMessage = "O Nome é obrigatório!")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Slug é obrigatório!")]
        public string Slug { get; set; }
    }
}
