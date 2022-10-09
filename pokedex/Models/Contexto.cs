using Microsoft.EntityFrameworkCore;

namespace pokedex.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):
            base(options)
        { }

        public DbSet<Jogador> jogadores { get; set; }
        public DbSet<Pokedex> pokedexs { get; set; }
        public DbSet<Pokemon> pokemons { get; set; }
        public DbSet<Transacao> transacoes { get; set; }
    }
}
