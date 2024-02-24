using System.ComponentModel.DataAnnotations;

namespace UserApi.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(11, ErrorMessage = "CPF inválido. Favor retirar os '-', '.' e qualquer espaço")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Contrato")]
        public EnumStatusContrato enumStatusContrato { get; set; }

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

        [StringLength(100)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [StringLength(50)]
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
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public enum EnumStatusContrato
        {
            Ativo = 1,
            Demitido = 2,
            Afastado = 3,
            Ferias = 4
        }
        public enum EnumSetor
        {
            TI = 1,
            RH = 2,
            Varejo = 3,
            Marketing = 4,
            Comercial = 5,
            Digital = 6,
            Compras = 7,
            Auditoria = 8,
            Contabilidade = 8,
            Fiscal = 9,
            Administração = 10
        }
    }
}
