using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Pokemon")]
public class Pokemon
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Numero { get; set; }

    [Required]
    public int RegiaoId { get; set; }
    [ForeignKey("RegiaoId")]
    public Regiao Regiao { get; set; }

    [Required]
    public int GeneroId { get; set; }
    [ForeignKey("GeneroId")]
    public string Genero { get; set; }

    [Required(ErrorMessage ="Informe o Nome")]
    [StringLength(30)]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Descricao { get; set; }

    [Required]
    [Column(TypeName = "decimal(5,2)")]

    public decimal Altura { get; set; }

    [Column(TypeName = "decimal(7,3)")]
    public decimal peso { get; set; }

   [StringLength(200)]
   public string Imagem {get; set; }

   [StringLength(400)]
   public string Animacao { get; set; }

   public ICollection<PokemonTipo> Tipos { get; set; }
}   

