namespace pokedex.Models
{
    public enum Estado {RS, SC, PR, SP, RJ, ES, MG, MS, MT ,TO ,GO, DF, RO, AC, AM, PA, PI, PE, PB, CE, RN }
    public class Jogador
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public Estado estado { get; set; }
        public int idade { get; set; }

        public ICollection<Pokedex> pokedexs { get; set; }
    }
}
