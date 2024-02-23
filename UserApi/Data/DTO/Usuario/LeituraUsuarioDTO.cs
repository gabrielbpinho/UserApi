using static UserApi.Models.Usuario;
using System.ComponentModel.DataAnnotations;

namespace UserApi.Data.DTO.Usuario
{
    public class LeituraUsuarioDTO
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(11, ErrorMessage = "CPF inválido. Favor retirar os '-', '.' e qualquer espaço")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Contrato")]
        public EnumStatusContrato enumStatusContrato { get; set; } = EnumStatusContrato.Ativo;

        [Display(Name = "Setor")]
        public EnumSetor enumSetor { get; set; }

        [Required(ErrorMessage = "Informe o seu CEP")]
        [Display(Name = "CEP")]
        [StringLength(10, MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o seu endereço")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco1 { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }

        [StringLength(100)]
        [Display(Name = "Complemento")]
        public string Endereco2 { get; set; }

        [StringLength(10)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [StringLength(50)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Informe o seu telefone")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o email.")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
        ErrorMessage = "O email não possui um formato correto")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
