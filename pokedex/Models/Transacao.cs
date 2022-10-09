namespace pokedex.Models
{
    public enum Operacao { Pegar, Soltar }

    public class Transacao
    {
        public int id { get; set; }
        public Pokedex pokedex { get; set; }
        public DateTime data { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }
        public Operacao operacao { get; set; }
    }
}
