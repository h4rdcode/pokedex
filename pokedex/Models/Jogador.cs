using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pokedex.Models
{
    public enum Estado {RS, SC, PR, SP, RJ, ES, MG, MS, MT ,TO ,GO, DF, RO, AC, AM, PA, PI, PE, PB, CE, RN }

    [Table("Jogadores")]
    public class Jogador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="ID:")]
        public int id { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Campo Cidade é obrigatório")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required(ErrorMessage = "Campo Estado é obrigatório")]
        [Display(Name = "Estado")]
        public Estado estado { get; set; }

        [Range (6,70, ErrorMessage ="Preencha uma idade entre 6 e 70 anos")]
        [Display(Name = "Idade:")]
        public int idade { get; set; }

        public ICollection<Pokedex> pokedexs { get; set; }
    }
}
