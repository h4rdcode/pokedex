namespace pokedex.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public float compra { get; set; }
        public float venda { get; set; }

        public ICollection<Pokedex> pokedex { get; set; }
    }
}
