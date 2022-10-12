namespace csharp_boolflix.Models
{
    public class TvSerie
    {
        public int TvSerieId { get; set; }
        public string Name { get; set; }
        public int Compatible { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public int Seasons { get; set; }

        public TvSerie()
        {

        }
        public TvSerie(string name, int compatible, int age, string image, int seasons)
        {
            Name = name;
            Compatible = compatible;
            Age = age;
            Image = image;
            Seasons = seasons;
        }
    }
}
