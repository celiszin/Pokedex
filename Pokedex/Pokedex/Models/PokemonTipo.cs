using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("PokemonTipo")]
    public class PokemonTipo
{
    [Key, Column(Order = 1)]
    public int PokemoNumero { get; set; }  
    [ForeignKey("PokemonNumero")]  
    public Pokemon Pokemon { get; set;}

    [Key, Column(Order = 2)]
    public int TipoId { get; set; }
    [ForeignKey("Tipo")]
     public Tipo Tipo {get; set; }



}
