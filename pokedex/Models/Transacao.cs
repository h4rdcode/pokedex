using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    public enum Operacao { Pegar, Soltar }


    [Table("Transacoes")]
    public class Transacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Pokedex precisa ser preenchido !")]
        [Display(Name = "Pokemon:")]
        public Pokedex pokedex { get; set; }

        [Display(Name = "Data:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy")]
        public DateTime data { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        [Display(Name = "Quantidade")]
        public float quantidade { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        [Display(Name = "Valor")]
        public float valor { get; set; }

        [Required(ErrorMessage = "Campo Tipo Operação precisa ser preenchido !")]
        [Display(Name = "Operação:")]
        public Operacao operacao { get; set; }
    }
}
