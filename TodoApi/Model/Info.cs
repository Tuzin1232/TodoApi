using System.ComponentModel.DataAnnotations;

namespace TodoApi.Model
{
    public class Info
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        [Required]
        [MaxLength(11, ErrorMessage = "Favor insira um CPF válido"), MinLength(11, ErrorMessage = "Favor insira um CPF válido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{###.###.###-##}")]
        public string CPF { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(14, ErrorMessage = "Favor insira um número para contato válido"), MinLength(13, ErrorMessage = "Favor insira um número para contato válido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{(##)####-####}")]
        public string Contato { get; set; }
    }
}