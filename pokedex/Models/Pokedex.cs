namespace pokedex.Models
{
    public class Pokedex
    {
        public int id { get; set; }
        public Jogador jogador { get; set; }
        public Pokemon pokemon { get; set; }
        public float quantidade { get; set; }

        public ICollection<Transacao> transacoes { get; set; }
    } 
}
