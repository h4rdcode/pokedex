using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    [Table("Pokedex")]
    public class Pokedex
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Jogador precisa ser preenchido !")]
        [Display(Name = "Jogador:")]
        public Jogador jogador { get; set; }

        [Required(ErrorMessage = "Campo Pokemon precisa ser preenchido !")]
        [Display(Name = "Pokemon:")]
        public Pokemon pokemon { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        [Display(Name = "Quantidade:")]
        public float quantidade { get; set; }

        public ICollection<Transacao> transacoes { get; set; }
    } 
}
