using Pokedex.Models;

namespace Pokedex.ViewModels;

public class DetailsVM
{
    public Pokemon Anterior { get; set; }
    public Pokemon Atual { get; set; }
    public Pokemon Proximo { get; set; }
}
