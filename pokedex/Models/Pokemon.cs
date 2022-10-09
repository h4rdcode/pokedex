using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    [Table("Pokemons")]
    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Preencha o tipo do Pokemon !")]
        [Display(Name = "Tipo")]
        public string tipo { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        [Display(Name = "Pegar")]
        public float compra { get; set; }

        [DisplayFormat(DataFormatString = "{0:N1}")]
        [Display(Name = "Soltar")]
        public float venda { get; set; }

        public ICollection<Pokedex> pokedex { get; set; }
    }
}
