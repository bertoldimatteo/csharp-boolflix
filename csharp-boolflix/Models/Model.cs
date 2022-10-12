using csharp_boolflix.Models;

namespace csharp_boolflix.Models
{
    public abstract class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Compatible { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }

        public int? TvSerieId { get; set; }
        public TvSerie? TvSerie { get; set; }

        public int? FilmId { get; set; }
        public Film? Film { get; set; }
    }
}

public class TvSerie : Model
{
    public int Seasons { get; set; }
    public Model Model { get; set; }
}

public class Film : Model
{
    public int Duration { get; set; }
    public Model Model { get; set; }
}
